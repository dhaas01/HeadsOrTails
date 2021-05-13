namespace Heads_or_Tails
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showHeads = new System.Windows.Forms.Label();
            this.showTails = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.headsCoin = new System.Windows.Forms.PictureBox();
            this.tailsCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headsCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // showHeads
            // 
            this.showHeads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showHeads.Location = new System.Drawing.Point(218, 197);
            this.showHeads.Name = "showHeads";
            this.showHeads.Size = new System.Drawing.Size(77, 39);
            this.showHeads.TabIndex = 0;
            this.showHeads.Text = "Show Heads";
            this.showHeads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showHeads.Click += new System.EventHandler(this.ShowHeads_Click);
            // 
            // showTails
            // 
            this.showTails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showTails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTails.Location = new System.Drawing.Point(325, 198);
            this.showTails.Name = "showTails";
            this.showTails.Size = new System.Drawing.Size(78, 38);
            this.showTails.TabIndex = 1;
            this.showTails.Text = "Show Tails";
            this.showTails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showTails.Click += new System.EventHandler(this.ShowTails_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(432, 198);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(75, 38);
            this.exitLabel.TabIndex = 2;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // headsCoin
            // 
            this.headsCoin.Image = ((System.Drawing.Image)(resources.GetObject("headsCoin.Image")));
            this.headsCoin.Location = new System.Drawing.Point(208, 54);
            this.headsCoin.Name = "headsCoin";
            this.headsCoin.Size = new System.Drawing.Size(100, 140);
            this.headsCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsCoin.TabIndex = 3;
            this.headsCoin.TabStop = false;
            // 
            // tailsCoin
            // 
            this.tailsCoin.Image = ((System.Drawing.Image)(resources.GetObject("tailsCoin.Image")));
            this.tailsCoin.Location = new System.Drawing.Point(314, 55);
            this.tailsCoin.Name = "tailsCoin";
            this.tailsCoin.Size = new System.Drawing.Size(100, 140);
            this.tailsCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsCoin.TabIndex = 4;
            this.tailsCoin.TabStop = false;
            this.tailsCoin.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tailsCoin);
            this.Controls.Add(this.headsCoin);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.showTails);
            this.Controls.Add(this.showHeads);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.headsCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label showHeads;
        private System.Windows.Forms.Label showTails;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox headsCoin;
        private System.Windows.Forms.PictureBox tailsCoin;
    }
}

