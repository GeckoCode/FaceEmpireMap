﻿using EnhancedMap.Core.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedMap.Core
{
    public static class MouseManager
    {
        public static Position Location { get; set; } = new Position();
        public static bool IsEnter { get; set; }
        public static bool LeftIsPressed { get; set; }
        public static bool RightIsPressed { get; set; }
        public static bool IsMove { get; set; }
        public static bool IsDragging => LeftIsPressed && IsMove;

        public static bool IsOverAnObject { get; set; }
    }
}
