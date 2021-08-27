﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachineParkSim.Models
{
    public class IotDeviceModel
    {
        public string DeviceId { get; set; } = "Not available";
        public string DeviceName { get; set; } = "Not available";
        public string ConnectionState { get; set; } = "Offline";
        public string Status { get; set; } = "Disabled";
        public string JsonData { get; set; } = "No data present";
        public DateTime JsonDataLastUpdated { get; set; } = DateTime.Now;
        //public bool AllowSending { get; set; } = false;
    }
}
