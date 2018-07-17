//------------------------------------------------------------------//
//                                                                  //
//Open Picture 2017                                                 //
//Mariusz Wrobel                                                    //
//Fizyka Ogolna                                                     //
//Instytut Fizyki Katowice                                          //
//Praca Licencjacka-Optyczne badania przejsc spinowych              //
//                                                                  //
//------------------------------------------------------------------//
// Glowna klasa programu dla okna MiainPage

//Importowanie bibliotek
using System;                       // systemowa
using System.Collections.Generic;   // obsluga danych
using System.Data;                  // obsluga czasu
using System.Drawing;               // funkcje rysowania
using System.Linq;                  // obsluga plikow/lokalizaji
using System.Drawing.Drawing2D;     // funkcje rysowania ksztaltow
using System.IO;                    // obsluga wejscia i wyjscia
using System.Windows.Forms;         // funkcje graficzne


namespace OpenPicture
{
    // Klasa glownego okna aplikacji
    // Wybieramy tutaj folder wczytywania i zapisu zdjec
    // Umozliwia przegladanie kazdego obrazu
    // Ustawianie obszaru do analizy RGB
    // Wywolanie klasy PlitFrom generujacej wykres

    public partial class OpenPicture : Form
    {
        // Deklarowanie zmiennych przechowujacych informacjie o obszarze analizy
        public int xi = 360, yi = 285, wii = 25, lei = 25; // Obszar krysztalu

        public int xiBack = 360, yiBack = 285, wiiBack = 25, leiBack = 25;  // Obszar tla

        // Funkcja inicjalizujaca program
        public OpenPicture()
        {
            InitializeComponent(); // Inicjacja programu

            // Ustawienia domyslne ustawien czytania temperatury
            Settings.IncludeTemp = true;

            // Zmienna sprawdzajaca czy zostaly zmienione ustawienia odczytu temperatury z nazwy
            Settings.NewIndex = false;

            // Deklaracja podpisow przyciskow
            ToolTip ToolTip = new ToolTip();

            // Podpisy dla kazdego przycisku
            ToolTip.SetToolTip(showButton, "Open one picture.");
            ToolTip.SetToolTip(clearButton, "Clear the picture box.");
            ToolTip.SetToolTip(searchButton, "Open file location.");
            ToolTip.SetToolTip(plotButton, "Get plot of RGB from selected pictures.");
            ToolTip.SetToolTip(uncheckedButton, "Uncheck all items from the list.");
            ToolTip.SetToolTip(loadUndo, "Load previous picture.");
            ToolTip.SetToolTip(loadNext, "Load next picture.");
            ToolTip.SetToolTip(saveChedked, "Save checked pictures to new folder.");
            ToolTip.SetToolTip(checkedButton, "Check all items from listbox.");

            // Podpisy dla CheckedBox
            ToolTip.SetToolTip(drawingSet, "Thick for set areas to analyse.");
            ToolTip.SetToolTip(setBackG, "Thick for set Background to analyse.");
            ToolTip.SetToolTip(dynamicSearth, "Thick for find photos with selected number.");

            // Podpisy dla sliderow-widoczne gdy slidery sa aktywne
            if (drawingSet.Checked == false)
            {
                ToolTip.SetToolTip(setX, "Set X for area to analyse. ");
                ToolTip.SetToolTip(setY, "Set Y for area to analyse. ");
                ToolTip.SetToolTip(setWidth, "Set Width for area to analyse. ");
                ToolTip.SetToolTip(setLength, "Set Length for area to analyse. ");
            }
        }

        // Funkcja obsługująca przycisk szukania
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Funkcja zwraca null gdy w polu openFileDialog1.FileName zapisane sa inne zmienne
            if (openFileDialog1.FileName.Count() != 0)
            {
                openFileDialog1.FileName = null;
            }

