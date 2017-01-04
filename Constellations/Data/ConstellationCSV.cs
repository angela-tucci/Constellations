/*
Author: Angela Tucci
Date: 12/30/2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constellations.Model;
using System.IO;

namespace Constellations.Data
{
    class ConstellationCSV : IConstellationData //implement the interface
    {
        public IEnumerable<Constellation> GetConstellationInfo()
        {
            StreamReader sr = null;
            string info = "";
            //create a list to hold all of the constellations in the CSV file
            List<Constellation> constellations = new List<Constellation>();

            using(sr = new StreamReader("Constellations.csv"))
            {
                //while the current line contains information...
                while((info = sr.ReadLine()) != null)
                {
                    //add a constelltion to the list
                    constellations.Add(new Constellation(info));
                }
            }
            //return the completed list
            return constellations;
        }
    }
}
