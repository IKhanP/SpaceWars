using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Game_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormClosed += MainMenu_FormClosed;

            //button's back color when mouse over
            Playbtn.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            Customisebtn.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            Settingbtn.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            Quitbtn.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            this.Hide();    //hide main menu
            Form1 startGameplay = new Form1();   //store form1
            startGameplay.Show();   //show instance of form1
            
        }

        private void Customisebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been added yet");  //show messagebox
        }

        private void Settingbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been added yet");
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();  //exit the application
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
