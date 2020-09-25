namespace Monitor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTerminal = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.buttonTerminal);
            this.panel2.Controls.Add(this.buttonQuery);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 450);
            this.panel2.TabIndex = 0;
            // 
            // buttonTerminal
            // 
            this.buttonTerminal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTerminal.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTerminal.Location = new System.Drawing.Point(0, 135);
            this.buttonTerminal.Name = "buttonTerminal";
            this.buttonTerminal.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonTerminal.Size = new System.Drawing.Size(200, 35);
            this.buttonTerminal.TabIndex = 1;
            this.buttonTerminal.Text = "Terminal";
            this.buttonTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminal.UseVisualStyleBackColor = true;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuery.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonQuery.Location = new System.Drawing.Point(0, 100);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonQuery.Size = new System.Drawing.Size(200, 35);
            this.buttonQuery.TabIndex = 1;
            this.buttonQuery.Text = "Query";
            this.buttonQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuery.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTerminal;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Panel panel1;
    }
}

