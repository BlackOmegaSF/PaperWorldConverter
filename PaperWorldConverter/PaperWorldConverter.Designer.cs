namespace PaperWorldConverter
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
            this.txtInputWorldMain = new System.Windows.Forms.TextBox();
            this.btnInputWorldMain = new System.Windows.Forms.Button();
            this.grpInputWorld = new System.Windows.Forms.GroupBox();
            this.lblInputWorldEnd = new System.Windows.Forms.Label();
            this.lblInputWorldNether = new System.Windows.Forms.Label();
            this.cbxDeleteInputWorld = new System.Windows.Forms.CheckBox();
            this.lblTheEndFolder = new System.Windows.Forms.Label();
            this.lblNetherFolder = new System.Windows.Forms.Label();
            this.lblInputWorldMain = new System.Windows.Forms.Label();
            this.lblOutputLocation = new System.Windows.Forms.Label();
            this.toolTipOutputInfo = new System.Windows.Forms.ToolTip(this.components);
            this.txtOutputWorld = new System.Windows.Forms.TextBox();
            this.btnOutputWorld = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grpInputWorld.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputWorldMain
            // 
            this.txtInputWorldMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputWorldMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputWorldMain.Location = new System.Drawing.Point(6, 38);
            this.txtInputWorldMain.Name = "txtInputWorldMain";
            this.txtInputWorldMain.Size = new System.Drawing.Size(257, 20);
            this.txtInputWorldMain.TabIndex = 0;
            this.txtInputWorldMain.TextChanged += new System.EventHandler(this.txtInputWorldMain_TextChanged);
            // 
            // btnInputWorldMain
            // 
            this.btnInputWorldMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputWorldMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputWorldMain.Location = new System.Drawing.Point(269, 38);
            this.btnInputWorldMain.Name = "btnInputWorldMain";
            this.btnInputWorldMain.Size = new System.Drawing.Size(60, 20);
            this.btnInputWorldMain.TabIndex = 1;
            this.btnInputWorldMain.Text = "Browse...";
            this.btnInputWorldMain.UseVisualStyleBackColor = true;
            this.btnInputWorldMain.Click += new System.EventHandler(this.btnInputWorldMain_Click);
            // 
            // grpInputWorld
            // 
            this.grpInputWorld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInputWorld.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpInputWorld.Controls.Add(this.lblInputWorldEnd);
            this.grpInputWorld.Controls.Add(this.lblInputWorldNether);
            this.grpInputWorld.Controls.Add(this.cbxDeleteInputWorld);
            this.grpInputWorld.Controls.Add(this.lblTheEndFolder);
            this.grpInputWorld.Controls.Add(this.lblNetherFolder);
            this.grpInputWorld.Controls.Add(this.lblInputWorldMain);
            this.grpInputWorld.Controls.Add(this.txtInputWorldMain);
            this.grpInputWorld.Controls.Add(this.btnInputWorldMain);
            this.grpInputWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInputWorld.Location = new System.Drawing.Point(12, 12);
            this.grpInputWorld.Name = "grpInputWorld";
            this.grpInputWorld.Size = new System.Drawing.Size(335, 173);
            this.grpInputWorld.TabIndex = 3;
            this.grpInputWorld.TabStop = false;
            this.grpInputWorld.Text = "World to Convert";
            // 
            // lblInputWorldEnd
            // 
            this.lblInputWorldEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInputWorldEnd.AutoEllipsis = true;
            this.lblInputWorldEnd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInputWorldEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInputWorldEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputWorldEnd.Location = new System.Drawing.Point(6, 117);
            this.lblInputWorldEnd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblInputWorldEnd.Name = "lblInputWorldEnd";
            this.lblInputWorldEnd.Size = new System.Drawing.Size(323, 15);
            this.lblInputWorldEnd.TabIndex = 11;
            // 
            // lblInputWorldNether
            // 
            this.lblInputWorldNether.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInputWorldNether.AutoEllipsis = true;
            this.lblInputWorldNether.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInputWorldNether.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInputWorldNether.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputWorldNether.Location = new System.Drawing.Point(6, 77);
            this.lblInputWorldNether.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblInputWorldNether.Name = "lblInputWorldNether";
            this.lblInputWorldNether.Size = new System.Drawing.Size(323, 15);
            this.lblInputWorldNether.TabIndex = 10;
            // 
            // cbxDeleteInputWorld
            // 
            this.cbxDeleteInputWorld.AutoSize = true;
            this.cbxDeleteInputWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeleteInputWorld.Location = new System.Drawing.Point(6, 147);
            this.cbxDeleteInputWorld.Name = "cbxDeleteInputWorld";
            this.cbxDeleteInputWorld.Size = new System.Drawing.Size(170, 17);
            this.cbxDeleteInputWorld.TabIndex = 9;
            this.cbxDeleteInputWorld.Text = "Delete original after converting";
            this.cbxDeleteInputWorld.UseVisualStyleBackColor = true;
            // 
            // lblTheEndFolder
            // 
            this.lblTheEndFolder.AutoSize = true;
            this.lblTheEndFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheEndFolder.Location = new System.Drawing.Point(3, 97);
            this.lblTheEndFolder.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTheEndFolder.Name = "lblTheEndFolder";
            this.lblTheEndFolder.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblTheEndFolder.Size = new System.Drawing.Size(80, 17);
            this.lblTheEndFolder.TabIndex = 8;
            this.lblTheEndFolder.Text = "The End Folder";
            // 
            // lblNetherFolder
            // 
            this.lblNetherFolder.AutoSize = true;
            this.lblNetherFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetherFolder.Location = new System.Drawing.Point(6, 61);
            this.lblNetherFolder.Name = "lblNetherFolder";
            this.lblNetherFolder.Size = new System.Drawing.Size(71, 13);
            this.lblNetherFolder.TabIndex = 5;
            this.lblNetherFolder.Text = "Nether Folder";
            // 
            // lblInputWorldMain
            // 
            this.lblInputWorldMain.AutoSize = true;
            this.lblInputWorldMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputWorldMain.Location = new System.Drawing.Point(7, 22);
            this.lblInputWorldMain.Name = "lblInputWorldMain";
            this.lblInputWorldMain.Size = new System.Drawing.Size(93, 13);
            this.lblInputWorldMain.TabIndex = 2;
            this.lblInputWorldMain.Text = "Main World Folder";
            // 
            // lblOutputLocation
            // 
            this.lblOutputLocation.AutoSize = true;
            this.lblOutputLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLocation.Location = new System.Drawing.Point(9, 188);
            this.lblOutputLocation.Name = "lblOutputLocation";
            this.lblOutputLocation.Size = new System.Drawing.Size(84, 16);
            this.lblOutputLocation.TabIndex = 4;
            this.lblOutputLocation.Text = "Output World";
            // 
            // txtOutputWorld
            // 
            this.txtOutputWorld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputWorld.Location = new System.Drawing.Point(12, 207);
            this.txtOutputWorld.Name = "txtOutputWorld";
            this.txtOutputWorld.Size = new System.Drawing.Size(269, 20);
            this.txtOutputWorld.TabIndex = 10;
            // 
            // btnOutputWorld
            // 
            this.btnOutputWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutputWorld.Location = new System.Drawing.Point(287, 207);
            this.btnOutputWorld.Name = "btnOutputWorld";
            this.btnOutputWorld.Size = new System.Drawing.Size(60, 20);
            this.btnOutputWorld.TabIndex = 10;
            this.btnOutputWorld.Text = "Browse...";
            this.btnOutputWorld.UseVisualStyleBackColor = true;
            this.btnOutputWorld.Click += new System.EventHandler(this.btnOutputWorld_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 249);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(335, 114);
            this.textBox1.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 230);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConvert.Location = new System.Drawing.Point(12, 369);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(337, 30);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 411);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOutputWorld);
            this.Controls.Add(this.txtOutputWorld);
            this.Controls.Add(this.lblOutputLocation);
            this.Controls.Add(this.grpInputWorld);
            this.MinimumSize = new System.Drawing.Size(375, 450);
            this.Name = "MainForm";
            this.Text = "World Converter";
            this.grpInputWorld.ResumeLayout(false);
            this.grpInputWorld.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputWorldMain;
        private System.Windows.Forms.Button btnInputWorldMain;
        private System.Windows.Forms.GroupBox grpInputWorld;
        private System.Windows.Forms.Label lblInputWorldMain;
        private System.Windows.Forms.Label lblTheEndFolder;
        private System.Windows.Forms.Label lblNetherFolder;
        private System.Windows.Forms.CheckBox cbxDeleteInputWorld;
        private System.Windows.Forms.Label lblOutputLocation;
        private System.Windows.Forms.ToolTip toolTipOutputInfo;
        private System.Windows.Forms.TextBox txtOutputWorld;
        private System.Windows.Forms.Button btnOutputWorld;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblInputWorldNether;
        private System.Windows.Forms.Label lblInputWorldEnd;
    }
}

