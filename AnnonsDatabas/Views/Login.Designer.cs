namespace AnnonsDatabas.Views
{
    partial class Login
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
            groupBoxLogIn = new GroupBox();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            buttonCreateUser = new Button();
            buttonLogin = new Button();
            buttonCancel = new Button();
            groupBoxLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLogIn
            // 
            groupBoxLogIn.Controls.Add(textBoxPassword);
            groupBoxLogIn.Controls.Add(textBoxUserName);
            groupBoxLogIn.Location = new Point(341, 211);
            groupBoxLogIn.Name = "groupBoxLogIn";
            groupBoxLogIn.Size = new Size(386, 285);
            groupBoxLogIn.TabIndex = 6;
            groupBoxLogIn.TabStop = false;
            groupBoxLogIn.Text = "Logga in";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(54, 190);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Lösenord";
            textBoxPassword.ScrollBars = ScrollBars.Horizontal;
            textBoxPassword.Size = new Size(280, 35);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(54, 73);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Användarnamn";
            textBoxUserName.Size = new Size(280, 35);
            textBoxUserName.TabIndex = 1;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(395, 599);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(280, 40);
            buttonCreateUser.TabIndex = 4;
            buttonCreateUser.Text = "Skappa nytt konto";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(395, 541);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(280, 40);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Logga in";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(395, 655);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(280, 40);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Avbryt";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 852);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            Controls.Add(buttonCreateUser);
            Controls.Add(groupBoxLogIn);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBoxLogIn.ResumeLayout(false);
            groupBoxLogIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxLogIn;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private Button buttonCreateUser;
        private Button buttonLogin;
        private Button buttonCancel;
    }
}