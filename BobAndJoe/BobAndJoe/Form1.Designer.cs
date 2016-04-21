namespace BobAndJoe
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.joeCashlabel1 = new System.Windows.Forms.Label();
            this.bobCashlabel2 = new System.Windows.Forms.Label();
            this.bankCashlabel3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGiveBobButton3 = new System.Windows.Forms.Button();
            this.bobGiveJoeButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashlabel1
            // 
            this.joeCashlabel1.AutoSize = true;
            this.joeCashlabel1.Location = new System.Drawing.Point(30, 25);
            this.joeCashlabel1.Name = "joeCashlabel1";
            this.joeCashlabel1.Size = new System.Drawing.Size(59, 12);
            this.joeCashlabel1.TabIndex = 0;
            this.joeCashlabel1.Text = "Joe has $50";
            // 
            // bobCashlabel2
            // 
            this.bobCashlabel2.AutoSize = true;
            this.bobCashlabel2.Location = new System.Drawing.Point(32, 59);
            this.bobCashlabel2.Name = "bobCashlabel2";
            this.bobCashlabel2.Size = new System.Drawing.Size(70, 12);
            this.bobCashlabel2.TabIndex = 1;
            this.bobCashlabel2.Text = "Bob has $100";
            // 
            // bankCashlabel3
            // 
            this.bankCashlabel3.AutoSize = true;
            this.bankCashlabel3.Location = new System.Drawing.Point(32, 98);
            this.bankCashlabel3.Name = "bankCashlabel3";
            this.bankCashlabel3.Size = new System.Drawing.Size(94, 12);
            this.bankCashlabel3.TabIndex = 2;
            this.bankCashlabel3.Text = "The bank has $100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive$5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGiveBobButton3
            // 
            this.joeGiveBobButton3.Location = new System.Drawing.Point(34, 248);
            this.joeGiveBobButton3.Name = "joeGiveBobButton3";
            this.joeGiveBobButton3.Size = new System.Drawing.Size(68, 47);
            this.joeGiveBobButton3.TabIndex = 5;
            this.joeGiveBobButton3.Text = "Joe gives $10 to Bob";
            this.joeGiveBobButton3.UseVisualStyleBackColor = true;
            this.joeGiveBobButton3.Click += new System.EventHandler(this.joeGiveBobButton3_Click_1);
            // 
            // bobGiveJoeButton4
            // 
            this.bobGiveJoeButton4.Location = new System.Drawing.Point(146, 248);
            this.bobGiveJoeButton4.Name = "bobGiveJoeButton4";
            this.bobGiveJoeButton4.Size = new System.Drawing.Size(77, 47);
            this.bobGiveJoeButton4.TabIndex = 6;
            this.bobGiveJoeButton4.Text = "Bob gives $5 to Joe";
            this.bobGiveJoeButton4.UseVisualStyleBackColor = true;
            this.bobGiveJoeButton4.Click += new System.EventHandler(this.bobGiveJoeButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 346);
            this.Controls.Add(this.bobGiveJoeButton4);
            this.Controls.Add(this.joeGiveBobButton3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashlabel3);
            this.Controls.Add(this.bobCashlabel2);
            this.Controls.Add(this.joeCashlabel1);
            this.Name = "Form1";
            this.Text = "Fun with john and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashlabel1;
        private System.Windows.Forms.Label bobCashlabel2;
        private System.Windows.Forms.Label bankCashlabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGiveBobButton3;
        private System.Windows.Forms.Button bobGiveJoeButton4;
    }
}

