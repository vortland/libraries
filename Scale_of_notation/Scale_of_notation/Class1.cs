﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scale_of_notation
{
    public class SON
    {
        private int[] number;
        private int scale;
        public SON(int scale)
        {
            this.scale = scale;
            number = new int[1];
        }
        public int this[int index]
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
        public static SON operator +(SON obj1,int obj2)
        {
            for (int i=0;obj2>0;i++)
            {
                if (i==obj1.Get_lenght())
                    Array.Resize(ref obj1.number, obj1.number.Length + 1);
                obj1.number[i] = obj1.number[i] + obj2;
                if(obj1.number[i]>obj1.scale-1)
                {
                    obj2 = (obj1.number[i] - obj1.number[i] % obj1.scale)/obj1.scale;
                    obj1.number[i] = obj1.number[i] % obj1.scale;
                    
                }
                else
                {
                    obj2 = 0;
                }
                
            }
            return obj1;
        }
        public int Get_lenght()
        {
            return number.Length;
        }
    }
}

