namespace BD_LAVR_KP
{
    partial class Template
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_info = new BD_LAVR_KP.GUI.GUI_Classes.RoundButton();
            this.panelContainer.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Controls.Add(this.button_info);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(725, 386);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.button_Minimize);
            this.panelTitleBar.Controls.Add(this.button_Close);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(725, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Страховые иски";
            // 
            // button_Minimize
            // 
            this.button_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Minimize.ForeColor = System.Drawing.Color.White;
            this.button_Minimize.Location = new System.Drawing.Point(625, 0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(50, 50);
            this.button_Minimize.TabIndex = 1;
            this.button_Minimize.Text = "__";
            this.button_Minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Location = new System.Drawing.Point(675, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(50, 50);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_info.BackColor2 = System.Drawing.Color.SkyBlue;
            this.button_info.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_info.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(200)))));
            this.button_info.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.button_info.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.button_info.ButtonPressedColor = System.Drawing.Color.Red;
            this.button_info.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.button_info.ButtonPressedForeColor = System.Drawing.Color.White;
            this.button_info.ButtonRoundRadius = 30;
            this.button_info.Font = new System.Drawing.Font("Verdana", 15F);
            this.button_info.ForeColor = System.Drawing.Color.White;
            this.button_info.Location = new System.Drawing.Point(666, 334);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(47, 40);
            this.button_info.TabIndex = 3;
            this.button_info.Text = "?";
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 386);
            this.Controls.Add(this.panelContainer);
            this.Name = "Template";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страховые иски";
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.ResizeEnd += new System.EventHandler(this.LoginForm_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.LoginForm_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button button_Minimize;
        public System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label1;
        protected GUI.GUI_Classes.RoundButton button_info;
    }
}

