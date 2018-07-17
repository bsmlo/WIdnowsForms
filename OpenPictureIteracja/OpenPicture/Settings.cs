// Klasa przechowujaca ustawienia

using System.Windows.Forms;

namespace OpenPicture
{
    public partial class Settings : Form
    {
        // Czytanie temperatury z nazwy
        internal static bool IncludeTemp { get; set; }
        // Czy zmienione zostaly ustawienia odczytu temperatury z nazwy
        internal static bool NewIndex { get; set; }
        // Indeks rozpoczynajacy wczytywanie obrazu-pierwsze zdjecie
        internal static int StartIndex { get; set; }
        // Indeks konczacy wczytywanie obrazu-ostatnie zdjecie
        internal static int StopIndex { get; set; }

        // Publiczne zmienne dotyczase ustawien-dla innych klas
        public Settings(bool incTemp, bool newIndex, int startIndex)
        {
            IncludeTemp = true;

            IncludeTemp = incTemp;
            NewIndex = newIndex;
            StartIndex = startIndex;
        }
    }


    // Przechowywanie danych odnosnie zaznaczonego zakresu na liscie
    // Opcja check range
    public partial class FromTo : Form
    {
        internal static int FromNumber { get; set; }
        internal static int ToNumber { get; set; }

        public FromTo(int from, int to)
        {
            FromNumber = from;
            ToNumber = to;
        }

    }
}
