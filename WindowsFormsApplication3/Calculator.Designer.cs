namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.tbX = new System.Windows.Forms.TextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.bf = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bp = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.btnEraseall = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.HideSelection = false;
            this.tbX.Location = new System.Drawing.Point(12, 12);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(50, 20);
            this.tbX.TabIndex = 0;
            this.tbX.Tag = "x";
            this.tbX.Enter += new System.EventHandler(this.tbX_Enter);
            // 
            // rtbResult
            // 
            this.rtbResult.BackColor = System.Drawing.SystemColors.Info;
            this.rtbResult.Location = new System.Drawing.Point(12, 38);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(132, 48);
            this.rtbResult.TabIndex = 2;
            this.rtbResult.Text = "";
            // 
            // bf
            // 
            this.bf.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bf.Location = new System.Drawing.Point(104, 276);
            this.bf.Name = "bf";
            this.bf.Size = new System.Drawing.Size(40, 40);
            this.bf.TabIndex = 15;
            this.bf.Text = "!";
            this.bf.UseVisualStyleBackColor = true;
            this.bf.Click += new System.EventHandler(this.bf_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(12, 276);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(86, 40);
            this.b0.TabIndex = 14;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bp
            // 
            this.bp.Font = new System.Drawing.Font("Bell MT", 9.25F, System.Drawing.FontStyle.Bold);
            this.bp.Location = new System.Drawing.Point(150, 276);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(40, 40);
            this.bp.TabIndex = 16;
            this.bp.Text = "x^y";
            this.bp.UseVisualStyleBackColor = true;
            this.bp.Click += new System.EventHandler(this.bp_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(150, 230);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(40, 40);
            this.btnDiv.TabIndex = 17;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(12, 230);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(40, 40);
            this.b7.TabIndex = 11;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(58, 230);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(40, 40);
            this.b8.TabIndex = 12;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(104, 230);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(40, 40);
            this.b9.TabIndex = 13;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(150, 184);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(40, 40);
            this.btnMulti.TabIndex = 18;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(12, 184);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 40);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(58, 184);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 40);
            this.b5.TabIndex = 9;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(104, 184);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(40, 40);
            this.b6.TabIndex = 10;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(150, 138);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(40, 40);
            this.btnMinus.TabIndex = 19;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(12, 138);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(40, 40);
            this.b1.TabIndex = 5;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(58, 138);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(40, 40);
            this.b2.TabIndex = 6;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(104, 138);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 40);
            this.b3.TabIndex = 7;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(150, 92);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(40, 40);
            this.btnPlus.TabIndex = 20;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(150, 12);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(40, 74);
            this.btnResult.TabIndex = 21;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // tbY
            // 
            this.tbY.BackColor = System.Drawing.SystemColors.Window;
            this.tbY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbY.HideSelection = false;
            this.tbY.Location = new System.Drawing.Point(94, 12);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(50, 20);
            this.tbY.TabIndex = 1;
            this.tbY.Tag = "y";
            this.tbY.Enter += new System.EventHandler(this.tbY_Enter);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(71, 13);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(13, 19);
            this.lblOperation.TabIndex = 3;
            this.lblOperation.Text = " ";
            // 
            // btnEraseall
            // 
            this.btnEraseall.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEraseall.Location = new System.Drawing.Point(81, 92);
            this.btnEraseall.Name = "btnEraseall";
            this.btnEraseall.Size = new System.Drawing.Size(63, 40);
            this.btnEraseall.TabIndex = 4;
            this.btnEraseall.Text = "C";
            this.btnEraseall.UseVisualStyleBackColor = true;
            this.btnEraseall.Click += new System.EventHandler(this.btnEraseall_Click);
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Location = new System.Drawing.Point(12, 92);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(63, 40);
            this.btnErase.TabIndex = 3;
            this.btnErase.Text = "←";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "©";
            this.label1.Click += new System.EventHandler(this.lblinfo_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(202, 347);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bp);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnEraseall);
            this.Controls.Add(this.bf);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button bf;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bp;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Button btnEraseall;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Label label1;
    }
}

