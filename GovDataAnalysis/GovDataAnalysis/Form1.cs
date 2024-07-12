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
        private void DisplayOutput()
        {
            string path = @"C:\Users\User\source\repos\GovTest\GovTest\Sachsen2021.csv"; //Dateipfad (Rechtsklick auf Sachsen2021/2022/2023 -> Vollst�ndigen Pfad kopieren -> in die "" einf�gen
            StreamReader reader = null;
            reader = new StreamReader(File.OpenRead(path)); //csv Datei wird ge�ffnet
            while (!reader.EndOfStream) 
            {
                var line = reader.ReadLine();
                var values = line.Split('|'); //Am Ende jeder Zeile muss ein | stehen, damit der reader in die n�chste Zeile �bergeht
                string output = values[0]; //Output
                textBox1.AppendText(output + Environment.NewLine); // Auch Output (?)
            }
        }
    }
}
