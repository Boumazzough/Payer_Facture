namespace Projet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelRightTop = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelRightBottom = new System.Windows.Forms.Panel();
            this.PanelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelRightTop
            // 
            this.panelRightTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.panelRightTop.Controls.Add(this.pictureBox3);
            this.panelRightTop.Controls.Add(this.pictureBox2);
            this.panelRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRightTop.Location = new System.Drawing.Point(249, 0);
            this.panelRightTop.Name = "panelRightTop";
            this.panelRightTop.Size = new System.Drawing.Size(852, 44);
            this.panelRightTop.TabIndex = 1;
            this.panelRightTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRightTop_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projet.Properties.Resources.shutdown;
            this.pictureBox3.Location = new System.Drawing.Point(808, 9);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projet.Properties.Resources.browser;
            this.pictureBox2.Location = new System.Drawing.Point(16, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelRightBottom
            // 
            this.panelRightBottom.BackColor = System.Drawing.Color.Thistle;
            this.panelRightBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelRightBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightBottom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.panelRightBottom.Location = new System.Drawing.Point(249, 44);
            this.panelRightBottom.Name = "panelRightBottom";
            this.panelRightBottom.Size = new System.Drawing.Size(852, 631);
            this.panelRightBottom.TabIndex = 2;
            this.panelRightBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRightBottom_Paint);
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(143)))), ((int)(((byte)(167)))));
            this.PanelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMenu.BackgroundImage")));
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenu.Controls.Add(this.bunifuFlatButton3);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton2);
            this.PanelMenu.Controls.Add(this.bunifuFlatButton1);
            this.PanelMenu.Controls.Add(this.panelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.PanelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(69)))), ((int)(((byte)(139)))));
            this.PanelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(55)))), ((int)(((byte)(117)))));
            this.PanelMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Quality = 10;
            this.PanelMenu.Size = new System.Drawing.Size(249, 675);
            this.PanelMenu.TabIndex = 0;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Mes Comptes";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconZoom = 50D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 437);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(249, 48);
            this.bunifuFlatButton3.TabIndex = 6;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bunifuFlatButton9);
            this.panel1.Controls.Add(this.bunifuFlatButton8);
            this.panel1.Controls.Add(this.bunifuFlatButton7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 291);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 146);
            this.panel1.TabIndex = 5;
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "Administration ";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = null;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconZoom = 90D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(0, 96);
            this.bunifuFlatButton9.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(249, 48);
            this.bunifuFlatButton9.TabIndex = 3;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.bunifuFlatButton9.Click += new System.EventHandler(this.bunifuFlatButton9_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Eau et Électricité";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(0, 48);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(249, 48);
            this.bunifuFlatButton8.TabIndex = 2;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Téléphone et Internet";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(249, 48);
            this.bunifuFlatButton7.TabIndex = 1;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Payer une Facture";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 243);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(249, 48);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Effectuer un Virement";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 195);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(54)))), ((int)(((byte)(89)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(249, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(249, 195);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(144)))), ((int)(((byte)(162)))));
            this.label1.Location = new System.Drawing.Point(59, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma Banque";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(75, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 675);
            this.Controls.Add(this.panelRightBottom);
            this.Controls.Add(this.panelRightTop);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelRightTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelRightTop;
        private System.Windows.Forms.Panel panelRightBottom;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton9;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

