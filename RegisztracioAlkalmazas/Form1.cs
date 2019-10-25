using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hozzaad_Click(object sender, EventArgs e)
        {
            Hobbik.Items.Add(ujHobbi.Text);
            ujHobbi.Text = "";
        }

        private void Mentes_Click(object sender, EventArgs e)
        {
            StreamWriter szemelyes = new StreamWriter("SzemelyesAdatok.txt", false, Encoding.UTF8);

            if (nev.Text != "")
            {
                szemelyes.Write(nev.Text + ";");
            }
            if (szulDate.Text != "")
            {
                szemelyes.Write(szulDate.Text + ";");
            }
            if (fiu.Checked == true)
            {
                szemelyes.Write("Férfi");
            }
            else
            {
                szemelyes.Write("Nő");
            }
            szemelyes.Close();            
            File.WriteAllLines("hobbik.txt", Hobbik.Items.Cast<string>());           
        }

        private void Betoltes_Click(object sender, EventArgs e)
        {
            foreach (var line in File.ReadLines("hobbik.txt"))
            {
                Hobbik.Items.Add(line);
            }

            foreach (var sor in File.ReadAllLines("SzemelyesAdatok.txt"))
            {
                string[] Sor = sor.Split(';');
                nev.Text = Sor[0];
                szulDate.Text = Sor[1];
                if (Sor[2].Equals("Férfi"))
                {
                    fiu.Checked=true;
                }else
                {
                    lany.Checked = true;
                }
            }
        }
    }
}
