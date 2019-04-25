using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        //Properties of a class - private variables here that help us define properties of a car (or of the class)
       private string colour;
       private int numberOfDoors;
       private bool isAConvertable;
        //create constructor here (what you need to create objects of the class
        public Car(string carColour,int doors, bool convertable) // always set these to the get and set property values not the class properties above
        {
            Colour = carColour;
            NumberOfDoors = doors;
            IsAConvertable = convertable;
        }
        // add get and set accessors- used to define properties (noun like attributes)
        public string Colour
        {
            get
            {
                return colour;
            }

            set
            {
                colour = value;
            }
        }

        public bool IsAConvertable
        {
            get;set;
        }

        public int NumberOfDoors
        {
            get
            {
                return numberOfDoors;
            }
            set
            {
                if(value <= 5)
                {
                    numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("That is an invalid number of doors");
                }
            }
        }

        //Methods- verb attributes that tell what a class can do

        public bool FamilyCar()
        {
            if (numberOfDoors != 4)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

    }
}
