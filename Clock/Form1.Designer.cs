
namespace Clock
{
    partial class ClockForm
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
            this.butCancel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butRepeatOfSignal = new System.Windows.Forms.Button();
            this.butName = new System.Windows.Forms.Button();
            this.butRepeat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(47, 27);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(88, 33);
            this.butCancel.TabIndex = 0;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(346, 27);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(94, 33);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.butRepeatOfSignal);
            this.panel1.Controls.Add(this.butName);
            this.panel1.Controls.Add(this.butRepeat);
            this.panel1.Location = new System.Drawing.Point(100, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 247);
            this.panel1.TabIndex = 2;
            // 
            // butRepeatOfSignal
            // 
            this.butRepeatOfSignal.Location = new System.Drawing.Point(58, 164);
            this.butRepeatOfSignal.Name = "butRepeatOfSignal";
            this.butRepeatOfSignal.Size = new System.Drawing.Size(166, 32);
            this.butRepeatOfSignal.TabIndex = 2;
            this.butRepeatOfSignal.Text = "Повторение сигнала";
            this.butRepeatOfSignal.UseVisualStyleBackColor = true;
            // 
            // butName
            // 
            this.butName.Location = new System.Drawing.Point(58, 103);
            this.butName.Name = "butName";
            this.butName.Size = new System.Drawing.Size(166, 37);
            this.butName.TabIndex = 1;
            this.butName.Text = "ЗАВЕСТИ";
            this.butName.UseVisualStyleBackColor = true;
            // 
            // butRepeat
            // 
            this.butRepeat.Location = new System.Drawing.Point(58, 45);
            this.butRepeat.Name = "butRepeat";
            this.butRepeat.Size = new System.Drawing.Size(166, 34);
            this.butRepeat.TabIndex = 0;
            this.butRepeat.Text = "Повтор";
            this.butRepeat.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(186, 172);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(117, 56);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 593);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butCancel);
            this.Name = "ClockForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butRepeatOfSignal;
        private System.Windows.Forms.Button butName;
        private System.Windows.Forms.Button butRepeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.Timer timer1;
    }
}

