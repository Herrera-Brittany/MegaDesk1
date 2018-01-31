namespace MegaDesk_3_BrittanyHerrera
{
    partial class DisplayQuote
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
            this.deskPrice = new System.Windows.Forms.Label();
            this.pricePerDesk = new System.Windows.Forms.TextBox();
            this.extraFees = new System.Windows.Forms.Label();
            this.additionalFees = new System.Windows.Forms.TextBox();
            this.rushFee = new System.Windows.Forms.Label();
            this.rushFees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orderTotal = new System.Windows.Forms.TextBox();
            this.cancelQuote = new System.Windows.Forms.Button();
            this.payNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deskPrice
            // 
            this.deskPrice.AutoSize = true;
            this.deskPrice.Location = new System.Drawing.Point(32, 28);
            this.deskPrice.Name = "deskPrice";
            this.deskPrice.Size = new System.Drawing.Size(77, 13);
            this.deskPrice.TabIndex = 0;
            this.deskPrice.Text = "Price per Desk";
            this.deskPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // pricePerDesk
            // 
            this.pricePerDesk.Location = new System.Drawing.Point(136, 25);
            this.pricePerDesk.Name = "pricePerDesk";
            this.pricePerDesk.Size = new System.Drawing.Size(94, 20);
            this.pricePerDesk.TabIndex = 1;
            // 
            // extraFees
            // 
            this.extraFees.AutoSize = true;
            this.extraFees.Location = new System.Drawing.Point(34, 64);
            this.extraFees.Name = "extraFees";
            this.extraFees.Size = new System.Drawing.Size(76, 13);
            this.extraFees.TabIndex = 2;
            this.extraFees.Text = "Additional fees";
            // 
            // additionalFees
            // 
            this.additionalFees.Location = new System.Drawing.Point(136, 61);
            this.additionalFees.Name = "additionalFees";
            this.additionalFees.Size = new System.Drawing.Size(94, 20);
            this.additionalFees.TabIndex = 3;
            // 
            // rushFee
            // 
            this.rushFee.AutoSize = true;
            this.rushFee.Location = new System.Drawing.Point(34, 96);
            this.rushFee.Name = "rushFee";
            this.rushFee.Size = new System.Drawing.Size(58, 13);
            this.rushFee.TabIndex = 4;
            this.rushFee.Text = "Rush Fees";
            // 
            // rushFees
            // 
            this.rushFees.Location = new System.Drawing.Point(136, 96);
            this.rushFees.Name = "rushFees";
            this.rushFees.Size = new System.Drawing.Size(94, 20);
            this.rushFees.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order Total";
            // 
            // orderTotal
            // 
            this.orderTotal.Location = new System.Drawing.Point(136, 179);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(94, 20);
            this.orderTotal.TabIndex = 7;
            // 
            // cancelQuote
            // 
            this.cancelQuote.BackColor = System.Drawing.Color.Red;
            this.cancelQuote.Location = new System.Drawing.Point(236, 217);
            this.cancelQuote.Name = "cancelQuote";
            this.cancelQuote.Size = new System.Drawing.Size(48, 23);
            this.cancelQuote.TabIndex = 8;
            this.cancelQuote.Text = "cancel";
            this.cancelQuote.UseVisualStyleBackColor = false;
            this.cancelQuote.Click += new System.EventHandler(this.cancelQuote_Click);
            // 
            // payNow
            // 
            this.payNow.Location = new System.Drawing.Point(72, 217);
            this.payNow.Name = "payNow";
            this.payNow.Size = new System.Drawing.Size(144, 25);
            this.payNow.TabIndex = 9;
            this.payNow.Text = "Pay Now";
            this.payNow.UseVisualStyleBackColor = true;
            this.payNow.Click += new System.EventHandler(this.button2_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 255);
            this.Controls.Add(this.payNow);
            this.Controls.Add(this.cancelQuote);
            this.Controls.Add(this.orderTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rushFees);
            this.Controls.Add(this.rushFee);
            this.Controls.Add(this.additionalFees);
            this.Controls.Add(this.extraFees);
            this.Controls.Add(this.pricePerDesk);
            this.Controls.Add(this.deskPrice);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deskPrice;
        private System.Windows.Forms.TextBox pricePerDesk;
        private System.Windows.Forms.Label extraFees;
        private System.Windows.Forms.TextBox additionalFees;
        private System.Windows.Forms.Label rushFee;
        private System.Windows.Forms.TextBox rushFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderTotal;
        private System.Windows.Forms.Button cancelQuote;
        private System.Windows.Forms.Button payNow;
    }
}