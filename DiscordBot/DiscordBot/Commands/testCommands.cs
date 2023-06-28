using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.CommandsNext;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class testCommand : BaseCommandModule
    {
        [Command("ping")]
        public async Task TestCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("bot pinged");
        }
        [Command("who")]
        public async Task WhoCommand(CommandContext ctx)
        {
            var user = ctx.User;
            await ctx.Channel.SendMessageAsync("Your username is :" + user.Username);
        }
    }
}