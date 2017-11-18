namespace airport_reg
{
    partial class RegForm
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
            this.pbCurPicture = new System.Windows.Forms.PictureBox();
            this.lbFlightSchedule = new System.Windows.Forms.ListBox();
            this.tbTicketInfo = new System.Windows.Forms.TextBox();
            this.lbScheduleTitle = new System.Windows.Forms.Label();
            this.lbTicketInfoTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCurPicture
            // 
            this.pbCurPicture.Location = new System.Drawing.Point(12, 7);
            this.pbCurPicture.Name = "pbCurPicture";
            this.pbCurPicture.Size = new System.Drawing.Size(895, 515);
            this.pbCurPicture.TabIndex = 0;
            this.pbCurPicture.TabStop = false;
            // 
            // lbFlightSchedule
            // 
            this.lbFlightSchedule.FormattingEnabled = true;
            this.lbFlightSchedule.Location = new System.Drawing.Point(913, 33);
            this.lbFlightSchedule.Name = "lbFlightSchedule";
            this.lbFlightSchedule.Size = new System.Drawing.Size(217, 225);
            this.lbFlightSchedule.TabIndex = 1;
            // 
            // tbTicketInfo
            // 
            this.tbTicketInfo.Location = new System.Drawing.Point(913, 376);
            this.tbTicketInfo.Multiline = true;
            this.tbTicketInfo.Name = "tbTicketInfo";
            this.tbTicketInfo.Size = new System.Drawing.Size(217, 146);
            this.tbTicketInfo.TabIndex = 2;
            // 
            // lbScheduleTitle
            // 
            this.lbScheduleTitle.AutoSize = true;
            this.lbScheduleTitle.Location = new System.Drawing.Point(910, 9);
            this.lbScheduleTitle.Name = "lbScheduleTitle";
            this.lbScheduleTitle.Size = new System.Drawing.Size(43, 13);
            this.lbScheduleTitle.TabIndex = 3;
            this.lbScheduleTitle.Text = "Рейсы:";
            // 
            // lbTicketInfoTitle
            // 
            this.lbTicketInfoTitle.AutoSize = true;
            this.lbTicketInfoTitle.Location = new System.Drawing.Point(910, 360);
            this.lbTicketInfoTitle.Name = "lbTicketInfoTitle";
            this.lbTicketInfoTitle.Size = new System.Drawing.Size(120, 13);
            this.lbTicketInfoTitle.TabIndex = 4;
            this.lbTicketInfoTitle.Text = "Информация о билете";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 535);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1118, 103);
            this.textBox1.TabIndex = 5;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 646);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTicketInfoTitle);
            this.Controls.Add(this.lbScheduleTitle);
            this.Controls.Add(this.tbTicketInfo);
            this.Controls.Add(this.lbFlightSchedule);
            this.Controls.Add(this.pbCurPicture);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCurPicture;
        private System.Windows.Forms.ListBox lbFlightSchedule;
        private System.Windows.Forms.TextBox tbTicketInfo;
        private System.Windows.Forms.Label lbScheduleTitle;
        private System.Windows.Forms.Label lbTicketInfoTitle;
        private System.Windows.Forms.TextBox textBox1;
    }
}

