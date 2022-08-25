using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;
using Discord.Net;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;


namespace DiscordBotWPF
{
    class MessageClient
    {
        private MainWindow main;

        private DiscordSocketClient _bot;

        public ObservableCollection<BotMessageLog> BotMessageLog { get; set; }
             

        //private async Task MainAsync()
        //{

        //    _bot = new DiscordSocketClient();
        //    _bot.Log += Log;


        //    var token = File.ReadAllText(@"C:\Users\pyatn\source\repos\SkillBox_bot\SkillBox_bot\bin\Debug\Token.txt");

        //    await _bot.LoginAsync(TokenType.Bot, token);
        //    await _bot.StartAsync();
        //}

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        public DiscordSocketClient client(MainWindow W,string PathToken = @"C:\Users\pyatn\source\repos\SkillBox_bot\SkillBox_bot\bin\Debug\Token.txt")
        {
            this.BotMessageLog = new ObservableCollection<BotMessageLog>();
            this.main = W;

            _bot = new DiscordSocketClient();
            _bot = File.ReadAllText(PathToken);
            _bot.Log += Log;

        }

    }
}
