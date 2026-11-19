namespace RevitAddinMvc
{
    partial class RevitAddinMvcForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWallCount = new System.Windows.Forms.Label();
            this.lblLevelCount = new System.Windows.Forms.Label();
            this.lblActiveView = new System.Windows.Forms.Label();
            this.lblSelectedWall = new System.Windows.Forms.Label();
            this.cboWalls = new System.Windows.Forms.ComboBox();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWallCount
            // 
            this.lblWallCount.AutoSize = true;
            this.lblWallCount.Location = new System.Drawing.Point(15, 15);
            this.lblWallCount.Name = "lblWallCount";
            this.lblWallCount.Size = new System.Drawing.Size(72, 13);
            this.lblWallCount.TabIndex = 0;
            this.lblWallCount.Text = "Wall Count:";
            // 
            // lblLevelCount
            // 
            this.lblLevelCount.AutoSize = true;
            this.lblLevelCount.Location = new System.Drawing.Point(15, 35);
            this.lblLevelCount.Name = "lblLevelCount";
            this.lblLevelCount.Size = new System.Drawing.Size(71, 13);
            this.lblLevelCount.TabIndex = 1;
            this.lblLevelCount.Text = "Level Count:";
            // 
            // lblActiveView
            // 
            this.lblActiveView.AutoSize = true;
            this.lblActiveView.Location = new System.Drawing.Point(15, 55);
            this.lblActiveView.Name = "lblActiveView";
            this.lblActiveView.Size = new System.Drawing.Size(71, 13);
            this.lblActiveView.TabIndex = 2;
            this.lblActiveView.Text = "Active View:";
            // 
            // lblSelectedWall
            // 
            this.lblSelectedWall.AutoSize = true;
            this.lblSelectedWall.Location = new System.Drawing.Point(15, 75);
            this.lblSelectedWall.Name = "lblSelectedWall";
            this.lblSelectedWall.Size = new System.Drawing.Size(77, 13);
            this.lblSelectedWall.TabIndex = 3;
            this.lblSelectedWall.Text = "Selected Wall:";
            // 
            // cboWalls
            // 
            this.cboWalls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWalls.Location = new System.Drawing.Point(120, 70);
            this.cboWalls.Name = "cboWalls";
            this.cboWalls.Size = new System.Drawing.Size(200, 21);
            this.cboWalls.TabIndex = 4;
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.Location = new System.Drawing.Point(15, 100);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Size = new System.Drawing.Size(305, 25);
            this.btnCreateNote.TabIndex = 5;
            this.btnCreateNote.Text = "Create Note at Wall Location";
            // 
            // RevitAddinMvcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 140);
            this.Controls.Add(this.btnCreateNote);
            this.Controls.Add(this.cboWalls);
            this.Controls.Add(this.lblSelectedWall);
            this.Controls.Add(this.lblActiveView);
            this.Controls.Add(this.lblLevelCount);
            this.Controls.Add(this.lblWallCount);
            this.Name = "RevitAddinMvcForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblWallCount;
        private System.Windows.Forms.Label lblLevelCount;
        private System.Windows.Forms.Label lblActiveView;
        private System.Windows.Forms.Label lblSelectedWall;
        private System.Windows.Forms.ComboBox cboWalls;
        private System.Windows.Forms.Button btnCreateNote;
    }
}