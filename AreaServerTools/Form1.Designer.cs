
namespace AreaServerTools
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_OpenAS = new System.Windows.Forms.Button();
            this.txt_ASPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.btn_IPPatch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_OpenAS);
            this.groupBox1.Controls.Add(this.txt_ASPath);
            this.groupBox1.Location = new System.Drawing.Point(21, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the Area Server EXE";
            // 
            // btn_OpenAS
            // 
            this.btn_OpenAS.Location = new System.Drawing.Point(210, 21);
            this.btn_OpenAS.Name = "btn_OpenAS";
            this.btn_OpenAS.Size = new System.Drawing.Size(33, 23);
            this.btn_OpenAS.TabIndex = 2;
            this.btn_OpenAS.Text = "....";
            this.btn_OpenAS.UseVisualStyleBackColor = true;
            this.btn_OpenAS.Click += new System.EventHandler(this.btn_OpenAS_Click);
            // 
            // txt_ASPath
            // 
            this.txt_ASPath.Location = new System.Drawing.Point(6, 22);
            this.txt_ASPath.Name = "txt_ASPath";
            this.txt_ASPath.ReadOnly = true;
            this.txt_ASPath.Size = new System.Drawing.Size(198, 23);
            this.txt_ASPath.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_IPPatch);
            this.groupBox2.Controls.Add(this.txt_IPAddress);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patch IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "New IP Address";
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Location = new System.Drawing.Point(7, 38);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(197, 23);
            this.txt_IPAddress.TabIndex = 3;
            // 
            // btn_IPPatch
            // 
            this.btn_IPPatch.Location = new System.Drawing.Point(7, 71);
            this.btn_IPPatch.Name = "btn_IPPatch";
            this.btn_IPPatch.Size = new System.Drawing.Size(117, 23);
            this.btn_IPPatch.TabIndex = 4;
            this.btn_IPPatch.Text = "Patch Area Server";
            this.btn_IPPatch.UseVisualStyleBackColor = true;
            this.btn_IPPatch.Click += new System.EventHandler(this.btn_IPPatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 233);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Area Server Tools";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_OpenAS;
        private System.Windows.Forms.TextBox txt_ASPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IPAddress;
        private System.Windows.Forms.Button btn_IPPatch;
    }
}

