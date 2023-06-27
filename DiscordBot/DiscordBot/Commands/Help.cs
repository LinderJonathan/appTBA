using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class Help : BaseCommandModule
    {
        [Command("help")]
        public async Task HelpCommand(CommandContext ctx)
        {
            //Command not yetspecified what it should do
        }
        [Command("list")]
        public async Task listOfCommands(CommandContext ctx)
        {
            //TODO: set up a txt file with all commands that are available
        }
    }
}
