
namespace Clock
{
    partial class MainForm
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
            this.panelOfPravka = new System.Windows.Forms.Panel();
            this.butOfPravka = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelOfPravka.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOfPravka
            // 
            this.panelOfPravka.BackColor = System.Drawing.SystemColors.GrayText;
            this.panelOfPravka.Controls.Add(this.butPlus);
            this.panelOfPravka.Controls.Add(this.butOfPravka);
            this.panelOfPravka.Location = new System.Drawing.Point(13, 13);
            this.panelOfPravka.Name = "panelOfPravka";
            this.panelOfPravka.Size = new System.Drawing.Size(775, 70);
            this.panelOfPravka.TabIndex = 0;
            // 
            // butOfPravka
            // 
            this.butOfPravka.Location = new System.Drawing.Point(18, 14);
            this.butOfPravka.Name = "butOfPravka";
            this.butOfPravka.Size = new System.Drawing.Size(182, 42);
            this.butOfPravka.TabIndex = 0;
            this.butOfPravka.Text = "Править";
            this.butOfPravka.UseVisualStyleBackColor = true;
            // 
            // butPlus
            // 
            this.butPlus.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPlus.Location = new System.Drawing.Point(686, 17);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(59, 39);
            this.butPlus.TabIndex = 1;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = true;
            this.butPlus.Click += new System.EventHandler(this.butPlus_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 96);
            this.panel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOfPravka);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelOfPravka.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOfPravka;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button butOfPravka;
        private System.Windows.Forms.Panel panel1;
    }
}