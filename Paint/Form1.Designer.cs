namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listShape = new System.Windows.Forms.ListBox();
            this.labelShape = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.listColor = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.languagePolish = new System.Windows.Forms.ToolStripMenuItem();
            this.languageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listShape
            // 
            resources.ApplyResources(this.listShape, "listShape");
            this.listShape.FormattingEnabled = true;
            this.listShape.Items.AddRange(new object[] {
            resources.GetString("listShape.Items"),
            resources.GetString("listShape.Items1"),
            resources.GetString("listShape.Items2")});
            this.listShape.Name = "listShape";
            this.listShape.SelectedIndexChanged += new System.EventHandler(this.listShape_SelectedIndexChanged);
            // 
            // labelShape
            // 
            resources.ApplyResources(this.labelShape, "labelShape");
            this.labelShape.Name = "labelShape";
            // 
            // labelColor
            // 
            resources.ApplyResources(this.labelColor, "labelColor");
            this.labelColor.Name = "labelColor";
            // 
            // listColor
            // 
            resources.ApplyResources(this.listColor, "listColor");
            this.listColor.FormattingEnabled = true;
            this.listColor.Items.AddRange(new object[] {
            resources.GetString("listColor.Items"),
            resources.GetString("listColor.Items1")});
            this.listColor.Name = "listColor";
            this.listColor.SelectedIndexChanged += new System.EventHandler(this.listColor_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenu,
            this.languageMenu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // optionsMenu
            // 
            this.optionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoItem,
            this.reduItem,
            this.openMenu});
            this.optionsMenu.Name = "optionsMenu";
            resources.ApplyResources(this.optionsMenu, "optionsMenu");
            // 
            // undoItem
            // 
            this.undoItem.Name = "undoItem";
            resources.ApplyResources(this.undoItem, "undoItem");
            this.undoItem.Click += new System.EventHandler(this.undoItem_Click);
            // 
            // reduItem
            // 
            this.reduItem.Name = "reduItem";
            resources.ApplyResources(this.reduItem, "reduItem");
            this.reduItem.Click += new System.EventHandler(this.reduItem_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            resources.ApplyResources(this.openMenu, "openMenu");
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // languageMenu
            // 
            this.languageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languagePolish,
            this.languageEnglish});
            this.languageMenu.Name = "languageMenu";
            resources.ApplyResources(this.languageMenu, "languageMenu");
            // 
            // languagePolish
            // 
            this.languagePolish.Name = "languagePolish";
            resources.ApplyResources(this.languagePolish, "languagePolish");
            // 
            // languageEnglish
            // 
            this.languageEnglish.Name = "languageEnglish";
            resources.ApplyResources(this.languageEnglish, "languageEnglish");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            resources.ApplyResources(this.statusLabel, "statusLabel");
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelShape);
            this.Controls.Add(this.listShape);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listShape;
        private System.Windows.Forms.Label labelShape;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ListBox listColor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem undoItem;
        private System.Windows.Forms.ToolStripMenuItem reduItem;
        private System.Windows.Forms.ToolStripMenuItem languageMenu;
        private System.Windows.Forms.ToolStripMenuItem languagePolish;
        private System.Windows.Forms.ToolStripMenuItem languageEnglish;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

