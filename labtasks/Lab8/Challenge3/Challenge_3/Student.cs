using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Student:Person
    {
        private string Program;
        private double Fee;
        private int Year;
        public Student(string name, string address,string program, int year, double fee):base( name,address)
        {
            Program = program;
            Name = name;
            Address = address;
            Year = year;
            Fee = fee;

        }
        public string GetProgram()
        {
            return Program; 
        }
        public double Getfee()
        {
            return Fee;
        }
         public int GetYear()
            {
                return Year;
            }
        public void  SetProgram(string program)
        {
            Program = program;  
        }
        public void Setfee(double fee)
        {
            Fee= fee;

        }
        public void SetYear(int year)
        {
           Year = year;
        }
        public string ToStringStudent()
        {
            return $"Name: {Name},address: {Address},Program: {Program},Year: {Year},Fee: {Fee}";
        }
    }
}
