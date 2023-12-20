namespace Transfer_Market
{
    partial class PurchasePlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasePlayer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.purchasebutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(290, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 171);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // purchasebutton
            // 
            this.purchasebutton.BackColor = System.Drawing.Color.Lime;
            this.purchasebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchasebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasebutton.Location = new System.Drawing.Point(290, 282);
            this.purchasebutton.Margin = new System.Windows.Forms.Padding(2);
            this.purchasebutton.Name = "purchasebutton";
            this.purchasebutton.Size = new System.Drawing.Size(79, 34);
            this.purchasebutton.TabIndex = 1;
            this.purchasebutton.Text = "Purchase";
            this.purchasebutton.UseVisualStyleBackColor = false;
            this.purchasebutton.Click += new System.EventHandler(this.purchasebutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Crimson;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(373, 282);
            this.backbutton.Margin = new System.Windows.Forms.Padding(2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(79, 34);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // PurchasePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 466);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.purchasebutton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PurchasePlayer";
            this.Text = "PurchasePlayer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button purchasebutton;
        private System.Windows.Forms.Button backbutton;
    }
}