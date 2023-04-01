// See https://aka.ms/new-console-template for more information
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

const string connectionString = "DefaultEndpointsProtocol=https;AccountName=itfiks;AccountKey=2/nT6sjZNpeUV1mkHMdTJzPgUsG3SKEDNvHQs6+xTKQAxInFAFIO1OmVqmx64unxLf/Og7hHF2Ne+ASt0Qn/Xw==;BlobEndpoint=https://itfiks.blob.core.windows.net/;QueueEndpoint=https://itfiks.queue.core.windows.net/;TableEndpoint=https://itfiks.table.core.windows.net/;FileEndpoint=https://itfiks.file.core.windows.net/;";

BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

string containerName = "text-files-container";

string localDirectory = "../../../Data";
string fileName = "textFile" + Guid.NewGuid().ToString() + ".txt";
string localFilePath =  Path.Combine(localDirectory, fileName);

await File.WriteAllTextAsync(localFilePath, "Желудок");


BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
await blobContainerClient.CreateIfNotExistsAsync();
BlobClient blobClient = blobContainerClient.GetBlobClient(fileName);
Console.WriteLine(blobClient.Uri);

using (FileStream fs = File.OpenRead(localFilePath))
{
    await blobClient.UploadAsync(content:fs,overwrite:true);
}

await foreach (var item in blobContainerClient.GetBlobsAsync())
{
    Console.WriteLine(item.Name);
    BlobClient client = blobContainerClient.GetBlobClient(item.Name);
    Console.WriteLine(client.Uri.AbsoluteUri);
    Console.WriteLine(client.Uri);
}

Console.WriteLine("\n");

string downloadFilePath = localFilePath.Replace(".txt", "DOWNLOAD.txt");

var blobDownloadInfo = blobClient.DownloadTo(downloadFilePath);

using (FileStream fs = File.OpenWrite(downloadFilePath))
{
    await fs.WriteAsync(blobDownloadInfo.Content);
}

Console.ReadLine();

await blobContainerClient.DeleteAsync();
await blobClient.DeleteAsync();

File.Delete(localFilePath);
File.Delete(downloadFilePath);