            // Warunek sproawdza poprawność odczytu lokalizacji
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Wywolanie picturebox jesli lokalizacja jest poprawna
                // Tu obraz jest ladowany do podgladu
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        // Obsluga przyciusku Clear-kasujacego aktualny podglad
        private void button2_Click(object sender, EventArgs e)
        {
            // Kasowanie obrazu pictureBox1
            pictureBox1.Image = null;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // Deklaracja zmiennych dla ustawień wyszukiwania
        // Zienne dla lokalizacji folderu, prefix nazwy, format, nazwa

        public FolderBrowserDialog saveFBD;

        public string namePrefix = "";

        public string format = "jpg";

        public string search;


        // Funkcja sortująca nazwy w liscie po długosci
        private void sortItems(string[] files)
        {

            List<string> filesDic = new List<string>();

            List<int> itels = new List<int>();

            // Lista przechowujaca dlugosci nazw kazdego elementu w liscie 
            List<int> nameLength = new List<int>(); 

            List<string> files1 = new List<string>();
            List<string> files2 = new List<string>();

            // Funkcja wypelnia lokalizacjami wszystkich plikow z listy wczytanych
            // do listy files1
            foreach (string file in files)
            {
                files1.Add(file);
            }

            // Sortowanie w liscie po dlugosci
            files1 = files1.OrderBy(q => q).ToList();

            // Warunek usuwa lokalizacje ze wszystkich plikow
            // W liscie files2 zapisuje wylacznie nazwy plikow
            foreach (string file in files1)
            {
                string name = file;
                while (name.Contains("\\"))
                {
                    name = name.Remove(0, file.IndexOf("\\"));
                }
                files2.Add(name);
            }

            // Sortowanie nazw po dlugosciach
            files2 = files2.OrderBy(q => q).ToList();
            foreach (string file in files2)
            {
                // Zapisuje dlugosc nazw do listy nameLength
                nameLength.Add(file.Count()); 
            }

            // Warunek sortujacy dlugosc nazw w liscie
            try
            {
                int j = 0;
                while (j <= nameLength.Max() - nameLength.Min())
                {

                    for (int i = 0; i <= nameLength.Count() - 1; i++)
                    {
                        // Zapisanie indeksow wyrazow odpowiadajace rosnacej kolejnosci nazw
                        if (nameLength[i] == nameLength.Min() + j)
                        {
                            // Lista posortowanych indeksow
                            itels.Add(i);
                        }
                        else
                        {

                        }
                    }
                    j++;
                }

                for (int i = 0; i < itels.Count(); i++)
                {
                    // Uzupelnienie nazw do listy wczytanych pliow posortowanymi w kolejnosci
                    // wykrzystane sa tu indeksy  listy itels
                    checkedListBox1.Items.Add(files[itels[i]]);
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("There is a problem with this operation");
            }

        }



        // Funkcja wprost sortuje wczytane pliki po dlugosci nazw
        private void sortItemsnumb(string[] files)
        {
            List<string> filesDictest = new List<string>();

            foreach (string file in files)
            {
                filesDictest.Add(file);
            }

            filesDictest = filesDictest.OrderBy(q => q).ToList();

            foreach (string file in filesDictest)
            {
                checkedListBox1.Items.Add(file);
            }
        }


        // Funkcja obslugujaca przycisk przeszukiwania
        private void searchButton_Click_1(object sender, EventArgs e)
        {

            FolderBrowserDialog FBD = new FolderBrowserDialog();

            // Zapisanie FBD do dodatkwej zmiennej aby mozliwe bylo ponowne wczytanie z tej samej lokalizacji
            saveFBD = FBD;

            // Tworzenie zmiennej string dla funkcji szukania konkretnego pliku we wszkazanych folderach
            search = string.Format("*{0}.{1}", namePrefix, format);


            if (FBD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Czyszczenie listbox, zapis wyszystkich nowych lokalizacji do listy, 
                    // zaladowanie do checkedlistbox wszystkich nowych lokalizacji
                    checkedListBox1.Items.Clear();
                    string[] files = Directory.GetFileSystemEntries(FBD.SelectedPath, search, SearchOption.AllDirectories);

                    // Wyslanie wszystkich nazw z checkedlistbox do funkcji sortujacej
                    sortItems(files);

                    // Zapisanie lokalizacji wczytanych zdjec do zmiennej string
                    DictionarySave newDic = new DictionarySave(FBD.SelectedPath.ToString());

                    // Zmienna do konrtoli wczytywania obraow od funkcji obliczajacej polozenie obszaru analizy
                    IterateLoadChecking = false;

                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Path is a null reference.");
                }
            }
        }


        // Listy do obslugi obliczen analizy RGB
        
        // Listy wartosci srednich z krysztalu
        public List<int> AveB = new List<int>();
        public List<int> AveR = new List<int>();
        public List<int> AveG = new List<int>();

        // Listy odchylen z krysztalu
        public List<int> DevAveB = new List<int>();
        public List<int> DevAveR = new List<int>();
        public List<int> DevAveG = new List<int>();

        // Listy wartosci srednich z tla
        public List<int> AveBBack = new List<int>();
        public List<int> AveRBack = new List<int>();
        public List<int> AveGBack = new List<int>();

        // Listy odchylen z tla
        public List<int> DevAveBBack = new List<int>();
        public List<int> DevAveRBack = new List<int>();
        public List<int> DevAveGBack = new List<int>();


        // Obliczenie odchylenia ze zmierzonych wartosci z kysztalu
        private void StandardDeviation(List<int> Red, List<int> Green, List<int> Blue)
        {
            // Dev Red
            double averageR = Red.Average();
            double sumOfDerivationR = 0;
            foreach (double valueR in Red)
            {
                sumOfDerivationR += (valueR) * (valueR);
            }
            double sumOfDerivationAverageR = sumOfDerivationR / (Red.Count() - 1);
            DevAveR.Add((int)Math.Sqrt(sumOfDerivationAverageR - (averageR * averageR)));

            // Dev Green
            double averageG = Green.Average();
            double sumOfDerivationG = 0;
            foreach (double valueG in Green)
            {
                sumOfDerivationG += (valueG) * (valueG);
            }
            double sumOfDerivationAverageG = sumOfDerivationG / (Green.Count() - 1);
            DevAveG.Add((int)Math.Sqrt(sumOfDerivationAverageG - (averageG * averageG)));

            // Dev Blue
            double averageB = Blue.Average();
            double sumOfDerivationB = 0;
            foreach (double valueB in Blue)
            {
                sumOfDerivationB += (valueB) * (valueB);
            }
            double sumOfDerivationAverageB = sumOfDerivationB / (Blue.Count() - 1);
            DevAveB.Add((int)Math.Sqrt(sumOfDerivationAverageB - (averageB * averageB)));
        }

        // Obliczenie odchylenia ze zmierzonych wartosci RGB
        private void StandardDeviationBack(List<int> Red, List<int> Green, List<int> Blue)
        {
            // Kolor czerwony
            double averageR = Red.Average();
            double sumOfDerivationR = 0;
            foreach (double valueR in Red)
            {
                sumOfDerivationR += (valueR) * (valueR);
            }
            double sumOfDerivationAverageR = sumOfDerivationR / (Red.Count() - 1);
            DevAveRBack.Add((int)Math.Sqrt(sumOfDerivationAverageR - (averageR * averageR)));

            // Kolor zielony
            double averageG = Green.Average();
            double sumOfDerivationG = 0;
            foreach (double valueG in Green)
            {
                sumOfDerivationG += (valueG) * (valueG);
            }
            double sumOfDerivationAverageG = sumOfDerivationG / (Green.Count() - 1);
            DevAveGBack.Add((int)Math.Sqrt(sumOfDerivationAverageG - (averageG * averageG)));

            // Kolor niebieski
            double averageB = Blue.Average();
            double sumOfDerivationB = 0;
            foreach (double valueB in Blue)
            {
                sumOfDerivationB += (valueB) * (valueB);
            }
            double sumOfDerivationAverageB = sumOfDerivationB / (Blue.Count() - 1);
            DevAveBBack.Add((int)Math.Sqrt(sumOfDerivationAverageB - (averageB * averageB)));
        }


        // Obliczanie odchyleń dla obszaru kryształu i tła
        public void GetPixelFunc(Bitmap bitmap)
        {
            // Zeklarowanie list dla kolorów z krysztalu
            var Blue = new List<int>();
            var Green = new List<int>();
            var Red = new List<int>();
            var Alpha = new List<int>();

            // Zadeklarowanie list dla kolorów z tła
            var BlueBack = new List<int>();
            var GreenBack = new List<int>();
            var RedBack = new List<int>();
            var AlphaBack = new List<int>();

            // Warunek sprawdzający ustwaienie obszaru o niezerowym polu
            if (xi > 0 && yi > 0)
            {
                // Zapis insormacji o kolorze po wyznaczonym obszarze
                // Rozmiar pola w pikselach wii - wysokość, lei - szerokość.
                for (int i = 0; i <= wii; i++)
                {
                    for (int j = 0; j <= lei; j++)
                    {
                        // Pobranie pojedynczo każdego piksela z obszaru
                        Color pixelColor = bitmap.GetPixel(xi + i, yi + j);
                        Blue.Add(pixelColor.B);
                        Green.Add(pixelColor.G);
                        Red.Add(pixelColor.R);
                    }
                }
            }

            // Obliczenia dla tła
            if (xiBack > 0 && yiBack > 0)
            {
                // Zapis insormacji o kolorze po wyznaczonym obszarze
                // Rozmiar pola w pikselach wiiBack - wysokość, leiBack - szerokość.
                for (int i = 0; i <= wiiBack; i++)
                {
                    for (int j = 0; j <= leiBack; j++)
                    {
                        // Pobranie pojedynczo każdego piksela z obszaru tła
                        Color pixelColor = bitmap.GetPixel(xiBack + i, yiBack + j);
                        BlueBack.Add(pixelColor.B);
                        GreenBack.Add(pixelColor.G);
                        RedBack.Add(pixelColor.R);
                    }
                }

                // Zapis sredniej wartosci z listy pikesli RGB kryształu
                AveB.Add(Blue.Sum() / Blue.Count());
                AveR.Add(Red.Sum() / Red.Count());
                AveG.Add(Green.Sum() / Green.Count());

                // Zapis sredniej wartosci z listy pikesli RGB tla
                AveBBack.Add(BlueBack.Sum() / BlueBack.Count());
                AveRBack.Add(RedBack.Sum() / RedBack.Count());
                AveGBack.Add(GreenBack.Sum() / GreenBack.Count());

                // Obliczenie odchyleń RGB z kryształu i tła
                StandardDeviation(Red, Green, Blue);
                StandardDeviationBack(RedBack, GreenBack, BlueBack);
            }
        }


        // Deklarowanie listy dla zapisu temperatury 
        public List<int> Temperature = new List<int>();


        // Obsluga przycisku uruchomienia obliczen
        private void plotButton_Click_1(object sender, EventArgs e)
        {
            // Wyczyszczenie poprzednich danych z list kolorów i temperatury
            AveB.Clear();
            AveG.Clear();
            AveR.Clear();

            AveBBack.Clear();
            AveGBack.Clear();
            AveRBack.Clear();

            DevAveB.Clear();
            DevAveG.Clear();
            DevAveR.Clear();

            DevAveBBack.Clear();
            DevAveGBack.Clear();
            DevAveRBack.Clear();

            Temperature.Clear();


            // Zmienna sluzaca do informowania o wystopieniu bledu odczytu
            // Jesli True-wykres nie zostanie wczytany
            bool DidBreak = false; 

            // Tor obliczeń bez użycia opcji Iterate-obliczenia obrazow z listy checkedListBox
            if (IterateLoadChecking == false)
            {
                // Oblicza dla kazdego obiektu w CheckedListBox
                foreach (object item in checkedListBox1.CheckedItems)
                {

                    try
                    {
                        // Pobiera obraz jako bitmape
                        Bitmap bitmap = (Bitmap)Image.FromFile(item.ToString());

                        // Wysylanie do obliczen RGB
                        GetPixelFunc(bitmap);

                        // Zapisuje nazwe jako string
                        string itemName = item.ToString();

                        // Jezeli uzywamy opcji czytania z nazw to uruchamia sie ta czesc
                        if (Settings.IncludeTemp == true)
                        {
                            // Pobiera wylacznie nazwe pliku z lokalizacji
                            while (itemName.Contains("\\"))
                            {
                                itemName = itemName.Remove(0, itemName.IndexOf("\\") + 1);
                            }

                            // Pobiera temperature wedlug wskazanego schematu
                            if (Settings.NewIndex == true)
                            {
                                for (int i = 1; i <= Settings.StartIndex; i++)
                                {
                                    // Reading temperature from name and save to list
                                    itemName = itemName.Remove(0, itemName.IndexOf("_") + 1);
                                }
                            }

                            // pobiera temperature wedlug ustawien domyslnych
                            else
                            {
                                for (int i = 1; i <= 3; i++)
                                {
                                    // Reading temperature from name and save to list
                                    itemName = itemName.Remove(0, itemName.IndexOf("_") + 1);
                                }
                            }

                            // Usuwa pozotale znaki po podkrslniku
                            namePrefix = itemName.Remove(itemName.IndexOf("_"));

                            // Zapisuje pobrana temperature
                            Temperature.Add(int.Parse(namePrefix));
                        }
                    }

                    // Obsluga bledu wyswietla informacje i zmienia zmienna didBreak na True
                    catch (Exception)
                    {
                        MessageBox.Show("Read name info error.\nTry change settings to Picture Number Only");
                        DidBreak = true;
                        break;
                    }
                }
            }

            // Tor obliczen dla uzycia opcji Load To Iterate
            if (IterateLoadChecking == true)
            {
                // Pętla ładujaca kolejne obrazy pomiedzy wartosciami start i stop
                for (int item = StartIndex; item <= StopIndex; item++)
                {

                    try
                    {
                        // Pobieranie bitmapy
                        Bitmap bitmap = (Bitmap)Image.FromFile(String.Format("{0}{1}.{2}", locationForSlider.ToString(), item.ToString(), format));

                        // Przeslanie wspolrzednych do obliczenia-wprzypadku uzycia estimatePosition
                        if (estimatePosition.Checked == true)
                        {
                            xi = EstimateXfunc(item);
                            yi = EstimateYfunc(item);
                        }

                        // Przeslanie bitmapy do obliczen
                        GetPixelFunc(bitmap);

                        // Utworzenie nazwy wczytywanego obrazu
                        string itemName = String.Format("{0}{1}.{2}", locationForSlider.ToString(), item.ToString(), format);

                        // Pobranie temperatury z nazwy- w przypadku uzyia tej opcji
                        // Jest to ta sama funkcja jak wczesniej w obliczeniach z listy
                        if (Settings.IncludeTemp == true)
                        {
                            while (itemName.Contains("\\"))
                            {
                                itemName = itemName.Remove(0, itemName.IndexOf("\\") + 1);
                            }

                            if (Settings.NewIndex == true)
                            {
                                for (int i = 1; i <= Settings.StartIndex; i++)
                                {                                    
                                    itemName = itemName.Remove(0, itemName.IndexOf("_") + 1);
                                }
                            }
                            else
                            {
                                for (int i = 1; i <= 3; i++)
                                {
                                    itemName = itemName.Remove(0, itemName.IndexOf("_") + 1);
                                }
                            }

                            namePrefix = itemName.Remove(itemName.IndexOf("_"));


                            Temperature.Add(int.Parse(namePrefix));
                        }

                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Read name info error.\nTry change settings to Picture Number Only");
                        DidBreak = true;
                        break;
                    }

                }
            }

            // Przekazanie danych do klasy GraphForm
            GraphForm f = new GraphForm(AveR, AveG, AveB, Temperature);
            GraphFormBack g = new GraphFormBack(AveRBack, AveGBack, AveBBack);
            DevGraphForm h = new DevGraphForm(DevAveR, DevAveG, DevAveB);
            DevGraphFormBack j = new DevGraphFormBack(DevAveRBack, DevAveGBack, DevAveBBack);

            // Sprawdzenie bledu przy zbieraniu danych z wykresu
            if (DidBreak == false)
            {   
                // Wczytanie okna wykresu
                f.Show();
            }

        }


        // Funkcja podglądu ostatniego zaznaczonego obrazu
        private void imageView(object sender, EventArgs e)
        {
            // Wyswietlanie wspolrzednych i rozmiarow obszarow analizy
            propDraw.Text = String.Format("Xd{0}, Yd{1}, Wd{2}, Ld{3}", xi.ToString(), yi.ToString(), wii.ToString(), lei.ToString());
            propBcg.Text = String.Format("Xb{0}, Yb{1}, Wb{2}, Lb{3}", xiBack.ToString(), yiBack.ToString(), wiiBack.ToString(), leiBack.ToString());
            // Loop for all the selected photos

            // Sprawdzanie ktory obraz zaznaczony jest jako ostatni
            int index = 0;

            foreach (Object item in checkedListBox1.CheckedItems)
            {
                int thisItem = checkedListBox1.Items.IndexOf(item);

                if (index < thisItem)
                {
                    index = thisItem;
                }
            }
            // Tworzenie bitmapy i wyslanie do funkcji tworzacej podglad
            Image bitmap = Image.FromFile(checkedListBox1.Items[index].ToString());

            imageBedec(bitmap);
        }

        // Funkcja rysujaca na zywo obszary analizy na obrazie z podgladu
        private void imageBedec(Image bitmap)
        {
            // Informacje o wspolrzednych i rozmiarach obszarow analizy
            propDraw.Text = String.Format("Xd{0}, Yd{1}, Wd{2}, Ld{3}", xi.ToString(), yi.ToString(), wii.ToString(), lei.ToString());
            propBcg.Text = String.Format("Xb{0}, Yb{1}, Wb{2}, Lb{3}", xiBack.ToString(), yiBack.ToString(), wiiBack.ToString(), leiBack.ToString());

            // Sprawdzanie uzycia opcji drawingSet
            if (drawingSet.Checked == true)
            {
                // Deklaracja zmiennych do obslugi rysowanie obrazow
                Graphics g = Graphics.FromImage(bitmap);
                Pen recCol = new Pen(Color.Gold, 4);
                Pen recBack = new Pen(Color.Red, 4);
                RectangleF rectf = new RectangleF(200, 90, 150, 150);
                Rectangle rectProp = new Rectangle(xi, yi, wii, lei);
                Rectangle rectBack = new Rectangle(xiBack, yiBack, wiiBack, leiBack);

                // Dodanie informacji do bitmapy
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.DrawString("Set Area", new Font("Tahoma", 12), Brushes.Yellow, rectf);
                g.DrawRectangle(recCol, rectProp);
                g.DrawRectangle(recBack, rectBack);

                // Wyswietlenie nowej bitmapy
                pictureBox1.Image = bitmap;
            }
            else
            {
                // Zaladowanie mapy ez dodatkowych informacji
                pictureBox1.Image = bitmap;
            }
        }

        // Fukcja sprawdzajaca zmiane zaznaczonaych na liscie obrazow
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Wyslanie obrazu do funkcji zamieszczajacej opis i obszary analizy
            imageView(sender, e);


            // Wlaczenie dostepnosci przyciskow po zaznaczeniu dowolnego obrazu
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                dynamicSearth.Enabled = true;
                saveChedked.Enabled = true;
                loadNext.Enabled = true;
                loadUndo.Enabled = true;
                checkedButton.Enabled = true;
                uncheckedButton.Enabled = true;
                plotButton.Enabled = true;
                drawingSet.Enabled = true;
                checkRange.Enabled = true;
            }

