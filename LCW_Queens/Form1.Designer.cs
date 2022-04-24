namespace LCW_Queens
{
    partial class NQueensMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumQueens = new System.Windows.Forms.NumericUpDown();
            this.btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumQueens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Queens";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudNumQueens
            // 
            this.nudNumQueens.Location = new System.Drawing.Point(167, 7);
            this.nudNumQueens.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            this.nudNumQueens.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            this.nudNumQueens.Name = "nudNumQueens";
            this.nudNumQueens.Size = new System.Drawing.Size(77, 20);
            this.nudNumQueens.TabIndex = 2;
            this.nudNumQueens.Value = new decimal(new int[] { 4, 0, 0, 0 });
            this.nudNumQueens.ValueChanged += new System.EventHandler(this.nudNumQueens_ValueChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(97, 44);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(85, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // NQueensMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 79);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.nudNumQueens);
            this.Controls.Add(this.label1);
            this.Name = "NQueensMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumQueens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumQueens;
        private System.Windows.Forms.Button btnGo;
    }
}

