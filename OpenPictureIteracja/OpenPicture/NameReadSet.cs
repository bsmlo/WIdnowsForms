// Klasa ustawien odczytu temperatury
using System;
using System.Windows.Forms;

namespace OpenPicture
{
    public partial class NameReadSet : Form
    {
        public NameReadSet()
        {
            // Inicjalizacja i infrmacje na temat wprowadzania zmian
            InitializeComponent();

            InfoRead.Text = "Here you can set settings for read temperature from name.\nDefault is set for XXX_XXX_XX_T_XX_XXX name type.";
            setNameInfo.Text = "Write your name as type as: xxx_xxx_T_xxx program will get number T as temperature";
            OnlyNumbInfo.Text = "Program will not read info from name. Temperature will not add to plot.";
        }

        // Dostepne opcje wyboru-delkaracja 3 ustawien
        private void readOption1_CheckedChanged(object sender, EventArgs e)
        {
            if (readOption1.Checked == true)
            {
                readOption2.Checked = false;
                readOption3.Checked = false;
            }
        }

        private void readOption2_CheckedChanged(object sender, EventArgs e)
        {
            if (readOption2.Checked == true)
            {
                readOption1.Checked = false;
                readOption3.Checked = false;
            }
        }

        private void readOption3_CheckedChanged(object sender, EventArgs e)
        {
            if (readOption3.Checked == true)
            {
                readOption1.Checked = false;
                readOption2.Checked = false;
            }
        }

        // Funkcja zapisu - informacje przehowywane w klasie Settings
        private void saveSettings_Click(object sender, EventArgs e)
        {
            if (readOption1.Checked == true)
            {
                Settings g = new Settings(true, false, 2);
                MessageBox.Show("Change Saved!");
                Close();
            }

            if (readOption2.Checked == true)
            {   
                // Odczyt nowych ostawien dla miejsca odczytu temperatuyr z nazw
                if (ReadName.Text.Contains("_") == true & ReadName.Text.Contains("T") == true)
                {
                int index = 0;

                string name = ReadName.Text;
                    try
                    {
                        name = name.Remove(name.IndexOf("T") + 1);


                        while (name.Contains("_"))
                        {
                            name = name.Remove(0, name.IndexOf("_") + 1);
                            index++;
                        }

                        Settings g = new Settings(true, true, index);

                        CheckName.Text = "Check: " + name;

                        MessageBox.Show("Change Saved!");
                        Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wrong Format!");
                        readOption1.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Format!");
                }
                

            }

            // Zapis w przypadku nieodczytywania temperatury z nazw
            if (readOption3.Checked == true)
            {
                Settings g = new Settings(false, false, 0);
                MessageBox.Show("Change Saved!");
                Close();
            }
        }
    }
}
