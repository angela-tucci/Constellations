/*
Author: Angela Tucci
Date: 12/30/2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constellations.Data
{
    class RepoFactory
    {
        //method to get each type of file that can be read from
        public static IConstellationData GetRepo(string repoName)
        {
            Type repo = Type.GetType("Constellations.Data." + repoName);//gets the actual type
            return (IConstellationData)Activator.CreateInstance(repo);//returns an instance of the type
        }
    }
}
