
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
            this.SuspendLayout();
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(145, 25);
            this.txtSourceDirectory.Multiline = true;
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(558, 60);
            this.txtSourceDirectory.TabIndex = 0;
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetDirectory.Location = new System.Drawing.Point(145, 92);
            this.txtTargetDirectory.Multiline = true;
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(558, 60);
            this.txtTargetDirectory.TabIndex = 1;
            // 
            // lblSourceDirectory
            // 
            this.lblSourceDirectory.AutoSize = true;
            this.lblSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceDirectory.Location = new System.Drawing.Point(12, 25);
            this.lblSourceDirectory.Name = "lblSourceDirectory";
            this.lblSourceDirectory.Size = new System.Drawing.Size(127, 20);
            this.lblSourceDirectory.TabIndex = 2;
            this.lblSourceDirectory.Text = "Source Directory";
            // 
            // lblTargetDirectory
            // 
            this.lblTargetDirectory.AutoSize = true;
            this.lblTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetDirectory.Location = new System.Drawing.Point(12, 92);
            this.lblTargetDirectory.Name = "lblTargetDirectory";
            this.lblTargetDirectory.Size = new System.Drawing.Size(122, 20);
            this.lblTargetDirectory.TabIndex = 3;
            this.lblTargetDirectory.Text = "Target Directory";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGo.Location = new System.Drawing.Point(709, 404);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(79, 34);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtCommentary
            // 
            this.txtCommentary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommentary.Location = new System.Drawing.Point(16, 199);
            this.txtCommentary.Multiline = true;
            this.txtCommentary.Name = "txtCommentary";
            this.txtCommentary.ReadOnly = true;
            this.txtCommentary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommentary.Size = new System.Drawing.Size(686, 239);
            this.txtCommentary.TabIndex = 5;
            // 
            // btnBrowseSourceDirectory
            // 
            this.btnBrowseSourceDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseSourceDirectory.Location = new System.Drawing.Point(709, 43);
            this.btnBrowseSourceDirectory.Name = "btnBrowseSourceDirectory";
            this.btnBrowseSourceDirectory.Size = new System.Drawing.Size(51, 23);
            this.btnBrowseSourceDirectory.TabIndex = 6;
            this.btnBrowseSourceDirectory.Text = "...";
            this.btnBrowseSourceDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseSourceDirectory.Click += new System.EventHandler(this.btnBrowseSourceDirectory_Click);
            // 
            // btnBrowseTargetDirectory
            // 
            this.btnBrowseTargetDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseTargetDirectory.Location = new System.Drawing.Point(709, 105);
            this.btnBrowseTargetDirectory.Name = "btnBrowseTargetDirectory";
            this.btnBrowseTargetDirectory.Size = new System.Drawing.Size(51, 23);
            this.btnBrowseTargetDirectory.TabIndex = 7;
            this.btnBrowseTargetDirectory.Text = "...";
            this.btnBrowseTargetDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseTargetDirectory.Click += new System.EventHandler(this.btnBrowseTargetDirectory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowseTargetDirectory);
            this.Controls.Add(this.btnBrowseSourceDirectory);
            this.Controls.Add(this.txtCommentary);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblTargetDirectory);
            this.Controls.Add(this.lblSourceDirectory);
            this.Controls.Add(this.txtTargetDirectory);
            this.Controls.Add(this.txtSourceDirectory);
            this.Name = "Form1";
            this.Text = "Canvas Assignment Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

