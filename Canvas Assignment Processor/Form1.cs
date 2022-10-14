﻿using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canvas_Assignment_Processor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnBrowseSourceDirectory_Click(object sender, EventArgs e)
        {
            ChooseFolder(txtSourceDirectory);
        }
        public void ChooseFolder(TextBox myTextBox)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                myTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseTargetDirectory_Click(object sender, EventArgs e)
        {
            ChooseFolder(txtTargetDirectory);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Process();
            }
        }
        private Boolean ValidateFields()
        {
            if (txtSourceDirectory.Text.Trim() != "" && txtTargetDirectory.Text.Trim() != "")
            {
                return true;
            }
            else { return false; }
        }
        private void Process()
        {
            txtCommentary.Text = "";
            Log("processing...");
            int count = 0;

            string[] files = Directory.GetFiles(txtSourceDirectory.Text.Trim());

            foreach (string file in files)
            {
                String adjustedTargetDirectory;
                adjustedTargetDirectory = txtTargetDirectory.Text.Trim() + "/" +  Path.GetFileName(file).TrimEnd(".zip".ToCharArray());
                Directory.CreateDirectory(adjustedTargetDirectory);
                Log(file + " to " + adjustedTargetDirectory );
                UnZip(file, adjustedTargetDirectory);
                count++;
            }
            Log(count.ToString() + " zip files processed.");
            Log("Done");
        }

        private void UnZip(String fileName, String targetDirectory)
        {
            using (Stream stream = File.OpenRead(fileName))
            using (var reader = ReaderFactory.Open(stream))
            {
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        Console.WriteLine(reader.Entry.Key);
                        reader.WriteEntryToDirectory(targetDirectory, new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSourceDirectory.Text = "C:\\temp\\input\\";
            txtTargetDirectory.Text = "C:\\temp\\output\\";
        }
        private void Log(String msg)
        {
            txtCommentary.AppendText(Environment.NewLine + msg);
        }
    }
}