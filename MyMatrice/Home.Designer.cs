namespace MyMatrice
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_colonne1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ligne1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_colonne2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_ligne2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_creat = new System.Windows.Forms.Button();
            this.sortir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sortir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 44);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to my first tp";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 48);
            this.panel2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(191, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(417, 34);
            this.label9.TabIndex = 3;
            this.label9.Text = "By Benkouider Messaoud 1st RSD";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.panel3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btn_creat);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(768, 329);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.txt_colonne1);
            this.panel5.Controls.Add(this.txt_ligne1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(94, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 135);
            this.panel5.TabIndex = 1;
            // 
            // txt_colonne1
            // 
            this.txt_colonne1.BackColor = System.Drawing.SystemColors.Control;
            this.txt_colonne1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_colonne1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_colonne1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_colonne1.HintForeColor = System.Drawing.Color.Silver;
            this.txt_colonne1.HintText = "Colonne";
            this.txt_colonne1.isPassword = false;
            this.txt_colonne1.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.txt_colonne1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_colonne1.LineMouseHoverColor = System.Drawing.Color.LightGreen;
            this.txt_colonne1.LineThickness = 3;
            this.txt_colonne1.Location = new System.Drawing.Point(82, 74);
            this.txt_colonne1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_colonne1.Name = "txt_colonne1";
            this.txt_colonne1.Size = new System.Drawing.Size(166, 29);
            this.txt_colonne1.TabIndex = 1;
            this.txt_colonne1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_colonne1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_colonne1_KeyPress_1);
            // 
            // txt_ligne1
            // 
            this.txt_ligne1.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ligne1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ligne1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_ligne1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ligne1.HintForeColor = System.Drawing.Color.Silver;
            this.txt_ligne1.HintText = "Ligne";
            this.txt_ligne1.isPassword = false;
            this.txt_ligne1.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.txt_ligne1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ligne1.LineMouseHoverColor = System.Drawing.Color.LightGreen;
            this.txt_ligne1.LineThickness = 3;
            this.txt_ligne1.Location = new System.Drawing.Point(82, 40);
            this.txt_ligne1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ligne1.Name = "txt_ligne1";
            this.txt_ligne1.Size = new System.Drawing.Size(166, 29);
            this.txt_ligne1.TabIndex = 0;
            this.txt_ligne1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ligne1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ligne1_KeyPress_1);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Matrice1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Colonne :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ligne :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.txt_colonne2);
            this.panel4.Controls.Add(this.txt_ligne2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(425, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 135);
            this.panel4.TabIndex = 2;
            // 
            // txt_colonne2
            // 
            this.txt_colonne2.BackColor = System.Drawing.SystemColors.Control;
            this.txt_colonne2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_colonne2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_colonne2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_colonne2.HintForeColor = System.Drawing.Color.Silver;
            this.txt_colonne2.HintText = "Colonne";
            this.txt_colonne2.isPassword = false;
            this.txt_colonne2.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.txt_colonne2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_colonne2.LineMouseHoverColor = System.Drawing.Color.LightGreen;
            this.txt_colonne2.LineThickness = 3;
            this.txt_colonne2.Location = new System.Drawing.Point(82, 74);
            this.txt_colonne2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_colonne2.Name = "txt_colonne2";
            this.txt_colonne2.Size = new System.Drawing.Size(166, 29);
            this.txt_colonne2.TabIndex = 1;
            this.txt_colonne2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_colonne2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_colonne2_KeyDown);
            this.txt_colonne2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_colonne2_KeyPress_1);
            // 
            // txt_ligne2
            // 
            this.txt_ligne2.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ligne2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ligne2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txt_ligne2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ligne2.HintForeColor = System.Drawing.Color.Silver;
            this.txt_ligne2.HintText = "Ligne";
            this.txt_ligne2.isPassword = false;
            this.txt_ligne2.LineFocusedColor = System.Drawing.Color.DeepPink;
            this.txt_ligne2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ligne2.LineMouseHoverColor = System.Drawing.Color.LightGreen;
            this.txt_ligne2.LineThickness = 9;
            this.txt_ligne2.Location = new System.Drawing.Point(82, 40);
            this.txt_ligne2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ligne2.Name = "txt_ligne2";
            this.txt_ligne2.Size = new System.Drawing.Size(166, 29);
            this.txt_ligne2.TabIndex = 0;
            this.txt_ligne2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ligne2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ligne2_KeyPress_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Matrice2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Colonne :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ligne :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insérier";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.panel4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 10;
            this.bunifuElipse5.TargetControl = this.btn_creat;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 10;
            this.bunifuElipse6.TargetControl = this.panel5;
            // 
            // btn_creat
            // 
            this.btn_creat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_creat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_creat.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_creat.FlatAppearance.BorderSize = 0;
            this.btn_creat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btn_creat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_creat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creat.ForeColor = System.Drawing.Color.White;
            this.btn_creat.Image = global::MyMatrice.Properties.Resources.apps;
            this.btn_creat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_creat.Location = new System.Drawing.Point(271, 258);
            this.btn_creat.Name = "btn_creat";
            this.btn_creat.Size = new System.Drawing.Size(233, 48);
            this.btn_creat.TabIndex = 4;
            this.btn_creat.Text = "Go For Creat";
            this.btn_creat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_creat.UseVisualStyleBackColor = false;
            this.btn_creat.Click += new System.EventHandler(this.btn_creat_Click);
            // 
            // sortir
            // 
            this.sortir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortir.FlatAppearance.BorderSize = 0;
            this.sortir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortir.Image = global::MyMatrice.Properties.Resources.delete;
            this.sortir.Location = new System.Drawing.Point(756, 6);
            this.sortir.Name = "sortir";
            this.sortir.Size = new System.Drawing.Size(28, 35);
            this.sortir.TabIndex = 1;
            this.sortir.UseVisualStyleBackColor = true;
            this.sortir.Click += new System.EventHandler(this.sortir_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(794, 435);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sortir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_colonne1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ligne1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_colonne2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ligne2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.Button btn_creat;

    }
}