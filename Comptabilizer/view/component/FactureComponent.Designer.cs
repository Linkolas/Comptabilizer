﻿namespace Comptabilizer.view.component
{
    partial class FactureComponent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FacName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Avatar_Owner = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar_Owner)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(101, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 100);
            this.panel2.TabIndex = 2;
            // 
            // FacName
            // 
            this.FacName.AutoSize = true;
            this.FacName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacName.Location = new System.Drawing.Point(125, 32);
            this.FacName.Name = "FacName";
            this.FacName.Size = new System.Drawing.Size(131, 38);
            this.FacName.TabIndex = 3;
            this.FacName.Text = "FacName";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Comptabilizer.Properties.Resources._checked;
            this.pictureBox1.Location = new System.Drawing.Point(727, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Avatar_Owner
            // 
            this.Avatar_Owner.Dock = System.Windows.Forms.DockStyle.Left;
            this.Avatar_Owner.Image = global::Comptabilizer.Properties.Resources.user;
            this.Avatar_Owner.Location = new System.Drawing.Point(0, 0);
            this.Avatar_Owner.Name = "Avatar_Owner";
            this.Avatar_Owner.Padding = new System.Windows.Forms.Padding(10);
            this.Avatar_Owner.Size = new System.Drawing.Size(100, 100);
            this.Avatar_Owner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar_Owner.TabIndex = 0;
            this.Avatar_Owner.TabStop = false;
            this.Avatar_Owner.Click += new System.EventHandler(this.Avatar_Owner_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Value);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(560, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 100);
            this.panel3.TabIndex = 5;
            // 
            // Value
            // 
            this.Value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Value.AutoSize = true;
            this.Value.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(19, 32);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(127, 38);
            this.Value.TabIndex = 0;
            this.Value.Text = "1000,00E";
            // 
            // FactureComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FacName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Avatar_Owner);
            this.Name = "FactureComponent";
            this.Size = new System.Drawing.Size(827, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar_Owner)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Avatar_Owner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FacName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Value;
    }
}