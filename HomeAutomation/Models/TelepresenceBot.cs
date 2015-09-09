using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAutomation.Models
{
    public class TelepresenceBot
    {
        public virtual int TelepresenceBotId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Status { get; set; }
    }
}