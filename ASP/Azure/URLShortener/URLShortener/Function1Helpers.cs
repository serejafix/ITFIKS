using Azure.Data.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using URLShortener.Models;
internal static class Function1Helpers
{
    [FunctionName("Set")]
    public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        [Microsoft.Azure.WebJobs.Table("ShorUrls")] TableClient tableClient,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");

        string address = req.Query["address"];

        string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        dynamic data = JsonConvert.DeserializeObject(requestBody);
        address = address ?? data?.name;

        string responseMessage = string.IsNullOrEmpty(address)
            ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            : $"Hello, {address}. This HTTP triggered function executed successfully.";
        UrlKey urlKey = null;

        if (string.IsNullOrEmpty(address))
        {
            return new OkObjectResult("Пустота");
        }

        var result = await tableClient.GetEntityIfExistsAsync<UrlKey>("1", "Key");
        if (result.HasValue == false)
        {
            urlKey = new UrlKey()
            {
                Id = 1000,
                PartitionKey = "1",
                RowKey = "Key"
            };
            await tableClient.UpsertEntityAsync(urlKey);
        }
        else
        {
            urlKey = result.Value;
        }
        int index = urlKey.Id;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string code = string.Empty;
        while (index > 0)
        {
            code += alphabet[index % alphabet.Length];
            index /= alphabet.Length;
        }
        code = string.Join("", code.Reverse());
        urlKey.Id++;
        await tableClient.UpsertEntityAsync<UrlKey>(urlKey);

        UrlData urlData = new UrlData()
        {
            Id = code,
            Url = address,
            Count = 1,
            PartitionKey = $"{code[0]}",
            RowKey = code
        };
        await tableClient.UpsertEntityAsync<UrlData>(urlData);
        return new OkObjectResult($"Was input URL =={urlData.Url} + \n" +
            $"Was input short URL == {urlData.PartitionKey}");
    }


    [FunctionName("Redirect")]
    public static  async Task<ActionResult> Redirect(
        [HttpTrigger(AuthorizationLevel.Anonymous,
        "get",
        "post",
        Route = "Redirect/{shortUrl}")] HttpRequest httpRequest,
        string shortUrl,
        [Microsoft.Azure.WebJobs.Table("ShortUrls")] TableClient tableClient,
        [Queue("requestCount")] IAsyncCollector<string> queue,
        ILogger logger)
    {
        if (string.IsNullOrWhiteSpace(shortUrl))
        {
            return new BadRequestResult();
        }

        shortUrl = shortUrl.ToUpper();

        var result = await tableClient
            .GetEntityIfExistsAsync<UrlData>(shortUrl[0].ToString(), shortUrl);

        string defaultUrl = "https://learn.microsoft.com/";

        if (result.HasValue && result.Value is UrlData data)
        {
            defaultUrl = data.Url;
            await queue.AddAsync(data.RowKey);
        }

        return new RedirectResult(defaultUrl);
    }

    [FunctionName("QueueShortUrlHandler")]
    public static async Task QueueShortUrlHandler(
        [QueueTrigger("requestsCount")] string shortUrl,
        [Table("ShortUrls")] TableClient tableClient,
        ILogger logger)
    {
        var result = await tableClient.GetEntityIfExistsAsync<UrlData>(shortUrl[0].ToString(), shortUrl);
        if (result.HasValue && result.Value is UrlData urlData)
        {
            urlData.Count++;
            await tableClient.UpsertEntityAsync<UrlData>(urlData);
        }

    }

}