using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Classes
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public void Falar(string value)
        {
            MessageBox.Show(value, "Resposta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadFile(TextBox textValue)
        {
            TextReader readFile = new StreamReader("conversa.txt");
            textValue.Visible = true;
            textValue.Text = readFile.ReadToEnd();
            readFile.Close();
        }

        public void SaveFile(TextBox textValue)
        {
            string fala = textValue.Text;

            if (!File.Exists("conversa.txt"))
            {
                TextWriter arquivo = new StreamWriter("conversa.txt");
                arquivo.WriteLine(fala);
                arquivo.Close();
                MessageBox.Show("Mensagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textValue.Text = "";
            }
            else
            {
                TextWriter file_content = File.AppendText("conversa.txt");
                file_content.WriteLine(fala);
                file_content.Close();
                MessageBox.Show("Mensagem salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textValue.Text = "";
            }
        }
    }
}
