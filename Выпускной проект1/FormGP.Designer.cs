namespace Выпускной_проект1
{
    partial class FormGP
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
            this.tPass = new System.Windows.Forms.TextBox();
            this.btnCreatePass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudPassL = new System.Windows.Forms.NumericUpDown();
            this.clbPass = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassL)).BeginInit();
            this.SuspendLayout();
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(15, 218);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(334, 20);
            this.tPass.TabIndex = 11;
            // 
            // btnCreatePass
            // 
            this.btnCreatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreatePass.Location = new System.Drawing.Point(12, 165);
            this.btnCreatePass.Name = "btnCreatePass";
            this.btnCreatePass.Size = new System.Drawing.Size(331, 47);
            this.btnCreatePass.TabIndex = 10;
            this.btnCreatePass.Text = "Создать пароль";
            this.btnCreatePass.UseVisualStyleBackColor = true;
            this.btnCreatePass.Click += new System.EventHandler(this.btnCreatePass_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Длина пароля";
            // 
            // nudPassL
            // 
            this.nudPassL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudPassL.Location = new System.Drawing.Point(117, 116);
            this.nudPassL.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudPassL.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPassL.Name = "nudPassL";
            this.nudPassL.Size = new System.Drawing.Size(60, 22);
            this.nudPassL.TabIndex = 8;
            this.nudPassL.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // clbPass
            // 
            this.clbPass.CheckOnClick = true;
            this.clbPass.FormattingEnabled = true;
            this.clbPass.Items.AddRange(new object[] {
            "Цифры",
            "Строчные буквы",
            "Прописные буквы",
            "Специальные символы"});
            this.clbPass.Location = new System.Drawing.Point(15, 13);
            this.clbPass.Name = "clbPass";
            this.clbPass.Size = new System.Drawing.Size(320, 94);
            this.clbPass.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ВНИМАНИЕ! Длина пароля должна быть от 4 до 15 символов";
            this.label2.UseCompatibleTextRendering = true;
            this.label2.UseWaitCursor = true;
            // 
            // FormGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 250);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbPass);
            this.Controls.Add(this.tPass);
            this.Controls.Add(this.btnCreatePass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPassL);
            this.Name = "FormGP";
            this.Text = "Генератор паролей";
            ((System.ComponentModel.ISupportInitialize)(this.nudPassL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.Button btnCreatePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPassL;
        private System.Windows.Forms.CheckedListBox clbPass;
        private System.Windows.Forms.Label label2;
    }
}