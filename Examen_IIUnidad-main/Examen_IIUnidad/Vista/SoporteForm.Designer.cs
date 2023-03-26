namespace Vista
{
    partial class SoporteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tipotextBox = new TextBox();
            soluciontextBox = new TextBox();
            descripciontextBox = new TextBox();
            preciotextBox = new TextBox();
            soportesdataGridView = new DataGridView();
            cancelarbutton = new Button();
            eliminarbutton = new Button();
            guardarbutton = new Button();
            modificarbutton = new Button();
            nuevobutton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)soportesdataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "TIPO DE SOPORTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 40);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "DESCRIPCION ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 71);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "SOLUCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 102);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "PRECIO";
            // 
            // tipotextBox
            // 
            tipotextBox.Location = new Point(159, 8);
            tipotextBox.Name = "tipotextBox";
            tipotextBox.Size = new Size(182, 23);
            tipotextBox.TabIndex = 4;
            // 
            // soluciontextBox
            // 
            soluciontextBox.Location = new Point(159, 70);
            soluciontextBox.Name = "soluciontextBox";
            soluciontextBox.Size = new Size(368, 23);
            soluciontextBox.TabIndex = 5;
            // 
            // descripciontextBox
            // 
            descripciontextBox.Location = new Point(159, 39);
            descripciontextBox.Name = "descripciontextBox";
            descripciontextBox.Size = new Size(368, 23);
            descripciontextBox.TabIndex = 6;
            // 
            // preciotextBox
            // 
            preciotextBox.Location = new Point(159, 101);
            preciotextBox.Name = "preciotextBox";
            preciotextBox.Size = new Size(132, 23);
            preciotextBox.TabIndex = 7;
            // 
            // soportesdataGridView
            // 
            soportesdataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            soportesdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            soportesdataGridView.Location = new Point(30, 229);
            soportesdataGridView.Name = "soportesdataGridView";
            soportesdataGridView.RowTemplate.Height = 25;
            soportesdataGridView.Size = new Size(673, 153);
            soportesdataGridView.TabIndex = 30;
            // 
            // cancelarbutton
            // 
            cancelarbutton.BackColor = SystemColors.ActiveCaption;
            cancelarbutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cancelarbutton.Location = new Point(494, 186);
            cancelarbutton.Name = "cancelarbutton";
            cancelarbutton.Size = new Size(72, 28);
            cancelarbutton.TabIndex = 29;
            cancelarbutton.Text = "Cancelar";
            cancelarbutton.UseVisualStyleBackColor = false;
            cancelarbutton.Click += cancelarbutton_Click;
            // 
            // eliminarbutton
            // 
            eliminarbutton.BackColor = SystemColors.ActiveCaption;
            eliminarbutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            eliminarbutton.Location = new Point(416, 186);
            eliminarbutton.Name = "eliminarbutton";
            eliminarbutton.Size = new Size(72, 28);
            eliminarbutton.TabIndex = 28;
            eliminarbutton.Text = "Eliminar";
            eliminarbutton.UseVisualStyleBackColor = false;
            eliminarbutton.Click += eliminarbutton_Click;
            // 
            // guardarbutton
            // 
            guardarbutton.BackColor = SystemColors.ActiveCaption;
            guardarbutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guardarbutton.Location = new Point(338, 186);
            guardarbutton.Name = "guardarbutton";
            guardarbutton.Size = new Size(72, 28);
            guardarbutton.TabIndex = 27;
            guardarbutton.Text = "Guardar";
            guardarbutton.UseVisualStyleBackColor = false;
            guardarbutton.Click += guardarbutton_Click;
            // 
            // modificarbutton
            // 
            modificarbutton.BackColor = SystemColors.ActiveCaption;
            modificarbutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            modificarbutton.Location = new Point(260, 186);
            modificarbutton.Name = "modificarbutton";
            modificarbutton.Size = new Size(72, 28);
            modificarbutton.TabIndex = 26;
            modificarbutton.Text = "Modificar";
            modificarbutton.UseVisualStyleBackColor = false;
            modificarbutton.Click += modificarbutton_Click;
            // 
            // nuevobutton
            // 
            nuevobutton.BackColor = SystemColors.ActiveCaption;
            nuevobutton.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nuevobutton.Location = new Point(182, 186);
            nuevobutton.Name = "nuevobutton";
            nuevobutton.Size = new Size(72, 28);
            nuevobutton.TabIndex = 25;
            nuevobutton.Text = "Nuevo";
            nuevobutton.UseVisualStyleBackColor = false;
            nuevobutton.Click += nuevobutton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SoporteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 409);
            Controls.Add(soportesdataGridView);
            Controls.Add(cancelarbutton);
            Controls.Add(eliminarbutton);
            Controls.Add(guardarbutton);
            Controls.Add(modificarbutton);
            Controls.Add(nuevobutton);
            Controls.Add(preciotextBox);
            Controls.Add(descripciontextBox);
            Controls.Add(soluciontextBox);
            Controls.Add(tipotextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SoporteForm";
            Text = "SoporteForm";
            Load += SoporteForm_Load;
            ((System.ComponentModel.ISupportInitialize)soportesdataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tipotextBox;
        private TextBox soluciontextBox;
        private TextBox descripciontextBox;
        private TextBox preciotextBox;
        private DataGridView soportesdataGridView;
        private Button cancelarbutton;
        private Button eliminarbutton;
        private Button guardarbutton;
        private Button modificarbutton;
        private Button nuevobutton;
        private ErrorProvider errorProvider1;
    }
}