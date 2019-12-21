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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //create_matrice();
            //calcul_matrice();
            txt_opération.Text = Program.Opération;
            txt_descreption.Text = Program.Description;
            Page1.getMyPage.Creation_Matrice(Program.ligne1, Program.colonne1, matrice11);
            Page1.getMyPage.Creation_Matrice(Program.ligne2, Program.colonne2, matrice22);
            Couper_Matrice(matrice11, Page1.getMyPage.matrice1);
            Couper_Matrice(matrice22, Page1.getMyPage.matrice2);
            calcul_matrice();
        }

        private void sortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Couper_Matrice(DataGridView Matrice1, DataGridView Matrice2)
        {
            //DataGridView d = new DataGridView();
            //d.Size.Width=""+22;
            //d.Size.Height = 44;
            for (int i = 0; i < Matrice1.RowCount; i++)
            {
                for (int j = 0; j < Matrice2.ColumnCount; j++)
                {
                    Matrice1[j, i].Value = Matrice2[j, i].Value;
                }
            }
        }
        //public void create_matrice()
        //{
        //    matrice11.RowCount = Program.ligne1;
        //    matrice11.ColumnCount = Program.colonne1;
        //    matrice22.RowCount = Program.ligne2;
        //    matrice22.ColumnCount = Program.colonne2;
        //    for (int i = 0; i < Program.ligne1; i++)
        //    {
        //        for (int j = 0; j < Program.colonne1; j++)
        //        {
        //            matrice11[j, i].Value = Page1.getMyPage.matrice1[j, i].Value;
        //        }
        //    }
        //    for (int i = 0; i < Program.ligne2; i++)
        //    {
        //        for (int j = 0; j < Program.colonne2; j++)
        //        {
        //            matrice22[j, i].Value = Page1.getMyPage.matrice2[j, i].Value;
        //        }
        //    }
        //    txt_opération.Text = Program.Opération;
        //    txt_descreption.Text = Program.Description;
        //}
        public void calcul_matrice()
        {
            try
            {
                if (txt_opération.Text == "*")
                {
                    //matrice_resultat.RowCount = Program.ligne1;
                    //matrice_resultat.ColumnCount = Program.colonne2;
                    Page1.getMyPage.Creation_Matrice(Program.ligne1, Program.colonne2,matrice_resultat);
                    Page1.getMyPage.Mul_Matrice(matrice11, matrice22, matrice_resultat);
                }
                else
                {
                    if (txt_opération.Text == "+")
                    {
                        //matrice_resultat.RowCount = Program.ligne1;
                        //matrice_resultat.ColumnCount = Program.colonne1;
                        Page1.getMyPage.Creation_Matrice(Program.ligne1, Program.colonne1, matrice_resultat);
                        Page1.getMyPage.Sum_Matrice(matrice11, matrice22, matrice_resultat);
                        
                    }
                }
            }
            catch 
            {
                return ;
            }
        }


        private void matrice11_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void matrice11_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string mot = "";
            try
            {
                mot = matrice11.CurrentCell.Value.ToString();
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
                    matrice11.CurrentCell.Value = 0;
                }
            }
            calcul_matrice();
        }

        private void matrice22_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string mot = "";
            try
            {
                mot = matrice22.CurrentCell.Value.ToString();
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
                    matrice22.CurrentCell.Value = 0;
                }
            }
            calcul_matrice();
        }

    }
}
