﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VORBS.Models.DTOs
{
    public class RoomDTO
    {
        public int ID { get; set; }

        public string RoomName { get; set; }
        public int ComputerCount { get; set; }
        public int PhoneCount { get; set; }
        public bool SmartRoom { get; set; }

    }
}