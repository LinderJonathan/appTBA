﻿using DSharpPlus.CommandsNext;
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
        //TODO: throw null-exception when no nickname is yet defined
        [Command("strike")]
        public async Task strikeMember(CommandContext ctx, [RemainingText] string targetMember) //string member
        {
            targetMember = targetMember.ToLower();
            List<DiscordMember> discordMembers = ctx.Guild.Members.Values.ToList();
            string nick1 = discordMembers[0].Nickname; //now we just need all nicknames and all usernames
            //TODO: still need to check for null value
            foreach (var discordMember in discordMembers)
            {
                //if (nickname == null || username == null)
                if (discordMember.Nickname.ToLower().Equals(targetMember) || discordMember.Username.ToLower().Equals(targetMember)) // '==' or 'equals'?
                {
                    await ctx.Channel.SendMessageAsync("STRIIIIIIIIIIIKKING " + discordMember.Nickname);
                    break;
                }
                else
                    //await ctx.Channel.SendMessageAsync(targetMember + " is not part of this channel and/or server");
                    continue;
            }
         }

    }
}
