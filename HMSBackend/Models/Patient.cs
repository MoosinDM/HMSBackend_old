﻿namespace HMSBackend.Models
{
    public class Patient
    {
        public string patient_id { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string doctor_id { get; set; }
        public string reg_by { get; set; }

    }
}
