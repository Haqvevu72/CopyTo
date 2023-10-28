using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CopyTo
{
    public partial class Form1 : Form
    {
        static Thread thread1;
        static Thread thread2;
       
        public Form1()
        {
            InitializeComponent();
             
            thread1 = new Thread(() =>
            {
                string sourceFilePath = txtbox_from.Text;

                string destinationDirectory = txtbox_to.Text;

                if (File.Exists(destinationDirectory + "\\" + $"{Path.GetFileName(sourceFilePath)}") == false)
                {

                    string fileName = Path.GetFileName(sourceFilePath);

                    string destinationFilePath = Path.Combine(destinationDirectory, fileName);

                    Thread.Sleep(3000);
                    File.Copy(sourceFilePath, destinationFilePath);

                }
                else
                {
                    MessageBox.Show("File already exists in this directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            });
            thread2 = new Thread(() => 
                {
                    Loading_Bar.Minimum = 0;
                    Loading_Bar.Maximum = 10;
                    Loading_Bar.Value = 0;

                    for (int currentValue = 0; currentValue <= 10; currentValue++)
                    {
                        Loading_Bar.Value = currentValue;
                        Application.DoEvents(); // Allow the UI to update
                        Thread.Sleep(100); // Sleep to control the speed of filling
                    }
                });
        }

        private void btn_filefrom_Click(object sender, EventArgs e)
        {
            // Create an instance of the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set properties of the dialog
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Set the initial directory
            openFileDialog.Title = "Select a File"; // Set the dialog's title
            openFileDialog.Filter = "All Files (*.*)|*.*";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                txtbox_from.Text = selectedFilePath;
            }
            else
            {
                Console.WriteLine("No file selected.");
            }
        }

        private void btn_fileto_Click(object sender, EventArgs e)
        {
            // Create an instance of the FolderBrowserDialog
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set properties of the dialog
            folderBrowserDialog.Description = "Select a Directory"; // Set a description for the dialog
            folderBrowserDialog.ShowNewFolderButton = true; // Show the "New Folder" button

            // Show the dialog and check if the user selected a directory
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedDirectoryPath = folderBrowserDialog.SelectedPath;
                txtbox_to.Text = selectedDirectoryPath;
            }
            else
            {
                Console.WriteLine("No directory selected.");
            }
        }

        
    }
}
