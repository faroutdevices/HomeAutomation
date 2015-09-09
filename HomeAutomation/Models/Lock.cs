using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAutomation.Models
{
    public class Lock
    {
        public virtual int LockId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string AccessCode { get; set; }
    }
}