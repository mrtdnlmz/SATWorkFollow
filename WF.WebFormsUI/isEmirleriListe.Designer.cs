namespace WF.WebFormsUI
{
    partial class isEmirleriListe
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
            this.dgwisEmri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwisEmri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwisEmri
            // 
            this.dgwisEmri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwisEmri.Location = new System.Drawing.Point(12, 12);
            this.dgwisEmri.Name = "dgwisEmri";
            this.dgwisEmri.Size = new System.Drawing.Size(776, 351);
            this.dgwisEmri.TabIndex = 3;
            // 
            // isEmirleriListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwisEmri);
            this.Name = "isEmirleriListe";
            this.Text = "isEmirleriListe";
            this.Load += new System.EventHandler(this.isEmirleriListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwisEmri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwisEmri;
    }
}