//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sensor
    {
        public int sensorId { get; set; }
        public string sensorMac { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    
        public virtual SensorPresence SensorPresence { get; set; }
    }
}