            // Wylaczenie przyciskow w przypadku niezaznaczenia obrazu na lisie
            else
            {
                dynamicSearth.Enabled = false;
                saveChedked.Enabled = false;
                loadNext.Enabled = false;
                loadUndo.Enabled = false;
                checkedButton.Enabled = false;
                uncheckedButton.Enabled = false;
                plotButton.Enabled = false;
                drawingSet.Enabled = false;
                checkRange.Enabled = false;
            }
        }

        // Funkcja wyszukujaca obrazy tego zamego numeru
        // stosuje sie ona przy wczytaniu obrazow z wielu folderow
        private void dynamicSearth_CheckedChanged(object sender, EventArgs e)
        {
            // Warunek sprawdza czy zaznaczono obszar i zaznaczono dynamicSearch
            if (checkedListBox1.CheckedItems.Count != 0 && dynamicSearth.Checked == true)
            {
                // Pobranie numeru zaznaczonego obrazu
                foreach (object item in checkedListBox1.CheckedItems)
                {
                    string itemName = item.ToString();
                    itemName = itemName.Remove(0, itemName.Length - 7);
                    namePrefix = itemName.Remove(3);
                }

                search = string.Format("*{0}.{1}", namePrefix, format);

                // Szukanie wszytkich obrazow z foderow o pobranym numerze
                try
                {
                    // Wczytanie nowych obrazow wyszukanych wedlug kryteriow
                    checkedListBox1.Items.Clear();
                    string[] files = Directory.GetFiles(saveFBD.SelectedPath, search, SearchOption.AllDirectories);
                    sortItems(files);
                    checkedListBox1.SetItemCheckState(0, CheckState.Checked);

                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Path is a null reference.");
                }
            }

            // Warunek w przypadku odznaczenia funkcji dynamiSearch 
            // Program wczytuje wszystkie poczatkowe obrazy
            if (dynamicSearth.Checked == false)
            {
                namePrefix = "";

                search = string.Format("*{0}.{1}", namePrefix, format);
                try
                {
                    checkedListBox1.Items.Clear();
                    string[] files = Directory.GetFileSystemEntries(saveFBD.SelectedPath, search, SearchOption.AllDirectories);
                    sortItems(files);

                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Path is a null reference.");
                }
            }
        }

