
namespace WFA_Calculator
{
    partial class Calculator
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
            this.components = new System.ComponentModel.Container();
            this.input1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.input2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.RadioButton();
            this.btnSubtract = new System.Windows.Forms.RadioButton();
            this.btnMultiply = new System.Windows.Forms.RadioButton();
            this.btnDivide = new System.Windows.Forms.RadioButton();
            this.btnOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(22, 12);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(74, 20);
            this.input1.TabIndex = 0;
            this.input1.TextChanged += new System.EventHandler(this.input1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(146, 12);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(88, 20);
            this.input2.TabIndex = 2;
            this.input2.TextChanged += new System.EventHandler(this.input2_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(22, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 17);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TabStop = true;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.CheckedChanged += new System.EventHandler(this.btnAdd_CheckedChanged);
            // 
            // btnSubtract
            // 
            this.btnSubtract.AutoSize = true;
            this.btnSubtract.Location = new System.Drawing.Point(92, 60);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(65, 17);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.TabStop = true;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.CheckedChanged += new System.EventHandler(this.btnSubtract_CheckedChanged);
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoSize = true;
            this.btnMultiply.Location = new System.Drawing.Point(183, 60);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 17);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.TabStop = true;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.CheckedChanged += new System.EventHandler(this.btnMultiply_CheckedChanged);
            // 
            // btnDivide
            // 
            this.btnDivide.AutoSize = true;
            this.btnDivide.Location = new System.Drawing.Point(270, 60);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(55, 17);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.TabStop = true;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.CheckedChanged += new System.EventHandler(this.btnDivide_CheckedChanged);
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(22, 102);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(65, 25);
            this.btnOperation.TabIndex = 7;
            this.btnOperation.Text = "Check";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.RadioButton btnAdd;
        private System.Windows.Forms.RadioButton btnSubtract;
        private System.Windows.Forms.RadioButton btnMultiply;
        private System.Windows.Forms.RadioButton btnDivide;
        private System.Windows.Forms.Button btnOperation;
    }
}

