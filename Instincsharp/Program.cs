using DSharpPlus;
using DSharpPlus.CommandsNext;
using Instincsharp.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instincsharp
{
    internal class Program
    {
        private static DiscordClient Instinc { get; set; }
        private static CommandsNextExtension Commands { get; set; }
        static async Task Main(string[] args)
        {
            var jsonReader = new Reader();
            await jsonReader.ReadJSON();

            var discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = jsonReader.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };

            Instinc = new DiscordClient(discordConfig);

            Instinc.Ready += Instinc_Ready;
            await Instinc.ConnectAsync();
            await Task.Delay(-1);
        }

        private static Task Instinc_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
