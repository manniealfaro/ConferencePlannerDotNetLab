﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class SessionAttendee
    {
        public int SessionID { get; set; }

        public Session Session { get; set; }

        public int AttendeeID { get; set; }

        public Attendee Attendee { get; set; }
    }
}