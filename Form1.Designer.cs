namespace TradingApp
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
            this.components = new System.ComponentModel.Container();
            this.binanceBox = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kucoinBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bybitBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // binanceBox
            // 
            this.binanceBox.Location = new System.Drawing.Point(75, 93);
            this.binanceBox.Name = "binanceBox";
            this.binanceBox.ReadOnly = true;
            this.binanceBox.Size = new System.Drawing.Size(367, 23);
            this.binanceBox.TabIndex = 1;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.header.Location = new System.Drawing.Point(122, 19);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(281, 37);
            this.header.TabIndex = 2;
            this.header.Text = "Курсы пары BTCUSDT";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kucoin";
            // 
            // kucoinBox
            // 
            this.kucoinBox.Location = new System.Drawing.Point(75, 170);
            this.kucoinBox.Name = "kucoinBox";
            this.kucoinBox.ReadOnly = true;
            this.kucoinBox.Size = new System.Drawing.Size(367, 23);
            this.kucoinBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bybit";
            // 
            // bybitBox
            // 
            this.bybitBox.Location = new System.Drawing.Point(75, 245);
            this.bybitBox.Name = "bybitBox";
            this.bybitBox.ReadOnly = true;
            this.bybitBox.Size = new System.Drawing.Size(367, 23);
            this.bybitBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bybitBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kucoinBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.binanceBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox binanceBox;
        private Label header;
        private Label label2;
        private Label label3;
        private TextBox kucoinBox;
        private Label label4;
        private TextBox bybitBox;
        private System.Windows.Forms.Timer timer1;
    }
}