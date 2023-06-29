using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//TODO: a lot. Work on the SMHI API for C#
namespace DiscordBot.Commands
{
    internal class weather : BaseCommandModule
    {
        [Command("weather")]
        public async Task weatherToday(CommandContext ctx, string city)
        {
            await ctx.Channel.SendMessageAsync("Sorry! Haven't implemented forecasts for given cities yet!");
        }
    }
}