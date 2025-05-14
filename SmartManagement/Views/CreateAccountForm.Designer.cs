namespace SmartManagement.Views
{
    partial class CreateAccountForm
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
            inputNomUser = new TextBox();
            textBox2 = new TextBox();
            inputPasswordUser = new TextBox();
            inputLoginUser = new TextBox();
            SuspendLayout();
            // 
            // inputNomUser
            // 
            inputNomUser.Location = new Point(111, 60);
            inputNomUser.Name = "inputNomUser";
            inputNomUser.Size = new Size(125, 27);
            inputNomUser.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 222);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // inputPasswordUser
            // 
            inputPasswordUser.Location = new Point(111, 171);
            inputPasswordUser.Name = "inputPasswordUser";
            inputPasswordUser.Size = new Size(125, 27);
            inputPasswordUser.TabIndex = 2;
            // 
            // inputLoginUser
            // 
            inputLoginUser.Location = new Point(111, 114);
            inputLoginUser.Name = "inputLoginUser";
            inputLoginUser.Size = new Size(125, 27);
            inputLoginUser.TabIndex = 3;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputLoginUser);
            Controls.Add(inputPasswordUser);
            Controls.Add(textBox2);
            Controls.Add(inputNomUser);
            Name = "CreateAccountForm";
            Text = "CreateAccount";
           // Load += this.CreateAccountForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNomUser;
        private TextBox textBox2;
        private TextBox inputPasswordUser;
        private TextBox inputLoginUser;
    }
}