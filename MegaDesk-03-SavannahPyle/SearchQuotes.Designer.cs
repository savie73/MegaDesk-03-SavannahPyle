namespace MegaDesk_03_SavannahPyle
{
    partial class SearchQuotes
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
            this.exitSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitSearch
            // 
            this.exitSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSearch.Location = new System.Drawing.Point(53, 12);
            this.exitSearch.Name = "exitSearch";
            this.exitSearch.Size = new System.Drawing.Size(103, 46);
            this.exitSearch.TabIndex = 0;
            this.exitSearch.Text = "EXIT";
            this.exitSearch.UseVisualStyleBackColor = true;
            this.exitSearch.Click += new System.EventHandler(this.exitSearch_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 714);
            this.Controls.Add(this.exitSearch);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitSearch;
    }
}