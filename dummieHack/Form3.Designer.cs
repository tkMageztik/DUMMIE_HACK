namespace dummieHack
{
    partial class Form3
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
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.kryptonRibbon = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonTab2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonTab3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonGallery1 = new ComponentFactory.Krypton.Ribbon.KryptonGallery();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Location = new System.Drawing.Point(0, 244);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(292, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // kryptonRibbon
            // 
            this.kryptonRibbon.InDesignHelperMode = true;
            this.kryptonRibbon.Name = "kryptonRibbon";
            this.kryptonRibbon.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1,
            this.kryptonRibbonTab2,
            this.kryptonRibbonTab3});
            this.kryptonRibbon.SelectedContext = null;
            this.kryptonRibbon.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon.Size = new System.Drawing.Size(292, 115);
            this.kryptonRibbon.TabIndex = 1;
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonGallery1);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 115);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(292, 129);
            this.kryptonPanel.TabIndex = 2;
            // 
            // kryptonGallery1
            // 
            this.kryptonGallery1.ImageList = null;
            this.kryptonGallery1.Location = new System.Drawing.Point(80, 40);
            this.kryptonGallery1.Name = "kryptonGallery1";
            this.kryptonGallery1.Size = new System.Drawing.Size(240, 30);
            this.kryptonGallery1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.kryptonPanel);
            this.Controls.Add(this.kryptonRibbon);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.StatusStrip statusStrip;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab3;
        private ComponentFactory.Krypton.Ribbon.KryptonGallery kryptonGallery1;
    }
}

