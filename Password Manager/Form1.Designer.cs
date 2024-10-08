namespace Password_Manager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numericPasswordLength;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Button btnEncryptDecrypt;

        /// <summary>
        /// Освобождение всех используемых ресурсов.
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numericPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.btnEncryptDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(12, 12);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(250, 20);
            this.textBoxAccount.TabIndex = 0;
            this.textBoxAccount.PlaceholderText = "Имя учётной записи";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(250, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.PlaceholderText = "Сгенерированный пароль";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 85);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 30);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numericPasswordLength
            // 
            this.numericPasswordLength.Location = new System.Drawing.Point(150, 92);
            this.numericPasswordLength.Name = "numericPasswordLength";
            this.numericPasswordLength.Size = new System.Drawing.Size(120, 20);
            this.numericPasswordLength.TabIndex = 3;
            this.numericPasswordLength.Value = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить пароль";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.Location = new System.Drawing.Point(12, 180);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(250, 95);
            this.listBoxAccounts.TabIndex = 5;
            // 
            // btnEncryptDecrypt
            // 
            this.btnEncryptDecrypt.Location = new System.Drawing.Point(150, 130);
            this.btnEncryptDecrypt.Name = "btnEncryptDecrypt";
            this.btnEncryptDecrypt.Size = new System.Drawing.Size(120, 30);
            this.btnEncryptDecrypt.TabIndex = 6;
            this.btnEncryptDecrypt.Text = "Шифр/Дешифр";
            this.btnEncryptDecrypt.UseVisualStyleBackColor = true;
            this.btnEncryptDecrypt.Click += new System.EventHandler(this.btnEncryptDecrypt_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.btnEncryptDecrypt);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericPasswordLength);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAccount);
            this.Name = "Form1";
            this.Text = "Менеджер Паролей";
            ((System.ComponentModel.ISupportInitialize)(this.numericPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
