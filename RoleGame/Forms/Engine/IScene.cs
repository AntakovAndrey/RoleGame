﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Engine
{
    internal interface IScene
    {
        void DrawBack(Graphics g, int x, int y);
        void DrawObjects(Graphics g);
        
    }
}
