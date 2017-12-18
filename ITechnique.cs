﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_v2._0 { 
    public interface ITech
    {
        void moveUFO(Graphics g);
        void drawUFO(Graphics g);
        void setPosition(int x, int y);
        void loadPassenger(int count);
        int getPassenger();

    }
}