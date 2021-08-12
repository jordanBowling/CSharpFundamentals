﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Fruits
{
    class Banana : IFruit
    {
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get { return "Banana"; }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peeled the banana.";
        }
    }

    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get { return "Orange"; }
        }
        public bool IsPeeled { get; private set; }
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "You peel the orange";

            }
        }

        public string Squeeze()
        {
            return "You squeeze the orange";
        }


    }
    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }

        public bool IsPeeled { get; } = false;
        public string Peel()
        {
            return "Who peels grapes?";
        }
    }
}
