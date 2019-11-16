using System;

namespace GrammarBotDotNetCoreClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Check();
            Console.ReadLine();
        }

        private static async void Check()
        {
            GrammarBotClient.GrammarBot grammarBot = new GrammarBotClient.GrammarBot(new GrammarBotClient.ApiConfig());
            var grammar = await grammarBot.CheckAsync(Console.ReadLine());
            if (grammar.Success)
            {
                foreach (var item in grammar.CheckContent.Matches)
                {
                    Console.WriteLine(item.Message);
                }
            }
            else 
            {
                Console.WriteLine(grammar.Message);
            }
          
        }
    }
}
