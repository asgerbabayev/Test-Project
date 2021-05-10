
namespace Matrix_From_App1
{
    partial class Form2
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
            this.txtText1 = new System.Windows.Forms.TextBox();
            this.txtText2 = new System.Windows.Forms.TextBox();
            this.btnCombine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText1
            // 
            this.txtText1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText1.Location = new System.Drawing.Point(12, 73);
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(407, 27);
            this.txtText1.TabIndex = 0;
            // 
            // txtText2
            // 
            this.txtText2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText2.Location = new System.Drawing.Point(12, 108);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(407, 27);
            this.txtText2.TabIndex = 1;
            // 
            // btnCombine
            // 
            this.btnCombine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombine.Location = new System.Drawing.Point(12, 151);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(407, 37);
            this.btnCombine.TabIndex = 2;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 210);
            this.Controls.Add(this.btnCombine);
            this.Controls.Add(this.txtText2);
            this.Controls.Add(this.txtText1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText1;
        private System.Windows.Forms.TextBox txtText2;
        private System.Windows.Forms.Button btnCombine;
    }
}