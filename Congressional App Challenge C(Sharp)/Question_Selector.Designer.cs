namespace Congressional_App_Challenge_C_Sharp_
{
    partial class Question_Selector
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
            this.Gobut = new System.Windows.Forms.Button();
            this.Gobox = new System.Windows.Forms.TextBox();
            this.tbl = new System.Windows.Forms.Label();
            this.tbr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gobut
            // 
            this.Gobut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gobut.Location = new System.Drawing.Point(12, 596);
            this.Gobut.Name = "Gobut";
            this.Gobut.Size = new System.Drawing.Size(61, 38);
            this.Gobut.TabIndex = 0;
            this.Gobut.Text = "GO";
            this.Gobut.UseVisualStyleBackColor = true;
            this.Gobut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gobox
            // 
            this.Gobox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gobox.Location = new System.Drawing.Point(79, 596);
            this.Gobox.Multiline = true;
            this.Gobox.Name = "Gobox";
            this.Gobox.Size = new System.Drawing.Size(61, 38);
            this.Gobox.TabIndex = 1;
            // 
            // tbl
            // 
            this.tbl.AutoSize = true;
            this.tbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbl.Location = new System.Drawing.Point(34, 9);
            this.tbl.Name = "tbl";
            this.tbl.Size = new System.Drawing.Size(16, 19);
            this.tbl.TabIndex = 6;
            this.tbl.Text = "L";
            // 
            // tbr
            // 
            this.tbr.AutoSize = true;
            this.tbr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbr.Location = new System.Drawing.Point(103, 9);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(18, 19);
            this.tbr.TabIndex = 7;
            this.tbr.Text = "R";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 570);
            this.label1.TabIndex = 8;
            this.label1.Text = "31.\r\n32.\r\n33.\r\n34.\r\n35.\r\n36.\r\n37.\r\n38.\r\n39.\r\n40.\r\n41.\r\n42.\r\n43.\r\n44.\r\n45.\r\n46.\r\n4" +
    "7.\r\n48.\r\n49.\r\n50.\r\n51.\r\n52.\r\n53.\r\n54.\r\n55.\r\n56.\r\n57.\r\n58.\r\n59.\r\n60.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 570);
            this.label2.TabIndex = 9;
            this.label2.Text = "1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n11.\r\n12.\r\n13.\r\n14.\r\n15.\r\n16.\r\n17.\r\n18.\r\n" +
    "19.\r\n20.\r\n21.\r\n22.\r\n23.\r\n24.\r\n25.\r\n26.\r\n27.\r\n28.\r\n29.\r\n30.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Question_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 646);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gobox);
            this.Controls.Add(this.Gobut);
            this.Location = new System.Drawing.Point(460, 200);
            this.Name = "Question_Selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Question_Selector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gobut;
        private System.Windows.Forms.TextBox Gobox;
        private System.Windows.Forms.Label tbl;
        private System.Windows.Forms.Label tbr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}