using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Auth;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace WiproMediaTool
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        
        private void blobUploadButton_Click(object sender, EventArgs e)
        {

            try
            {
                string storageAccountName = "hab1hydstorage";
                string storageAccountKey = "ziuuQljYtNxJGQNIHDPUrN8YEEKwFQMbW2rq5A0AG5ntmIynaaWE5ZJx1PVmSmPYyl7bBvJelcKfvE7Qoe6OBw==";
                StorageCredentials storeCred = new StorageCredentials(storageAccountName, storageAccountKey);
                CloudStorageAccount storeaccount = new CloudStorageAccount(storeCred, useHttps: true);
                CloudBlobClient blobClient = storeaccount.CreateCloudBlobClient();

                CloudBlobContainer cloudBlobContainer = blobClient.GetContainerReference("testcontainer");
                cloudBlobContainer.CreateIfNotExists();
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                var blobPath = dialog.FileName;
                var blobName = dialog.SafeFileName;

                CloudBlockBlob blockBlob = cloudBlobContainer.GetBlockBlobReference(blobName);
                var fileStream = File.OpenRead(blobPath);
                blockBlob.UploadFromStream(fileStream);
                MessageBox.Show(blobName + " " + "Uploaded successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception )
            {
                throw;

            }

        }

        public void containerUploadButton_Click(object sender, EventArgs e)
        {
            string containerName = ContainerTextBox.Text;
            Regex regex = new Regex(@"^[a-z0-9](?!.*--)[a-z0-9-]{1,61}[a-z0-9]$");//Azure Container Name validation
            Match match = regex.Match(containerName);
            if (containerName == "" || !(match.Success))
            {
                MessageBox.Show("Media Box Name only contains lowercase letters,numbers and hyphens,and must begin with a letter or a number. Each hyphen must be preceded and followed by a non-hyphen character.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    string storageAccountName = "hab1hydstorage";
                    string storageAccountKey = "ziuuQljYtNxJGQNIHDPUrN8YEEKwFQMbW2rq5A0AG5ntmIynaaWE5ZJx1PVmSmPYyl7bBvJelcKfvE7Qoe6OBw==";
                    StorageCredentials storeCred = new StorageCredentials(storageAccountName, storageAccountKey);
                    CloudStorageAccount storeAccount = new CloudStorageAccount(storeCred, useHttps: true);
                    CloudBlobClient blobClient = storeAccount.CreateCloudBlobClient();
                    string blobContainerName = containerName;
                    CloudBlobContainer cloudBlobContainer = blobClient.GetContainerReference(blobContainerName);
                    cloudBlobContainer.CreateIfNotExists();
                    MessageBox.Show(containerName + " " + "Container created successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    ContainerTextBox.Text = "";
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        private void ListBlobButton_Click(object sender, EventArgs e)
        {
            string containerName = ContainerTextBox.Text;

            string storageAccountName = "hab1hydstorage";
            string storageAccountKey = "ziuuQljYtNxJGQNIHDPUrN8YEEKwFQMbW2rq5A0AG5ntmIynaaWE5ZJx1PVmSmPYyl7bBvJelcKfvE7Qoe6OBw==";
            StorageCredentials storeCred = new StorageCredentials(storageAccountName, storageAccountKey);

            CloudStorageAccount storeAccount = new CloudStorageAccount(storeCred, useHttps: true);
            CloudBlobClient blobClient = storeAccount.CreateCloudBlobClient();

            CloudBlobContainer cloudBlobContainer = blobClient.GetContainerReference("testcontainer");
            cloudBlobContainer.CreateIfNotExists();
            var Blobs = cloudBlobContainer.ListBlobs();
            foreach(var Blob in Blobs)
            {
                listBox1.Items.Add(Blob.Uri.AbsoluteUri);
            }
           
        }

    }
}
