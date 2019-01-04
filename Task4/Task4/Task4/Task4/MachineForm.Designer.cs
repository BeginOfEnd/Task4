namespace Task4
{
    partial class MachineForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddMachineButton = new System.Windows.Forms.Button();
            this.AddLoaderButton = new System.Windows.Forms.Button();
            this.GiveAwayDetailBox = new System.Windows.Forms.Button();
            this.TakeDetailBox = new System.Windows.Forms.Button();
            this.LoaderBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XBox = new System.Windows.Forms.TextBox();
            this.YBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DetailLoaderButton = new System.Windows.Forms.Button();
            this.AddMillerButton = new System.Windows.Forms.Button();
            this.AddDetailButton = new System.Windows.Forms.Button();
            this.DetailBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddMachineButton
            // 
            this.AddMachineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMachineButton.Location = new System.Drawing.Point(812, 462);
            this.AddMachineButton.Name = "AddMachineButton";
            this.AddMachineButton.Size = new System.Drawing.Size(115, 44);
            this.AddMachineButton.TabIndex = 0;
            this.AddMachineButton.Text = "Добавить станок";
            this.AddMachineButton.UseVisualStyleBackColor = true;
            this.AddMachineButton.Click += new System.EventHandler(this.AddMachineButton_Click);
            // 
            // AddLoaderButton
            // 
            this.AddLoaderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLoaderButton.Location = new System.Drawing.Point(812, 512);
            this.AddLoaderButton.Name = "AddLoaderButton";
            this.AddLoaderButton.Size = new System.Drawing.Size(94, 44);
            this.AddLoaderButton.TabIndex = 1;
            this.AddLoaderButton.Text = "Добавить погрузчика";
            this.AddLoaderButton.UseVisualStyleBackColor = true;
            this.AddLoaderButton.Click += new System.EventHandler(this.AddLoaderButton_Click);
            // 
            // GiveAwayDetailBox
            // 
            this.GiveAwayDetailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GiveAwayDetailBox.Location = new System.Drawing.Point(164, 438);
            this.GiveAwayDetailBox.Name = "GiveAwayDetailBox";
            this.GiveAwayDetailBox.Size = new System.Drawing.Size(100, 44);
            this.GiveAwayDetailBox.TabIndex = 2;
            this.GiveAwayDetailBox.Text = "Отдать деталь фрезеровщику";
            this.GiveAwayDetailBox.UseVisualStyleBackColor = true;
            this.GiveAwayDetailBox.Click += new System.EventHandler(this.GiveAwayDetailBox_Click);
            // 
            // TakeDetailBox
            // 
            this.TakeDetailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TakeDetailBox.Location = new System.Drawing.Point(16, 438);
            this.TakeDetailBox.Name = "TakeDetailBox";
            this.TakeDetailBox.Size = new System.Drawing.Size(98, 44);
            this.TakeDetailBox.TabIndex = 3;
            this.TakeDetailBox.Text = "Взять деталь у фрезеровщика";
            this.TakeDetailBox.UseVisualStyleBackColor = true;
            this.TakeDetailBox.Click += new System.EventHandler(this.TakeDetailBox_Click);
            // 
            // LoaderBox
            // 
            this.LoaderBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoaderBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoaderBox.Location = new System.Drawing.Point(13, 507);
            this.LoaderBox.Name = "LoaderBox";
            this.LoaderBox.Size = new System.Drawing.Size(100, 20);
            this.LoaderBox.TabIndex = 4;
            this.LoaderBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер погрузчика";
            // 
            // XBox
            // 
            this.XBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XBox.Location = new System.Drawing.Point(317, 506);
            this.XBox.Name = "XBox";
            this.XBox.Size = new System.Drawing.Size(100, 20);
            this.XBox.TabIndex = 8;
            // 
            // YBox
            // 
            this.YBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YBox.Location = new System.Drawing.Point(481, 507);
            this.YBox.Name = "YBox";
            this.YBox.Size = new System.Drawing.Size(100, 20);
            this.YBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Y";
            // 
            // WidthBox
            // 
            this.WidthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WidthBox.Location = new System.Drawing.Point(317, 451);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 20);
            this.WidthBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Width";
            // 
            // HeightBox
            // 
            this.HeightBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightBox.Location = new System.Drawing.Point(484, 451);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(100, 20);
            this.HeightBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Height";
            // 
            // DetailLoaderButton
            // 
            this.DetailLoaderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailLoaderButton.Location = new System.Drawing.Point(654, 498);
            this.DetailLoaderButton.Name = "DetailLoaderButton";
            this.DetailLoaderButton.Size = new System.Drawing.Size(115, 49);
            this.DetailLoaderButton.TabIndex = 16;
            this.DetailLoaderButton.Text = "Погрузчик получает деталь";
            this.DetailLoaderButton.UseVisualStyleBackColor = true;
            this.DetailLoaderButton.Click += new System.EventHandler(this.DetailLoaderButton_Click);
            // 
            // AddMillerButton
            // 
            this.AddMillerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMillerButton.Location = new System.Drawing.Point(821, 408);
            this.AddMillerButton.Name = "AddMillerButton";
            this.AddMillerButton.Size = new System.Drawing.Size(94, 44);
            this.AddMillerButton.TabIndex = 17;
            this.AddMillerButton.Text = "Добавить фрезеровщика";
            this.AddMillerButton.UseVisualStyleBackColor = true;
            this.AddMillerButton.Click += new System.EventHandler(this.AddMillerButton_Click);
            // 
            // AddDetailButton
            // 
            this.AddDetailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDetailButton.Location = new System.Drawing.Point(812, 367);
            this.AddDetailButton.Name = "AddDetailButton";
            this.AddDetailButton.Size = new System.Drawing.Size(115, 35);
            this.AddDetailButton.TabIndex = 18;
            this.AddDetailButton.Text = "Добавить деталь";
            this.AddDetailButton.UseVisualStyleBackColor = true;
            this.AddDetailButton.Click += new System.EventHandler(this.AddDetailButton_Click);
            // 
            // DetailBox
            // 
            this.DetailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailBox.Location = new System.Drawing.Point(654, 431);
            this.DetailBox.Name = "DetailBox";
            this.DetailBox.Size = new System.Drawing.Size(100, 20);
            this.DetailBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Номер детали";
            // 
            // MachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(939, 559);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DetailBox);
            this.Controls.Add(this.AddDetailButton);
            this.Controls.Add(this.AddMillerButton);
            this.Controls.Add(this.DetailLoaderButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YBox);
            this.Controls.Add(this.XBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoaderBox);
            this.Controls.Add(this.TakeDetailBox);
            this.Controls.Add(this.GiveAwayDetailBox);
            this.Controls.Add(this.AddLoaderButton);
            this.Controls.Add(this.AddMachineButton);
            this.Name = "MachineForm";
            this.Text = "MachineForm";
            this.Load += new System.EventHandler(this.MachineForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MachineForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMachineButton;
        private System.Windows.Forms.Button AddLoaderButton;
        private System.Windows.Forms.Button GiveAwayDetailBox;
        private System.Windows.Forms.Button TakeDetailBox;
        private System.Windows.Forms.TextBox LoaderBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XBox;
        private System.Windows.Forms.TextBox YBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DetailLoaderButton;
        private System.Windows.Forms.Button AddMillerButton;
        private System.Windows.Forms.Button AddDetailButton;
        private System.Windows.Forms.TextBox DetailBox;
        private System.Windows.Forms.Label label7;
    }
}

