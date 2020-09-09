using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_mid
{
    class Decoration
    {
        private string name;
        private int cost;
        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public Decoration()
        {
        }
        public Decoration(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
        public override string ToString()
        {
            return "Style" + this.Name + " " +
                "The cose" + this.Cost + " " + "Bath";
        }
    }
}
