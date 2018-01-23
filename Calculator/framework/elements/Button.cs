﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace Calculator.framework.elements
{
    class Button : BaseElement
    {
        public Button(Window window, SearchCriteria searchCriteria, string name) : base(name, searchCriteria, window)
        {
            //
        }
    }
}
