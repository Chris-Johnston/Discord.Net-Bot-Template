using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace BotTemplate
{
    public class Program
    {
        private DiscordSocketClient client;
        /// <summary>
        ///     The name of the environment variable, which will contain your Bot's token.
        /// </summary>
        private const string TokenEnvironmentVariable = "DiscordToken";

        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            client = new DiscordSocketClient();
            client.Log += Log;
            await client.LoginAsync(TokenType.Bot,
                Environment.GetEnvironmentVariable(TokenEnvironmentVariable));
            await client.StartAsync();

            // block indefinitely
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            System.Console.WriteLine(msg);
            return Task.CompletedTask;
        }
    }
}
