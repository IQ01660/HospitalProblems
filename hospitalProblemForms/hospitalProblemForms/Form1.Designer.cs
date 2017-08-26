namespace hospitalProblemForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sectorAddInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addSectorBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sectorRemoveBtn = new System.Windows.Forms.Button();
            this.sectorRemoveSelector = new System.Windows.Forms.ComboBox();
            this.addingDoctorSectorSelector1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addDoctorName = new System.Windows.Forms.TextBox();
            this.addDoctorBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addDoctorID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.removingDoctorSectorSelector = new System.Windows.Forms.ComboBox();
            this.removingDoctorSelector = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.removeDoctorBtn = new System.Windows.Forms.Button();
            this.eventuallyRemoveDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(110, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sectors";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(707, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Doctors";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(106, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adding Sector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(701, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adding Doctor";
            // 
            // sectorAddInput
            // 
            this.sectorAddInput.Location = new System.Drawing.Point(134, 130);
            this.sectorAddInput.Name = "sectorAddInput";
            this.sectorAddInput.Size = new System.Drawing.Size(115, 20);
            this.sectorAddInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sector Name";
            // 
            // addSectorBtn
            // 
            this.addSectorBtn.Location = new System.Drawing.Point(255, 130);
            this.addSectorBtn.Name = "addSectorBtn";
            this.addSectorBtn.Size = new System.Drawing.Size(90, 20);
            this.addSectorBtn.TabIndex = 6;
            this.addSectorBtn.Text = "Add";
            this.addSectorBtn.UseVisualStyleBackColor = true;
            this.addSectorBtn.Click += new System.EventHandler(this.addSectorBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(106, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Removing Sector";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sector Name";
            // 
            // sectorRemoveBtn
            // 
            this.sectorRemoveBtn.Location = new System.Drawing.Point(255, 233);
            this.sectorRemoveBtn.Name = "sectorRemoveBtn";
            this.sectorRemoveBtn.Size = new System.Drawing.Size(90, 20);
            this.sectorRemoveBtn.TabIndex = 10;
            this.sectorRemoveBtn.Text = "Remove";
            this.sectorRemoveBtn.UseVisualStyleBackColor = true;
            this.sectorRemoveBtn.Click += new System.EventHandler(this.sectorRemoveBtn_Click);
            // 
            // sectorRemoveSelector
            // 
            this.sectorRemoveSelector.FormattingEnabled = true;
            this.sectorRemoveSelector.Location = new System.Drawing.Point(134, 233);
            this.sectorRemoveSelector.Name = "sectorRemoveSelector";
            this.sectorRemoveSelector.Size = new System.Drawing.Size(115, 21);
            this.sectorRemoveSelector.TabIndex = 11;
            // 
            // addingDoctorSectorSelector1
            // 
            this.addingDoctorSectorSelector1.FormattingEnabled = true;
            this.addingDoctorSectorSelector1.Location = new System.Drawing.Point(730, 133);
            this.addingDoctorSectorSelector1.Name = "addingDoctorSectorSelector1";
            this.addingDoctorSectorSelector1.Size = new System.Drawing.Size(115, 21);
            this.addingDoctorSectorSelector1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sector Name";
            // 
            // addDoctorName
            // 
            this.addDoctorName.Location = new System.Drawing.Point(730, 193);
            this.addDoctorName.Name = "addDoctorName";
            this.addDoctorName.Size = new System.Drawing.Size(115, 20);
            this.addDoctorName.TabIndex = 14;
            // 
            // addDoctorBtn
            // 
            this.addDoctorBtn.Location = new System.Drawing.Point(755, 283);
            this.addDoctorBtn.Name = "addDoctorBtn";
            this.addDoctorBtn.Size = new System.Drawing.Size(90, 20);
            this.addDoctorBtn.TabIndex = 15;
            this.addDoctorBtn.Text = "Add";
            this.addDoctorBtn.UseVisualStyleBackColor = true;
            this.addDoctorBtn.Click += new System.EventHandler(this.addDoctorBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Doctor Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(642, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Doctor ID";
            // 
            // addDoctorID
            // 
            this.addDoctorID.Location = new System.Drawing.Point(730, 247);
            this.addDoctorID.Name = "addDoctorID";
            this.addDoctorID.Size = new System.Drawing.Size(115, 20);
            this.addDoctorID.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(675, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Removing Doctor";
            // 
            // removingDoctorSectorSelector
            // 
            this.removingDoctorSectorSelector.FormattingEnabled = true;
            this.removingDoctorSectorSelector.Location = new System.Drawing.Point(730, 366);
            this.removingDoctorSectorSelector.Name = "removingDoctorSectorSelector";
            this.removingDoctorSectorSelector.Size = new System.Drawing.Size(115, 21);
            this.removingDoctorSectorSelector.TabIndex = 20;
            // 
            // removingDoctorSelector
            // 
            this.removingDoctorSelector.FormattingEnabled = true;
            this.removingDoctorSelector.Location = new System.Drawing.Point(731, 414);
            this.removingDoctorSelector.Name = "removingDoctorSelector";
            this.removingDoctorSelector.Size = new System.Drawing.Size(115, 21);
            this.removingDoctorSelector.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(642, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Sector Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(642, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Doctor Name";
            // 
            // removeDoctorBtn
            // 
            this.removeDoctorBtn.Location = new System.Drawing.Point(851, 367);
            this.removeDoctorBtn.Name = "removeDoctorBtn";
            this.removeDoctorBtn.Size = new System.Drawing.Size(90, 20);
            this.removeDoctorBtn.TabIndex = 24;
            this.removeDoctorBtn.Text = "Select";
            this.removeDoctorBtn.UseVisualStyleBackColor = true;
            this.removeDoctorBtn.Click += new System.EventHandler(this.removeDoctorBtn_Click);
            // 
            // eventuallyRemoveDoctor
            // 
            this.eventuallyRemoveDoctor.Location = new System.Drawing.Point(851, 415);
            this.eventuallyRemoveDoctor.Name = "eventuallyRemoveDoctor";
            this.eventuallyRemoveDoctor.Size = new System.Drawing.Size(90, 20);
            this.eventuallyRemoveDoctor.TabIndex = 25;
            this.eventuallyRemoveDoctor.Text = "Remove";
            this.eventuallyRemoveDoctor.UseVisualStyleBackColor = true;
            this.eventuallyRemoveDoctor.Click += new System.EventHandler(this.eventuallyRemoveDoctor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 498);
            this.Controls.Add(this.eventuallyRemoveDoctor);
            this.Controls.Add(this.removeDoctorBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.removingDoctorSelector);
            this.Controls.Add(this.removingDoctorSectorSelector);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addDoctorID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addDoctorBtn);
            this.Controls.Add(this.addDoctorName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addingDoctorSectorSelector1);
            this.Controls.Add(this.sectorRemoveSelector);
            this.Controls.Add(this.sectorRemoveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addSectorBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sectorAddInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Hospital App by Ikram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sectorAddInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addSectorBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sectorRemoveBtn;
        private System.Windows.Forms.ComboBox sectorRemoveSelector;
        private System.Windows.Forms.ComboBox addingDoctorSectorSelector1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addDoctorName;
        private System.Windows.Forms.Button addDoctorBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addDoctorID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox removingDoctorSectorSelector;
        private System.Windows.Forms.ComboBox removingDoctorSelector;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button removeDoctorBtn;
        private System.Windows.Forms.Button eventuallyRemoveDoctor;
    }
}

