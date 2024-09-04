
namespace Food_Stuffs
{
    partial class Verify
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblStudentClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(27, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(224, 200);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(24, 215);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(40, 17);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "_ _ _";
            // 
            // lblStudentClass
            // 
            this.lblStudentClass.AutoSize = true;
            this.lblStudentClass.Location = new System.Drawing.Point(24, 254);
            this.lblStudentClass.Name = "lblStudentClass";
            this.lblStudentClass.Size = new System.Drawing.Size(40, 17);
            this.lblStudentClass.TabIndex = 2;
            this.lblStudentClass.Text = "_ _ _";
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStudentClass);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.Picture);
            this.Name = "Verify";
            this.Text = "Verify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Verify_FormClosing);
            this.Load += new System.EventHandler(this.Verify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblStudentClass;
    }
}