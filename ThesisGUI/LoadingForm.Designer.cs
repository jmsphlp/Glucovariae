
namespace ThesisGUI
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingBar = new System.Windows.Forms.Panel();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Enabled = true;
            this.LoadingTimer.Interval = 10;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.loadingBar);
            this.loadingPanel.Location = new System.Drawing.Point(0, 280);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(480, 20);
            this.loadingPanel.TabIndex = 0;
            // 
            // loadingBar
            // 
            this.loadingBar.BackColor = System.Drawing.Color.White;
            this.loadingBar.Location = new System.Drawing.Point(0, 0);
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(0, 20);
            this.loadingBar.TabIndex = 0;
            // 
            // logoImage
            // 
            this.logoImage.Image = global::ThesisGUI.Properties.Resources.glucovariae_logo_full;
            this.logoImage.Location = new System.Drawing.Point(40, 30);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(400, 220);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 1;
            this.logoImage.TabStop = false;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.loadingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.loadingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.Panel loadingBar;
        private System.Windows.Forms.PictureBox logoImage;
    }
}

