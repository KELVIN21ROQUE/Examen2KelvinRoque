namespace Vista
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
            components = new System.ComponentModel.Container();
            label3 = new Label();
            button1 = new Button();
            clavetextBox = new TextBox();
            usuarioTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Algerian", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 58);
            label3.Name = "label3";
            label3.Size = new Size(314, 24);
            label3.TabIndex = 11;
            label3.Text = "BIENVENIDOS A CELL-KELVIN";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Image = Properties.Resources.entrar;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(138, 279);
            button1.Name = "button1";
            button1.Size = new Size(103, 25);
            button1.TabIndex = 10;
            button1.Text = "ACCEDER";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clavetextBox
            // 
            clavetextBox.Location = new Point(78, 218);
            clavetextBox.Name = "clavetextBox";
            clavetextBox.Size = new Size(214, 23);
            clavetextBox.TabIndex = 9;
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(78, 150);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(214, 23);
            usuarioTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 198);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "CLAVE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 130);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "USUARIO";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 398);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(clavetextBox);
            Controls.Add(usuarioTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button1;
        private TextBox clavetextBox;
        private TextBox usuarioTextBox;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}