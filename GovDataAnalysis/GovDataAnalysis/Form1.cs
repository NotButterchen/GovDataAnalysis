using CsvHelper;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

public enum Month
{
    Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
}

namespace GovDataAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayOutput();
        }

        public class CsvData21
        {
            public string ZeileEins { get; set; } //Beschäftigtenindex, Umsatzindex nominal, Umsatzindex real.
            public string Sektor { get; set; }
            public Dictionary<Month, decimal> MonthlyValues { get; set; } //Einzelnen Zahle, sortiert nach Monaten.

            public CsvData21()
            {
                MonthlyValues = new Dictionary<Month, decimal>(); //Neue Bibliothek wird erstellt, in der alles die Werte: "Monate & Dezimal" haben
                foreach (Month month in Enum.GetValues(typeof(Month)))
                {
                    MonthlyValues.Add(month, 0); //Anfangs wird jeder Wert jedes Monats auf 0 gesetzt, einfach ein Failsave praktisch.
                }
            }
        }
        private List<CsvData21> CsvToClass(string filePath) //Die csv Datei wird gelesen & einer Klasse zugewiesen.
        {
            var dataList = new List<CsvData21>(); // in dataList kommen die Daten rein, CsvData21 ist die Klasse (Name temporär).
            using (StreamReader reader = new StreamReader(filePath)) //Datei wird geöffnet
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';'); //Zeile wird gelesen und bei ";" enden die Zeilen (Auch wenns nicht so aussieht, so funktioniert .

                    if (values.Length < 14) // Stelle sicher, dass jede Zeile mindestens 14 Spalten hat
                    {
                        continue;
                    }

                    var data = new CsvData21
                    {
                        ZeileEins = values[0],
                        Sektor = values[1],
                        MonthlyValues = new Dictionary<Month, decimal>() //Neue Bibliothek wird geöffnet
                    };
                    int monthIndex = 2;  // Startet nach "ZeileEins" und "Sektor"

                    foreach (Month month in Enum.GetValues(typeof(Month))) //für jeden Monat
                    {
                        decimal parsedValue;
                        if (Decimal.TryParse(values[monthIndex++], NumberStyles.Any, CultureInfo.GetCultureInfo("de-DE"), out parsedValue)) //Damit ein Komma wie ein Punkt gewertet wird
                        {
                            data.MonthlyValues[month] = parsedValue; //Wertzusweisung
                        }
                        else
                        {
                            data.MonthlyValues[month] = 0;
                        }
                    }
                    dataList.Add(data);
                }
            }
            return dataList;
        }


        private void DisplayOutput()
        {
            string path = @"C:\Users\User\source\repos\GovTest\GovTest\Sachsen2021.csv"; //Pfad der .csv
            var dataList = CsvToClass(path); //Methode CsvToClass aufgerufen mit dem Pfad

            foreach (var data in dataList) //Output
            {
                string outputSekt = data.Sektor;
                string outputEins = data.ZeileEins;
                string outputMonth = string.Join("   ", data.MonthlyValues.Values);
                //textBox1.AppendText(output + Environment.NewLine); 
            }
        }
    }
}
