using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace BotTemplate
{
    public class PingModule : ModuleBase
    {
        [Command("ping")]
        public async Task PingCommand()
        {
            await ReplyAsync("Pong!");
        }
    }
}
