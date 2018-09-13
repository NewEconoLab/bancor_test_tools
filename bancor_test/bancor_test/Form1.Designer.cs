namespace bancor_test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.butRin = new System.Windows.Forms.Button();
            this.butRout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.butGetP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.butReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(151, 34);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 21);
            this.txtR.TabIndex = 0;
            this.txtR.Text = "2000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "R-准备金代币余额";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "S-智能代币供应量";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(151, 77);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 21);
            this.txtS.TabIndex = 2;
            this.txtS.Text = "100000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "F-恒定准备金率";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(151, 118);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 21);
            this.txtF.TabIndex = 4;
            this.txtF.Text = "0.02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-准备金变动";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(151, 184);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(100, 21);
            this.txtE.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "T-智能代币变动";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(151, 279);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 21);
            this.txtT.TabIndex = 8;
            // 
            // butRin
            // 
            this.butRin.Location = new System.Drawing.Point(286, 182);
            this.butRin.Name = "butRin";
            this.butRin.Size = new System.Drawing.Size(75, 23);
            this.butRin.TabIndex = 10;
            this.butRin.Text = "存入准备金";
            this.butRin.UseVisualStyleBackColor = true;
            this.butRin.Click += new System.EventHandler(this.butRin_Click);
            // 
            // butRout
            // 
            this.butRout.Location = new System.Drawing.Point(286, 277);
            this.butRout.Name = "butRout";
            this.butRout.Size = new System.Drawing.Size(94, 23);
            this.butRout.TabIndex = 11;
            this.butRout.Text = "清算智能代币";
            this.butRout.UseVisualStyleBackColor = true;
            this.butRout.Click += new System.EventHandler(this.butRout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "P-智能代币价格";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(151, 356);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 21);
            this.txtP.TabIndex = 12;
            // 
            // butGetP
            // 
            this.butGetP.Location = new System.Drawing.Point(286, 354);
            this.butGetP.Name = "butGetP";
            this.butGetP.Size = new System.Drawing.Size(116, 23);
            this.butGetP.TabIndex = 14;
            this.butGetP.Text = "计算智能代币价格";
            this.butGetP.UseVisualStyleBackColor = true;
            this.butGetP.Click += new System.EventHandler(this.butGetP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 80);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(450, 149);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 80);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(450, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(271, 80);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // butReset
            // 
            this.butReset.Location = new System.Drawing.Point(304, 74);
            this.butReset.Name = "butReset";
            this.butReset.Size = new System.Drawing.Size(75, 23);
            this.butReset.TabIndex = 18;
            this.butReset.Text = "重置";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butGetP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.butRout);
            this.Controls.Add(this.butRin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtR);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Button butRin;
        private System.Windows.Forms.Button butRout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button butGetP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button butReset;
    }
}

