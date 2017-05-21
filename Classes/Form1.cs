using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_falar_Click(object sender, EventArgs e)
        {
            Pessoa p2 = new Pessoa();
            //p2.nome = "Carlos Encine";

            string speak = txt_fala.Text;
            p2.Falar(speak);
            txt_fala.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa save = new Pessoa();
            save.saveFile(txt_fala);

        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            Pessoa file = new Pessoa();
            file.loadFile(txt_load);
        }
    }
}
