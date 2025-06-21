using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subprocesos_y_WinForm.Player
{
    public partial class LoadPlayer : Form
    {
        private SoundPlayer player;

        public LoadPlayer()
        {
            InitializeComponent();
            player = new SoundPlayer();
            player.LoadCompleted += Player_LoadCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                player.SoundLocation = textBox1.Text;
                player.LoadAsync(); // Carga el .wav de forma asincrónica
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Player_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Falló la carga: " + e.Error.Message);
            }
            else
            {
                MessageBox.Show("¡Sonido cargado correctamente!");
                player.Play(); // Reproduce después de cargar
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.WaitOnLoad = false;
            pictureBox1.LoadAsync("https://img.remediosdigitales.com/a453d6/yamaha-yzf-r6-2017-023/1366_2000.jpg"); 
        }
    }
}
