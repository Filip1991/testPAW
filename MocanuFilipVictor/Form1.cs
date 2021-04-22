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

namespace MocanuFilipVictor
{
    public partial class Form1 : Form
    {
        Gestiune g1 = new Gestiune();
        public static int nr1;
        public static string[] disponibilitate1 = new string[30];
        public static float pret1;
        public static int ziua1;

        public Form1(Gestiune g)
        {
            InitializeComponent();
            g1 = g;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNr.Text == "")
                errorProvider1.SetError(tbNr, "introduceti nr rezervarii");
            else
             if (tbZiua.Text == "")
                errorProvider1.SetError(tbZiua, "introduceti ziua");
            else
              if (tbPret.Text == "")
                errorProvider1.SetError(tbPret, "introduceti pretul");


            else
                try
                {
                    int nr = Convert.ToInt32(tbNr.Text);
                    int ziua = Convert.ToInt32(tbZiua.Text);
                    float pret = (float)Convert.ToDouble(tbPret.Text);


                    Rezervare r = new Rezervare(nr, pret, ziua);

                    

                    g1 += r;

                    MessageBox.Show(r.ToString());
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNr.Clear();
                    tbZiua.Clear();
                    tbPret.Clear();

                    errorProvider1.Clear();


                }

        }

        private void tbPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbZiua_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg1 = new SaveFileDialog();
            dlg1.Filter = "(.xml)|.xml";
            if (dlg1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(dlg1.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                string r = null;
                for (int i = 0; i < g1.vect.Length; i++)
                {


                    r += "Nr rezervare:  " + g1.vect[i].Nr.ToString() + " Ziua rezervarii:  " + g1.vect[i].ziua.ToString() +
                        " Pret rezervare:  " + g1.vect[i].Pret.ToString() + Environment.NewLine;


                }

                sw.WriteLine(r);
                sw.Close();
                fs.Close();
            }
        }
    }
}
