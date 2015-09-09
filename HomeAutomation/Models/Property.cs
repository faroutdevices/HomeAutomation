using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeAutomation.Models
{
    public class Property
    {
        public virtual int PropertyId { get; set; }
        public virtual int LightId { get; set; }
        public virtual int LockId { get; set; }
        public virtual int CameraId { get; set; }
        public virtual int MotionDetectorId { get; set; }
        public virtual int BatteryId { get; set; }
        public virtual int TelepresenceBotId { get; set; }

        public virtual string PropertyName { get; set; }
        public virtual List<Light> Light { get; set; }
        public virtual List<Lock> Lock { get; set; }
        public virtual List<Camera> Camera { get; set; }
        public virtual List<MotionDetector> MotionDetector { get; set; }
        public virtual List<Battery> Battery { get; set; }
        public virtual List<TelepresenceBot> TelepresenceBot { get; set; }
    }
}