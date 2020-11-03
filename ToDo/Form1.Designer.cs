namespace ToDo
{
    partial class frmKezdo
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
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.listákKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nBeolvavas = new System.Windows.Forms.ToolStripMenuItem();
            this.nMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.nKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEltavolit = new System.Windows.Forms.Button();
            this.btnKivesz = new System.Windows.Forms.Button();
            this.btnListabol = new System.Windows.Forms.Button();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTodo = new System.Windows.Forms.ListBox();
            this.tbBevitel = new System.Windows.Forms.TextBox();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.ofdMegnyitas = new System.Windows.Forms.OpenFileDialog();
            this.sfdMentes = new System.Windows.Forms.SaveFileDialog();
            this.mMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listákKezeléseToolStripMenuItem});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(584, 24);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "menuStrip1";
            // 
            // listákKezeléseToolStripMenuItem
            // 
            this.listákKezeléseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nBeolvavas,
            this.nMentes,
            this.toolStripMenuItem1,
            this.nKilepes});
            this.listákKezeléseToolStripMenuItem.Name = "listákKezeléseToolStripMenuItem";
            this.listákKezeléseToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.listákKezeléseToolStripMenuItem.Text = "Listák kezelése";
            // 
            // nBeolvavas
            // 
            this.nBeolvavas.Name = "nBeolvavas";
            this.nBeolvavas.Size = new System.Drawing.Size(180, 22);
            this.nBeolvavas.Text = "Beolvasás";
            this.nBeolvavas.Click += new System.EventHandler(this.nBeolvavas_Click);
            // 
            // nMentes
            // 
            this.nMentes.Name = "nMentes";
            this.nMentes.Size = new System.Drawing.Size(180, 22);
            this.nMentes.Text = "Mentés";
            this.nMentes.Click += new System.EventHandler(this.nMentes_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // nKilepes
            // 
            this.nKilepes.Name = "nKilepes";
            this.nKilepes.Size = new System.Drawing.Size(180, 22);
            this.nKilepes.Text = "Kilépés";
            this.nKilepes.Click += new System.EventHandler(this.nKilepes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnEltavolit);
            this.panel1.Controls.Add(this.btnKivesz);
            this.panel1.Controls.Add(this.btnListabol);
            this.panel1.Controls.Add(this.btnFelvitel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbTodo);
            this.panel1.Controls.Add(this.tbBevitel);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 350);
            this.panel1.TabIndex = 1;
            // 
            // btnEltavolit
            // 
            this.btnEltavolit.BackgroundImage = global::ToDo.Properties.Resources.trash_can;
            this.btnEltavolit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEltavolit.Location = new System.Drawing.Point(223, 292);
            this.btnEltavolit.Name = "btnEltavolit";
            this.btnEltavolit.Size = new System.Drawing.Size(40, 40);
            this.btnEltavolit.TabIndex = 7;
            this.btnEltavolit.UseVisualStyleBackColor = true;
            this.btnEltavolit.Click += new System.EventHandler(this.btnEltavolit_Click);
            // 
            // btnKivesz
            // 
            this.btnKivesz.BackgroundImage = global::ToDo.Properties.Resources.minus;
            this.btnKivesz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKivesz.Location = new System.Drawing.Point(225, 114);
            this.btnKivesz.Name = "btnKivesz";
            this.btnKivesz.Size = new System.Drawing.Size(40, 40);
            this.btnKivesz.TabIndex = 5;
            this.btnKivesz.UseVisualStyleBackColor = true;
            this.btnKivesz.Click += new System.EventHandler(this.btnKivesz_Click);
            // 
            // btnListabol
            // 
            this.btnListabol.BackgroundImage = global::ToDo.Properties.Resources.plus_sign;
            this.btnListabol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListabol.Location = new System.Drawing.Point(225, 68);
            this.btnListabol.Name = "btnListabol";
            this.btnListabol.Size = new System.Drawing.Size(40, 40);
            this.btnListabol.TabIndex = 4;
            this.btnListabol.UseVisualStyleBackColor = true;
            this.btnListabol.Click += new System.EventHandler(this.btnListabol_Click);
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.BackgroundImage = global::ToDo.Properties.Resources.trash_can;
            this.btnFelvitel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFelvitel.Location = new System.Drawing.Point(225, 9);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(40, 40);
            this.btnFelvitel.TabIndex = 3;
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tennivalók";
            // 
            // lbTodo
            // 
            this.lbTodo.FormattingEnabled = true;
            this.lbTodo.ItemHeight = 20;
            this.lbTodo.Location = new System.Drawing.Point(15, 68);
            this.lbTodo.Name = "lbTodo";
            this.lbTodo.Size = new System.Drawing.Size(204, 264);
            this.lbTodo.TabIndex = 2;
            this.lbTodo.SelectedIndexChanged += new System.EventHandler(this.lbTodo_SelectedIndexChanged);
            // 
            // tbBevitel
            // 
            this.tbBevitel.Location = new System.Drawing.Point(15, 16);
            this.tbBevitel.Name = "tbBevitel";
            this.tbBevitel.Size = new System.Drawing.Size(204, 26);
            this.tbBevitel.TabIndex = 2;
            // 
            // btnKilepes
            // 
            this.btnKilepes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKilepes.Image = global::ToDo.Properties.Resources.exit_small;
            this.btnKilepes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKilepes.Location = new System.Drawing.Point(451, 352);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btnKilepes.Size = new System.Drawing.Size(121, 49);
            this.btnKilepes.TabIndex = 6;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // ofdMegnyitas
            // 
            this.ofdMegnyitas.Filter = "ToDo lista|*.txt";
            this.ofdMegnyitas.Title = "ToDo lista beolvasása";
            // 
            // sfdMentes
            // 
            this.sfdMentes.DefaultExt = "txt";
            this.sfdMentes.Filter = "ToDo lista|*.txt";
            this.sfdMentes.Title = "ToDo lista mentése";
            // 
            // frmKezdo
            // 
            this.AcceptButton = this.btnFelvitel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.mMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKezdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo lista készítése";
            this.Shown += new System.EventHandler(this.frmKezdo_Shown);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem listákKezeléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nBeolvavas;
        private System.Windows.Forms.ToolStripMenuItem nMentes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nKilepes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEltavolit;
        private System.Windows.Forms.Button btnKivesz;
        private System.Windows.Forms.Button btnListabol;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTodo;
        private System.Windows.Forms.TextBox tbBevitel;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.OpenFileDialog ofdMegnyitas;
        private System.Windows.Forms.SaveFileDialog sfdMentes;
    }
}

