﻿using System;

namespace AmadeusW.Mirror.GUI.Transit
{
    public class ArrivalViewModel
    {
        public string RouteName { get; set; }
        public int WhenINeedToLeave { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}