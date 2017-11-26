﻿namespace airport_reg
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
            this.components = new System.ComponentModel.Container();
            this.pbCurPicture = new System.Windows.Forms.PictureBox();
            this.tbTicketInfo = new System.Windows.Forms.TextBox();
            this.lbScheduleTitle = new System.Windows.Forms.Label();
            this.lbTicketInfoTitle = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.dgSchedule = new System.Windows.Forms.DataGridView();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCurPicture
            // 
            this.pbCurPicture.Location = new System.Drawing.Point(12, 7);
            this.pbCurPicture.Name = "pbCurPicture";
            this.pbCurPicture.Size = new System.Drawing.Size(774, 588);
            this.pbCurPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCurPicture.TabIndex = 0;
            this.pbCurPicture.TabStop = false;
            // 
            // tbTicketInfo
            // 
            this.tbTicketInfo.Location = new System.Drawing.Point(425, 614);
            this.tbTicketInfo.Multiline = true;
            this.tbTicketInfo.Name = "tbTicketInfo";
            this.tbTicketInfo.Size = new System.Drawing.Size(361, 146);
            this.tbTicketInfo.TabIndex = 2;
            // 
            // lbScheduleTitle
            // 
            this.lbScheduleTitle.AutoSize = true;
            this.lbScheduleTitle.Location = new System.Drawing.Point(9, 598);
            this.lbScheduleTitle.Name = "lbScheduleTitle";
            this.lbScheduleTitle.Size = new System.Drawing.Size(43, 13);
            this.lbScheduleTitle.TabIndex = 3;
            this.lbScheduleTitle.Text = "Рейсы:";
            // 
            // lbTicketInfoTitle
            // 
            this.lbTicketInfoTitle.AutoSize = true;
            this.lbTicketInfoTitle.Location = new System.Drawing.Point(422, 598);
            this.lbTicketInfoTitle.Name = "lbTicketInfoTitle";
            this.lbTicketInfoTitle.Size = new System.Drawing.Size(120, 13);
            this.lbTicketInfoTitle.TabIndex = 4;
            this.lbTicketInfoTitle.Text = "Информация о билете";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(792, 7);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(308, 753);
            this.tbLog.TabIndex = 5;
            // 
            // dgSchedule
            // 
            this.dgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchedule.Location = new System.Drawing.Point(12, 614);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.ReadOnly = true;
            this.dgSchedule.Size = new System.Drawing.Size(407, 146);
            this.dgSchedule.TabIndex = 6;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(airport_reg.Schedule);
            // 
            // schTimer
            // 
            this.schTimer.Interval = 2000;
            this.schTimer.Tick += new System.EventHandler(this.schTimer_Tick);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 772);
            this.Controls.Add(this.dgSchedule);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.lbTicketInfoTitle);
            this.Controls.Add(this.lbScheduleTitle);
            this.Controls.Add(this.tbTicketInfo);
            this.Controls.Add(this.pbCurPicture);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.pbCurPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCurPicture;
        private System.Windows.Forms.TextBox tbTicketInfo;
        private System.Windows.Forms.Label lbScheduleTitle;
        private System.Windows.Forms.Label lbTicketInfoTitle;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.DataGridView dgSchedule;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.Timer schTimer;
    }
}

