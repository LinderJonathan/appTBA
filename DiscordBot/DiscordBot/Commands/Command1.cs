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
    public class Command1 : BaseCommandModule
    {

        [Command("test")]
        //[Cooldown(5, 60.0, bucketType:CommandCooldownBucket)]
        public async Task TestCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("test command pinged");

        }
        [Command("who")]
        public async Task WhoCommand(CommandContext ctx)
        {
            var user = ctx.User;
            await ctx.Channel.SendMessageAsync("You are " + user.Username);
        }
        [Command("strike")]
        public async Task UserStrike(CommandContext ctx, string user)
        {
            //TODO: get all usernames from the server
        }
    }
}
