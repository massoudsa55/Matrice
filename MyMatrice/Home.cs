using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMatrice
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void sortir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_ligne1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_colonne1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_ligne2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_colonne2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void txt_ligne1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_colonne1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_ligne2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_colonne2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_colonne2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_creat_Click(sender, e);
            }
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (txt_ligne1.Text == string.Empty)
            {
                MessageBox.Show("Nombre de ligne de 1er matrice est vide ,s'il vous plaît remplaire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txt_colonne1.Text == string.Empty)
                {
                    MessageBox.Show("Nombre de colonne de 1er matrice est vide ,s'il vous plaît remplaire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txt_ligne2.Text == string.Empty)
                    {
                        MessageBox.Show("Nombre de ligne de 2ème matrice est vide ,s'il vous plaît remplaire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (txt_colonne2.Text == string.Empty)
                        {
                            MessageBox.Show("Nombre de colonne de 2ème matrice est vide ,s'il vous plaît remplaire !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Program.ligne1 = Convert.ToInt32(txt_ligne1.Text);
                            Program.ligne2 = Convert.ToInt32(txt_ligne2.Text);
                            Program.colonne1 = Convert.ToInt32(txt_colonne1.Text);
                            Program.colonne2 = Convert.ToInt32(txt_colonne2.Text);
                            Page1.getMyPage.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }
    }
}
