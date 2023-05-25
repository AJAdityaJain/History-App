namespace History
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.Main_Image = new System.Windows.Forms.PictureBox();
            this.Main_Date = new System.Windows.Forms.Label();
            this.Main_Desc = new System.Windows.Forms.RichTextBox();
            this.Main_Name = new System.Windows.Forms.Label();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.People = new System.Windows.Forms.TabPage();
            this.People_eb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.People_Image = new System.Windows.Forms.TextBox();
            this.People_ImageB = new System.Windows.Forms.PictureBox();
            this.People_Remove = new System.Windows.Forms.Button();
            this.People_Add = new System.Windows.Forms.Button();
            this.People_People = new System.Windows.Forms.ListBox();
            this.People_Info = new System.Windows.Forms.RichTextBox();
            this.People_Name = new System.Windows.Forms.TextBox();
            this.People_End = new System.Windows.Forms.DateTimePicker();
            this.People_Start = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Image)).BeginInit();
            this.People.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.People_ImageB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.People);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1488, 734);
            this.tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Main.Controls.Add(this.Main_Image);
            this.Main.Controls.Add(this.Main_Date);
            this.Main.Controls.Add(this.Main_Desc);
            this.Main.Controls.Add(this.Main_Name);
            this.Main.Controls.Add(this.Main_Panel);
            this.Main.Location = new System.Drawing.Point(31, 4);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(1453, 726);
            this.Main.TabIndex = 3;
            this.Main.Text = "Main";
            this.Main.Enter += new System.EventHandler(this.RefMain_Click);
            // 
            // Main_Image
            // 
            this.Main_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Main_Image.Location = new System.Drawing.Point(867, 342);
            this.Main_Image.Name = "Main_Image";
            this.Main_Image.Size = new System.Drawing.Size(590, 378);
            this.Main_Image.TabIndex = 4;
            this.Main_Image.TabStop = false;
            // 
            // Main_Date
            // 
            this.Main_Date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Main_Date.AutoSize = true;
            this.Main_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Date.Location = new System.Drawing.Point(23, 390);
            this.Main_Date.Name = "Main_Date";
            this.Main_Date.Size = new System.Drawing.Size(92, 32);
            this.Main_Date.TabIndex = 3;
            this.Main_Date.Text = "-Date-";
            // 
            // Main_Desc
            // 
            this.Main_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Main_Desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Main_Desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main_Desc.Location = new System.Drawing.Point(29, 425);
            this.Main_Desc.Name = "Main_Desc";
            this.Main_Desc.ReadOnly = true;
            this.Main_Desc.Size = new System.Drawing.Size(817, 295);
            this.Main_Desc.TabIndex = 2;
            this.Main_Desc.Text = "";
            this.Main_Desc.Visible = false;
            // 
            // Main_Name
            // 
            this.Main_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Main_Name.AutoSize = true;
            this.Main_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Name.Location = new System.Drawing.Point(23, 358);
            this.Main_Name.Name = "Main_Name";
            this.Main_Name.Size = new System.Drawing.Size(107, 32);
            this.Main_Name.TabIndex = 1;
            this.Main_Name.Text = "-Name-";
            // 
            // Main_Panel
            // 
            this.Main_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Panel.AutoScroll = true;
            this.Main_Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.Main_Panel.Location = new System.Drawing.Point(6, 6);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1436, 330);
            this.Main_Panel.TabIndex = 0;
            // 
            // People
            // 
            this.People.BackColor = System.Drawing.Color.White;
            this.People.Controls.Add(this.People_eb);
            this.People.Controls.Add(this.label5);
            this.People.Controls.Add(this.label4);
            this.People.Controls.Add(this.label3);
            this.People.Controls.Add(this.label2);
            this.People.Controls.Add(this.label1);
            this.People.Controls.Add(this.People_Image);
            this.People.Controls.Add(this.People_ImageB);
            this.People.Controls.Add(this.People_Remove);
            this.People.Controls.Add(this.People_Add);
            this.People.Controls.Add(this.People_People);
            this.People.Controls.Add(this.People_Info);
            this.People.Controls.Add(this.People_Name);
            this.People.Controls.Add(this.People_End);
            this.People.Controls.Add(this.People_Start);
            this.People.Location = new System.Drawing.Point(31, 4);
            this.People.Name = "People";
            this.People.Padding = new System.Windows.Forms.Padding(3);
            this.People.Size = new System.Drawing.Size(1453, 726);
            this.People.TabIndex = 2;
            this.People.Text = "Events";
            // 
            // People_eb
            // 
            this.People_eb.AutoSize = true;
            this.People_eb.Checked = true;
            this.People_eb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.People_eb.Location = new System.Drawing.Point(12, 86);
            this.People_eb.Name = "People_eb";
            this.People_eb.Size = new System.Drawing.Size(18, 17);
            this.People_eb.TabIndex = 14;
            this.People_eb.UseVisualStyleBackColor = true;
            this.People_eb.CheckedChanged += new System.EventHandler(this.People_Edit_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(32, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 50);
            this.label5.TabIndex = 13;
            this.label5.Text = "Image File\r\n(Optional)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ended On";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Started On";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // People_Image
            // 
            this.People_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.People_Image.BackColor = System.Drawing.Color.WhiteSmoke;
            this.People_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.People_Image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_Image.Location = new System.Drawing.Point(142, 495);
            this.People_Image.Name = "People_Image";
            this.People_Image.Size = new System.Drawing.Size(289, 30);
            this.People_Image.TabIndex = 8;
            this.People_Image.Leave += new System.EventHandler(this.People_Edit_Click);
            // 
            // People_ImageB
            // 
            this.People_ImageB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.People_ImageB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.People_ImageB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.People_ImageB.Location = new System.Drawing.Point(1097, 81);
            this.People_ImageB.Name = "People_ImageB";
            this.People_ImageB.Size = new System.Drawing.Size(350, 350);
            this.People_ImageB.TabIndex = 7;
            this.People_ImageB.TabStop = false;
            // 
            // People_Remove
            // 
            this.People_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.People_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_Remove.Location = new System.Drawing.Point(437, 538);
            this.People_Remove.Name = "People_Remove";
            this.People_Remove.Size = new System.Drawing.Size(64, 60);
            this.People_Remove.TabIndex = 0;
            this.People_Remove.Text = "-";
            this.People_Remove.UseVisualStyleBackColor = true;
            this.People_Remove.Click += new System.EventHandler(this.People_Remove_Click);
            // 
            // People_Add
            // 
            this.People_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.People_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_Add.Location = new System.Drawing.Point(348, 538);
            this.People_Add.Name = "People_Add";
            this.People_Add.Size = new System.Drawing.Size(64, 60);
            this.People_Add.TabIndex = 5;
            this.People_Add.Text = "+";
            this.People_Add.UseVisualStyleBackColor = true;
            this.People_Add.Click += new System.EventHandler(this.People_Add_Click);
            // 
            // People_People
            // 
            this.People_People.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.People_People.BackColor = System.Drawing.Color.WhiteSmoke;
            this.People_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_People.FormattingEnabled = true;
            this.People_People.ItemHeight = 20;
            this.People_People.Location = new System.Drawing.Point(437, 6);
            this.People_People.Name = "People_People";
            this.People_People.Size = new System.Drawing.Size(654, 504);
            this.People_People.TabIndex = 4;
            this.People_People.SelectedIndexChanged += new System.EventHandler(this.People_People_SelectedIndexChanged);
            // 
            // People_Info
            // 
            this.People_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.People_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_Info.Location = new System.Drawing.Point(142, 116);
            this.People_Info.Name = "People_Info";
            this.People_Info.Size = new System.Drawing.Size(289, 373);
            this.People_Info.TabIndex = 3;
            this.People_Info.Text = "";
            this.People_Info.Leave += new System.EventHandler(this.People_Edit_Click);
            // 
            // People_Name
            // 
            this.People_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.People_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.People_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_Name.Location = new System.Drawing.Point(142, 5);
            this.People_Name.Name = "People_Name";
            this.People_Name.Size = new System.Drawing.Size(289, 34);
            this.People_Name.TabIndex = 2;
            this.People_Name.Leave += new System.EventHandler(this.People_Edit_Click);
            // 
            // People_End
            // 
            this.People_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.People_End.Location = new System.Drawing.Point(142, 81);
            this.People_End.Name = "People_End";
            this.People_End.Size = new System.Drawing.Size(200, 30);
            this.People_End.TabIndex = 1;
            this.People_End.Leave += new System.EventHandler(this.People_Edit_Click);
            // 
            // People_Start
            // 
            this.People_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.People_Start.Location = new System.Drawing.Point(142, 45);
            this.People_Start.Name = "People_Start";
            this.People_Start.Size = new System.Drawing.Size(200, 30);
            this.People_Start.TabIndex = 0;
            this.People_Start.Value = new System.DateTime(2022, 7, 8, 20, 20, 49, 0);
            this.People_Start.Leave += new System.EventHandler(this.People_Edit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "hn";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "History Files|*.hn";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.Title = "Name";
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Location = new System.Drawing.Point(43, 3);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 38);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(124, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 38);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "hn";
            this.saveFileDialog1.FileName = "MyTimeline";
            this.saveFileDialog1.Filter = "History Files|*.hn";
            this.saveFileDialog1.InitialDirectory = "C:\\";
            this.saveFileDialog1.Title = "Save your notes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1512, 793);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "History - AJ";
            this.tabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Image)).EndInit();
            this.People.ResumeLayout(false);
            this.People.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.People_ImageB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage People;
        private System.Windows.Forms.Button People_Remove;
        private System.Windows.Forms.Button People_Add;
        private System.Windows.Forms.ListBox People_People;
        private System.Windows.Forms.RichTextBox People_Info;
        private System.Windows.Forms.TextBox People_Name;
        private System.Windows.Forms.DateTimePicker People_End;
        private System.Windows.Forms.DateTimePicker People_Start;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.PictureBox People_ImageB;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.RichTextBox Main_Desc;
        private System.Windows.Forms.Label Main_Name;
        private System.Windows.Forms.Label Main_Date;
        private System.Windows.Forms.TextBox People_Image;
        private System.Windows.Forms.PictureBox Main_Image;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox People_eb;
    }
}

