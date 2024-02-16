
namespace Canvas_Assignment_Processor
{
    partial class Form1
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
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.lblSourceDirectory = new System.Windows.Forms.Label();
            this.lblTargetDirectory = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtCommentary = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowseSourceDirectory = new System.Windows.Forms.Button();
            this.btnBrowseTargetDirectory = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(193, 55);
            this.txtSourceDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSourceDirectory.Multiline = true;
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(743, 73);
            this.txtSourceDirectory.TabIndex = 0;
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(193, 137);
            this.txtTargetDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTargetDirectory.Multiline = true;
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(743, 73);
            this.txtTargetDirectory.TabIndex = 1;
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceDirectory.Location = new System.Drawing.Point(16, 55);
            this.lblSourceDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(157, 25);
            this.lblSourceDirectory.TabIndex = 2;
            this.lblSourceDirectory.Text = "Source Directory";
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetDirectory.Location = new System.Drawing.Point(16, 137);
            this.lblTargetDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.Size = new System.Drawing.Size(151, 25);
            this.lblTargetDirectory.TabIndex = 3;
            this.lblTargetDirectory.Text = "Target Directory";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGo.Location = new System.Drawing.Point(945, 497);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(105, 42);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtCommentary
            // 
            this.txtCommentary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentary.Location = new System.Drawing.Point(21, 245);
            this.txtCommentary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCommentary.Multiline = true;
            this.txtCommentary.Name = "txtCommentary";
            this.txtCommentary.ReadOnly = true;
            this.txtCommentary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommentary.Size = new System.Drawing.Size(913, 293);
            this.txtCommentary.TabIndex = 5;
            // 
            // btnBrowseSourceDirectory
            // 
            this.btnBrowseSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSourceDirectory.Location = new System.Drawing.Point(945, 77);
            this.btnBrowseSourceDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseSourceDirectory.Name = "btnBrowseSourceDirectory";
            this.btnBrowseSourceDirectory.Size = new System.Drawing.Size(68, 28);
            this.btnBrowseSourceDirectory.TabIndex = 6;
            this.btnBrowseSourceDirectory.Text = "...";
            this.btnBrowseSourceDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseSourceDirectory.Click += new System.EventHandler(this.btnBrowseSourceDirectory_Click);
            // 
            // btnBrowseTargetDirectory
            // 
            this.btnBrowseTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseTargetDirectory.Location = new System.Drawing.Point(945, 153);
            this.btnBrowseTargetDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseTargetDirectory.Name = "btnBrowseTargetDirectory";
            this.btnBrowseTargetDirectory.Size = new System.Drawing.Size(68, 28);
            this.btnBrowseTargetDirectory.TabIndex = 7;
            this.btnBrowseTargetDirectory.Text = "...";
            this.btnBrowseTargetDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseTargetDirectory.Click += new System.EventHandler(this.btnBrowseTargetDirectory_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "mnusMain";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBrowseTargetDirectory);
            this.Controls.Add(this.btnBrowseSourceDirectory);
            this.Controls.Add(this.txtCommentary);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblTargetDirectory);
            this.Controls.Add(this.lblSourceDirectory);
            this.Controls.Add(this.txtTargetDirectory);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Canvas Assignment Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.Label lblSourceDirectory;
        private System.Windows.Forms.Label lblTargetDirectory;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtCommentary;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowseSourceDirectory;
        private System.Windows.Forms.Button btnBrowseTargetDirectory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

