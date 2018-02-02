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
            this.total = new System.Windows.Forms.Label();
            this.orderTotal = new System.Windows.Forms.TextBox();
            this.cancelQuote = new System.Windows.Forms.Button();
            this.payNow = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deskPrice
            // 
            this.deskPrice.AutoSize = true;
            this.deskPrice.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskPrice.Location = new System.Drawing.Point(30, 90);
            this.deskPrice.Name = "deskPrice";
            this.deskPrice.Size = new System.Drawing.Size(122, 22);
            this.deskPrice.TabIndex = 0;
            this.deskPrice.Text = "Price per Desk";
            this.deskPrice.Click += new System.EventHandler(this.deskPrice_Click);
            // 
            // pricePerDesk
            // 
            this.pricePerDesk.Location = new System.Drawing.Point(181, 96);
            this.pricePerDesk.Name = "pricePerDesk";
            this.pricePerDesk.Size = new System.Drawing.Size(94, 20);
            this.pricePerDesk.TabIndex = 1;
            // 
            // extraFees
            // 
            this.extraFees.AutoSize = true;
            this.extraFees.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraFees.Location = new System.Drawing.Point(24, 122);
            this.extraFees.Name = "extraFees";
            this.extraFees.Size = new System.Drawing.Size(128, 22);
            this.extraFees.TabIndex = 2;
            this.extraFees.Text = "Additional fees";
            // 
            // additionalFees
            // 
            this.additionalFees.Location = new System.Drawing.Point(181, 125);
            this.additionalFees.Name = "additionalFees";
            this.additionalFees.Size = new System.Drawing.Size(94, 20);
            this.additionalFees.TabIndex = 3;
            // 
            // rushFee
            // 
            this.rushFee.AutoSize = true;
            this.rushFee.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushFee.Location = new System.Drawing.Point(64, 157);
            this.rushFee.Name = "rushFee";
            this.rushFee.Size = new System.Drawing.Size(88, 22);
            this.rushFee.TabIndex = 4;
            this.rushFee.Text = "Rush Fees";
            // 
            // rushFees
            // 
            this.rushFees.Location = new System.Drawing.Point(181, 159);
            this.rushFees.Name = "rushFees";
            this.rushFees.Size = new System.Drawing.Size(94, 20);
            this.rushFees.TabIndex = 5;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(16, 259);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(136, 33);
            this.total.TabIndex = 6;
            this.total.Text = "Order Total";
            // 
            // orderTotal
            // 
            this.orderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotal.Location = new System.Drawing.Point(181, 257);
            this.orderTotal.Name = "orderTotal";
            this.orderTotal.Size = new System.Drawing.Size(94, 32);
            this.orderTotal.TabIndex = 7;
            // 
            // cancelQuote
            // 
            this.cancelQuote.BackColor = System.Drawing.Color.Red;
            this.cancelQuote.Location = new System.Drawing.Point(249, 7);
            this.cancelQuote.Name = "cancelQuote";
            this.cancelQuote.Size = new System.Drawing.Size(48, 23);
            this.cancelQuote.TabIndex = 8;
            this.cancelQuote.Text = "cancel";
            this.cancelQuote.UseVisualStyleBackColor = false;
            this.cancelQuote.Click += new System.EventHandler(this.cancelQuote_Click);
            // 
            // payNow
            // 
            this.payNow.BackColor = System.Drawing.Color.Black;
            this.payNow.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payNow.ForeColor = System.Drawing.Color.Red;
            this.payNow.Location = new System.Drawing.Point(68, 295);
            this.payNow.Name = "payNow";
            this.payNow.Size = new System.Drawing.Size(175, 35);
            this.payNow.TabIndex = 9;
            this.payNow.Text = "Pay Now";
            this.payNow.UseVisualStyleBackColor = false;
            this.payNow.Click += new System.EventHandler(this.PayNow_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(24, 58);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(131, 22);
            this.CustomerName.TabIndex = 10;
            this.CustomerName.Text = "Customer Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(181, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(93, 20);
            this.name.TabIndex = 11;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(85, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(138, 26);
            this.title.TabIndex = 12;
            this.title.Text = "Desk Quote";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(104, 192);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 22);
            this.Date.TabIndex = 13;
            this.Date.Text = "Date";
            // 
            // today
            // 
            this.today.Location = new System.Drawing.Point(181, 195);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(93, 20);
            this.today.TabIndex = 14;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(309, 342);
            this.Controls.Add(this.today);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.title);
            this.Controls.Add(this.name);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.payNow);
            this.Controls.Add(this.cancelQuote);
            this.Controls.Add(this.orderTotal);
            this.Controls.Add(this.total);
            this.Controls.Add(this.rushFees);
            this.Controls.Add(this.rushFee);
            this.Controls.Add(this.additionalFees);
            this.Controls.Add(this.extraFees);
            this.Controls.Add(this.pricePerDesk);
            this.Controls.Add(this.deskPrice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.Load += new System.EventHandler(this.DisplayQuote_Load);
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
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox orderTotal;
        private System.Windows.Forms.Button cancelQuote;
        private System.Windows.Forms.Button payNow;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox today;
    }
}