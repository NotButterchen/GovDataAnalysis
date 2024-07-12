using System;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;

namespace GovDataAnalysis
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}