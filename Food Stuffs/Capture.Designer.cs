
namespace Food_Stuffs
{
    partial class Capture
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
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStudentClass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(12, 136);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(119, 151);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(177, 136);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(119, 151);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(341, 136);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(119, 151);
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(495, 136);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(119, 151);
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ready _ _ _";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Class";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(113, 54);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(348, 22);
            this.txtFullName.TabIndex = 7;
            // 
            // txtStudentClass
            // 
            this.txtStudentClass.Location = new System.Drawing.Point(113, 93);
            this.txtStudentClass.Name = "txtStudentClass";
            this.txtStudentClass.Size = new System.Drawing.Size(348, 22);
            this.txtStudentClass.TabIndex = 8;
            // 
            // Capture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.txtStudentClass);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.Picture);
            this.Name = "Capture";
            this.Text = "Capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Capture_FormClosing);
            this.Load += new System.EventHandler(this.Capture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStudentClass;
    }
}