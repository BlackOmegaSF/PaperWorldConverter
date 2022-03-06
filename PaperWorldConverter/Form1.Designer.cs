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
            this.lblInputWorldMain = new System.Windows.Forms.Label();
            this.lblInputWorldNether = new System.Windows.Forms.Label();
            this.txtInputWorldNether = new System.Windows.Forms.TextBox();
            this.btnInputWorldNether = new System.Windows.Forms.Button();
            this.lblInputWorldEnd = new System.Windows.Forms.Label();
            this.txtInputWorldEnd = new System.Windows.Forms.TextBox();
            this.btnInputWorldEnd = new System.Windows.Forms.Button();
            this.cbxDeleteInputWorld = new System.Windows.Forms.CheckBox();
            this.lblOutputLocation = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpInputWorld.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputWorldMain
            // 
            this.txtInputWorldMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputWorldMain.Location = new System.Drawing.Point(6, 38);
            this.txtInputWorldMain.Name = "txtInputWorldMain";
            this.txtInputWorldMain.Size = new System.Drawing.Size(242, 20);
            this.txtInputWorldMain.TabIndex = 0;
            // 
            // btnInputWorldMain
            // 
            this.btnInputWorldMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputWorldMain.Location = new System.Drawing.Point(254, 38);
            this.btnInputWorldMain.Name = "btnInputWorldMain";
            this.btnInputWorldMain.Size = new System.Drawing.Size(60, 20);
            this.btnInputWorldMain.TabIndex = 1;
            this.btnInputWorldMain.Text = "Browse...";
            this.btnInputWorldMain.UseVisualStyleBackColor = true;
            // 
            // grpInputWorld
            // 
            this.grpInputWorld.Controls.Add(this.cbxDeleteInputWorld);
            this.grpInputWorld.Controls.Add(this.lblInputWorldEnd);
            this.grpInputWorld.Controls.Add(this.txtInputWorldEnd);
            this.grpInputWorld.Controls.Add(this.btnInputWorldEnd);
            this.grpInputWorld.Controls.Add(this.lblInputWorldNether);
            this.grpInputWorld.Controls.Add(this.txtInputWorldNether);
            this.grpInputWorld.Controls.Add(this.btnInputWorldNether);
            this.grpInputWorld.Controls.Add(this.lblInputWorldMain);
            this.grpInputWorld.Controls.Add(this.txtInputWorldMain);
            this.grpInputWorld.Controls.Add(this.btnInputWorldMain);
            this.grpInputWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInputWorld.Location = new System.Drawing.Point(12, 12);
            this.grpInputWorld.Name = "grpInputWorld";
            this.grpInputWorld.Size = new System.Drawing.Size(320, 170);
            this.grpInputWorld.TabIndex = 3;
            this.grpInputWorld.TabStop = false;
            this.grpInputWorld.Text = "World to Convert";
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
            // lblInputWorldNether
            // 
            this.lblInputWorldNether.AutoSize = true;
            this.lblInputWorldNether.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputWorldNether.Location = new System.Drawing.Point(6, 61);
            this.lblInputWorldNether.Name = "lblInputWorldNether";
            this.lblInputWorldNether.Size = new System.Drawing.Size(71, 13);
            this.lblInputWorldNether.TabIndex = 5;
            this.lblInputWorldNether.Text = "Nether Folder";
            // 
            // txtInputWorldNether
            // 
            this.txtInputWorldNether.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputWorldNether.Location = new System.Drawing.Point(5, 77);
            this.txtInputWorldNether.Name = "txtInputWorldNether";
            this.txtInputWorldNether.Size = new System.Drawing.Size(242, 20);
            this.txtInputWorldNether.TabIndex = 3;
            // 
            // btnInputWorldNether
            // 
            this.btnInputWorldNether.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputWorldNether.Location = new System.Drawing.Point(253, 77);
            this.btnInputWorldNether.Name = "btnInputWorldNether";
            this.btnInputWorldNether.Size = new System.Drawing.Size(60, 20);
            this.btnInputWorldNether.TabIndex = 4;
            this.btnInputWorldNether.Text = "Browse...";
            this.btnInputWorldNether.UseVisualStyleBackColor = true;
            // 
            // lblInputWorldEnd
            // 
            this.lblInputWorldEnd.AutoSize = true;
            this.lblInputWorldEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputWorldEnd.Location = new System.Drawing.Point(6, 100);
            this.lblInputWorldEnd.Name = "lblInputWorldEnd";
            this.lblInputWorldEnd.Size = new System.Drawing.Size(80, 13);
            this.lblInputWorldEnd.TabIndex = 8;
            this.lblInputWorldEnd.Text = "The End Folder";
            // 
            // txtInputWorldEnd
            // 
            this.txtInputWorldEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputWorldEnd.Location = new System.Drawing.Point(5, 116);
            this.txtInputWorldEnd.Name = "txtInputWorldEnd";
            this.txtInputWorldEnd.Size = new System.Drawing.Size(242, 20);
            this.txtInputWorldEnd.TabIndex = 6;
            // 
            // btnInputWorldEnd
            // 
            this.btnInputWorldEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputWorldEnd.Location = new System.Drawing.Point(253, 116);
            this.btnInputWorldEnd.Name = "btnInputWorldEnd";
            this.btnInputWorldEnd.Size = new System.Drawing.Size(60, 20);
            this.btnInputWorldEnd.TabIndex = 7;
            this.btnInputWorldEnd.Text = "Browse...";
            this.btnInputWorldEnd.UseVisualStyleBackColor = true;
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
            // lblOutputLocation
            // 
            this.lblOutputLocation.AutoSize = true;
            this.lblOutputLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputLocation.Location = new System.Drawing.Point(9, 195);
            this.lblOutputLocation.Name = "lblOutputLocation";
            this.lblOutputLocation.Size = new System.Drawing.Size(84, 16);
            this.lblOutputLocation.TabIndex = 4;
            this.lblOutputLocation.Text = "Output World";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 381);
            this.Controls.Add(this.lblOutputLocation);
            this.Controls.Add(this.grpInputWorld);
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
        private System.Windows.Forms.Label lblInputWorldEnd;
        private System.Windows.Forms.TextBox txtInputWorldEnd;
        private System.Windows.Forms.Button btnInputWorldEnd;
        private System.Windows.Forms.Label lblInputWorldNether;
        private System.Windows.Forms.TextBox txtInputWorldNether;
        private System.Windows.Forms.Button btnInputWorldNether;
        private System.Windows.Forms.CheckBox cbxDeleteInputWorld;
        private System.Windows.Forms.Label lblOutputLocation;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

