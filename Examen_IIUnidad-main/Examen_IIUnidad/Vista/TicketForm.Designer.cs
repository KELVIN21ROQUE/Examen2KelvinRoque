namespace Vista
{
    partial class TicketForm
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
            groupBox2 = new GroupBox();
            preciotextBox = new TextBox();
            respuestatextBox = new TextBox();
            label6 = new Label();
            label11 = new Label();
            solicitudtextBox = new TextBox();
            label4 = new Label();
            tipotextBox = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            clientetextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            usuariotextBox = new TextBox();
            label1 = new Label();
            soportedataGridView = new DataGridView();
            isvtextBox = new TextBox();
            label9 = new Label();
            descuentotextBox = new TextBox();
            label12 = new Label();
            totaltextBox = new TextBox();
            label7 = new Label();
            guardarButton = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soportedataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(preciotextBox);
            groupBox2.Controls.Add(respuestatextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(solicitudtextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tipotextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(671, 192);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "DETALLE";
            // 
            // preciotextBox
            // 
            preciotextBox.Location = new Point(581, 30);
            preciotextBox.Name = "preciotextBox";
            preciotextBox.Size = new Size(75, 23);
            preciotextBox.TabIndex = 13;
            // 
            // respuestatextBox
            // 
            respuestatextBox.Location = new Point(16, 152);
            respuestatextBox.Name = "respuestatextBox";
            respuestatextBox.ReadOnly = true;
            respuestatextBox.Size = new Size(639, 23);
            respuestatextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 134);
            label6.Name = "label6";
            label6.Size = new Size(73, 14);
            label6.TabIndex = 10;
            label6.Text = "RESPUESTA";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(528, 33);
            label11.Name = "label11";
            label11.Size = new Size(47, 14);
            label11.TabIndex = 12;
            label11.Text = "PRECIO";
            // 
            // solicitudtextBox
            // 
            solicitudtextBox.Location = new Point(16, 95);
            solicitudtextBox.Name = "solicitudtextBox";
            solicitudtextBox.ReadOnly = true;
            solicitudtextBox.Size = new Size(639, 23);
            solicitudtextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 77);
            label4.Name = "label4";
            label4.Size = new Size(64, 14);
            label4.TabIndex = 8;
            label4.Text = "SOLICITUD";
            // 
            // tipotextBox
            // 
            tipotextBox.Location = new Point(147, 30);
            tipotextBox.Name = "tipotextBox";
            tipotextBox.ReadOnly = true;
            tipotextBox.Size = new Size(287, 23);
            tipotextBox.TabIndex = 7;
            tipotextBox.KeyPress += tipotextBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 33);
            label5.Name = "label5";
            label5.Size = new Size(102, 14);
            label5.TabIndex = 6;
            label5.Text = "TIPO DE SOPORTE";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clientetextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(usuariotextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(671, 90);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // clientetextBox
            // 
            clientetextBox.Location = new Point(92, 46);
            clientetextBox.Name = "clientetextBox";
            clientetextBox.ReadOnly = true;
            clientetextBox.Size = new Size(268, 23);
            clientetextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 53);
            label3.Name = "label3";
            label3.Size = new Size(53, 14);
            label3.TabIndex = 4;
            label3.Text = "CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(478, 21);
            label2.Name = "label2";
            label2.Size = new Size(45, 14);
            label2.TabIndex = 3;
            label2.Text = "FECHA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(538, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(117, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // usuariotextBox
            // 
            usuariotextBox.Location = new Point(92, 17);
            usuariotextBox.Name = "usuariotextBox";
            usuariotextBox.ReadOnly = true;
            usuariotextBox.Size = new Size(268, 23);
            usuariotextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // soportedataGridView
            // 
            soportedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            soportedataGridView.Location = new Point(12, 306);
            soportedataGridView.Name = "soportedataGridView";
            soportedataGridView.RowTemplate.Height = 25;
            soportedataGridView.Size = new Size(671, 150);
            soportedataGridView.TabIndex = 7;
            // 
            // isvtextBox
            // 
            isvtextBox.Location = new Point(57, 486);
            isvtextBox.Name = "isvtextBox";
            isvtextBox.Size = new Size(72, 23);
            isvtextBox.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(28, 489);
            label9.Name = "label9";
            label9.Size = new Size(25, 14);
            label9.TabIndex = 15;
            label9.Text = "ISV";
            // 
            // descuentotextBox
            // 
            descuentotextBox.Location = new Point(247, 486);
            descuentotextBox.Name = "descuentotextBox";
            descuentotextBox.Size = new Size(70, 23);
            descuentotextBox.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(169, 489);
            label12.Name = "label12";
            label12.Size = new Size(70, 14);
            label12.TabIndex = 17;
            label12.Text = "DESCUENTO";
            // 
            // totaltextBox
            // 
            totaltextBox.Location = new Point(413, 486);
            totaltextBox.Name = "totaltextBox";
            totaltextBox.Size = new Size(75, 23);
            totaltextBox.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(360, 489);
            label7.Name = "label7";
            label7.Size = new Size(44, 14);
            label7.TabIndex = 19;
            label7.Text = "TOTAL";
            // 
            // guardarButton
            // 
            guardarButton.BackColor = SystemColors.Desktop;
            guardarButton.Font = new Font("Algerian", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guardarButton.ForeColor = SystemColors.ActiveCaptionText;
            guardarButton.Location = new Point(593, 478);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(90, 36);
            guardarButton.TabIndex = 21;
            guardarButton.Text = "GUARDAR";
            guardarButton.UseVisualStyleBackColor = false;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 538);
            Controls.Add(guardarButton);
            Controls.Add(totaltextBox);
            Controls.Add(label7);
            Controls.Add(descuentotextBox);
            Controls.Add(label12);
            Controls.Add(isvtextBox);
            Controls.Add(label9);
            Controls.Add(soportedataGridView);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TicketForm";
            Text = "TicketForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soportedataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private TextBox respuestatextBox;
        private Label label6;
        private TextBox solicitudtextBox;
        private Label label4;
        private TextBox tipotextBox;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox clientetextBox;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox usuariotextBox;
        private Label label1;
        private TextBox preciotextBox;
        private Label label11;
        private DataGridView soportedataGridView;
        private TextBox isvtextBox;
        private Label label9;
        private TextBox descuentotextBox;
        private Label label12;
        private TextBox totaltextBox;
        private Label label7;
        private Button guardarButton;
    }
}