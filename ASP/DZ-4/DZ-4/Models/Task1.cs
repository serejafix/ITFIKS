namespace DZ_4.Models
{
    public class Task1
    {
        List<string> quote;
        Random random;
        public Task1() 
        {
            quote = new List<string>();
            random = new Random();
            Seed();
        }
        public void Seed()
        {
            quote.Add("Когда люди смотрят трагедию, они плачут над тем же, над чем смеются, когда смотрят комедию.Август Стриндберг, Красная комната");
            quote.Add("Существуют известные границы, где снисходительность уже граничит с преступлением.Август Стриндберг,На шхерах");
            quote.Add("Если любовь — взаимный обман, то почему же не обманываться? И если нет совершенного счастья," +
                      " то почему же не удовлетвориться несовершенным?Август Стриндберг,На шхерах");
        }
        public string  GetQuote()
        {
            int rnd = random.Next(quote.Count);
            return quote[rnd];
        }
    }
    public class Task2
    {
        Random random1;
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public char[]? ch = null;
        public Task2()
        {
            random1 = new Random();
        }
        public char GetChar()
        {
            ch = chars.ToCharArray();
            int rnd1 = random1.Next(ch.Length);
            return ch[rnd1];
        }
    }
}
