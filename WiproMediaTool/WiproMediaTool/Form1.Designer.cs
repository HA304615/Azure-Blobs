namespace WiproMediaTool
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
            this.headlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContainerTextBox = new System.Windows.Forms.TextBox();
            this.containerUploadButton = new System.Windows.Forms.Button();
            this.ListBlobButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.blobUploadButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // headlabel
            // 
            this.headlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlabel.Location = new System.Drawing.Point(126, 24);
            this.headlabel.Name = "headlabel";
            this.headlabel.Size = new System.Drawing.Size(315, 72);
            this.headlabel.TabIndex = 0;
            this.headlabel.Text = " Wipro Media App";
            this.headlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Media Box Name:";
            // 
            // ContainerTextBox
            // 
            this.ContainerTextBox.Location = new System.Drawing.Point(193, 113);
            this.ContainerTextBox.Name = "ContainerTextBox";
            this.ContainerTextBox.Size = new System.Drawing.Size(143, 20);
            this.ContainerTextBox.TabIndex = 2;
            // 
            // containerUploadButton
            // 
            this.containerUploadButton.Location = new System.Drawing.Point(366, 111);
            this.containerUploadButton.Name = "containerUploadButton";
            this.containerUploadButton.Size = new System.Drawing.Size(90, 23);
            this.containerUploadButton.TabIndex = 3;
            this.containerUploadButton.Text = "Click to Create";
            this.containerUploadButton.UseVisualStyleBackColor = true;
            this.containerUploadButton.Click += new System.EventHandler(this.containerUploadButton_Click);
            // 
            // ListBlobButton
            // 
            this.ListBlobButton.Location = new System.Drawing.Point(366, 159);
            this.ListBlobButton.Name = "ListBlobButton";
            this.ListBlobButton.Size = new System.Drawing.Size(90, 23);
            this.ListBlobButton.TabIndex = 5;
            this.ListBlobButton.Text = "List Blobs";
            this.ListBlobButton.UseVisualStyleBackColor = true;
            this.ListBlobButton.Click += new System.EventHandler(this.ListBlobButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of Blobs:";
            // 
            // blobUploadButton
            // 
            this.blobUploadButton.Location = new System.Drawing.Point(480, 110);
            this.blobUploadButton.Name = "blobUploadButton";
            this.blobUploadButton.Size = new System.Drawing.Size(93, 23);
            this.blobUploadButton.TabIndex = 4;
            this.blobUploadButton.Text = "Upload Blobs";
            this.blobUploadButton.UseVisualStyleBackColor = true;
            this.blobUploadButton.Click += new System.EventHandler(this.blobUploadButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(193, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 95);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 320);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBlobButton);
            this.Controls.Add(this.blobUploadButton);
            this.Controls.Add(this.containerUploadButton);
            this.Controls.Add(this.ContainerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headlabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WiproMediaTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContainerTextBox;
        private System.Windows.Forms.Button containerUploadButton;
        private System.Windows.Forms.Button ListBlobButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button blobUploadButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

