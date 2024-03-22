using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task1
{
    internal class Staff:Person
    {
        private string School;
        private double Pay;
        public Staff(string school, double pay, string name, string address) : base(name, address)
        {
            Name = name;
            Address = address;
            School = school;
            Pay = pay;
        }
        public void SetSchool(string school)
        {
            School = school;
        }
        public void SetPay(double pay)
        {
            Pay = pay;
        }
        public string Getschool()
        {
            return School;
        }
        public double GetPay()
        {
            return Pay;
        }
        public string ToStringStaff()
        {
            return $"Name: {Name},address: {Address},School: {School},Pay: {Pay}";
        }
    }
}
