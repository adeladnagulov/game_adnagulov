﻿namespace игра
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new System.Windows.Forms.PictureBox();
            this.backGround2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backGround1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(77, 375);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(90, 62);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // backGround2
            // 
            this.backGround2.Image = ((System.Drawing.Image)(resources.GetObject("backGround2.Image")));
            this.backGround2.Location = new System.Drawing.Point(512, 0);
            this.backGround2.Name = "backGround2";
            this.backGround2.Size = new System.Drawing.Size(512, 512);
            this.backGround2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backGround2.TabIndex = 3;
            this.backGround2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backGround1
            // 
            this.backGround1.Image = ((System.Drawing.Image)(resources.GetObject("backGround1.Image")));
            this.backGround1.Location = new System.Drawing.Point(0, 0);
            this.backGround1.Name = "backGround1";
            this.backGround1.Size = new System.Drawing.Size(512, 512);
            this.backGround1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backGround1.TabIndex = 4;
            this.backGround1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.player);
            this.Controls.Add(this.backGround2);
            this.Controls.Add(this.backGround1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGround1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox backGround2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox backGround1;
    }
}

