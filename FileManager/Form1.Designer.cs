namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            OpenBtn = new Button();
            groupBox1 = new GroupBox();
            checkEncrypted = new CheckBox();
            checkCompressed = new CheckBox();
            button2 = new Button();
            checkArchive = new CheckBox();
            checkReadOnly = new CheckBox();
            checkHidden = new CheckBox();
            checkSystem = new CheckBox();
            groupBox2 = new GroupBox();
            Accesslabel = new Label();
            ModifiedLabel = new Label();
            CreateLabel = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 47);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "File path:";
            // 
            // OpenBtn
            // 
            OpenBtn.Location = new Point(77, 42);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.Size = new Size(112, 34);
            OpenBtn.TabIndex = 1;
            OpenBtn.Text = "Open";
            OpenBtn.UseVisualStyleBackColor = true;
            OpenBtn.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkEncrypted);
            groupBox1.Controls.Add(checkCompressed);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(checkArchive);
            groupBox1.Controls.Add(checkReadOnly);
            groupBox1.Controls.Add(checkHidden);
            groupBox1.Controls.Add(checkSystem);
            groupBox1.Location = new Point(54, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 367);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Attributes";
            // 
            // checkEncrypted
            // 
            checkEncrypted.AutoSize = true;
            checkEncrypted.Location = new Point(32, 222);
            checkEncrypted.Name = "checkEncrypted";
            checkEncrypted.Size = new Size(117, 29);
            checkEncrypted.TabIndex = 13;
            checkEncrypted.Text = "Encrypted";
            checkEncrypted.UseVisualStyleBackColor = true;
            // 
            // checkCompressed
            // 
            checkCompressed.AutoSize = true;
            checkCompressed.Location = new Point(32, 187);
            checkCompressed.Name = "checkCompressed";
            checkCompressed.Size = new Size(138, 29);
            checkCompressed.TabIndex = 12;
            checkCompressed.Text = "Compressed";
            checkCompressed.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(299, 297);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkArchive
            // 
            checkArchive.AutoSize = true;
            checkArchive.Location = new Point(32, 152);
            checkArchive.Name = "checkArchive";
            checkArchive.Size = new Size(96, 29);
            checkArchive.TabIndex = 7;
            checkArchive.Text = "Archive";
            checkArchive.UseVisualStyleBackColor = true;
            // 
            // checkReadOnly
            // 
            checkReadOnly.AutoSize = true;
            checkReadOnly.Location = new Point(32, 117);
            checkReadOnly.Name = "checkReadOnly";
            checkReadOnly.Size = new Size(114, 29);
            checkReadOnly.TabIndex = 6;
            checkReadOnly.Text = "ReadOnly";
            checkReadOnly.UseVisualStyleBackColor = true;
            // 
            // checkHidden
            // 
            checkHidden.AutoSize = true;
            checkHidden.Location = new Point(32, 82);
            checkHidden.Name = "checkHidden";
            checkHidden.Size = new Size(96, 29);
            checkHidden.TabIndex = 5;
            checkHidden.Text = "Hidden";
            checkHidden.UseVisualStyleBackColor = true;
            // 
            // checkSystem
            // 
            checkSystem.AutoSize = true;
            checkSystem.Location = new Point(32, 47);
            checkSystem.Name = "checkSystem";
            checkSystem.Size = new Size(95, 29);
            checkSystem.TabIndex = 4;
            checkSystem.Text = "System";
            checkSystem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Accesslabel);
            groupBox2.Controls.Add(ModifiedLabel);
            groupBox2.Controls.Add(CreateLabel);
            groupBox2.Location = new Point(481, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 367);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Time Parameters";
            // 
            // Accesslabel
            // 
            Accesslabel.AutoSize = true;
            Accesslabel.Location = new Point(58, 152);
            Accesslabel.Name = "Accesslabel";
            Accesslabel.Size = new Size(109, 25);
            Accesslabel.TabIndex = 10;
            Accesslabel.Text = "Accessed at:";
            // 
            // ModifiedLabel
            // 
            ModifiedLabel.AutoSize = true;
            ModifiedLabel.Location = new Point(58, 100);
            ModifiedLabel.Name = "ModifiedLabel";
            ModifiedLabel.Size = new Size(108, 25);
            ModifiedLabel.TabIndex = 9;
            ModifiedLabel.Text = "Modified at:";
            // 
            // CreateLabel
            // 
            CreateLabel.AutoSize = true;
            CreateLabel.Location = new Point(58, 51);
            CreateLabel.Name = "CreateLabel";
            CreateLabel.Size = new Size(97, 25);
            CreateLabel.TabIndex = 8;
            CreateLabel.Text = "Created at:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 538);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 4;
            label5.Text = "Move to:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 485);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 5;
            label6.Text = "Rename to:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 538);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 482);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(493, 31);
            textBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(749, 538);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 8;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(881, 538);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 9;
            button4.Text = "Copy";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(749, 480);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 10;
            button5.Text = "Rename";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 615);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(OpenBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button OpenBtn;
        private GroupBox groupBox1;
        private Label CreateLabel;
        private CheckBox checkArchive;
        private CheckBox checkReadOnly;
        private CheckBox checkHidden;
        private CheckBox checkSystem;
        private GroupBox groupBox2;
        private Button button2;
        private Label Accesslabel;
        private Label ModifiedLabel;
        private CheckBox checkEncrypted;
        private CheckBox checkCompressed;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}