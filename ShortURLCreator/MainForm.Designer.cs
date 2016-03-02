namespace ShortURLCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnMake = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblLongURL = new System.Windows.Forms.Label();
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.mnuProviders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tinyURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinyArrowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kissabeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isgdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.toolBar1 = new ShortURLCreator.ToolBar();
            this.txtLongURL = new ShortURLCreator.TextBoxExtended();
            this.mnuProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(236, 23);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(98, 23);
            this.btnMake.TabIndex = 7;
            this.btnMake.Text = "Make Short URL";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 59);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // lblLongURL
            // 
            this.lblLongURL.AutoSize = true;
            this.lblLongURL.Location = new System.Drawing.Point(12, 9);
            this.lblLongURL.Name = "lblLongURL";
            this.lblLongURL.Size = new System.Drawing.Size(152, 13);
            this.lblLongURL.TabIndex = 5;
            this.lblLongURL.Text = "Enter a long URL to make tiny:";
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "TinyURL");
            this.imlIcons.Images.SetKeyName(1, "TinyArro.ws");
            this.imlIcons.Images.SetKeyName(2, "Bit.ly");
            this.imlIcons.Images.SetKeyName(3, "kissa.be");
            this.imlIcons.Images.SetKeyName(4, "is.gd");
            this.imlIcons.Images.SetKeyName(5, "tr.im");
            this.imlIcons.Images.SetKeyName(6, "Cort.as");
            this.imlIcons.Images.SetKeyName(7, "u.nu");
            this.imlIcons.Images.SetKeyName(8, "Karmacracy");
            // 
            // mnuProviders
            // 
            this.mnuProviders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinyURLToolStripMenuItem,
            this.tinyArrowsToolStripMenuItem,
            this.bitlyToolStripMenuItem,
            this.kissabeToolStripMenuItem,
            this.isgdToolStripMenuItem,
            this.trimToolStripMenuItem,
            this.cortasToolStripMenuItem,
            this.unuToolStripMenuItem});
            this.mnuProviders.Name = "mnuProviders";
            this.mnuProviders.Size = new System.Drawing.Size(153, 202);
            this.mnuProviders.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuProviders_ItemClicked);
            // 
            // tinyURLToolStripMenuItem
            // 
            this.tinyURLToolStripMenuItem.Image = global::ShortURLCreator.Properties.Resources.TinyURL;
            this.tinyURLToolStripMenuItem.Name = "tinyURLToolStripMenuItem";
            this.tinyURLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tinyURLToolStripMenuItem.Text = "TinyURL";
            // 
            // tinyArrowsToolStripMenuItem
            // 
            this.tinyArrowsToolStripMenuItem.Image = global::ShortURLCreator.Properties.Resources.TinyArro_ws;
            this.tinyArrowsToolStripMenuItem.Name = "tinyArrowsToolStripMenuItem";
            this.tinyArrowsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tinyArrowsToolStripMenuItem.Text = "TinyArro.ws";
            // 
            // bitlyToolStripMenuItem
            // 
            this.bitlyToolStripMenuItem.Image = global::ShortURLCreator.Properties.Resources.Bit_ly;
            this.bitlyToolStripMenuItem.Name = "bitlyToolStripMenuItem";
            this.bitlyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bitlyToolStripMenuItem.Text = "Bit.ly";
            // 
            // kissabeToolStripMenuItem
            // 
            this.kissabeToolStripMenuItem.Image = global::ShortURLCreator.Properties.Resources.kissa_be;
            this.kissabeToolStripMenuItem.Name = "kissabeToolStripMenuItem";
            this.kissabeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kissabeToolStripMenuItem.Text = "kissa.be";
            // 
            // isgdToolStripMenuItem
            // 
            this.isgdToolStripMenuItem.Image = global::ShortURLCreator.Properties.Resources.is_gd;
            this.isgdToolStripMenuItem.Name = "isgdToolStripMenuItem";
            this.isgdToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.isgdToolStripMenuItem.Text = "is.gd";
            // 
            // trimToolStripMenuItem
            // 
            this.trimToolStripMenuItem.Image = global::ShortURLCreator.Properties.Resources.tr_im;
            this.trimToolStripMenuItem.Name = "trimToolStripMenuItem";
            this.trimToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trimToolStripMenuItem.Text = "tr.im";
            // 
            // cortasToolStripMenuItem
            // 
            this.cortasToolStripMenuItem.Image = global::ShortURLCreator.Properties.Resources.Cort_as;
            this.cortasToolStripMenuItem.Name = "cortasToolStripMenuItem";
            this.cortasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cortasToolStripMenuItem.Text = "Cort.as";
            // 
            // unuToolStripMenuItem
            // 
            this.unuToolStripMenuItem.Image = global::ShortURLCreator.Properties.Resources.u_nu;
            this.unuToolStripMenuItem.Name = "unuToolStripMenuItem";
            this.unuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unuToolStripMenuItem.Text = "u.nu";
            // 
            // picSettings
            // 
            this.picSettings.Image = global::ShortURLCreator.Properties.Resources.Gear;
            this.picSettings.Location = new System.Drawing.Point(324, 3);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(18, 18);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSettings.TabIndex = 11;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // toolBar1
            // 
            this.toolBar1.Location = new System.Drawing.Point(16, 45);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(214, 24);
            this.toolBar1.TabIndex = 12;
            this.toolBar1.Visible = false;
            this.toolBar1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolBar1_ItemClicked);
            // 
            // txtLongURL
            // 
            this.txtLongURL.Image = null;
            this.txtLongURL.Location = new System.Drawing.Point(15, 25);
            this.txtLongURL.Name = "txtLongURL";
            this.txtLongURL.Size = new System.Drawing.Size(215, 20);
            this.txtLongURL.TabIndex = 10;
            this.txtLongURL.ImageClick += new System.EventHandler(this.txtLongURL_ImageClick);
            this.txtLongURL.Click += new System.EventHandler(this.txtLongURL_Click);
            this.txtLongURL.Leave += new System.EventHandler(this.txtLongURL_Leave);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnMake;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 93);
            this.Controls.Add(this.picSettings);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLongURL);
            this.Controls.Add(this.txtLongURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short URL Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mnuProviders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnMake;
        internal System.Windows.Forms.Label lblResult;
        internal System.Windows.Forms.Label lblLongURL;
        private System.Windows.Forms.ImageList imlIcons;
        private System.Windows.Forms.ContextMenuStrip mnuProviders;
        private System.Windows.Forms.ToolStripMenuItem tinyURLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinyArrowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kissabeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isgdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortasToolStripMenuItem;
        private TextBoxExtended txtLongURL;
        private System.Windows.Forms.ToolStripMenuItem unuToolStripMenuItem;
        private System.Windows.Forms.PictureBox picSettings;
        private ToolBar toolBar1;
    }
}

