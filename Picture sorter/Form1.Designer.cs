
namespace Picture_sorter
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
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblWork = new System.Windows.Forms.Label();
            txtFrom = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtTo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(110, 198);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 32);
            button1.TabIndex = 0;
            button1.Text = "DO IT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 233);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 15);
            label1.TabIndex = 1;
            label1.Text = "Currently working on... ";
            // 
            // lblWork
            // 
            lblWork.AutoSize = true;
            lblWork.Location = new System.Drawing.Point(13, 157);
            lblWork.Name = "lblWork";
            lblWork.Size = new System.Drawing.Size(0, 15);
            lblWork.TabIndex = 2;
            // 
            // txtFrom
            // 
            txtFrom.Location = new System.Drawing.Point(25, 53);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new System.Drawing.Size(284, 23);
            txtFrom.TabIndex = 3;
            txtFrom.Text = "M:\\JoNo\\Pics\\to sort";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(133, 15);
            label2.TabIndex = 4;
            label2.Text = "Start from this Directory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 15);
            label3.TabIndex = 5;
            label3.Text = "Sort to this directory";
            // 
            // txtTo
            // 
            txtTo.Location = new System.Drawing.Point(25, 111);
            txtTo.Name = "txtTo";
            txtTo.Size = new System.Drawing.Size(284, 23);
            txtTo.TabIndex = 6;
            txtTo.Text = "M:\\JoNo\\Pics\\Sorted";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(321, 417);
            Controls.Add(txtTo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFrom);
            Controls.Add(lblWork);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
    }
}

