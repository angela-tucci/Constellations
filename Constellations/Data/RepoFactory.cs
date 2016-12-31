using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constellations.Data
{
    class RepoFactory
    {
        public static IConstellationData GetRepo(string repoName)
        {
            Type repo = Type.GetType("Constellations.Data." + repoName);//gets the actual type
            return (IConstellationData)Activator.CreateInstance(repo);//returns an instance of the type
        }
    }
}
