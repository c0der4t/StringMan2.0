
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
            this.lblClearInput = new System.Windows.Forms.LinkLabel();
            this.lblClearOutput = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // edtLinePrefix
            // 
            this.edtLinePrefix.AcceptsTab = true;
            this.edtLinePrefix.Location = new System.Drawing.Point(12, 36);
            this.edtLinePrefix.Multiline = true;
            this.edtLinePrefix.Name = "edtLinePrefix";
            this.edtLinePrefix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtLinePrefix.Size = new System.Drawing.Size(512, 42);
            this.edtLinePrefix.TabIndex = 0;
            // 
            // edtLineSuffix
            // 
            this.edtLineSuffix.AcceptsTab = true;
            this.edtLineSuffix.Location = new System.Drawing.Point(12, 106);
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
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prefix Each Line with the Following";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suffix Each Line with the Following";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 165);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 218);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 389);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(512, 218);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // btnProcess
            // 
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(448, 625);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(76, 28);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // lblClearInput
            // 
            this.lblClearInput.AutoSize = true;
            this.lblClearInput.BackColor = System.Drawing.Color.White;
            this.lblClearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearInput.Location = new System.Drawing.Point(473, 168);
            this.lblClearInput.Name = "lblClearInput";
            this.lblClearInput.Size = new System.Drawing.Size(41, 13);
            this.lblClearInput.TabIndex = 7;
            this.lblClearInput.TabStop = true;
            this.lblClearInput.Text = "CLEAR";
            this.lblClearInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClearOutput
            // 
            this.lblClearOutput.AutoSize = true;
            this.lblClearOutput.BackColor = System.Drawing.Color.White;
            this.lblClearOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearOutput.Location = new System.Drawing.Point(473, 392);
            this.lblClearOutput.Name = "lblClearOutput";
            this.lblClearOutput.Size = new System.Drawing.Size(41, 13);
            this.lblClearOutput.TabIndex = 8;
            this.lblClearOutput.TabStop = true;
            this.lblClearOutput.Text = "CLEAR";
            this.lblClearOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 633);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(337, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to send the output to another utility for additional processing";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStringManV1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 663);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblClearOutput);
            this.Controls.Add(this.lblClearInput);
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
        private System.Windows.Forms.LinkLabel lblClearInput;
        private System.Windows.Forms.LinkLabel lblClearOutput;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}