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
        IEnumerable<Constellation> GetConstellationInfo();
    }
}
