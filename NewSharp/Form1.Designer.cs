
namespace NewSharp
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
            this.maintab = new System.Windows.Forms.TabControl();
            this.tbdash = new System.Windows.Forms.TabPage();
            this.tbdentry = new System.Windows.Forms.TabPage();
            this.tdMasters = new System.Windows.Forms.TabPage();
            this.tdreport = new System.Windows.Forms.TabPage();
            this.tdsetting = new System.Windows.Forms.TabPage();
            this.tdUtilities = new System.Windows.Forms.TabPage();
            this.tdhelp = new System.Windows.Forms.TabPage();
            this.tdDataMerge = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.maintab.SuspendLayout();
            this.SuspendLayout();
            // 
            // maintab
            // 
            this.maintab.Controls.Add(this.tbdash);
            this.maintab.Controls.Add(this.tbdentry);
            this.maintab.Controls.Add(this.tdMasters);
            this.maintab.Controls.Add(this.tdreport);
            this.maintab.Controls.Add(this.tdsetting);
            this.maintab.Controls.Add(this.tdUtilities);
            this.maintab.Controls.Add(this.tdhelp);
            this.maintab.Controls.Add(this.tdDataMerge);
            this.maintab.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintab.HotTrack = true;
            this.maintab.ItemSize = new System.Drawing.Size(100, 30);
            this.maintab.Location = new System.Drawing.Point(1, 121);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Drawing.Point(43, 3);
            this.maintab.SelectedIndex = 0;
            this.maintab.Size = new System.Drawing.Size(2050, 750);
            this.maintab.TabIndex = 0;
            // 
            // tbdash
            // 
            this.tbdash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.tbdash.Location = new System.Drawing.Point(4, 34);
            this.tbdash.Name = "tbdash";
            this.tbdash.Padding = new System.Windows.Forms.Padding(3);
            this.tbdash.Size = new System.Drawing.Size(2042, 712);
            this.tbdash.TabIndex = 0;
            this.tbdash.Text = "Home (Alt+H)";
            this.tbdash.Click += new System.EventHandler(this.tbdash_Click);
            // 
            // tbdentry
            // 
            this.tbdentry.Location = new System.Drawing.Point(4, 34);
            this.tbdentry.Name = "tbdentry";
            this.tbdentry.Padding = new System.Windows.Forms.Padding(3);
            this.tbdentry.Size = new System.Drawing.Size(2042, 712);
            this.tbdentry.TabIndex = 1;
            this.tbdentry.Text = "Data Entry(Alt+D)";
            this.tbdentry.UseVisualStyleBackColor = true;
            this.tbdentry.Click += new System.EventHandler(this.tbdentry_Click);
            // 
            // tdMasters
            // 
            this.tdMasters.Location = new System.Drawing.Point(4, 34);
            this.tdMasters.Name = "tdMasters";
            this.tdMasters.Size = new System.Drawing.Size(2042, 712);
            this.tdMasters.TabIndex = 2;
            this.tdMasters.Text = "Masters(Alt+M)";
            this.tdMasters.UseVisualStyleBackColor = true;
            this.tdMasters.Click += new System.EventHandler(this.tdMasters_Click);
            // 
            // tdreport
            // 
            this.tdreport.Location = new System.Drawing.Point(4, 34);
            this.tdreport.Name = "tdreport";
            this.tdreport.Size = new System.Drawing.Size(2042, 712);
            this.tdreport.TabIndex = 3;
            this.tdreport.Text = "Report(Alt+R)";
            this.tdreport.UseVisualStyleBackColor = true;
            this.tdreport.Click += new System.EventHandler(this.tdreport_Click);
            // 
            // tdsetting
            // 
            this.tdsetting.Location = new System.Drawing.Point(4, 34);
            this.tdsetting.Name = "tdsetting";
            this.tdsetting.Size = new System.Drawing.Size(2042, 712);
            this.tdsetting.TabIndex = 4;
            this.tdsetting.Text = "Setting(Alt+E)";
            this.tdsetting.UseVisualStyleBackColor = true;
            this.tdsetting.Click += new System.EventHandler(this.tdsetting_Click);
            // 
            // tdUtilities
            // 
            this.tdUtilities.Location = new System.Drawing.Point(4, 34);
            this.tdUtilities.Name = "tdUtilities";
            this.tdUtilities.Size = new System.Drawing.Size(2042, 712);
            this.tdUtilities.TabIndex = 5;
            this.tdUtilities.Text = "Utilities(Alt+U)";
            this.tdUtilities.UseVisualStyleBackColor = true;
            // 
            // tdhelp
            // 
            this.tdhelp.Location = new System.Drawing.Point(4, 34);
            this.tdhelp.Name = "tdhelp";
            this.tdhelp.Size = new System.Drawing.Size(2042, 712);
            this.tdhelp.TabIndex = 6;
            this.tdhelp.Text = "Help(Alt+F1)";
            this.tdhelp.UseVisualStyleBackColor = true;
            this.tdhelp.Click += new System.EventHandler(this.tdhelp_Click);
            // 
            // tdDataMerge
            // 
            this.tdDataMerge.Location = new System.Drawing.Point(4, 34);
            this.tdDataMerge.Name = "tdDataMerge";
            this.tdDataMerge.Size = new System.Drawing.Size(2042, 712);
            this.tdDataMerge.TabIndex = 7;
            this.tdDataMerge.Text = "DataMerge(Alt+A)";
            this.tdDataMerge.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1663, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 32);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(1591, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1859, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sign Up!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maintab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.maintab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TabControl maintab;
        internal System.Windows.Forms.TabPage tbdash;
        private System.Windows.Forms.TabPage tbdentry;
        private System.Windows.Forms.TabPage tdMasters;
        private System.Windows.Forms.TabPage tdreport;
        private System.Windows.Forms.TabPage tdsetting;
        private System.Windows.Forms.TabPage tdUtilities;
        private System.Windows.Forms.TabPage tdhelp;
        private System.Windows.Forms.TabPage tdDataMerge;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

