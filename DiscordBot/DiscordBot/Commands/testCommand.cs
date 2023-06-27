using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Net;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DiscordBot.commands
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
            await ctx.Channel.SendMessageAsync("Your username is " + user.Username);
        }
    }
}
