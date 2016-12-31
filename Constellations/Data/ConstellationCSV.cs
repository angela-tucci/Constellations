using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constellations.Model;
using System.IO;

namespace Constellations.Data
{
    class ConstellationCSV : IConstellationData
    {
        public IEnumerable<Constellation> GetConstellationInfo()
        {
            StreamReader sr = null;
            string info = "";
            List<Constellation> constellations = new List<Constellation>();

            using(sr = new StreamReader("Constellations.csv"))
            {
                while((info = sr.ReadLine()) != null)
                {
                    constellations.Add(new Constellation(info));
                }
            }

            return constellations;
        }
    }
}
