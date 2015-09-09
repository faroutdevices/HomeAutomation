using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAutomation.Models
{
    public class Battery
    {
        public virtual int BatteryId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Status { get; set; }
    }
}