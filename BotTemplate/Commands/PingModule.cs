using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace BotTemplate.Commands
{
    public class PingModule : ModuleBase
    {
        [Command]
        public async Task Ping()
        {
            await ReplyAsync("Pong!");
        }
    }
}
