using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    public class Dewey_Decimal
    {
        private double callNumberPart;
        private string descriptionPart;



        public Dewey_Decimal()
        {
        }

        public Dewey_Decimal(string v)
        {
        }

        public Dewey_Decimal(double callNum, string desc)
        {
            this.callNumberPart = callNum;
            this.descriptionPart = desc;
        }

        public static int Count { get; internal set; }

        public double CallNumberPart { get => callNumberPart; set => callNumberPart = value; }
        public string DescriptionPart { get => descriptionPart; set => descriptionPart = value; }


        override public string ToString()
        {
            string callpart = this.CallNumberPart.ToString("000");
            string NumCall = String.Format("{0} {1}", callpart, this.descriptionPart);
            return NumCall;
        }
    }
}