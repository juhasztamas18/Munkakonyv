namespace Beadando
{
    partial class FoAblak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoAblak));
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbNap = new System.Windows.Forms.TextBox();
            this.tbBer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbFelvetel = new System.Windows.Forms.RadioButton();
            this.rbSzerkesztes = new System.Windows.Forms.RadioButton();
            this.lvAdatok = new System.Windows.Forms.ListView();
            this.nev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.napok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKilepes = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKesz = new System.Windows.Forms.Button();
            this.tbFizetes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkásBéreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összeFizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.táblazatTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.munkásEltávolitásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(951, 387);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(96, 33);
            this.btnFelvesz.TabIndex = 1;
            this.btnFelvesz.Text = "Felvesz";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            this.btnFelvesz.Visible = false;
            this.btnFelvesz.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(603, 326);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(85, 22);
            this.tbNev.TabIndex = 2;
            this.tbNev.Visible = false;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(709, 326);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(85, 22);
            this.tbTelefon.TabIndex = 3;
            this.tbTelefon.Visible = false;
            // 
            // tbNap
            // 
            this.tbNap.Location = new System.Drawing.Point(815, 326);
            this.tbNap.Name = "tbNap";
            this.tbNap.Size = new System.Drawing.Size(85, 22);
            this.tbNap.TabIndex = 4;
            this.tbNap.Visible = false;
            // 
            // tbBer
            // 
            this.tbBer.Location = new System.Drawing.Point(921, 326);
            this.tbBer.Name = "tbBer";
            this.tbBer.Size = new System.Drawing.Size(85, 22);
            this.tbBer.TabIndex = 5;
            this.tbBer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(599, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adja meg a megfelelő adatokat sorrendben!";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(760, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mit akar csinálni?";
            // 
            // rbFelvetel
            // 
            this.rbFelvetel.AutoSize = true;
            this.rbFelvetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbFelvetel.Location = new System.Drawing.Point(684, 75);
            this.rbFelvetel.Name = "rbFelvetel";
            this.rbFelvetel.Size = new System.Drawing.Size(127, 24);
            this.rbFelvetel.TabIndex = 8;
            this.rbFelvetel.Text = "Adat felvétel!";
            this.rbFelvetel.UseVisualStyleBackColor = true;
            this.rbFelvetel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbSzerkesztes
            // 
            this.rbSzerkesztes.AutoSize = true;
            this.rbSzerkesztes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbSzerkesztes.Location = new System.Drawing.Point(850, 75);
            this.rbSzerkesztes.Name = "rbSzerkesztes";
            this.rbSzerkesztes.Size = new System.Drawing.Size(165, 24);
            this.rbSzerkesztes.TabIndex = 9;
            this.rbSzerkesztes.Text = "Adat szerkesztés!";
            this.rbSzerkesztes.UseVisualStyleBackColor = true;
            this.rbSzerkesztes.CheckedChanged += new System.EventHandler(this.rbSzerkesztes_CheckedChanged);
            // 
            // lvAdatok
            // 
            this.lvAdatok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAdatok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nev,
            this.telefon,
            this.napok,
            this.ber});
            this.lvAdatok.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdatok.FullRowSelect = true;
            this.lvAdatok.GridLines = true;
            this.lvAdatok.Location = new System.Drawing.Point(0, 28);
            this.lvAdatok.Name = "lvAdatok";
            this.lvAdatok.Size = new System.Drawing.Size(540, 457);
            this.lvAdatok.TabIndex = 10;
            this.lvAdatok.UseCompatibleStateImageBehavior = false;
            this.lvAdatok.View = System.Windows.Forms.View.Details;
            this.lvAdatok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvAdatok_MouseClick);
            // 
            // nev
            // 
            this.nev.Text = "Név";
            // 
            // telefon
            // 
            this.telefon.Text = "Telefonszám";
            this.telefon.Width = 120;
            // 
            // napok
            // 
            this.napok.Text = "Óra";
            // 
            // ber
            // 
            this.ber.Text = "Bér";
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(951, 435);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(96, 29);
            this.btnKilepes.TabIndex = 11;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(599, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Válassza ki a sort!";
            this.label3.Visible = false;
            // 
            // btnKesz
            // 
            this.btnKesz.Location = new System.Drawing.Point(951, 387);
            this.btnKesz.Name = "btnKesz";
            this.btnKesz.Size = new System.Drawing.Size(96, 33);
            this.btnKesz.TabIndex = 13;
            this.btnKesz.Text = "Szerkeszt!";
            this.btnKesz.UseVisualStyleBackColor = true;
            this.btnKesz.Visible = false;
            this.btnKesz.Click += new System.EventHandler(this.btnKesz_Click);
            // 
            // tbFizetes
            // 
            this.tbFizetes.Location = new System.Drawing.Point(603, 232);
            this.tbFizetes.Name = "tbFizetes";
            this.tbFizetes.Size = new System.Drawing.Size(100, 22);
            this.tbFizetes.TabIndex = 14;
            this.tbFizetes.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(603, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "A munkási jelenlegi fizetése:";
            this.label4.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müveletekToolStripMenuItem,
            this.táblazatTörléseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müveletekToolStripMenuItem
            // 
            this.müveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munkásBéreToolStripMenuItem,
            this.összeFizetésToolStripMenuItem,
            this.munkásEltávolitásaToolStripMenuItem});
            this.müveletekToolStripMenuItem.Name = "müveletekToolStripMenuItem";
            this.müveletekToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.müveletekToolStripMenuItem.Text = "Müveletek";
            // 
            // munkásBéreToolStripMenuItem
            // 
            this.munkásBéreToolStripMenuItem.Name = "munkásBéreToolStripMenuItem";
            this.munkásBéreToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.munkásBéreToolStripMenuItem.Text = "Munkás bére";
            this.munkásBéreToolStripMenuItem.Click += new System.EventHandler(this.munkásBéreToolStripMenuItem_Click);
            // 
            // összeFizetésToolStripMenuItem
            // 
            this.összeFizetésToolStripMenuItem.Name = "összeFizetésToolStripMenuItem";
            this.összeFizetésToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.összeFizetésToolStripMenuItem.Text = "Össz fizetés";
            this.összeFizetésToolStripMenuItem.Click += new System.EventHandler(this.összeFizetésToolStripMenuItem_Click);
            // 
            // táblazatTörléseToolStripMenuItem
            // 
            this.táblazatTörléseToolStripMenuItem.Name = "táblazatTörléseToolStripMenuItem";
            this.táblazatTörléseToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.táblazatTörléseToolStripMenuItem.Text = "Táblazat törlése";
            this.táblazatTörléseToolStripMenuItem.Click += new System.EventHandler(this.táblazatTörléseToolStripMenuItem_Click);
            // 
            // munkásEltávolitásaToolStripMenuItem
            // 
            this.munkásEltávolitásaToolStripMenuItem.Name = "munkásEltávolitásaToolStripMenuItem";
            this.munkásEltávolitásaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.munkásEltávolitásaToolStripMenuItem.Text = "Munkás eltávolitása";
            this.munkásEltávolitásaToolStripMenuItem.Click += new System.EventHandler(this.munkásEltávolitásaToolStripMenuItem_Click);
            // 
            // FoAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 485);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFizetes);
            this.Controls.Add(this.btnKesz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.lvAdatok);
            this.Controls.Add(this.rbSzerkesztes);
            this.Controls.Add(this.rbFelvetel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBer);
            this.Controls.Add(this.tbNap);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.btnFelvesz);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FoAblak";
            this.Text = "FoAblak";
            this.Load += new System.EventHandler(this.FoAblak_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFelvesz;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbNap;
        private System.Windows.Forms.TextBox tbBer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbFelvetel;
        private System.Windows.Forms.RadioButton rbSzerkesztes;
        private System.Windows.Forms.ListView lvAdatok;
        private System.Windows.Forms.ColumnHeader nev;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader napok;
        private System.Windows.Forms.ColumnHeader ber;
        private System.Windows.Forms.Button btnKilepes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKesz;
        private System.Windows.Forms.TextBox tbFizetes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munkásBéreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összeFizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem táblazatTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem munkásEltávolitásaToolStripMenuItem;
    }
}