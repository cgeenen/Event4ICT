namespace Event4ICT
{
    partial class MaterialBerheerForm
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
            this.pbMaterial = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMaterial
            // 
            this.pbMaterial.Location = new System.Drawing.Point(351, 300);
            this.pbMaterial.Name = "pbMaterial";
            this.pbMaterial.Size = new System.Drawing.Size(176, 148);
            this.pbMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaterial.TabIndex = 7;
            this.pbMaterial.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(210, 300);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(210, 345);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // MaterialBerheerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 472);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pbMaterial);
            this.Name = "MaterialBerheerForm";
            this.Text = "MaterialBerheerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMaterial;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnUpload;

    }
}