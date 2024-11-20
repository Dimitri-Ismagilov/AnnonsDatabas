namespace AnnonsDatabas.Views
{
    partial class CreateNewUser
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
            buttonCreateUser = new Button();
            groupBoxCreateNew = new GroupBox();
            textBoxPassword = new TextBox();
            textBoxUserName = new TextBox();
            buttonCancel = new Button();
            groupBoxCreateNew.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(397, 553);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(280, 40);
            buttonCreateUser.TabIndex = 4;
            buttonCreateUser.Text = "Skappa nytt konto";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // groupBoxCreateNew
            // 
            groupBoxCreateNew.Controls.Add(textBoxPassword);
            groupBoxCreateNew.Controls.Add(textBoxUserName);
            groupBoxCreateNew.Location = new Point(343, 212);
            groupBoxCreateNew.Name = "groupBoxCreateNew";
            groupBoxCreateNew.Size = new Size(386, 285);
            groupBoxCreateNew.TabIndex = 3;
            groupBoxCreateNew.TabStop = false;
            groupBoxCreateNew.Text = "Skappa nytt konto";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(54, 190);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Lösenord";
            textBoxPassword.Size = new Size(280, 35);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(54, 73);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Användarnamn";
            textBoxUserName.Size = new Size(280, 35);
            textBoxUserName.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(397, 609);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(280, 40);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Avbryt";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // CreateNewUser
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 852);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreateUser);
            Controls.Add(groupBoxCreateNew);
            Name = "CreateNewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateNewUser";
            groupBoxCreateNew.ResumeLayout(false);
            groupBoxCreateNew.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCreateUser;
        private GroupBox groupBoxCreateNew;
        private TextBox textBoxPassword;
        private TextBox textBoxUserName;
        private Button buttonCancel;
    }
}