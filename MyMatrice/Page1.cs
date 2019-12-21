using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MyMatrice
{
    public partial class Page1 : Form
    {
        public int ligne1 = Program.ligne1, colonne1 = Program.colonne1, ligne2 = Program.ligne2, colonne2 = Program.colonne2;
        private static Page1 frm;
        static void page1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Page1 getMyPage
        {
            get
            {
            
                if(frm == null)
                {
                   frm = new Page1();
                   frm.FormClosed += new FormClosedEventHandler(page1_FormClosed);
                }
                return frm;
            }
        }
        public Page1()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            //create_matrice();
            Creation_Matrice(ligne1, colonne1, matrice1);
            Creation_Matrice(ligne2, colonne2, matrice2);

        }

        private void sortir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void create_matrice()
        {
            matrice1.RowCount = Program.ligne1;
            matrice1.ColumnCount = Program.colonne1;
            matrice2.RowCount = Program.ligne2;
            matrice2.ColumnCount = Program.colonne2;
            for (int i = 0; i < matrice1.RowCount; i++)
            {
                for (int j = 0; j < matrice1.ColumnCount; j++)
                {
                    matrice1[j, i].Value = 0;
                }
            }

            for (int i = 0; i < matrice2.RowCount; i++)
            {
                for (int j = 0; j < matrice2.ColumnCount; j++)
                {
                    matrice2[j, i].Value = 0;
                }
            }
           
        }

        public void Creation_Matrice(int Ligne, int Colonne, DataGridView Name)
        {

            Name.RowCount = Ligne;
            Name.ColumnCount = Colonne;
            for (int i = 0; i < Name.RowCount; i++)
            {
                for (int j = 0; j < Name.ColumnCount; j++)
                {
                    Name[j, i].Value = 0;
                }
            }
        }

        public void Sum_Matrice(DataGridView Matrice1, DataGridView Matrice2, DataGridView Result)
        {

            for (int i = 0; i < Matrice1.RowCount; i++)
            {
                for (int j = 0; j < Matrice1.ColumnCount; j++)
                {
                    Result[j, i].Value = Convert.ToInt32(Matrice1[j, i].Value) + Convert.ToInt32(Matrice2[j, i].Value);
                }
            }
        }

        public void Mul_Matrice(DataGridView Matrice1, DataGridView Matrice2, DataGridView Result)
        {

            for (int i = 0; i < Matrice2.ColumnCount; i++)
            {
                for (int j = 0; j < Matrice1.RowCount; j++)
                {
                    Result[i, j].Value = 0;
                    for (int t = 0; t < Matrice1.ColumnCount; t++)
                    {
                        Result[i, j].Value = Convert.ToInt32(Result[i, j].Value) +
                                             (Convert.ToInt32(Matrice1[t, j].Value) * 
                                             Convert.ToInt32(Matrice2[i, t].Value));
                    }
                }
            }
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            if (Program.ligne2 == Program.colonne1)
            {
                Program.Opération = "*";
                Program.Description = "Matrice1 * Matrice2";
                Form1 f = new Form1();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("N'est exist pas la solution pour le produit entre les deux matrice !", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_somme_Click(object sender, EventArgs e)
        {
            if ((Program.ligne1 == Program.ligne2) && (Program.colonne1 == Program.colonne2))
            {
                Program.Opération = "+";
                Program.Description = "Matrice1 + Matrice2";
                Form1 f = new Form1();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("N'est exist pas la solution pour la somme entre les deux matrice !", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }

        private void matrice1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string mot = "";
            try
            {
                mot = matrice1.CurrentCell.Value.ToString();
            }
            catch
            {
                return;
            }
            for (int i = 0; i < mot.Length; i++)
            {
                char c = mot.ElementAt(i);
                char DecimalSeparator = Char.Parse(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                if (!char.IsDigit(c) || c == DecimalSeparator)
                {
                    matrice1.CurrentCell.Value = 0;
                }
            }
        }

        private void matrice2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string mot = "";
            try
            {
                mot = matrice2.CurrentCell.Value.ToString();
            }
            catch
            {
                return;
            }
            for (int i = 0; i < mot.Length; i++)
            {
                char c = mot.ElementAt(i);
                char DecimalSeparator = Char.Parse(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                if (!char.IsDigit(c) || c == DecimalSeparator)
                {
                    matrice2.CurrentCell.Value = 0;
                }
            }
        }
    }
}
