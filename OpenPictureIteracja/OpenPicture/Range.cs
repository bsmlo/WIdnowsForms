// Okno ustawien zaznaczenia na liscie obszaru
using System;
using System.Windows.Forms;

namespace OpenPicture
{
    public partial class Range : Form
    {
        public Range()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            try
            {
                // Zapis do klasy FromTo wskazanego zakresu
                FromTo fromTo = new FromTo(Convert.ToInt32(fromBox.Text), Convert.ToInt32(toBox.Text));
                Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Wrong Range!");
            }
            
        }
    }
}
