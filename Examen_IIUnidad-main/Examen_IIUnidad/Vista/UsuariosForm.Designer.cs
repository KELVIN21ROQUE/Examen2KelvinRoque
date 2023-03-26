namespace Vista
{
    partial class UsuariosForm
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
            cancelarbutton = new Button();
            eliminarbutton = new Button();
            guardarbutton = new Button();
            modificarbutton = new Button();
            usuariosdataGridView = new DataGridView();
            nuevobutton = new Button();
            estaactivocheckBox = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            rolcomboBox = new ComboBox();
            clavetextBox = new TextBox();
            label3 = new Label();
            nombretextBox = new TextBox();
            label2 = new Label();
            codigotextBox = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)usuariosdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // cancelarbutton
            // 
            cancelarbutton.BackColor = SystemColors.ActiveCaption;
            cancelarbutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancelarbutton.Location = new Point(411, 192);
            cancelarbutton.Name = "cancelarbutton";
            cancelarbutton.Size = new Size(72, 28);
            cancelarbutton.TabIndex = 35;
            cancelarbutton.Text = "Cancelar";
            cancelarbutton.UseVisualStyleBackColor = false;
            cancelarbutton.Click += cancelarbutton_Click;
            // 
            // eliminarbutton
            // 
            eliminarbutton.BackColor = SystemColors.ActiveCaption;
            eliminarbutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eliminarbutton.Location = new Point(333, 192);
            eliminarbutton.Name = "eliminarbutton";
            eliminarbutton.Size = new Size(72, 28);
            eliminarbutton.TabIndex = 34;
            eliminarbutton.Text = "Eliminar";
            eliminarbutton.UseVisualStyleBackColor = false;
            eliminarbutton.Click += eliminarbutton_Click;
            // 
            // guardarbutton
            // 
            guardarbutton.BackColor = SystemColors.ActiveCaption;
            guardarbutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guardarbutton.Location = new Point(255, 192);
            guardarbutton.Name = "guardarbutton";
            guardarbutton.Size = new Size(72, 28);
            guardarbutton.TabIndex = 33;
            guardarbutton.Text = "Guardar";
            guardarbutton.UseVisualStyleBackColor = false;
            guardarbutton.Click += guardarbutton_Click;
            // 
            // modificarbutton
            // 
            modificarbutton.BackColor = SystemColors.ActiveCaption;
            modificarbutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            modificarbutton.Location = new Point(177, 192);
            modificarbutton.Name = "modificarbutton";
            modificarbutton.Size = new Size(72, 28);
            modificarbutton.TabIndex = 32;
            modificarbutton.Text = "Modificar";
            modificarbutton.UseVisualStyleBackColor = false;
            modificarbutton.Click += modificarbutton_Click;
            // 
            // usuariosdataGridView
            // 
            usuariosdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usuariosdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usuariosdataGridView.Location = new Point(35, 236);
            usuariosdataGridView.Name = "usuariosdataGridView";
            usuariosdataGridView.RowTemplate.Height = 25;
            usuariosdataGridView.Size = new Size(533, 119);
            usuariosdataGridView.TabIndex = 31;
            // 
            // nuevobutton
            // 
            nuevobutton.BackColor = SystemColors.ActiveCaption;
            nuevobutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nuevobutton.Location = new Point(99, 192);
            nuevobutton.Name = "nuevobutton";
            nuevobutton.Size = new Size(72, 28);
            nuevobutton.TabIndex = 30;
            nuevobutton.Text = "Nuevo";
            nuevobutton.UseVisualStyleBackColor = false;
            nuevobutton.Click += nuevobutton_Click;
            // 
            // estaactivocheckBox
            // 
            estaactivocheckBox.AutoSize = true;
            estaactivocheckBox.Enabled = false;
            estaactivocheckBox.Location = new Point(168, 141);
            estaactivocheckBox.Name = "estaactivocheckBox";
            estaactivocheckBox.Size = new Size(15, 14);
            estaactivocheckBox.TabIndex = 29;
            estaactivocheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(58, 141);
            label6.Name = "label6";
            label6.Size = new Size(81, 14);
            label6.TabIndex = 28;
            label6.Text = "Esta Activo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(99, 115);
            label5.Name = "label5";
            label5.Size = new Size(29, 14);
            label5.TabIndex = 27;
            label5.Text = "Rol";
            // 
            // rolcomboBox
            // 
            rolcomboBox.Enabled = false;
            rolcomboBox.FormattingEnabled = true;
            rolcomboBox.Items.AddRange(new object[] { "Administrador", "Usuario" });
            rolcomboBox.Location = new Point(168, 112);
            rolcomboBox.Name = "rolcomboBox";
            rolcomboBox.Size = new Size(202, 23);
            rolcomboBox.TabIndex = 26;
            // 
            // clavetextBox
            // 
            clavetextBox.Enabled = false;
            clavetextBox.Location = new Point(170, 83);
            clavetextBox.Name = "clavetextBox";
            clavetextBox.PasswordChar = '*';
            clavetextBox.Size = new Size(200, 23);
            clavetextBox.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 86);
            label3.Name = "label3";
            label3.Size = new Size(44, 14);
            label3.TabIndex = 22;
            label3.Text = "Clave";
            // 
            // nombretextBox
            // 
            nombretextBox.Enabled = false;
            nombretextBox.Location = new Point(170, 52);
            nombretextBox.Name = "nombretextBox";
            nombretextBox.Size = new Size(200, 23);
            nombretextBox.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 14);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // codigotextBox
            // 
            codigotextBox.Enabled = false;
            codigotextBox.Location = new Point(170, 21);
            codigotextBox.Name = "codigotextBox";
            codigotextBox.Size = new Size(200, 23);
            codigotextBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 14);
            label1.TabIndex = 18;
            label1.Text = "Codigo";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 367);
            Controls.Add(cancelarbutton);
            Controls.Add(eliminarbutton);
            Controls.Add(guardarbutton);
            Controls.Add(modificarbutton);
            Controls.Add(usuariosdataGridView);
            Controls.Add(nuevobutton);
            Controls.Add(estaactivocheckBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rolcomboBox);
            Controls.Add(clavetextBox);
            Controls.Add(label3);
            Controls.Add(nombretextBox);
            Controls.Add(label2);
            Controls.Add(codigotextBox);
            Controls.Add(label1);
            Name = "UsuariosForm";
            Text = "UsuariosForm";
            Load += UsuariosForm_Load;
            ((System.ComponentModel.ISupportInitialize)usuariosdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarbutton;
        private Button eliminarbutton;
        private Button guardarbutton;
        private Button modificarbutton;
        private DataGridView usuariosdataGridView;
        private Button nuevobutton;
        private CheckBox estaactivocheckBox;
        private Label label6;
        private Label label5;
        private ComboBox rolcomboBox;
        private TextBox clavetextBox;
        private Label label3;
        private TextBox nombretextBox;
        private Label label2;
        private TextBox codigotextBox;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}