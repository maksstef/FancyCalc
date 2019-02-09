﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            //throw new NotImplementedException();
            double n1 = 0;
            double n2 = 0;

            string[] strarr = expression.Split();
            string znak;
            if (strarr[1] == " ")
            {
                n1 = Double.Parse(strarr[0]);
                n2 = Double.Parse(strarr[4]);
                znak = strarr[2];
            }
            else
            {
                n1 = Double.Parse(strarr[0]);
                n2 = Double.Parse(strarr[2]);
                znak = strarr[1];
            }

            if (znak == "+")
                return n1 + n2;
            else if (znak == "-")
                return n1 - n2;
            else if (znak == "*")
            {
                if(n1 == 0 || n2 == 0)
                {
                    return 0;
                }
                return n1 * n2;
            }
            else
                return 0;
        }
    }
}