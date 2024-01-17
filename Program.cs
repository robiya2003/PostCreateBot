namespace PostCreateBot
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            EssentialControlBot bot = new EssentialControlBot();
            await bot.WorkingBot();
            
        }
    }
}
