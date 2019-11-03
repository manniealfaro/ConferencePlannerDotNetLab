﻿using System;
using System.Collections.Generic;

namespace Backend.Data
{
    public class Attendee : ConferenceDTO.Attendee
    {
        public virtual ICollection<ConferenceAttendee> ConferenceAttendees { get; set; }

        public virtual ICollection<SessionAttendee> SessionsAttendees { get; set; }
    }
}