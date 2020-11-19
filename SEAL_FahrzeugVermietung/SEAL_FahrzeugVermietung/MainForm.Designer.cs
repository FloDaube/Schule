namespace SEAL_FahrzeugVermietung
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Fahrzeuge = new System.Windows.Forms.Button();
            this.button_reservierungen = new System.Windows.Forms.Button();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.timer_LoadData = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_Fahrzeuge);
            this.splitContainer1.Panel1.Controls.Add(this.button_reservierungen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView_Main);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 491);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_Fahrzeuge
            // 
            this.button_Fahrzeuge.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Fahrzeuge.Location = new System.Drawing.Point(0, 50);
            this.button_Fahrzeuge.Name = "button_Fahrzeuge";
            this.button_Fahrzeuge.Size = new System.Drawing.Size(349, 50);
            this.button_Fahrzeuge.TabIndex = 1;
            this.button_Fahrzeuge.Text = "Fahrzeuge";
            this.button_Fahrzeuge.UseVisualStyleBackColor = true;
            this.button_Fahrzeuge.Click += new System.EventHandler(this.button_Fahrzeuge_Click);
            // 
            // button_reservierungen
            // 
            this.button_reservierungen.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_reservierungen.Location = new System.Drawing.Point(0, 0);
            this.button_reservierungen.Name = "button_reservierungen";
            this.button_reservierungen.Size = new System.Drawing.Size(349, 50);
            this.button_reservierungen.TabIndex = 0;
            this.button_reservierungen.Text = "Reservirungen";
            this.button_reservierungen.UseVisualStyleBackColor = true;
            this.button_reservierungen.Click += new System.EventHandler(this.button_reservierungen_Click);
            // 
            // listView_Main
            // 
            this.listView_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Main.FullRowSelect = true;
            this.listView_Main.GridLines = true;
            this.listView_Main.HideSelection = false;
            this.listView_Main.Location = new System.Drawing.Point(0, 0);
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(694, 491);
            this.listView_Main.TabIndex = 0;
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Details;
            this.listView_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ItemAreClickt);
            // 
            // timer_LoadData
            // 
            this.timer_LoadData.Tick += new System.EventHandler(this.timer_LoadData_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.neuToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öffnenToolStripMenuItem.Text = "Öffnen";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 491);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "VCM";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView_Main;
        private System.Windows.Forms.Timer timer_LoadData;
        private System.Windows.Forms.Button button_reservierungen;
        private System.Windows.Forms.Button button_Fahrzeuge;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
    }
}

