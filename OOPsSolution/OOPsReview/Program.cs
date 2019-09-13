using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        //assume you know how to obtain user entered data
        static void Main(string[] args)
        {
            double height = 6.5;
            double width = 8.0;
            double linearlength = 135.0;
            string style = "Neighbour Friendly: Spruce";
            double price = 108.00;

            //store the fence data
            // declare a storage area for the fence data

            //create a non-static instance of a class
            //use the new command to create the class instance
            //the new command references the class constructor
            FencePanel fenceInfo = new FencePanel(height, width, style, price); //greedie

            //obtain and store gate info
            Gate gateinfo;
            List<Gate> gatelist = new List<Gate>();

            //assume looping to obtain all gate data
            //each loop is one gate
            //pass 1
            gateinfo = new Gate(); //system constructor since Gate has NO constructors
            height = 6.25;
            width = 4.0;
            style = "Neighbour Frienly 1/2 Picket: Spruce";
            price = 86.45;
            gateinfo.Height = height;
            gateinfo.Width = width;
            gateinfo.Style = style;
            gateinfo.Price = price;
            gatelist.Add(gateinfo);

            //pass 2
            gateinfo = new Gate(); //system constructor since Gate has NO constructors
            height = 6.25;
            width = 3.25;
            style = "Neighbour Frienly: Spruce";
            price = 86.45;
            gateinfo.Height = height;
            gateinfo.Width = width;
            gateinfo.Style = style;
            gateinfo.Price = price;
            gatelist.Add(gateinfo);

            //assume end of gate looping

            //create the Estimate
            Estimate theEstimate = new Estimate() //class default constructor
            theEstimate.LinearLenght = linearlength;
            theEstimate.Panel = fenceInfo;
            theEstimate.Gates = gatelist;
            theEstimate.CalculatePrice();


            //client wishes an output of the estimate
            Console.WriteLine("The fence is to be a " + theEstimate.Panel.Style + " style");
            Console.WriteLine("Total linear length requested {0}", theEstimate.LinearLength);
            Console.WriteLine("Number of required panels: {0}"), theEstimate.Panel.EstimatedNumberOfPanels(theEstimate.LinearLength));
            Console.WriteLine("Number of gates: {0}"), theEstimate.Gates.Count);
            double fenceArea = theEstimate.Panel.FenceArea(theEstimate.LinearLength);
            foreach(var item in theEstimate.Gates)
            {
                fenceArea += item.GateArea();
            }
        }
    }
}
