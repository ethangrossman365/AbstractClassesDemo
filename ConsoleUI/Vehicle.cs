using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "Default Value";
        public string Make { get; set; } = "Default Value";
        public string Model { get; set; } = "Default Value";

        public abstract void DriveAbstract();
        public virtual void DriveVirutal()
        {
            Console.WriteLine("Default Virtual Drive Method");
        }


    }
}
