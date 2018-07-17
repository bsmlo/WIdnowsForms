// Klasa tworzaca wykres

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace OpenPicture
{
    public partial class PlotForm : Form
    {
        // Zmienna liczby danych na wykresie
        public int numPoints;

        public PlotForm()
        {
            // Inicjowanie elementu
            InitializeComponent();
        }

        // Obsluga pokazania wykresu-wczytuje dane przechowane w klasie GraphForm
        private void button1_Click(object sender, EventArgs e)
        {
            // Wczytanie do list Red Green Blue danych z klasy GraphFomr
            for (int i = 0; i < GraphForm.RedPix.Count(); i++)
            {
                chart1.Series["Red"].Points.AddXY(i, GraphForm.RedPix[i]);
                chart1.Series["Green"].Points.AddXY(i, GraphForm.GreenPix[i]);
                chart1.Series["Blue"].Points.AddXY(i, GraphForm.BluePix[i]);

                // Wczytanie temperatury
                if (Settings.IncludeTemp == true)
                {
                    chart1.Series["Temperature"].Points.AddXY(i, GraphForm.Temperature[i]);
                }
                else
                {
                    // Usuniecie serii Temperature jesli nie bylo jej odczytu
                    chart1.Series["Temperature"].Enabled = false;
                }

                // Zaladowanie danych do serii 
                chart1.Series["RedBack"].Points.AddXY(i, GraphFormBack.RedPix[i]);
                chart1.Series["GreenBack"].Points.AddXY(i, GraphFormBack.GreenPix[i]);
                chart1.Series["BlueBack"].Points.AddXY(i, GraphFormBack.BluePix[i]);
            }

            // Ustawienie grubosci linii i kolorow dla kazdej z nich - dane z krysztalu
            chart1.Series["Red"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Red"].Color = Color.Red;

            chart1.Series["Green"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Green"].Color = Color.Green;

            chart1.Series["Blue"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Blue"].Color = Color.Blue;

            if (Settings.IncludeTemp == true)
            {
                chart1.Series["Temperature"].ChartType = SeriesChartType.FastLine;
                chart1.Series["Temperature"].Color = Color.Black;
            }

            // Ustawienie grubosci linii i kolorow dla kazdej z nich - dane z tla
            chart1.Series["RedBack"].ChartType = SeriesChartType.FastPoint;
            chart1.Series["RedBack"].Color = Color.Red;

            chart1.Series["GreenBack"].ChartType = SeriesChartType.FastPoint;
            chart1.Series["GreenBack"].Color = Color.Green;

            chart1.Series["BlueBack"].ChartType = SeriesChartType.FastPoint;
            chart1.Series["BlueBack"].Color = Color.Blue;
            button1.Enabled = false;
        }


        // Funkcja czyszczaca wszystkie serie z wykresu
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Red"].Points.Clear();
            chart1.Series["Green"].Points.Clear();
            chart1.Series["Blue"].Points.Clear();
            chart1.Series["Temperature"].Points.Clear();

            chart1.Series["RedBack"].Points.Clear();
            chart1.Series["GreenBack"].Points.Clear();
            chart1.Series["BlueBack"].Points.Clear();

            button1.Enabled = true;
        }


        // Funkcja zapisu danych do pliku log i wykresu
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            // Tworzenie nazwy pliku graficznego z wykreem
            string name = string.Format("{0}\\{1}.png", DictionarySave.LocationDic.ToString(),
                DateTime.Now.ToString("dd_mm_yyyy hh mm ss"));

            // Tworzenie nazwy pliku log
            string nameLog = string.Format("{0}\\{1}.txt", DictionarySave.LocationDic.ToString(),
                DateTime.Now.ToString("dd_mm_yyyy hh mm ss"));

            // Wyswietla utrzworzna nazwe pliku
            MessageBox.Show(name);
            // Zapis wykresu
            chart1.SaveImage(name, ChartImageFormat.Png);

            // Tworzenie pliku tekstowego
            System.IO.StreamWriter file = new System.IO.StreamWriter(nameLog, true);

            // Zapis w pliku podpisow kolumn
            file.WriteLine("Red;dRed;Green;dGreen;Blue;dBlue;RedBack;dRedRedBack;GreenRedBack;dGreenRedBack;BlueRedBack;dBlueRedBack;Temperature");
            if (Settings.IncludeTemp == true)
            {
                for (int i = 0; i < GraphForm.RedPix.Count(); i++)
                {
                    // Zapis o LOG wszytkich danych z seri wykresow
                    file.WriteLine(string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12}",
                        GraphForm.RedPix[i].ToString(), DevGraphForm.RedPix[i].ToString(),
                        GraphForm.GreenPix[i].ToString(), DevGraphForm.GreenPix[i].ToString(),
                        GraphForm.BluePix[i].ToString(), DevGraphForm.BluePix[i].ToString(),
                        GraphFormBack.RedPix[i].ToString(), DevGraphFormBack.RedPix[i].ToString(),
                        GraphFormBack.GreenPix[i].ToString(), DevGraphFormBack.GreenPix[i].ToString(),
                        GraphFormBack.BluePix[i].ToString(), DevGraphFormBack.BluePix[i].ToString(),
                        GraphForm.Temperature[i].ToString()));
                }
                // Zamkniecie pliku
                file.Close();
            }
            // Zapis w przypdaku nieodczytania temperatury
            if (Settings.IncludeTemp == false)
            {
                for (int i = 0; i < GraphForm.RedPix.Count(); i++)
                {
                    file.WriteLine(string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11}",
                        GraphForm.RedPix[i].ToString(), DevGraphForm.RedPix[i].ToString(),
                        GraphForm.GreenPix[i].ToString(), DevGraphForm.GreenPix[i].ToString(),
                        GraphForm.BluePix[i].ToString(), DevGraphForm.BluePix[i].ToString(),
                        GraphFormBack.RedPix[i].ToString(), DevGraphFormBack.RedPix[i].ToString(),
                        GraphFormBack.GreenPix[i].ToString(), DevGraphFormBack.GreenPix[i].ToString(),
                        GraphFormBack.BluePix[i].ToString(), DevGraphFormBack.BluePix[i].ToString()));
                }
                // Zamkniecie pliku
                file.Close();
            }
        }

    }
}
