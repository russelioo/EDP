namespace jf_edp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtusername = new Label();
            txtpassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            login = new Button();
            close = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.AutoSize = true;
            txtusername.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(103, 174);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(97, 29);
            txtusername.TabIndex = 0;
            txtusername.Text = "Username:";
            txtusername.Click += label1_Click;
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.Black;
            txtpassword.Location = new Point(101, 229);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(95, 29);
            txtpassword.TabIndex = 1;
            txtpassword.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(395, 36);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 36);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += password_TextChanged;
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.Location = new Point(273, 317);
            login.Name = "login";
            login.Size = new Size(150, 46);
            login.TabIndex = 4;
            login.Text = "Log in";
            login.UseVisualStyleBackColor = true;
            login.Click += button1_Click;
            // 
            // close
            // 
            close.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(273, 369);
            close.Name = "close";
            close.Size = new Size(150, 46);
            close.TabIndex = 5;
            close.Text = "Close";
            close.UseVisualStyleBackColor = true;
            close.Click += button1_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 255);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(login);
            groupBox1.Controls.Add(close);
            groupBox1.Controls.Add(txtusername);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 485);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter your username and password";
            groupBox1.UseCompatibleTextRendering = true;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(332, 53);
            button2.Name = "button2";
            button2.Size = new Size(91, 95);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 519);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Log In";
            TopMost = true;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label txtusername;
        private Label txtpassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button login;
        private Button close;
        private GroupBox groupBox1;
        private Button button2;
    }
}
