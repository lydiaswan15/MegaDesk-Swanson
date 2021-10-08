
namespace MegaDesk_Swanson
{
    partial class AddQuote
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumOfDrawers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbShipping = new System.Windows.Forms.ComboBox();
            this.btnGetQuotePrice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name: ";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(346, 116);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(212, 20);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(226, 195);
            this.numWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(120, 20);
            this.numWidth.TabIndex = 3;
            this.numWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth:";
            // 
            // numDepth
            // 
            this.numDepth.Location = new System.Drawing.Point(226, 243);
            this.numDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(120, 20);
            this.numDepth.TabIndex = 5;
            this.numDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Drawers:";
            // 
            // nudNumOfDrawers
            // 
            this.nudNumOfDrawers.Location = new System.Drawing.Point(581, 195);
            this.nudNumOfDrawers.Name = "nudNumOfDrawers";
            this.nudNumOfDrawers.Size = new System.Drawing.Size(120, 20);
            this.nudNumOfDrawers.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Surface Material:";
            // 
            // cmbSurfaceMaterial
            // 
            this.cmbSurfaceMaterial.FormattingEnabled = true;
            this.cmbSurfaceMaterial.Location = new System.Drawing.Point(580, 245);
            this.cmbSurfaceMaterial.Name = "cmbSurfaceMaterial";
            this.cmbSurfaceMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbSurfaceMaterial.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Shipping:";
            // 
            // cmbShipping
            // 
            this.cmbShipping.FormattingEnabled = true;
            this.cmbShipping.Location = new System.Drawing.Point(580, 291);
            this.cmbShipping.Name = "cmbShipping";
            this.cmbShipping.Size = new System.Drawing.Size(121, 21);
            this.cmbShipping.TabIndex = 11;
            // 
            // btnGetQuotePrice
            // 
            this.btnGetQuotePrice.Location = new System.Drawing.Point(243, 370);
            this.btnGetQuotePrice.Name = "btnGetQuotePrice";
            this.btnGetQuotePrice.Size = new System.Drawing.Size(124, 49);
            this.btnGetQuotePrice.TabIndex = 12;
            this.btnGetQuotePrice.Text = "Save";
            this.btnGetQuotePrice.UseVisualStyleBackColor = true;
            this.btnGetQuotePrice.Click += new System.EventHandler(this.btnGetQuotePrice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(444, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 49);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 39);
            this.label7.TabIndex = 14;
            this.label7.Text = "Add Quote";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetQuotePrice);
            this.Controls.Add(this.cmbShipping);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSurfaceMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudNumOfDrawers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumOfDrawers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSurfaceMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbShipping;
        private System.Windows.Forms.Button btnGetQuotePrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
    }
}