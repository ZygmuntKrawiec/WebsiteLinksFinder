namespace WebsiteLinksFinder
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
            this.lbl_Url = new System.Windows.Forms.Label();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.lv_Links = new System.Windows.Forms.ListView();
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLinks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_Url
            // 
            this.lbl_Url.AutoSize = true;
            this.lbl_Url.Location = new System.Drawing.Point(13, 13);
            this.lbl_Url.Name = "lbl_Url";
            this.lbl_Url.Size = new System.Drawing.Size(23, 13);
            this.lbl_Url.TabIndex = 0;
            this.lbl_Url.Text = "Url:";
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(12, 30);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(260, 20);
            this.txt_Url.TabIndex = 1;
            this.txt_Url.Text = "www.stackoverflow.com/";
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(12, 56);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // lv_Links
            // 
            this.lv_Links.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumber,
            this.colLinks});
            this.lv_Links.Location = new System.Drawing.Point(12, 85);
            this.lv_Links.Name = "lv_Links";
            this.lv_Links.Size = new System.Drawing.Size(260, 332);
            this.lv_Links.TabIndex = 3;
            this.lv_Links.UseCompatibleStateImageBehavior = false;
            this.lv_Links.View = System.Windows.Forms.View.Details;
            // 
            // colNumber
            // 
            this.colNumber.Text = "No.";
            // 
            // colLinks
            // 
            this.colLinks.Text = "Links";
            this.colLinks.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 429);
            this.Controls.Add(this.lv_Links);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.lbl_Url);
            this.Name = "Form1";
            this.Text = "Website Links Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Url;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.ListView lv_Links;
        private System.Windows.Forms.ColumnHeader colNumber;
        private System.Windows.Forms.ColumnHeader colLinks;
    }
}

