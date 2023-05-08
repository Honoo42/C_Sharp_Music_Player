using System;
using System.Windows.Forms;

namespace C_Sharp_Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        // Browse
        private void Button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }
        
        // Stop
        private void Button2_Click(object sender, EventArgs e) => Player.Ctlcontrols.stop();
        
        // Pause
        private void Button3_Click(object sender, EventArgs e) => Player.Ctlcontrols.pause();
        
        // Play
        private void Button4_Click(object sender, EventArgs e) => Player.Ctlcontrols.play();
        
        // Exit
        private void Button5_Click(object sender, EventArgs e) => Close();
    }
}
