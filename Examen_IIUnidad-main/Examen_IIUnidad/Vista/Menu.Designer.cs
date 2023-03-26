namespace Vista
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            uSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            lISTADEUSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            tIPOSDESOPORTEToolStripMenuItem = new ToolStripMenuItem();
            lISTADESOPORTESToolStripMenuItem = new ToolStripMenuItem();
            tICKECTToolStripMenuItem = new ToolStripMenuItem();
            gENERARTICKETToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { uSUARIOSToolStripMenuItem, tIPOSDESOPORTEToolStripMenuItem, tICKECTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            uSUARIOSToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lISTADEUSUARIOSToolStripMenuItem });
            uSUARIOSToolStripMenuItem.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            uSUARIOSToolStripMenuItem.Size = new Size(87, 20);
            uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // lISTADEUSUARIOSToolStripMenuItem
            // 
            lISTADEUSUARIOSToolStripMenuItem.Name = "lISTADEUSUARIOSToolStripMenuItem";
            lISTADEUSUARIOSToolStripMenuItem.Size = new Size(209, 22);
            lISTADEUSUARIOSToolStripMenuItem.Text = "LISTA DE USUARIOS";
            lISTADEUSUARIOSToolStripMenuItem.Click += lISTADEUSUARIOSToolStripMenuItem_Click;
            // 
            // tIPOSDESOPORTEToolStripMenuItem
            // 
            tIPOSDESOPORTEToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            tIPOSDESOPORTEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lISTADESOPORTESToolStripMenuItem });
            tIPOSDESOPORTEToolStripMenuItem.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tIPOSDESOPORTEToolStripMenuItem.Name = "tIPOSDESOPORTEToolStripMenuItem";
            tIPOSDESOPORTEToolStripMenuItem.Size = new Size(147, 20);
            tIPOSDESOPORTEToolStripMenuItem.Text = "TIPOS DE SOPORTE";
            // 
            // lISTADESOPORTESToolStripMenuItem
            // 
            lISTADESOPORTESToolStripMenuItem.Name = "lISTADESOPORTESToolStripMenuItem";
            lISTADESOPORTESToolStripMenuItem.Size = new Size(211, 22);
            lISTADESOPORTESToolStripMenuItem.Text = "LISTA DE SOPORTES";
            lISTADESOPORTESToolStripMenuItem.Click += lISTADESOPORTESToolStripMenuItem_Click;
            // 
            // tICKECTToolStripMenuItem
            // 
            tICKECTToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            tICKECTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gENERARTICKETToolStripMenuItem });
            tICKECTToolStripMenuItem.Font = new Font("Algerian", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tICKECTToolStripMenuItem.Name = "tICKECTToolStripMenuItem";
            tICKECTToolStripMenuItem.Size = new Size(79, 20);
            tICKECTToolStripMenuItem.Text = "TICKECT";
            // 
            // gENERARTICKETToolStripMenuItem
            // 
            gENERARTICKETToolStripMenuItem.Name = "gENERARTICKETToolStripMenuItem";
            gENERARTICKETToolStripMenuItem.Size = new Size(195, 22);
            gENERARTICKETToolStripMenuItem.Text = "GENERAR TICKET";
            gENERARTICKETToolStripMenuItem.Click += gENERARTICKETToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private ToolStripMenuItem lISTADEUSUARIOSToolStripMenuItem;
        private ToolStripMenuItem tIPOSDESOPORTEToolStripMenuItem;
        private ToolStripMenuItem lISTADESOPORTESToolStripMenuItem;
        private ToolStripMenuItem tICKECTToolStripMenuItem;
        private ToolStripMenuItem gENERARTICKETToolStripMenuItem;
    }
}