﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Interactivity;
using Newtonsoft.Json;
using DSharpPlus.Interactivity.Extensions;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using DSharpPlus.EventArgs;

namespace DiscordBot
{
    public class Bot
    {
        public DiscordClient Client { get; private set; }
        public InteractivityExtension interactivity { get; private set; }
        public CommandsNextExtension Commands { get; private set; }

        public async Task RunAsync()
        {
            var json = string.Empty;
            using (FileStream fs = File.OpenRead("config.json"))
            using (StreamReader sr = new StreamReader(fs, new UTF8Encoding(false)))
            {
                json = await sr.ReadToEndAsync();
            }
            var configJson = JsonConvert.DeserializeObject<configJSON>(json);
            var config = new DiscordConfiguration()
            {
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,

            };
            Client = new DiscordClient(config);
            Client.UseInteractivity(new InteractivityConfiguration() { Timeout = TimeSpan.FromMinutes(2) });

            var commandConfig = new CommandsNextConfiguration() 
            { 
                CaseSensitive = true, 
                StringPrefixes = new string[] { configJson.Prefix },
                EnableMentionPrefix = true,
                EnableDefaultHelp = false,
            };

            Commands = Client.GetCommandsNext();

            await Client.ConnectAsync();
            await Task.Delay(-1);
        }
        
        private Task onClientReady(ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}
