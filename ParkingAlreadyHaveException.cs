﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("Такой объект уже существует")
        {
        }
    }
}
