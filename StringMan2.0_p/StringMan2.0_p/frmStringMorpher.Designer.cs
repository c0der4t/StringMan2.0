
namespace StringMan2._0_p
{
    partial class frmStringMorpher
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lstboxCommandQueue = new System.Windows.Forms.ListBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grpbxAddCommand = new System.Windows.Forms.GroupBox();
            this.chckbxProcessLive = new System.Windows.Forms.CheckBox();
            this.tabctrlAvailableCommands = new System.Windows.Forms.TabControl();
            this.tabReplace = new System.Windows.Forms.TabPage();
            this.tabRemove = new System.Windows.Forms.TabPage();
            this.tabSequence = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddCommand_Remove = new System.Windows.Forms.Label();
            this.lblAddCommand_Replace = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpbxAddCommand.SuspendLayout();
            this.tabctrlAvailableCommands.SuspendLayout();
            this.tabReplace.SuspendLayout();
            this.tabRemove.SuspendLayout();
            this.tabSequence.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(729, 218);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(15, 415);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(729, 218);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // lstboxCommandQueue
            // 
            this.lstboxCommandQueue.FormattingEnabled = true;
            this.lstboxCommandQueue.Location = new System.Drawing.Point(398, 12);
            this.lstboxCommandQueue.Name = "lstboxCommandQueue";
            this.lstboxCommandQueue.Size = new System.Drawing.Size(346, 173);
            this.lstboxCommandQueue.TabIndex = 8;
            // 
            // btnProcess
            // 
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(668, 639);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(76, 28);
            this.btnProcess.TabIndex = 9;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 647);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(337, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to send the output to another utility for additional processing";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbxAddCommand
            // 
            this.grpbxAddCommand.Controls.Add(this.tabctrlAvailableCommands);
            this.grpbxAddCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxAddCommand.Location = new System.Drawing.Point(15, 12);
            this.grpbxAddCommand.Name = "grpbxAddCommand";
            this.grpbxAddCommand.Size = new System.Drawing.Size(377, 173);
            this.grpbxAddCommand.TabIndex = 13;
            this.grpbxAddCommand.TabStop = false;
            this.grpbxAddCommand.Text = "Add a morphing command";
            // 
            // chckbxProcessLive
            // 
            this.chckbxProcessLive.AutoSize = true;
            this.chckbxProcessLive.Location = new System.Drawing.Point(464, 647);
            this.chckbxProcessLive.Name = "chckbxProcessLive";
            this.chckbxProcessLive.Size = new System.Drawing.Size(198, 17);
            this.chckbxProcessLive.TabIndex = 14;
            this.chckbxProcessLive.Text = "Enable live processing of commands";
            this.chckbxProcessLive.UseVisualStyleBackColor = true;
            // 
            // tabctrlAvailableCommands
            // 
            this.tabctrlAvailableCommands.Controls.Add(this.tabReplace);
            this.tabctrlAvailableCommands.Controls.Add(this.tabRemove);
            this.tabctrlAvailableCommands.Controls.Add(this.tabSequence);
            this.tabctrlAvailableCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlAvailableCommands.Location = new System.Drawing.Point(3, 17);
            this.tabctrlAvailableCommands.Name = "tabctrlAvailableCommands";
            this.tabctrlAvailableCommands.SelectedIndex = 0;
            this.tabctrlAvailableCommands.Size = new System.Drawing.Size(371, 153);
            this.tabctrlAvailableCommands.TabIndex = 0;
            // 
            // tabReplace
            // 
            this.tabReplace.Controls.Add(this.textBox3);
            this.tabReplace.Controls.Add(this.textBox4);
            this.tabReplace.Controls.Add(this.label5);
            this.tabReplace.Controls.Add(this.label6);
            this.tabReplace.Controls.Add(this.lblAddCommand_Replace);
            this.tabReplace.Location = new System.Drawing.Point(4, 24);
            this.tabReplace.Name = "tabReplace";
            this.tabReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabReplace.Size = new System.Drawing.Size(363, 125);
            this.tabReplace.TabIndex = 0;
            this.tabReplace.Text = "Replace";
            this.tabReplace.UseVisualStyleBackColor = true;
            // 
            // tabRemove
            // 
            this.tabRemove.Controls.Add(this.lblAddCommand_Remove);
            this.tabRemove.Controls.Add(this.label4);
            this.tabRemove.Controls.Add(this.textBox2);
            this.tabRemove.Controls.Add(this.textBox1);
            this.tabRemove.Controls.Add(this.label3);
            this.tabRemove.Controls.Add(this.label2);
            this.tabRemove.Location = new System.Drawing.Point(4, 24);
            this.tabRemove.Name = "tabRemove";
            this.tabRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemove.Size = new System.Drawing.Size(363, 125);
            this.tabRemove.TabIndex = 1;
            this.tabRemove.Text = "Remove";
            this.tabRemove.UseVisualStyleBackColor = true;
            // 
            // tabSequence
            // 
            this.tabSequence.Controls.Add(this.label1);
            this.tabSequence.Location = new System.Drawing.Point(4, 24);
            this.tabSequence.Name = "tabSequence";
            this.tabSequence.Size = new System.Drawing.Size(363, 125);
            this.tabSequence.TabIndex = 2;
            this.tabSequence.Text = "Sequence";
            this.tabSequence.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coming Soon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Remove all after :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Remove all before :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "HINT : By using both after and before you achieve a between";
            // 
            // lblAddCommand_Remove
            // 
            this.lblAddCommand_Remove.AutoSize = true;
            this.lblAddCommand_Remove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddCommand_Remove.Location = new System.Drawing.Point(323, 105);
            this.lblAddCommand_Remove.Name = "lblAddCommand_Remove";
            this.lblAddCommand_Remove.Size = new System.Drawing.Size(34, 17);
            this.lblAddCommand_Remove.TabIndex = 5;
            this.lblAddCommand_Remove.Text = "ADD";
            // 
            // lblAddCommand_Replace
            // 
            this.lblAddCommand_Replace.AutoSize = true;
            this.lblAddCommand_Replace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddCommand_Replace.Location = new System.Drawing.Point(326, 105);
            this.lblAddCommand_Replace.Name = "lblAddCommand_Replace";
            this.lblAddCommand_Replace.Size = new System.Drawing.Size(34, 17);
            this.lblAddCommand_Replace.TabIndex = 6;
            this.lblAddCommand_Replace.Text = "ADD";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 21);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 21);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Replace With";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "To Replace";
            // 
            // frmStringMorpher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 674);
            this.Controls.Add(this.chckbxProcessLive);
            this.Controls.Add(this.grpbxAddCommand);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lstboxCommandQueue);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmStringMorpher";
            this.Text = "String Morpher";
            this.Load += new System.EventHandler(this.frmStringMorpher_Load);
            this.grpbxAddCommand.ResumeLayout(false);
            this.tabctrlAvailableCommands.ResumeLayout(false);
            this.tabReplace.ResumeLayout(false);
            this.tabReplace.PerformLayout();
            this.tabRemove.ResumeLayout(false);
            this.tabRemove.PerformLayout();
            this.tabSequence.ResumeLayout(false);
            this.tabSequence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListBox lstboxCommandQueue;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox grpbxAddCommand;
        private System.Windows.Forms.CheckBox chckbxProcessLive;
        private System.Windows.Forms.TabControl tabctrlAvailableCommands;
        private System.Windows.Forms.TabPage tabReplace;
        private System.Windows.Forms.TabPage tabRemove;
        private System.Windows.Forms.TabPage tabSequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddCommand_Remove;
        private System.Windows.Forms.Label lblAddCommand_Replace;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}