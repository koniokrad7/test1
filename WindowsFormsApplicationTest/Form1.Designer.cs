namespace WindowsFormsApplicationTest
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btZaznacz = new System.Windows.Forms.Button();
            this.btOdznacz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(285, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 192);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(12, 29);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(255, 192);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btZaznacz
            // 
            this.btZaznacz.Location = new System.Drawing.Point(12, 248);
            this.btZaznacz.Name = "btZaznacz";
            this.btZaznacz.Size = new System.Drawing.Size(133, 23);
            this.btZaznacz.TabIndex = 2;
            this.btZaznacz.Text = "zaznacz";
            this.btZaznacz.UseVisualStyleBackColor = true;
            // 
            // btOdznacz
            // 
            this.btOdznacz.Location = new System.Drawing.Point(151, 248);
            this.btOdznacz.Name = "btOdznacz";
            this.btOdznacz.Size = new System.Drawing.Size(116, 23);
            this.btOdznacz.TabIndex = 3;
            this.btOdznacz.Text = "odznacz";
            this.btOdznacz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 412);
            this.Controls.Add(this.btOdznacz);
            this.Controls.Add(this.btZaznacz);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btZaznacz;
        private System.Windows.Forms.Button btOdznacz;
    }
}

