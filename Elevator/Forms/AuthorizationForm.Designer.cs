﻿namespace Elevator
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authirizationButton = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.ForeColor = System.Drawing.Color.Gray;
            this.loginTextBox.Location = new System.Drawing.Point(54, 21);
            this.loginTextBox.MaxLength = 15;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(196, 33);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.Text = "Логин";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTextBox.Location = new System.Drawing.Point(54, 70);
            this.passwordTextBox.MaxLength = 15;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(196, 33);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Пароль";
            // 
            // authirizationButton
            // 
            this.authirizationButton.BackColor = System.Drawing.Color.DarkOrange;
            this.authirizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.authirizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authirizationButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.authirizationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.authirizationButton.Location = new System.Drawing.Point(39, 123);
            this.authirizationButton.Name = "authirizationButton";
            this.authirizationButton.Size = new System.Drawing.Size(88, 28);
            this.authirizationButton.TabIndex = 49;
            this.authirizationButton.Text = "Войти";
            this.authirizationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.authirizationButton.UseVisualStyleBackColor = false;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegistration.Location = new System.Drawing.Point(162, 124);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(122, 28);
            this.buttonRegistration.TabIndex = 50;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegistration.UseVisualStyleBackColor = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(313, 178);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.authirizationButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button authirizationButton;
        private System.Windows.Forms.Button buttonRegistration;
    }
}

