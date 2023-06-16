namespace Eval.Controls
{
    partial class LargeCard
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInventor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Image = global::Eval.Properties.Resources.skateboarding;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox1";
            this.pictureBox.Size = new System.Drawing.Size(339, 158);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(153, 206);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(53, 16);
            this.labelOrigin.TabIndex = 2;
            this.labelOrigin.Text = "ORIGIN";
            // 
            // label2
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(153, 239);
            this.labelPeriod.Name = "label2";
            this.labelPeriod.Size = new System.Drawing.Size(58, 16);
            this.labelPeriod.TabIndex = 4;
            this.labelPeriod.Text = "PERIOD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PÉRIODE";
            // 
            // label4
            // 
            this.labelInventor.AutoSize = true;
            this.labelInventor.Location = new System.Drawing.Point(153, 268);
            this.labelInventor.Name = "labelInventor";
            this.labelInventor.Size = new System.Drawing.Size(77, 16);
            this.labelInventor.TabIndex = 6;
            this.labelInventor.Text = "INVENTOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "INVENTEUR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORIGINE";
            // 
            // label6
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(26, 331);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(98, 16);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // LargeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelInventor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Name = "LargeCard";
            this.Size = new System.Drawing.Size(339, 548);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInventor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescription;
    }
}
