using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    /*
     * Command: strike
     * Can be used to strike a user part of the same guild
     * !strike <member>, where the member is a string and this can either be the nickname or the displayname 
     * 
     */
    public class MemberInteractions : BaseCommandModule
    {
        [Command("strike")]
        public async Task strikeMember(CommandContext ctx, [RemainingText] string targetMember) //string member
        {
            targetMember = targetMember.ToLower();
            List<DiscordMember> discordMembers = ctx.Guild.Members.Values.ToList();
            List<string> memberNicknames = new List<string> { };
            List<string> memberUsernames = new List<string> { };
            foreach(DiscordMember member in discordMembers)
            {
                if (!(member.Nickname == null))
                {
                    memberNicknames.Add(member.Nickname.ToLower());

                }
                if (!(member.Username == null))
                {
                    memberUsernames.Add(member.Username.ToLower());
                }
                //nickname and username should be made ToLower()
            }
            if (memberNicknames.Contains(targetMember) || memberUsernames.Contains(targetMember))
            {
                await ctx.Channel.SendMessageAsync($"Sorry, {targetMember}, strike maffaka");
            }
            else
            {
                await ctx.Channel.SendMessageAsync($"{targetMember} not found." + $" {targetMember} has either not set their nickname or are a part of the server.");
            }
         }

    }
}
