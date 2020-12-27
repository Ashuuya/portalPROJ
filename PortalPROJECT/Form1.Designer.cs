namespace PortalPROJECT
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
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPerTick = new System.Windows.Forms.Label();
            this.tbPerTick = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSpreading = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbPerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 501);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(117, 17);
            this.checkBox3.TabIndex = 43;
            this.checkBox3.Text = "Добавить снежок";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // infoButton
            // 
            this.infoButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.infoButton.Location = new System.Drawing.Point(15, 545);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(180, 23);
            this.infoButton.TabIndex = 42;
            this.infoButton.Text = "INFO";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Cursor = System.Windows.Forms.Cursors.Help;
            this.label6.Location = new System.Drawing.Point(989, 545);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 28);
            this.label6.TabIndex = 41;
            this.label6.Text = "*радиус телепорта \r\nуправляется колесиком мыши";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Настройка эмиттера";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Настройка портала";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(952, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Частиц за раз";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbPerTick
            // 
            this.lbPerTick.AutoSize = true;
            this.lbPerTick.Location = new System.Drawing.Point(1047, 88);
            this.lbPerTick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPerTick.Name = "lbPerTick";
            this.lbPerTick.Size = new System.Drawing.Size(19, 13);
            this.lbPerTick.TabIndex = 37;
            this.lbPerTick.Text = "10";
            this.lbPerTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPerTick.Click += new System.EventHandler(this.lbPerTick_Click);
            // 
            // tbPerTick
            // 
            this.tbPerTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbPerTick.Location = new System.Drawing.Point(955, 56);
            this.tbPerTick.Margin = new System.Windows.Forms.Padding(2);
            this.tbPerTick.Maximum = 300;
            this.tbPerTick.Minimum = 1;
            this.tbPerTick.Name = "tbPerTick";
            this.tbPerTick.Size = new System.Drawing.Size(188, 45);
            this.tbPerTick.TabIndex = 36;
            this.tbPerTick.Value = 10;
            this.tbPerTick.Scroll += new System.EventHandler(this.tbPerTick_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(961, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Разброс";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbSpreading
            // 
            this.lbSpreading.AutoSize = true;
            this.lbSpreading.Location = new System.Drawing.Point(1053, 172);
            this.lbSpreading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpreading.Name = "lbSpreading";
            this.lbSpreading.Size = new System.Drawing.Size(13, 13);
            this.lbSpreading.TabIndex = 34;
            this.lbSpreading.Text = "5";
            this.lbSpreading.Click += new System.EventHandler(this.lbSpreading_Click);
            // 
            // tbSpreading
            // 
            this.tbSpreading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSpreading.Location = new System.Drawing.Point(955, 139);
            this.tbSpreading.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpreading.Maximum = 360;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(188, 45);
            this.tbSpreading.TabIndex = 33;
            this.tbSpreading.Value = 5;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Скорость";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(90, 171);
            this.lbSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(13, 13);
            this.lbSpeed.TabIndex = 31;
            this.lbSpeed.Text = "5";
            this.lbSpeed.Click += new System.EventHandler(this.lbSpeed_Click);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbSpeed.Location = new System.Drawing.Point(7, 140);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpeed.Maximum = 20;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(188, 45);
            this.tbSpeed.TabIndex = 30;
            this.tbSpeed.Value = 5;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Направление";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(90, 88);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(13, 13);
            this.lblDirection.TabIndex = 28;
            this.lblDirection.Text = "0";
            this.lblDirection.Click += new System.EventHandler(this.lblDirection_Click);
            // 
            // tbDirection
            // 
            this.tbDirection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDirection.Location = new System.Drawing.Point(9, 56);
            this.tbDirection.Margin = new System.Windows.Forms.Padding(2);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(186, 45);
            this.tbDirection.TabIndex = 27;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // picDisplay
            // 
            this.picDisplay.BackColor = System.Drawing.SystemColors.Desktop;
            this.picDisplay.Location = new System.Drawing.Point(203, -1);
            this.picDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(736, 582);
            this.picDisplay.TabIndex = 26;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1161, 580);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPerTick);
            this.Controls.Add(this.tbPerTick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSpreading);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbPerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPerTick;
        private System.Windows.Forms.TrackBar tbPerTick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSpreading;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
    }
}

