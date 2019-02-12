namespace D7
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
            this.labelCount = new System.Windows.Forms.Label();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(67, 52);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(50, 17);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Skaits:";
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(70, 87);
            this.inputNumber.Multiline = true;
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(225, 22);
            this.inputNumber.TabIndex = 1;
            this.inputNumber.Text = "1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(70, 127);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 26);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Pieskaitīt";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(185, 127);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(110, 26);
            this.buttonSub.TabIndex = 3;
            this.buttonSub.Text = "Atņemt";
            this.buttonSub.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(70, 159);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(225, 26);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Notīrīt";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 242);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.labelCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonCancel;
    }
}

