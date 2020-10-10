namespace The_Poetry_Bank
{
    partial class PoemViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoemViewer));
            this.Title = new System.Windows.Forms.Label();
            this.Poem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(306, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(87, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "A Poem";
            // 
            // Poem
            // 
            this.Poem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poem.Location = new System.Drawing.Point(12, 34);
            this.Poem.Name = "Poem";
            this.Poem.Size = new System.Drawing.Size(693, 589);
            this.Poem.TabIndex = 1;
            this.Poem.Text = "This is the poem";
            // 
            // PoemViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 634);
            this.Controls.Add(this.Poem);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PoemViewer";
            this.Text = "Poem Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Poem;
    }
}