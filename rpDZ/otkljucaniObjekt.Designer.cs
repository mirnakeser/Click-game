
namespace rpDZ
{
    partial class otkljucaniObjekt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kolikoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cijenaLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(32, 29);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(35, 13);
            this.imeLabel.TabIndex = 0;
            this.imeLabel.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "You have:";
            // 
            // kolikoLabel
            // 
            this.kolikoLabel.AutoSize = true;
            this.kolikoLabel.Location = new System.Drawing.Point(94, 64);
            this.kolikoLabel.Name = "kolikoLabel";
            this.kolikoLabel.Size = new System.Drawing.Size(13, 13);
            this.kolikoLabel.TabIndex = 2;
            this.kolikoLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // cijenaLabel
            // 
            this.cijenaLabel.AutoSize = true;
            this.cijenaLabel.Location = new System.Drawing.Point(73, 100);
            this.cijenaLabel.Name = "cijenaLabel";
            this.cijenaLabel.Size = new System.Drawing.Size(13, 13);
            this.cijenaLabel.TabIndex = 4;
            this.cijenaLabel.Text = "0";
            this.cijenaLabel.Click += new System.EventHandler(this.cijenaLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(131, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(33, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // otkljucaniObjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cijenaLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kolikoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imeLabel);
            this.Name = "otkljucaniObjekt";
            this.Size = new System.Drawing.Size(278, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kolikoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cijenaLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}
