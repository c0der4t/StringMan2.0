
namespace StringMan2._0_p
{
    partial class frmStringManV1
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
            this.edtLinePrefix = new System.Windows.Forms.TextBox();
            this.edtLineSuffix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edtLinePrefix
            // 
            this.edtLinePrefix.AcceptsTab = true;
            this.edtLinePrefix.Location = new System.Drawing.Point(12, 29);
            this.edtLinePrefix.Multiline = true;
            this.edtLinePrefix.Name = "edtLinePrefix";
            this.edtLinePrefix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtLinePrefix.Size = new System.Drawing.Size(512, 42);
            this.edtLinePrefix.TabIndex = 0;
            // 
            // edtLineSuffix
            // 
            this.edtLineSuffix.AcceptsTab = true;
            this.edtLineSuffix.Location = new System.Drawing.Point(12, 99);
            this.edtLineSuffix.Multiline = true;
            this.edtLineSuffix.Name = "edtLineSuffix";
            this.edtLineSuffix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtLineSuffix.Size = new System.Drawing.Size(512, 42);
            this.edtLineSuffix.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prefix Each Line with the Following";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suffix Each Line with the Following";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 158);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 218);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 382);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(512, 218);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // btnProcess
            // 
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(448, 606);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(76, 28);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnClearInput
            // 
            this.btnClearInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInput.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInput.Location = new System.Drawing.Point(460, 167);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(51, 28);
            this.btnClearInput.TabIndex = 7;
            this.btnClearInput.Text = "Clear";
            this.btnClearInput.UseVisualStyleBackColor = true;
            // 
            // frmStringManV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 660);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtLineSuffix);
            this.Controls.Add(this.edtLinePrefix);
            this.Name = "frmStringManV1";
            this.Text = "frmStringManV1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtLinePrefix;
        private System.Windows.Forms.TextBox edtLineSuffix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnClearInput;
    }
}