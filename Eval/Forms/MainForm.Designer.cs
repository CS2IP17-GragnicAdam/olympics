namespace Eval
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichagePetitesCartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageLargesCartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentationCard1 = new Eval.Controls.PresentationCard();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichagePetitesCartesToolStripMenuItem,
            this.affichageLargesCartesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // affichagePetitesCartesToolStripMenuItem
            // 
            this.affichagePetitesCartesToolStripMenuItem.Name = "affichagePetitesCartesToolStripMenuItem";
            this.affichagePetitesCartesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.affichagePetitesCartesToolStripMenuItem.Text = "Affichage: petites  cartes";
            this.affichagePetitesCartesToolStripMenuItem.Click += new System.EventHandler(this.affichagePetitesCartesToolStripMenuItem_Click);
            // 
            // affichageLargesCartesToolStripMenuItem
            // 
            this.affichageLargesCartesToolStripMenuItem.Name = "affichageLargesCartesToolStripMenuItem";
            this.affichageLargesCartesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.affichageLargesCartesToolStripMenuItem.Text = "Affichage: larges cartes";
            this.affichageLargesCartesToolStripMenuItem.Click += new System.EventHandler(this.affichageLargesCartesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // presentationCard1
            // 
            this.presentationCard1.Dock = System.Windows.Forms.DockStyle.Right;
            this.presentationCard1.Location = new System.Drawing.Point(558, 28);
            this.presentationCard1.Name = "presentationCard1";
            this.presentationCard1.Size = new System.Drawing.Size(242, 422);
            this.presentationCard1.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(558, 422);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.presentationCard1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PresentationCard presentationCard1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichagePetitesCartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageLargesCartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}

