﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public int wins;
        public string name;
        public string chosenGesture;
        List<string> gestures = new List<string> ();
        gestures.Add("Rock");
    }
}