        // Funkcja obslugi przycisku odznaczania wszyskich elementow na liscie
        private void uncheckedButton_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            // Utawenie dostepnosci przyciskow po uzyciu opcji uncheckAll
            dynamicSearth.Checked = false;
            dynamicSearth.Enabled = false;
            saveChedked.Enabled = false;
            loadNext.Enabled = false;
            loadUndo.Enabled = false;
            drawingSet.Enabled = false;
            plotButton.Enabled = false;

        }

        // Obsluga wczytania nastepnego obrazu z listy
        private void loadNext_Click(object sender, EventArgs e)
        {

            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);

                if (i + 2 > checkedListBox1.Items.Count)
                {
                    checkedListBox1.SetItemCheckState(0, CheckState.Checked);
                }
                else
                {
                    checkedListBox1.SetItemCheckState(i + 1, CheckState.Checked);
                }
            }
            foreach (object item in checkedListBox1.CheckedItems)
            {
                pictureBox1.Load(item.ToString());
                imageView(sender, e);
            }

        }

        // Obsluga wczytania poprzedniego obrazu z listy
        private void loadUndo_Click(object sender, EventArgs e)
        {

            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);

                if (i - 1 < 0)
                {
                    checkedListBox1.SetItemCheckState(checkedListBox1.Items.Count - 1, CheckState.Checked);
                }
                else
                {
                    checkedListBox1.SetItemCheckState(i - 1, CheckState.Checked);
                }
            }
            foreach (object item in checkedListBox1.CheckedItems)
            {

                pictureBox1.Load(item.ToString());
                imageView(sender, e);
            }

        }

        // Funkcja zapisu wszystkich zaznaczonych obrazow do nowego folderu
        private void saveChedked_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            string location;
            {
                location = folderBrowserDialog1.SelectedPath;

                if (location != "")
                {
                    try
                    {
                        // Zmienna do sprawdzenia czy obrazy zostaly skopiowane
                        bool copyed = false;

                        // Kopiowanie obrazu do nowego folderu
                        foreach (object item in checkedListBox1.CheckedItems)
                        {
                            string source = item.ToString();
                            string fileName = Path.GetFileName(source);

                            if (source != Path.Combine(location, fileName))
                            {
                                copyed = true;
                                File.Copy(Path.Combine(source), Path.Combine(location, fileName), true);
                            }

                        }

                        // Obsluga po zakonczeniu kopiowania
                        if (copyed == true)
                        {
                            MessageBox.Show("Done !");

                            dynamicSearth.Checked = false;

                            // Zapis nowej lokalizacji do zmiennej
                            DictionarySave newDic = new DictionarySave(location.ToString());

                            // Wczytanie obrazow z nowej lokalizacji
                            string[] files = Directory.GetFiles(location);
                            checkedListBox1.Items.Clear();
                            sortItems(files);
                            location = "";
                            copyed = false;
                            checkedListBox1.SetItemCheckState(0, CheckState.Checked);

                        }
                    }

                    catch (DirectoryNotFoundException dirNotFound)
                    {
                        MessageBox.Show(dirNotFound.Message);
                    }
                }

            }
        }

        // Ustawienie zmiennych do zapisu informacji o obszarach analizy
        private void setBackG_CheckedChanged(object sender, EventArgs e)
        {
            // Zmienne dla obszaru analizy tla
            if (setBackG.Checked == true)
            {
                setLength.Value = leiBack;
                setWidth.Value = wiiBack;
                setY.Value = yiBack;
                setX.Value = xiBack;
            }

            // Zmienna dla obszaru analizy krysztalu
            if (setBackG.Checked == false)
            {
                setLength.Value = lei;
                setWidth.Value = wii;
                setY.Value = yi;
                setX.Value = xi;
            }

        }

        // Obsluga zamykania programu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Uruchomienie tutorialu
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tutorial t = new Tutorial();
            t.Show();
        }

        // Wywolanie okna ,,Info''
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About t = new About();
            t.Show();
        }
        
        // Wywolanie okna ustawien czytania temperatury z nazwy
        private void nameReadSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameReadSet t = new NameReadSet();
            t.Show();
        }

        // Obsluga sortowania plikow wczytanych na liste wedlug nazwy
        private void SortNameNumber_Click(object sender, EventArgs e)
        {
            try
            {
                if (SortByLength.Checked == true)
                {
                    SortByLength.Checked = false;
                }
                List<string> files = new List<string>();

                foreach (object file in checkedListBox1.Items)
                {
                    files.Add(file.ToString());
                }


                string[] files1 = files.ToArray();


                checkedListBox1.Items.Clear();

                sortItemsnumb(files1);
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to do!");
            }

        }

        // Obsluga sortowania plikow wczytanych na liste wedlug dlugosci
        private void SortByLength_Click(object sender, EventArgs e)
        {
            try
            {
                if (SortNameNumber.Checked == true)
                {
                    SortNameNumber.Checked = false;
                }
                List<string> files = new List<string>();

                foreach (object file in checkedListBox1.Items)
                {
                    files.Add(file.ToString());
                }


                string[] files1 = files.ToArray();


                checkedListBox1.Items.Clear();

                sortItems(files1);
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to do!");
            }
        }

        // Obsluga zaznaczania na liscie wskazanego zakresu wczytanych plikow
        private void checkRange_Click(object sender, EventArgs e)
        {
            Range r = new Range();
            r.Show();

            try
            {
                for (int i = FromTo.FromNumber; i < FromTo.ToNumber; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    // Ustawienia dostepnosci przyciskow po urzyciu opcji
                    dynamicSearth.Enabled = true;
                    saveChedked.Enabled = true;
                    loadNext.Enabled = true;
                    loadUndo.Enabled = true;
                    checkedButton.Enabled = true;
                    uncheckedButton.Enabled = true;
                    plotButton.Enabled = true;
                    drawingSet.Enabled = true;
                    plotButton.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong! Try set values agin.");
            }

        }

        // Obsluga menu toolStrip
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Obsluga ustawien formatu wczytywanych plikow jpg
        private void jPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pNGToolStripMenuItem.Checked == true)
            {
                pNGToolStripMenuItem.Checked = false;
            }
            format = "jpg";
        }

        // Obsluga ustawien formatu wczytywanych plikow png
        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (jPGToolStripMenuItem.Checked == true)
            {
                jPGToolStripMenuItem.Checked = false;
            }
            format = "png";
        }

        // Odczytywanie pozycji obszaru analizy wskazanej przez klikniecie na obraz
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Pobranie pozycji myszy po kliknieciu
            int x = pictureBox1.PointToClient(Cursor.Position).X;
            int y = pictureBox1.PointToClient(Cursor.Position).Y;

            try
            {
                double xscale = Convert.ToDouble(pictureBox1.Image.Width) / Convert.ToDouble(pictureBox1.Size.Width);
                double yscale = Convert.ToDouble(pictureBox1.Image.Height) / Convert.ToDouble(pictureBox1.Size.Height);
                if (setBackG.Checked == true)
                {
                    xiBack = Convert.ToInt32(x * xscale);
                    yiBack = Convert.ToInt32(y * yscale);
                    if (setX.Maximum < xiBack)
                    {
                        setX.Maximum = xiBack;
                    }
                    if (setY.Maximum < yiBack)
                    {
                        setY.Maximum = yiBack;
                    }

                    // Ustawienie nowych wartosci zmiennych
                    setX.Value = xiBack;
                    setY.Value = yiBack;
                    if (pictureBox1.Image != null)
                    {
                        if (IterateLoadChecking == false)
                        {
                            imageView(sender, e);
                        }
                        else
                        {
                            loadBitmap(actualLoadedLocation);
                        }
                    }
                }
                else
                {
                    xi = Convert.ToInt32(x * xscale);
                    yi = Convert.ToInt32(y * yscale);
                    if (setX.Maximum < xi)
                    {
                        setX.Maximum = xi;
                    }
                    if (setY.Maximum < yi)
                    {
                        setY.Maximum = yi;
                    }
                    setX.Value = xi;
                    setY.Value = yi;

                    if (pictureBox1.Image != null)
                    {
                        if (IterateLoadChecking == false)
                        {
                            imageView(sender, e);
                        }
                        else
                        {
                            loadBitmap(actualLoadedLocation);
                        }
                    }

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Load Image!");
            }
        }

        // Zmienne bool kontrolujaca wyczytanie do iterate
        public bool IterateLoadChecking = false;

        // Zmienne int dla indekwow poczatku i konca w iterate
        public int StartIndex, StopIndex;

        // Obsluga ladowania zdjec do iterate
        private void loadIterateButton_Click(object sender, EventArgs e)
        {
            // okna kontekstowe do wczytania zdjec poczatku i konca
            OpenFileDialog File1 = new OpenFileDialog();
            OpenFileDialog File2 = new OpenFileDialog();

            string first, last;

            IterateLoadChecking = true;

            if (File1.ShowDialog() == DialogResult.OK)
            {
                File1.Title = "Choose First Picture";
                DirectoryInfo First = new DirectoryInfo(File1.FileName);

                Bitmap bitmap1 = (Bitmap)Image.FromFile(First.ToString());
                first = First.ToString();
                actualLoadedLocation = first;

                // Wyslanie do funkcji tworzacej podglad
                imageBedec(bitmap1);


                if (File2.ShowDialog() == DialogResult.OK)
                {
                    File1.Title = "Choose Last Picture";
                    DirectoryInfo Last = new DirectoryInfo(File2.FileName);
                    Bitmap bitmap2 = (Bitmap)Image.FromFile(Last.ToString());

                    last = Last.ToString();

                    // Wyslanie do funkcji tworzacej podglad
                    imageBedec(bitmap2);

                    findFirstLast(first, last);
                }

            }


        }

        // Lokalizacja wczytanych plikow w trybie iterate
        public string locationForSlider;

        // Aktualnie uzywana lokalizacja plikow w trybie iterate
        public string actualLoadedLocation;

        // Obsluga lokalizacji plikow dla trybu iterate  
        private void findFirstLast(string First, string Last)
        {
            string locmin = readLocation(First);
            string locmax = readLocation(Last);

            if (locmin == locmax)
            {
                // Lokalizacja z ktorej wczytywany jest obraz - dla funkcji slider
                locationForSlider = locmin;

                if (getNumber(First) < getNumber(Last))
                {
                    // DOstepnosc przyciskow po uzyciu iterate
                    pictureSlider.Minimum = getNumber(First);
                    pictureSlider.Maximum = getNumber(Last);
                    StartIndex = getNumber(First);
                    StopIndex = getNumber(Last);
                    pictureSlider.Enabled = true;

                    plotButton.Enabled = true;
                    drawingSet.Enabled = true;
                }
                else
                {
                    MessageBox.Show("ERROR! First picture index is larger then last!");
                }
            }
            else
            {
                MessageBox.Show("Location of first and last picture are diferent!");
            }

        }

        // Wczytywanie lokalizacji dla obrazow
        string readLocation(string name)
        {
            string workName = name;
            string deleteLast;
            int ToRemove;

            // Pobranie wylwcznie nazwy pliku

            while (workName.Contains("\\"))
            {
                workName = workName.Remove(0, workName.IndexOf("\\") + 1);
            }

            DictionarySave newDic = new DictionarySave(name.Remove(name.Length - (1 + workName.Length), (1 + workName.Length)));

            deleteLast = workName;

            while (deleteLast.Contains("_"))
            {
                deleteLast = deleteLast.Remove(0, deleteLast.IndexOf("_") + 1);
            }

            ToRemove = workName.Remove(workName.IndexOf("."), workName.Length - workName.IndexOf(".")).Length;

            return name.Remove(name.Length - deleteLast.Length, deleteLast.Length);
        }

        // Pobranie numeru zdjecia pierwszego i ostatniego
        int getNumber(string name)
        {
            string workName = name;

            while (workName.Contains("_"))
            {
                workName = workName.Remove(0, workName.IndexOf("_") + 1);
            }

            workName = workName.Remove(workName.IndexOf("."), workName.Length - workName.IndexOf("."));
            return Convert.ToInt32(workName);
        }

        // Funcja laczaca lokalizacje z numerem pliku ustawionym przy pomocy slider
        private void pictureSlider_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0} {1}", "Picture Number: ", pictureSlider.Value.ToString());

            Bitmap bitmap1 = (Bitmap)Image.FromFile(String.Format("{0}{1}.{2}", locationForSlider.ToString(), pictureSlider.Value.ToString(), format));

            actualLoadedLocation = String.Format("{0}{1}.{2}", locationForSlider.ToString(), pictureSlider.Value.ToString(), format);

            if (estimatePosition.Checked == true)
            {
                // Przeslanie wspolrzednych do funkcji obliczajacej polozenie obszaru analizy w trybie estimate
                // Zapis w zmiennych otrzymanych wartosci
                xi = EstimateXfunc(pictureSlider.Value);
                yi = EstimateYfunc(pictureSlider.Value);
            }
            
            // Przeslanie bitmapy do podgladu
            imageBedec(bitmap1);
        }

        // Proste wczytanie pojedynczego obrazu do podgladu
        private void loadBitmap(string Location)
        {
            Bitmap bitmap1 = (Bitmap)Image.FromFile(Location);

            imageBedec(bitmap1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Listy do obliczen polozenia obszarow analizy RGB w trybie estimate
        public List<int> PositionX = new List<int>();
        public List<int> PositionY = new List<int>();
        public List<int> FrameXY = new List<int>();
        public List<double> EstimatedX = new List<double>();
        public List<double> EstimatedY = new List<double>();


        // Obsluga dostepnosci przyciskow po uzyciu opcji clear
        private void clearPositionList_Click(object sender, EventArgs e)
        {
            estimatePosition.Checked = false;
            estimatePosition.Enabled = false;
            PositionX.Clear();
            PositionY.Clear();
            EstimatedX.Clear();
            EstimatedY.Clear();
            FrameXY.Clear();
            newEstimatePoint.Text = "Last Estimate Point:";
        }

        // Funkcja zapisujaca wskazane polozenie dla danego numeru obrazu
        private void savePosition_Click(object sender, EventArgs e)
        {
            PositionX.Add(xi);
            PositionY.Add(yi);
            FrameXY.Add(pictureSlider.Value);
            newEstimatePoint.Text = String.Format("Last Estimate Point: X {0}, Y {1}, Frame {2}", xi.ToString(), yi.ToString(), pictureSlider.Value.ToString());
            if (FrameXY[0] != pictureSlider.Minimum)
            {
                estimatePosition.Enabled = false;
                MessageBox.Show("Estimating Position must starts from frame 0 to last frame! Make new points 0-Last.");
                PositionX.Clear();
                PositionY.Clear();
                FrameXY.Clear();
            }
            if (FrameXY.Count > 1)
            {
                if (FrameXY[FrameXY.Count - 1] == pictureSlider.Maximum)
                {
                    estimatePosition.Enabled = true;
                }
            }

        }

        // Funkcja przesyla pozycje i numer zdjecia do obliczenia kolejnych pozycji
        // Obliczenia wykonuje funkcja countEstimatePosition
        private void estimatePosition_CheckedChanged(object sender, EventArgs e)
        {
            countEstimatePosition(PositionX, PositionY, FrameXY);
        }

        // Funkcja obliczajaca polozenie obszarow nalizy w trybie estimate
        private void countEstimatePosition(List<int> X, List<int> Y, List<int> Frame)
        {
            for (int i = 1; i <= Frame.Count - 1; i++)
            {
                for (int j = Frame[i - 1]; j < Frame[i]; j++)
                {

                    if (j > 1)
                    {
                        // Liniowe przyblizeniezmiany polozenia pomiedzy wkazanymi klatkami
                        EstimatedX.Add((Convert.ToDouble((X[i] - X[i - 1])) / Convert.ToDouble((Frame[i] - Frame[i - 1]))) + EstimatedX[j - 2]);
                        EstimatedY.Add((Convert.ToDouble((Y[i] - Y[i - 1])) / Convert.ToDouble((Frame[i] - Frame[i - 1]))) + EstimatedY[j - 2]);
                    }

                    if (j == 1)
                    {
                        // Zapis poczatkowych wartosci
                        EstimatedX.Add(X[0]);
                        EstimatedY.Add(Y[0]);
                    }
                }
            }
            EstimatedX.Add(X[X.Count - 1]);
            EstimatedY.Add(Y[Y.Count - 1]);
        }

        // Funkcje zwaracjace int ze wspolrzednych X i Y obszaru analizy
        public int EstimateXfunc(int X)
        {
            return Convert.ToInt32(EstimatedX[X - 1]);
        }

        public int EstimateYfunc(int Y)
        {
            return Convert.ToInt32(EstimatedY[Y - 1]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        // Funkcja zanaczajaca wszystkie pozycje na liscie wczytanych obrazow
        private void checkedButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                MessageBox.Show(outOfRange.Message);
            }

            // Obsluga dostepnosci przyciskow po uzyciu opcji chceked all
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                dynamicSearth.Enabled = true;
                saveChedked.Enabled = true;
                loadNext.Enabled = true;
                loadUndo.Enabled = true;
                checkedButton.Enabled = true;
                uncheckedButton.Enabled = true;
                plotButton.Enabled = true;
                drawingSet.Enabled = true;
                plotButton.Enabled = true;
            }
        }

        // Obsluga ustawienia obszaru analizy RGB
        private void drawingSet_CheckedChanged(object sender, EventArgs e)
        {
            if (drawingSet.Checked == true)
            {
                // Obsluga dostpenosci przyciskow po zaznaczeniu deawingSet
                flowLayoutPanel3.Enabled = true;
                setBackG.Enabled = true;

                // Zapis wspolrzednych ze sliderow dla obszaru analizy tla
                if (setBackG.Checked == true)
                {
                    setLength.Value = leiBack;
                    setWidth.Value = wiiBack;
                    setY.Value = yiBack;
                    setX.Value = xiBack;
                }

                // Zapis wspolrzednych ze sliderow dla obszaru analizy krysztalu
                if (setBackG.Checked == false)
                {
                    setLength.Value = lei;
                    setWidth.Value = wii;
                    setY.Value = yi;
                    setX.Value = xi;
                }

            }
            else
            {
                // Dostepnosc opcji set background i sliderow po odznaczneniu setDrawing
                flowLayoutPanel3.Enabled = false;
                setBackG.Enabled = false;
            }
        }

// Funkcje odczytu wartosci ze sliderow zbudowane sa tak samo dla kazdej zmiennej
// Zmiana dowolnego z nich powoduje ponone zaladowanie obrazu z nowym polozeniem

        // Odczyt wartosci polozen ze slideru setX
        public void setX_Scroll(object sender, EventArgs e)
        {
            // Dla tla
            if (setBackG.Checked == true)
            {
                xiBack = setX.Value;
                if (IterateLoadChecking == false)
                {
                    imageView(sender, e);
                }
                else
                {
                    // Zaladowanie obrazu z nowym polozeniem obszaru
                    loadBitmap(actualLoadedLocation);
                }
            }

            // Dla krysztalu
            else
            {
                xi = setX.Value;
                if (IterateLoadChecking == false)
                {
                    imageView(sender, e);
                }
                else
                {
                    // Zaladowanie obrazu z nowym polozeniem obszaru
                    loadBitmap(actualLoadedLocation);
                }
            }
        }

        // Ustawienie wspolrzednej Y dla obszarow analizy
        public void setY_Scroll(object sender, EventArgs e)
        {
            if (setBackG.Checked == true)
            {
                yiBack = setY.Value;
                if (IterateLoadChecking == false)
                {
                    imageView(sender, e);
                }
                else
                {
                    loadBitmap(actualLoadedLocation);
                }
            }
            else
            {
                yi = setY.Value;
                if (IterateLoadChecking == false)
                {
                    imageView(sender, e);
                }
                else
                {
                    loadBitmap(actualLoadedLocation);
                }
            }
        }

        // Ustawienie szerokosci dla obszarow analizy
        public void setWidth_Scroll(object sender, EventArgs e)
        {
            if (setBackG.Checked == true)
            {
                wiiBack = setWidth.Value;
                if (IterateLoadChecking == false)
                {
                    imageView(sender, e);
                }
                else
                {
                    loadBitmap(actualLoadedLocation);
                }
            }
            else
            {
                wii = setWidth.Value;
                if (IterateLoadChecking == false)
                {
                    imageView(sender, e);
                }
                else
                {
                    loadBitmap(actualLoadedLocation);
                }
            }
        }

        // Ustawienie dlugosci dla obszarow analizy
        public void setLength_Scroll(object sender, EventArgs e)
        {
            if (setBackG.Checked == true)
            {
                leiBack = setLength.Value;
                if (IterateLoadChecking == false)
                {
                    imageView(sender, e);
                }
                else
                {
                    loadBitmap(actualLoadedLocation);
                }
            }
            else
            {
                lei = setLength.Value;
                if (IterateLoadChecking == false)
                {
                    imageView(sender, e);
                }
                else
                {
                    loadBitmap(actualLoadedLocation);
                }
            }
        }
    }
}
