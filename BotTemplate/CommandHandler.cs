using Discord.Commands;
using Discord.WebSocket;
using System.Reflection;
using System.Threading.Tasks;

namespace BotTemplate
{
    public class CommandHandler
    {
        private readonly DiscordSocketClient client;
        private readonly CommandService commands;

        public CommandHandler(DiscordSocketClient client, CommandService commands)
        {
            this.client = client;
            this.commands = commands;
        }

        public async Task InstallCommandsAsync()
        {
            client.MessageReceived += HandleCommandAsync;
            // The second parameter of AddModulesAsync is the service provider
            // that will be used for Dependency Injection (DI)
            // By passing a value of null, DI will not be used.
            // Refer to the "Dependency Injection" guide in the documentation
            // for more information.
            await commands.AddModulesAsync(Assembly.GetEntryAssembly(), null);
        }   

        private async Task HandleCommandAsync(SocketMessage messageParam)
        {
            var message = messageParam as SocketUserMessage;
            if (message == null) return;

            int argPos = 0;
            if (!(message.HasCharPrefix('!', ref argPos) ||
                message.HasMentionPrefix(client.CurrentUser, ref argPos)) ||
                message.Author.IsBot)
                return;

            var context = new SocketCommandContext(client, message);
            // A null service provider parameter is passed,
            // Dependency Injection is not being used here.
            await commands.ExecuteAsync(context, argPos, null);
        }
    }
}
