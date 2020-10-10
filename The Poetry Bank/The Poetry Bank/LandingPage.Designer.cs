namespace The_Poetry_Bank
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.ListOfPoems = new System.Windows.Forms.ListBox();
            this.Main = new System.Windows.Forms.Panel();
            this.ButtonArea = new System.Windows.Forms.FlowLayoutPanel();
            this.ReadPoem = new System.Windows.Forms.Button();
            this.RatePoem = new System.Windows.Forms.Button();
            this.DownloadPoem = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.GroupBox();
            this.PoemInfo = new System.Windows.Forms.Label();
            this.Main.SuspendLayout();
            this.ButtonArea.SuspendLayout();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfPoems
            // 
            resources.ApplyResources(this.ListOfPoems, "ListOfPoems");
            this.ListOfPoems.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListOfPoems.FormattingEnabled = true;
            this.ListOfPoems.Name = "ListOfPoems";
            // 
            // Main
            // 
            resources.ApplyResources(this.Main, "Main");
            this.Main.Controls.Add(this.ButtonArea);
            this.Main.Controls.Add(this.Title);
            this.Main.Controls.Add(this.Info);
            this.Main.Name = "Main";
            // 
            // ButtonArea
            // 
            resources.ApplyResources(this.ButtonArea, "ButtonArea");
            this.ButtonArea.Controls.Add(this.ReadPoem);
            this.ButtonArea.Controls.Add(this.RatePoem);
            this.ButtonArea.Controls.Add(this.DownloadPoem);
            this.ButtonArea.Name = "ButtonArea";
            // 
            // ReadPoem
            // 
            resources.ApplyResources(this.ReadPoem, "ReadPoem");
            this.ReadPoem.Name = "ReadPoem";
            this.ReadPoem.UseVisualStyleBackColor = true;
            // 
            // RatePoem
            // 
            resources.ApplyResources(this.RatePoem, "RatePoem");
            this.RatePoem.Name = "RatePoem";
            this.RatePoem.UseVisualStyleBackColor = true;
            // 
            // DownloadPoem
            // 
            resources.ApplyResources(this.DownloadPoem, "DownloadPoem");
            this.DownloadPoem.Name = "DownloadPoem";
            this.DownloadPoem.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.Controls.Add(this.PoemInfo);
            this.Info.Name = "Info";
            this.Info.TabStop = false;
            // 
            // PoemInfo
            // 
            resources.ApplyResources(this.PoemInfo, "PoemInfo");
            this.PoemInfo.Name = "PoemInfo";
            // 
            // LandingPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Main);
            this.Controls.Add(this.ListOfPoems);
            this.Name = "LandingPage";
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.ButtonArea.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListOfPoems;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.FlowLayoutPanel ButtonArea;
        private System.Windows.Forms.Button ReadPoem;
        private System.Windows.Forms.Button RatePoem;
        private System.Windows.Forms.Button DownloadPoem;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.Label PoemInfo;
        private System.Windows.Forms.Label Title;
    }
}

