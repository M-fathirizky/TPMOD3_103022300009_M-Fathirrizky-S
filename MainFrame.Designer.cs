namespace TP_Modul_03
{
    partial class MainFrame
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.clickBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(16, 37);
            this.InputText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(320, 22);
            this.InputText.TabIndex = 0;
            this.InputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clickBtn
            // 
            this.clickBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clickBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickBtn.Location = new System.Drawing.Point(345, 18);
            this.clickBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(204, 165);
            this.clickBtn.TabIndex = 2;
            this.clickBtn.Text = "Submit";
            this.clickBtn.UseVisualStyleBackColor = false;
            this.clickBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickBtn_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // OutputText
            // 
            this.OutputText.AutoSize = true;
            this.OutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OutputText.Location = new System.Drawing.Point(16, 112);
            this.OutputText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputText.MaximumSize = new System.Drawing.Size(321, 52);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(51, 24);
            this.OutputText.TabIndex = 5;
            this.OutputText.Text = "Text";
            this.OutputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(563, 188);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clickBtn);
            this.Controls.Add(this.InputText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(581, 235);
            this.MinimumSize = new System.Drawing.Size(581, 235);
            this.Name = "MainFrame";
            this.Text = "TP Modul 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button clickBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutputText;
    }
}