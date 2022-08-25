using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotWPF
{
    class BotMessageLog
    {
        public string Date { get; set; }

        public long Id { get; set; }

        public string Message { get; set; }

        public string Name { get; set; }

        public BotMessageLog(string Date, long Id, string Message, string Name)
        {
            this.Date = Date;
            this.Id = Id;
            this.Message = Message;
            this.Name = Name;
        }


    }
}
