using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_mid
{
    class HouseProject
    {
        private string name;
        private House[] houses = new House[10];
        public string Name { get => name; set => name = value; }
        public HouseProject(string name)
        {
            this.name = name;
        }
        public void setHouse(House h, int index)
        {
            this.houses[index] = h;
        }
        public House GetHouse(int index)
        {
            return this.houses[index];
        }
        public void listAllHouse()
        {
            for (int i = 0; i < this.houses.Length; i++)
            {
                if (this.houses[i] != null)
                {
                    Console.WriteLine(this.houses[i].ToString());
                }
            }
        }
    }
}
