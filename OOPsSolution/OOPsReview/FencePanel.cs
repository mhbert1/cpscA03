﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //by default all class are private
    //for this class to be used by an outside user
    //   you must alter the permission for this class
    //   you will use public

    public class FencePanel
    {
        //properties is associated with a single piece of data
        // a property has two sub components:
        // get:returns a value from the calling chlient
        // set: recieve a value is used to hold the incoming data to the property
        // the property has a return datatype (rdt) which specifies the type of data allowed
        // theproperty syntax does NOT allow for a parameter.

        // auto implemented Property:
        //this style does NOT need a private data member
        //this system will create an internal data member of the rdt specified in the porperty definition
        //public double Height { get; set; } what about negs num

        //assuming you wish to validate your data, then you should be using a fully implemented property
        // heigth must be +non zero value and not greater than 8ft
        private double _Height;
        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                //validation of data
                //throe exception is invalid
                if (value > 0.0 && value <= 8.0)
                {
                    _Height = value;
                }
                else
                {
                    throw new Exception("Invalid Height");
                }
            }
        }
        public double Width { get; set; }


        //fully implemented property:
        //this style NEEDS a private data member
        // the private data member will store the incoming data value
        //usually, this form or property is used when additional coding is required for the incoming data such as: validation of data

        //example: the string data CAN NOT be an empty string
        private string _Style;

        public string Style
        {
            //the keyword "value" holds the incoming data to the property
            get
            {
                //returns the stored data value
                return _Style;
            }

            set
            {
                //stores the incoming value in "value" to the private data member for storage
                if(string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
            }
        }

        //nullable numeric property for a  double.
        //there are only two posibillity: data is missing: null 
        //data is present and is of the right dztatype

        public double? Price { get; set; }

        //constructors

        //either you code your constructors or yuo omit your constructor
        //if omit contructors than the sys will initialize your data member to the natural sys defaults for that data member datatype.
        //if you code any constructor you are responsible for coding all constructor to be used by this class

        //default
        //simulates the sys initialization of your data
        //default execute on a : new FencePanel()

        public FencePanel ()
        {
            Height = 6.0;
            Width = 8.0;
        }

        //greedie: the constructor has a list of parameters which will receive an argument value for each property in the class
        public FencePanel(double height, double width, string style, double? price)
        {
            Height = height;
            Width = width;
            Style = style;
            Price = price;
        }

        //behaviours (aka methods)
        public double EstimatedNumberOfPanels(double linearlength)
        {
            //you could use either the property Width of the data member _Width
            //using the property ensure all validation or excess logic is in play
            double numberofpanels = linearlength / Width; //_Width
            return numberofpanels;
        }

        public double FenceArea(double linearlength)
        {
            return linearlength * Height;            
        }
    }
}
