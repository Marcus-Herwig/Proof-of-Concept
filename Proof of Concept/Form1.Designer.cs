
namespace Proof_of_Concept
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
            this.WriteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.dataDisplay = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addDataButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(352, 205);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(204, 80);
            this.WriteButton.TabIndex = 0;
            this.WriteButton.Text = "Load csv";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(352, 752);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(204, 75);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dataDisplay
            // 
            this.dataDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataDisplay.Location = new System.Drawing.Point(95, 306);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.ReadOnly = true;
            this.dataDisplay.Size = new System.Drawing.Size(779, 422);
            this.dataDisplay.TabIndex = 3;
            this.dataDisplay.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1136, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proof of Concept: Reading from CSV file and writing to TXT file";
            // 
            // dataInput
            // 
            this.dataInput.Location = new System.Drawing.Point(966, 478);
            this.dataInput.Name = "dataInput";
            this.dataInput.Size = new System.Drawing.Size(559, 96);
            this.dataInput.TabIndex = 5;
            this.dataInput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1005, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type the data that should be added ";
            // 
            // addDataButton
            // 
            this.addDataButton.Location = new System.Drawing.Point(1138, 619);
            this.addDataButton.Name = "addDataButton";
            this.addDataButton.Size = new System.Drawing.Size(226, 76);
            this.addDataButton.TabIndex = 7;
            this.addDataButton.Text = "Add data";
            this.addDataButton.UseVisualStyleBackColor = true;
            this.addDataButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(485, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please choose a .csv file to read from";
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(705, 205);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(183, 80);
            this.processButton.TabIndex = 9;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 925);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addDataButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDisplay);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.WriteButton);
            this.Name = "Form1";
            this.Text = "Proof of Concept ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RichTextBox dataDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox dataInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addDataButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button processButton;
    }
}

