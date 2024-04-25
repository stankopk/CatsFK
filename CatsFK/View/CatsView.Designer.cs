namespace CatsFK.View
{
    partial class CatsView
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
            this.dgvCats = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCats
            // 
            this.dgvCats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCats.Location = new System.Drawing.Point(26, 26);
            this.dgvCats.Name = "dgvCats";
            this.dgvCats.RowHeadersWidth = 62;
            this.dgvCats.RowTemplate.Height = 28;
            this.dgvCats.Size = new System.Drawing.Size(483, 206);
            this.dgvCats.TabIndex = 0;
            // 
            // CatsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCats);
            this.Name = "CatsView";
            this.Text = "CatsView";
            this.Load += new System.EventHandler(this.CatsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCats;
    }
}