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

namespace Constellations.Data
{
    interface IConstellationData
    {
        //method to get the constellations from the file
        IEnumerable<Constellation> GetConstellationInfo();
    }
}
