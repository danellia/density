namespace lab1
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.labelResultText = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(13, 13);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(35, 20);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a = ";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(11, 50);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(36, 20);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "b = ";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(7, 116);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(40, 20);
            this.labelH.TabIndex = 3;
            this.labelH.Text = "m = ";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(12, 80);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(35, 20);
            this.labelM.TabIndex = 2;
            this.labelM.Text = "h = ";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(44, 13);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(125, 27);
            this.textBoxA.TabIndex = 4;
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxA_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(44, 47);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(125, 27);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxB_KeyPress);
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(44, 80);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(125, 27);
            this.textBoxH.TabIndex = 6;
            this.textBoxH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxH_KeyPress);
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(44, 113);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(125, 27);
            this.textBoxM.TabIndex = 7;
            this.textBoxM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxM_KeyPress);
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(15, 152);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(154, 29);
            this.buttonCompute.TabIndex = 8;
            this.buttonCompute.Text = "вычислить";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResultText
            // 
            this.labelResultText.AutoSize = true;
            this.labelResultText.Location = new System.Drawing.Point(263, 50);
            this.labelResultText.Name = "labelResultText";
            this.labelResultText.Size = new System.Drawing.Size(79, 20);
            this.labelResultText.TabIndex = 9;
            this.labelResultText.Text = "результат:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(252, 70);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(105, 20);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "                        ";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 200);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelResultText);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Найти плотность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Label labelResultText;
        private System.Windows.Forms.Label labelResult;
    }
}

