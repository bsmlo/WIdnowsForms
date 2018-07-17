// Klasa tutorialu
using System;
using System.Windows.Forms;

namespace OpenPicture
{
    public partial class Tutorial : Form
    {
        public Tutorial()
        {
            InitializeComponent();
            label1.Text = "Welcome to Open Picture Program.\nIf You want to start the tutorial press Continue.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        
        // Wyswietla kolejne porady po kliknieciu przycisku
        private void printTxt(int a)
        {
            if (a == 1)
            {
                label1.Text = "Click on the Search button and select folder witch conteins folders with pictures.\nYou can see all the photos from all the folders in main folder you choose.";
            }
            if (a == 2)
            {
                label1.Text = "Click on list of photos. Now you can see every photo.\nUse Undo, Next, Check All and Uncheck All to control.\nOnly the last checked photo from list is visable.";
            }
            if (a == 3)
            {
                label1.Text = "Select only one photo with position you need and click Find Similar To.\nNow you can see all the photos from main folder with selected number.";
            }
            if (a == 4)
            {
                label1.Text = "Scroll all photo and select all the photos that you want to analyse.";
            }
            if (a == 5)
            {
                label1.Text = "Click on Save button, make new folder and click Ok.";
            }
            if (a == 6)
            {
                label1.Text = "Now you can see all the selected photos saved in new folder.\nSelect first one and tick Set Drawing and Set Background.";
            }
            if (a == 7)
            {
                label1.Text = "Select with sliders area for analyse background. (Red rectangle)\nUntick Set Background and do the same with gold rectangle for analyse cristal area.";
            }
            if (a == 8)
            {
                label1.Text = "If you can't see the rectangle change a vaalue of all sliders.";
            }
            if (a == 9)
            {
                label1.Text = "Click on the Get Plot button and Plot button in new window.\nNow you see plot with RGB from both areas and temperature.";
            }
            if (a == 10)
            {
                label1.Text = "Click on Save Checked button. Plot will be save in photos location.\nClick on Close to Exit the program.";
            }


        }

        public int i;

        private void continueButton_Click_1(object sender, EventArgs e)
        {
            backButton.Enabled = true;
            if (i < 10)
            {
                i++;
                if (i == 10)
                {
                    i = 10;
                    continueButton.Enabled = false;
                }
                if (i == 1)
                {
                    backButton.Enabled = false;
                }
            }
            printTxt(i);
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            if (i > 0)
            {
                i--;
                if (i == 1)
                {
                    backButton.Enabled = false;
                }

            }
            printTxt(i);
        }


    }
}
