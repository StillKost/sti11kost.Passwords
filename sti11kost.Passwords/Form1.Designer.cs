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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.sizeError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.includeStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPasswords = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.difirentRegister = new System.Windows.Forms.CheckBox();
            this.useNums = new System.Windows.Forms.CheckBox();
            this.includeStrWarning = new System.Windows.Forms.Label();
            this.useSpecDigits = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countErrorMsg = new System.Windows.Forms.Label();
            this.exportTxt = new System.Windows.Forms.Button();
            this.fileExtError = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dontUse = new System.Windows.Forms.TextBox();
            this.settings = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.passwordsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина пароля:";
            // 
            // sizeError
            // 
            this.sizeError.AutoSize = true;
            this.sizeError.ForeColor = System.Drawing.Color.Red;
            this.sizeError.Location = new System.Drawing.Point(203, 24);
            this.sizeError.Name = "sizeError";
            this.sizeError.Size = new System.Drawing.Size(10, 13);
            this.sizeError.TabIndex = 2;
            this.sizeError.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Включить\r\nподстроку:";
            // 
            // includeStr
            // 
            this.includeStr.Location = new System.Drawing.Point(127, 84);
            this.includeStr.Name = "includeStr";
            this.includeStr.Size = new System.Drawing.Size(168, 20);
            this.includeStr.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароли:";
            // 
            // totalPasswords
            // 
            this.totalPasswords.Location = new System.Drawing.Point(127, 154);
            this.totalPasswords.Multiline = true;
            this.totalPasswords.Name = "totalPasswords";
            this.totalPasswords.ReadOnly = true;
            this.totalPasswords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.totalPasswords.Size = new System.Drawing.Size(342, 118);
            this.totalPasswords.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сгенерировать пароль (и)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // difirentRegister
            // 
            this.difirentRegister.AutoSize = true;
            this.difirentRegister.Location = new System.Drawing.Point(127, 288);
            this.difirentRegister.Name = "difirentRegister";
            this.difirentRegister.Size = new System.Drawing.Size(247, 17);
            this.difirentRegister.TabIndex = 8;
            this.difirentRegister.Text = "Использовать символы в разном регистре";
            this.difirentRegister.UseVisualStyleBackColor = true;
            // 
            // useNums
            // 
            this.useNums.AutoSize = true;
            this.useNums.Location = new System.Drawing.Point(127, 312);
            this.useNums.Name = "useNums";
            this.useNums.Size = new System.Drawing.Size(136, 17);
            this.useNums.TabIndex = 9;
            this.useNums.Text = "Использовать цифры";
            this.useNums.UseVisualStyleBackColor = true;
            // 
            // includeStrWarning
            // 
            this.includeStrWarning.AutoSize = true;
            this.includeStrWarning.ForeColor = System.Drawing.Color.Goldenrod;
            this.includeStrWarning.Location = new System.Drawing.Point(124, 107);
            this.includeStrWarning.Name = "includeStrWarning";
            this.includeStrWarning.Size = new System.Drawing.Size(10, 13);
            this.includeStrWarning.TabIndex = 10;
            this.includeStrWarning.Text = " ";
            // 
            // useSpecDigits
            // 
            this.useSpecDigits.AutoSize = true;
            this.useSpecDigits.Location = new System.Drawing.Point(127, 335);
            this.useSpecDigits.Name = "useSpecDigits";
            this.useSpecDigits.Size = new System.Drawing.Size(178, 17);
            this.useSpecDigits.TabIndex = 9;
            this.useSpecDigits.Text = "Использовать спец. символы";
            this.useSpecDigits.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Количество\r\nпаролей:";
            // 
            // countErrorMsg
            // 
            this.countErrorMsg.AutoSize = true;
            this.countErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.countErrorMsg.Location = new System.Drawing.Point(203, 48);
            this.countErrorMsg.Name = "countErrorMsg";
            this.countErrorMsg.Size = new System.Drawing.Size(10, 13);
            this.countErrorMsg.TabIndex = 13;
            this.countErrorMsg.Text = " ";
            // 
            // exportTxt
            // 
            this.exportTxt.Enabled = false;
            this.exportTxt.Location = new System.Drawing.Point(311, 423);
            this.exportTxt.Name = "exportTxt";
            this.exportTxt.Size = new System.Drawing.Size(158, 23);
            this.exportTxt.TabIndex = 14;
            this.exportTxt.Text = "Экспорт в .txt";
            this.exportTxt.UseVisualStyleBackColor = true;
            this.exportTxt.Click += new System.EventHandler(this.exportTxt_Click);
            // 
            // fileExtError
            // 
            this.fileExtError.AutoSize = true;
            this.fileExtError.ForeColor = System.Drawing.Color.Red;
            this.fileExtError.Location = new System.Drawing.Point(319, 393);
            this.fileExtError.Name = "fileExtError";
            this.fileExtError.Size = new System.Drawing.Size(10, 13);
            this.fileExtError.TabIndex = 15;
            this.fileExtError.Text = " ";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(374, 121);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 23);
            this.clear.TabIndex = 16;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.version.Location = new System.Drawing.Point(12, 461);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(10, 13);
            this.version.TabIndex = 17;
            this.version.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Исключить строки\r\n(через \",\")";
            // 
            // dontUse
            // 
            this.dontUse.Location = new System.Drawing.Point(127, 376);
            this.dontUse.Name = "dontUse";
            this.dontUse.Size = new System.Drawing.Size(342, 20);
            this.dontUse.TabIndex = 19;
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(419, 11);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 20;
            this.settings.Text = "Настройки";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(127, 21);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(120, 20);
            this.size.TabIndex = 21;
            this.size.ValueChanged += new System.EventHandler(this.size_ValueChanged);
            // 
            // passwordsCount
            // 
            this.passwordsCount.Location = new System.Drawing.Point(127, 48);
            this.passwordsCount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.passwordsCount.Name = "passwordsCount";
            this.passwordsCount.Size = new System.Drawing.Size(120, 20);
            this.passwordsCount.TabIndex = 21;
            this.passwordsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 483);
            this.Controls.Add(this.passwordsCount);
            this.Controls.Add(this.size);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.dontUse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.version);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.fileExtError);
            this.Controls.Add(this.exportTxt);
            this.Controls.Add(this.countErrorMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.includeStrWarning);
            this.Controls.Add(this.useSpecDigits);
            this.Controls.Add(this.useNums);
            this.Controls.Add(this.difirentRegister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalPasswords);
            this.Controls.Add(this.includeStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeError);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "sti11kost.Passwords: Генератор паролей";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sizeError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox includeStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalPasswords;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox difirentRegister;
        private System.Windows.Forms.CheckBox useNums;
        private System.Windows.Forms.Label includeStrWarning;
        private System.Windows.Forms.CheckBox useSpecDigits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label countErrorMsg;
        private System.Windows.Forms.Button exportTxt;
        private System.Windows.Forms.Label fileExtError;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dontUse;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.NumericUpDown passwordsCount;
    }
}

