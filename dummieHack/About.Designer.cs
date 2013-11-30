namespace dummieHack
{
    partial class About
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.txtAbout = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.txtAbout);
            this.grpBox.Location = new System.Drawing.Point(12, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(439, 356);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Términos de uso";
            // 
            // txtAbout
            // 
            this.txtAbout.Location = new System.Drawing.Point(18, 20);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.ReadOnly = true;
            this.txtAbout.Size = new System.Drawing.Size(404, 320);
            this.txtAbout.TabIndex = 1;
            this.txtAbout.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 380);
            this.Controls.Add(this.grpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de Taurox";
            this.Load += new System.EventHandler(this.About_Load);
            this.grpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RichTextBox txtAbout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    }
}