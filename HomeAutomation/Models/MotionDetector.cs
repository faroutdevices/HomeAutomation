using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAutomation.Models
{
    public class MotionDetector
    {
        public virtual int MotionDetectorId { get; set; }
        public virtual string Name { get; set; }
        public virtual int Status { get; set; }
    }
}