namespace WindowsFormsApp9
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.butticket = new System.Windows.Forms.Button();
            this.findticket = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxTicketCode = new System.Windows.Forms.TextBox();
            this.dateTimePickerEventDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTicketPrice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // butticket
            // 
            this.butticket.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.butticket.Location = new System.Drawing.Point(234, 283);
            this.butticket.Name = "butticket";
            this.butticket.Size = new System.Drawing.Size(75, 29);
            this.butticket.TabIndex = 0;
            this.butticket.Text = "Купить";
            this.butticket.UseVisualStyleBackColor = true;
            this.butticket.Click += new System.EventHandler(this.butticket_Click);
            // 
            // findticket
            // 
            this.findticket.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.findticket.Location = new System.Drawing.Point(223, 407);
            this.findticket.Name = "findticket";
            this.findticket.Size = new System.Drawing.Size(105, 29);
            this.findticket.TabIndex = 1;
            this.findticket.Text = "Проверить:";
            this.findticket.UseVisualStyleBackColor = true;
            this.findticket.Click += new System.EventHandler(this.findticket_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.textBoxFirstName.Location = new System.Drawing.Point(223, 54);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 27);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.textBoxLastName.Location = new System.Drawing.Point(223, 102);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 27);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxTicketCode
            // 
            this.textBoxTicketCode.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.textBoxTicketCode.Location = new System.Drawing.Point(259, 362);
            this.textBoxTicketCode.Name = "textBoxTicketCode";
            this.textBoxTicketCode.Size = new System.Drawing.Size(100, 27);
            this.textBoxTicketCode.TabIndex = 4;
            // 
            // dateTimePickerEventDate
            // 
            this.dateTimePickerEventDate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.dateTimePickerEventDate.Location = new System.Drawing.Point(223, 143);
            this.dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            this.dateTimePickerEventDate.Size = new System.Drawing.Size(100, 27);
            this.dateTimePickerEventDate.TabIndex = 5;
            // 
            // comboBoxTicketPrice
            // 
            this.comboBoxTicketPrice.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.comboBoxTicketPrice.FormattingEnabled = true;
            this.comboBoxTicketPrice.Location = new System.Drawing.Point(173, 194);
            this.comboBoxTicketPrice.Name = "comboBoxTicketPrice";
            this.comboBoxTicketPrice.Size = new System.Drawing.Size(100, 27);
            this.comboBoxTicketPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.label2.Location = new System.Drawing.Point(127, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.label3.Location = new System.Drawing.Point(144, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.label4.Location = new System.Drawing.Point(136, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "От:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.label5.Location = new System.Drawing.Point(136, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер билета:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.label6.Location = new System.Drawing.Point(280, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "До:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(320, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 27);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 239);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 27);
            this.comboBox2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.label7.Location = new System.Drawing.Point(139, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Тип билета:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Покупка билета";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(183, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Проверка билета:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(564, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTicketPrice);
            this.Controls.Add(this.dateTimePickerEventDate);
            this.Controls.Add(this.textBoxTicketCode);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.findticket);
            this.Controls.Add(this.butticket);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butticket;
        private System.Windows.Forms.Button findticket;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxTicketCode;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventDate;
        private System.Windows.Forms.ComboBox comboBoxTicketPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}