﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1c.Models
{
    public class LogModel
    {
        // The ID of the record
        public string ID { get; set; } = Guid.NewGuid().ToString();

        // The Event Type
        // Todo, change to an Enum
        public int EventType { get; set; }

        // The Value Sent by the Phone, as a string
        public string Value { get; set; }

        // Recorded Date Time at the Server
        public DateTime RecordedDateTime { get; set; } = DateTime.Now;

        // ID of the Phone as a quid
        public string PhoneID { get; set; }

        // App Version string
        public string AppVersion { get; set; }

        /// <summary>
        /// Constructor for Log Model
        /// Calls to Initialize to set initial settings
        /// </summary>
        public LogModel()
        {
            Initialize();
        }

        /// <summary>
        /// Intialize
        /// Sets default values, such as DateTime as needed by the system
        /// </summary>
        public void Initialize()
        {
            // None right now...
        }

        /// <summary>
        /// Update fields passed in
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Update(LogModel data)
        {
            if (data == null)
            {
                return false;
            }

            EventType = data.EventType;
            Value = data.Value;
            RecordedDateTime = data.RecordedDateTime;
            PhoneID = data.PhoneID;
            AppVersion = AppVersion;

            return true;
        }
    }
}