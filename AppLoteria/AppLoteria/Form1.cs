using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLoteria
{
    public partial class Form1 : Form
    {
        const int CANTIDAD_CARTAS = 54;
        private PictureBox[] tabla;
        public Form1()
        {
            InitializeComponent();
            tabla = new PictureBox[25];
            inicializarTabla();
        }

        private void inicializarTabla()
        {
            int renglon = 0, columna = 0;

            int[] cartas = new int[CANTIDAD_CARTAS];

            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = i + 1;
            }

            Random rnd = new Random();
            int a, aux;
            for (int i = 0; i < cartas.Length; i++)
            {
                a = rnd.Next(cartas.Length);
                aux = cartas[i];
                cartas[i] = cartas[a];
                cartas[a] = aux;

            }

            for (int i = 0; i < tabla.Length; i++)
            {
                tabla[i] = new PictureBox();
                tabla[i].Location = new System.Drawing.Point(100 + (columna * 90), 25 + (renglon * 125));
                tabla[i].Name = "picTabla" + i;
                tabla[i].Size = new System.Drawing.Size(85, 110);
                tabla[i].TabIndex = 0 + i;
                tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tabla[i].TabStop = false;
                tabla[i].Image = Image.FromFile(@"C:\Users\dcedi\Downloads\Loteria\Imagenes\" +(i+1)+ ".jpg");
                this.Controls.Add(tabla[i]);
                columna++;
                if (columna == 5)
                {
                    renglon++;
                    columna = 0;
                }
            }
        }

        private void bntGane_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\dcedi\Downloads\Loteria\Sonidos\1.wav");
            player.Play();
        }
    }
}
