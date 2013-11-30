namespace dummieHack
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIntro = new System.Windows.Forms.RichTextBox();
            this.btnIngles = new System.Windows.Forms.Button();
            this.btnEspaniol = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(17, 202);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(764, 31);
            this.txtLink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese el link del libro que quiere descargar :";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.Location = new System.Drawing.Point(794, 199);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(196, 37);
            this.btnDescargar.TabIndex = 7;
            this.btnDescargar.Text = "Descargar Libro";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(794, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Borrar Texto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1011, 24);
            this.menu.TabIndex = 9;
            this.menu.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.aboutToolStripMenuItem.Text = "&?";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // txtIntro
            // 
            this.txtIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntro.Location = new System.Drawing.Point(17, 36);
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(764, 129);
            this.txtIntro.TabIndex = 10;
            this.txtIntro.Text = global::dummieHack.Resources.textoLinkDescargaUS;
            // 
            // btnIngles
            // 
            this.btnIngles.Image = global::dummieHack.Resources.us;
            this.btnIngles.Location = new System.Drawing.Point(943, 27);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(56, 31);
            this.btnIngles.TabIndex = 12;
            this.btnIngles.UseVisualStyleBackColor = true;
            // 
            // btnEspaniol
            // 
            this.btnEspaniol.Image = global::dummieHack.Resources.pe;
            this.btnEspaniol.Location = new System.Drawing.Point(881, 27);
            this.btnEspaniol.Name = "btnEspaniol";
            this.btnEspaniol.Size = new System.Drawing.Size(56, 31);
            this.btnEspaniol.TabIndex = 11;
            this.btnEspaniol.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 254);
            this.Controls.Add(this.btnIngles);
            this.Controls.Add(this.btnEspaniol);
            this.Controls.Add(this.txtIntro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "FrmPrincipal";
            this.Text = "Taurox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtIntro;
        private System.Windows.Forms.Button btnIngles;
        private System.Windows.Forms.Button btnEspaniol;
    }
}

