namespace HttpCleint
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync("https://baconipsum.com/api/?type=meat-and-filler");

                Console.WriteLine(result.Content.ReadAsStringAsync().Result);
                Console.WriteLine(result);
                Console.WriteLine(result.Content);
            }
        }
    }
}