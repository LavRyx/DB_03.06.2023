namespace BD_LAVR_KP.GUI.Forms
{
    partial class LoginForm
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
            this.roundButton2 = new BD_LAVR_KP.GUI.GUI_Classes.RoundButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ServerName = new System.Windows.Forms.TextBox();
            this.textBox_DBname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.animationComponent1 = new BD_LAVR_KP.GUI.GUI_Classes.AnimationComponent(this.components);
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.label7);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.textBox_DBname);
            this.panelContainer.Controls.Add(this.textBox_ServerName);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.textBox_Password);
            this.panelContainer.Controls.Add(this.textBox_Login);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.roundButton2);
            this.panelContainer.Controls.SetChildIndex(this.button_info, 0);
            this.panelContainer.Controls.SetChildIndex(this.roundButton2, 0);
            this.panelContainer.Controls.SetChildIndex(this.label2, 0);
            this.panelContainer.Controls.SetChildIndex(this.textBox_Login, 0);
            this.panelContainer.Controls.SetChildIndex(this.textBox_Password, 0);
            this.panelContainer.Controls.SetChildIndex(this.label3, 0);
            this.panelContainer.Controls.SetChildIndex(this.label4, 0);
            this.panelContainer.Controls.SetChildIndex(this.label5, 0);
            this.panelContainer.Controls.SetChildIndex(this.textBox_ServerName, 0);
            this.panelContainer.Controls.SetChildIndex(this.textBox_DBname, 0);
            this.panelContainer.Controls.SetChildIndex(this.label6, 0);
            this.panelContainer.Controls.SetChildIndex(this.label7, 0);
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 0;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundButton2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundButton2.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundButton2.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundButton2.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.roundButton2.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.roundButton2.ButtonPressedColor = System.Drawing.Color.Red;
            this.roundButton2.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.roundButton2.ButtonPressedForeColor = System.Drawing.Color.White;
            this.roundButton2.ButtonRoundRadius = 30;
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(294, 333);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(135, 41);
            this.roundButton2.TabIndex = 4;
            this.roundButton2.Text = "Вход";
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Авторизация";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(18, 130);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(243, 33);
            this.textBox_Login.TabIndex = 5;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(18, 201);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(243, 33);
            this.textBox_Password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(568, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Подключение";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_ServerName
            // 
            this.textBox_ServerName.Location = new System.Drawing.Point(470, 130);
            this.textBox_ServerName.Name = "textBox_ServerName";
            this.textBox_ServerName.Size = new System.Drawing.Size(243, 33);
            this.textBox_ServerName.TabIndex = 10;
            // 
            // textBox_DBname
            // 
            this.textBox_DBname.Location = new System.Drawing.Point(470, 201);
            this.textBox_DBname.Name = "textBox_DBname";
            this.textBox_DBname.Size = new System.Drawing.Size(243, 33);
            this.textBox_DBname.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(627, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Сервер";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(518, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Имя базы данных";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // animationComponent1
            // 
            this.animationComponent1.ActivateEffect = BD_LAVR_KP.GUI.GUI_Classes.FormAnimateEffects.РАСКРЫТИЕ_СКРЫТИЕ;
            this.animationComponent1.CloseEffect = BD_LAVR_KP.GUI.GUI_Classes.FormAnimateEffects.ПОЯВЛЕНИЕ_ЗАТУХАНИЕ;
            this.animationComponent1.SourceForm = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(725, 386);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GUI_Classes.RoundButton roundButton2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_DBname;
        private System.Windows.Forms.TextBox textBox_ServerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label2;
        private GUI_Classes.AnimationComponent animationComponent1;
    }
}
