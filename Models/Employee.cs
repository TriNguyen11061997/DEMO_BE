using System;
using System.Data.SqlTypes;
using System.Runtime.Serialization;
namespace DEMO_2.Models {
    public class Employee {
        public int ID { get; set; }
        public string Name { get; set; }
        public double BirthDay { get; set; }

        public string Desc { get; set; }
    }
}