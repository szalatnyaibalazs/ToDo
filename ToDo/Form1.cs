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

namespace ToDo
{
    public partial class frmKezdo : Form
    {
        private List<string> todos = new List<string>();
        public frmKezdo()
        {
            InitializeComponent();
            StreamReader ol = new StreamReader("todoitems.txt");
            while (!ol.EndOfStream)
            {
                todos.Add(ol.ReadLine());
            }

            ol.Close();
        }

        private void nKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmKezdo_Shown(object sender, EventArgs e)
        {
            tbBevitel.Text = "";
            lbTodo.Items.Clear();
            tbBevitel.Focus();
        }

        private void btnListabol_Click(object sender, EventArgs e)
        {
            frmLista formLista = new frmLista(todos);
            

            var result = formLista.ShowDialog();

            if (result==DialogResult.OK)
            {
                tbBevitel.Text = formLista.SelectedTodo;
            }

            tbBevitel.Focus();
            tbBevitel.SelectionStart = tbBevitel.Text.Length;
            tbBevitel.SelectionLength = 0;

            tbBevitel.Text = formLista.SelectedTodo;
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            string todo = tbBevitel.Text.Trim();
            if (todo!="" && !lbTodo.Items.Contains(todo))
            {
                lbTodo.Items.Add(tbBevitel.Text);
                tbBevitel.Text = "";
            }
        }

        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            lbTodo.Items.Clear();
        }

        private void btnKivesz_Click(object sender, EventArgs e)
        {
            int index = lbTodo.SelectedIndex;
            if (index>-1)
            {
                lbTodo.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Válassz ki egyet!","Nincs kiválasztva",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            var a =lbTodo.FindStringExact(" ");
        }

        private void lbTodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nBeolvavas_Click(object sender, EventArgs e)
        {
            if (ofdMegnyitas.ShowDialog() == DialogResult.OK)
            {
                lbTodo.Items.Clear();
                StreamReader be = new StreamReader(ofdMegnyitas.FileName);
                while (!be.EndOfStream)
                {
                    lbTodo.Items.Add(be.ReadLine());
                }
                be.Close();
                MessageBox.Show("Sikeres beolvasás", "Beolvasás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nMentes_Click(object sender, EventArgs e)
        {
        if (lbTodo.Items.Count >0)
        {

            
            sfdMentes.FileName = FileNameDate();
            if (sfdMentes.ShowDialog() == DialogResult.OK)
            {
                StreamWriter iro = new StreamWriter(sfdMentes.FileName);
                foreach (var item in lbTodo.Items)
                {
                    iro.WriteLine(item);
                }


                iro.Close();
                MessageBox.Show("Sikeres mentés", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            else
            {
                MessageBox.Show("Nincs mit menteni","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        private string FileNameDate()
        {
            var datum = DateTime.Now;
            string ev = datum.Year.ToString();
            string honap = datum.Month.ToString();
            if (datum.Month < 10)
            {
                honap = 0 + datum.Month.ToString();
            }
            else
            {
                honap = datum.Month.ToString();
            }
            string nap = datum.Day.ToString();
            if (datum.Day<10)
            {
                nap =  0+datum.Day.ToString();
            }
            else
            {
                nap = datum.Day.ToString();
            }
            return ev + honap + nap;
        }
    }
}