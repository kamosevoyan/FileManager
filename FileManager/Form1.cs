namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filePath = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                label1.Text = $"File path:{filePath}";
                FileAttributes fileAttributes =
                    File.GetAttributes(filePath);
                checkSystem.Checked =
                    (fileAttributes & FileAttributes.System) != 0;
                checkHidden.Checked =
                    (fileAttributes & FileAttributes.Hidden) != 0;
                checkReadOnly.Checked =
                    (fileAttributes & FileAttributes.ReadOnly) != 0;
                checkArchive.Checked =
                    (fileAttributes & FileAttributes.Archive) != 0;

                CreateLabel.Text =
                    $"Created at:{File.GetCreationTime(filePath)}";
                ModifiedLabel.Text =
                   $"Modified at:{File.GetLastWriteTime(filePath)}";
                Accesslabel.Text =
                   $"Accessed at:{File.GetLastAccessTime(filePath)}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                FileAttributes attributes = File.GetAttributes(filePath);

                attributes = checkSystem.Checked
                    ? attributes | FileAttributes.System
                    : attributes & ~FileAttributes.System;
                attributes = checkHidden.Checked
                   ? attributes | FileAttributes.Hidden
                   : attributes & ~FileAttributes.Hidden;
                attributes = checkReadOnly.Checked
                   ? attributes | FileAttributes.ReadOnly
                   : attributes & ~FileAttributes.ReadOnly;
                attributes = checkArchive.Checked
                   ? attributes | FileAttributes.Archive
                   : attributes & ~FileAttributes.Archive;
                attributes = checkCompressed.Checked
                   ? attributes | FileAttributes.Compressed
                   : attributes & ~FileAttributes.Compressed;
                attributes = checkEncrypted.Checked
                    ? attributes | FileAttributes.Encrypted
                    : attributes & ~FileAttributes.Encrypted;

                File.SetAttributes(filePath, attributes);
            }
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            File.Copy(filePath, textBox1.Text + "\\" + Path.GetFileName(openFileDialog1.FileName));
            MessageBox.Show("File copied");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(openFileDialog1.FileName);
            string fileType = fileName.Substring(fileName.IndexOf("."), fileName.Length - fileName.IndexOf("."));

            string oldName = filePath;
            string getPath = oldName.Substring(0, oldName.LastIndexOf('\\'));
            string newName = textBox2.Text;

            File.Move(oldName, getPath + "\\" + newName + fileType);

            filePath = "";
            textBox2.Text = "";
            MessageBox.Show("File renamed");
        }
    }
}