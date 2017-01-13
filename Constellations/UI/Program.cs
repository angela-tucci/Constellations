﻿/*
Author: Angela Tucci
Date: 12/30/2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constellations.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Application.Run(new MainForm()); //run the main form
            }
            catch(Exception e)
            {

            }
        }
    }
}
