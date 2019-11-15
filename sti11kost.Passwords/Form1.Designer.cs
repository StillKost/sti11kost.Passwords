namespace sti11kost.Passwords
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
            this.label1 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.TextBox();
            this.sizeError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.includeStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPasswords = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.difirentRegister = new System.Windows.Forms.CheckBox();
            this.useNums = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина пароля:";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(127, 38);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(70, 20);
            this.size.TabIndex = 1;
            // 
            // sizeError
            // 
            this.sizeError.AutoSize = true;
            this.sizeError.ForeColor = System.Drawing.Color.Red;
            this.sizeError.Location = new System.Drawing.Point(127, 61);
            this.sizeError.Name = "sizeError";
            this.sizeError.Size = new System.Drawing.Size(10, 13);
            this.sizeError.TabIndex = 2;
            this.sizeError.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Включить\r\nподстроку:";
            // 
            // includeStr
            // 
            this.includeStr.Location = new System.Drawing.Point(127, 91);
            this.includeStr.Name = "includeStr";
            this.includeStr.Size = new System.Drawing.Size(342, 20);
            this.includeStr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Варианты\r\nпаролей:";
            // 
            // totalPasswords
            // 
            this.totalPasswords.Location = new System.Drawing.Point(127, 150);
            this.totalPasswords.Multiline = true;
            this.totalPasswords.Name = "totalPasswords";
            this.totalPasswords.ReadOnly = true;
            this.totalPasswords.Size = new System.Drawing.Size(342, 118);
            this.totalPasswords.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сгенерировать пароли";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // difirentRegister
            // 
            this.difirentRegister.AutoSize = true;
            this.difirentRegister.Location = new System.Drawing.Point(127, 284);
            this.difirentRegister.Name = "difirentRegister";
            this.difirentRegister.Size = new System.Drawing.Size(247, 17);
            this.difirentRegister.TabIndex = 8;
            this.difirentRegister.Text = "Использовать символы в разном регистре";
            this.difirentRegister.UseVisualStyleBackColor = true;
            // 
            // useNums
            // 
            this.useNums.AutoSize = true;
            this.useNums.Location = new System.Drawing.Point(127, 308);
            this.useNums.Name = "useNums";
            this.useNums.Size = new System.Drawing.Size(136, 17);
            this.useNums.TabIndex = 9;
            this.useNums.Text = "Использовать цифры";
            this.useNums.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 409);
            this.Controls.Add(this.useNums);
            this.Controls.Add(this.difirentRegister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalPasswords);
            this.Controls.Add(this.includeStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeError);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "sti11kost.Passwords: Генератор паролей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label sizeError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox includeStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalPasswords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox difirentRegister;
        private System.Windows.Forms.CheckBox useNums;
    }
}

