namespace игра
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLevels = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кубические приключения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите уровень";
            // 
            // comboBoxLevels
            // 
            this.comboBoxLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevels.FormattingEnabled = true;
            this.comboBoxLevels.Items.AddRange(new object[] {
            "1 ",
            "Бесконечный"});
            this.comboBoxLevels.Location = new System.Drawing.Point(250, 157);
            this.comboBoxLevels.Name = "comboBoxLevels";
            this.comboBoxLevels.Size = new System.Drawing.Size(200, 24);
            this.comboBoxLevels.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Turquoise;
            this.StartButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(125, 257);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(250, 53);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.ClickStart);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Crimson;
            this.ExitButton.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(125, 402);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(250, 55);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ClickExit);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.comboBoxLevels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLevels;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
    }
}