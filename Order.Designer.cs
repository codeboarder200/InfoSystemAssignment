namespace InfoSystemAssignment
{
    partial class Order
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCostOfCatering = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFullBar = new System.Windows.Forms.RadioButton();
            this.radWineAndOthers = new System.Windows.Forms.RadioButton();
            this.radSoftDrinks = new System.Windows.Forms.RadioButton();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.chkWaiters = new System.Windows.Forms.CheckBox();
            this.cmbCaterType = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudNoPeople = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "POSH NOSH";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(882, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.returnToolStripMenuItem,
            this.toolStripSeparator2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Catering type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cost of catering";
            // 
            // lblCostOfCatering
            // 
            this.lblCostOfCatering.AutoSize = true;
            this.lblCostOfCatering.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostOfCatering.Location = new System.Drawing.Point(392, 502);
            this.lblCostOfCatering.Name = "lblCostOfCatering";
            this.lblCostOfCatering.Size = new System.Drawing.Size(52, 20);
            this.lblCostOfCatering.TabIndex = 7;
            this.lblCostOfCatering.Text = "R0.00";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(537, 502);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(20, 20);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSoftDrinks);
            this.groupBox1.Controls.Add(this.radWineAndOthers);
            this.groupBox1.Controls.Add(this.radFullBar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(541, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 162);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drinks service";
            // 
            // radFullBar
            // 
            this.radFullBar.AutoSize = true;
            this.radFullBar.Location = new System.Drawing.Point(44, 41);
            this.radFullBar.Name = "radFullBar";
            this.radFullBar.Size = new System.Drawing.Size(145, 24);
            this.radFullBar.TabIndex = 0;
            this.radFullBar.TabStop = true;
            this.radFullBar.Text = "Full bar service";
            this.radFullBar.UseVisualStyleBackColor = true;
            // 
            // radWineAndOthers
            // 
            this.radWineAndOthers.AutoSize = true;
            this.radWineAndOthers.Location = new System.Drawing.Point(44, 83);
            this.radWineAndOthers.Name = "radWineAndOthers";
            this.radWineAndOthers.Size = new System.Drawing.Size(224, 24);
            this.radWineAndOthers.TabIndex = 1;
            this.radWineAndOthers.TabStop = true;
            this.radWineAndOthers.Text = "Wine, malt and soft drinks";
            this.radWineAndOthers.UseVisualStyleBackColor = true;
            // 
            // radSoftDrinks
            // 
            this.radSoftDrinks.AutoSize = true;
            this.radSoftDrinks.Location = new System.Drawing.Point(44, 123);
            this.radSoftDrinks.Name = "radSoftDrinks";
            this.radSoftDrinks.Size = new System.Drawing.Size(110, 24);
            this.radSoftDrinks.TabIndex = 2;
            this.radSoftDrinks.TabStop = true;
            this.radSoftDrinks.Text = "Soft drinks";
            this.radSoftDrinks.UseVisualStyleBackColor = true;
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDelivery.Location = new System.Drawing.Point(625, 341);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(158, 24);
            this.chkDelivery.TabIndex = 10;
            this.chkDelivery.Text = "Delivery required";
            this.chkDelivery.UseVisualStyleBackColor = true;
            // 
            // chkWaiters
            // 
            this.chkWaiters.AutoSize = true;
            this.chkWaiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWaiters.Location = new System.Drawing.Point(625, 409);
            this.chkWaiters.Name = "chkWaiters";
            this.chkWaiters.Size = new System.Drawing.Size(155, 24);
            this.chkWaiters.TabIndex = 11;
            this.chkWaiters.Text = "Waiters required";
            this.chkWaiters.UseVisualStyleBackColor = true;
            // 
            // cmbCaterType
            // 
            this.cmbCaterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaterType.FormattingEnabled = true;
            this.cmbCaterType.Location = new System.Drawing.Point(287, 182);
            this.cmbCaterType.Name = "cmbCaterType";
            this.cmbCaterType.Size = new System.Drawing.Size(170, 28);
            this.cmbCaterType.TabIndex = 12;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(206, 382);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(288, 26);
            this.dtpDate.TabIndex = 13;
            // 
            // nudNoPeople
            // 
            this.nudNoPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNoPeople.Location = new System.Drawing.Point(386, 275);
            this.nudNoPeople.Name = "nudNoPeople";
            this.nudNoPeople.Size = new System.Drawing.Size(71, 26);
            this.nudNoPeople.TabIndex = 14;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 643);
            this.Controls.Add(this.nudNoPeople);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbCaterType);
            this.Controls.Add(this.chkWaiters);
            this.Controls.Add(this.chkDelivery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblCostOfCatering);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Order";
            this.Text = "Order";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCostOfCatering;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSoftDrinks;
        private System.Windows.Forms.RadioButton radWineAndOthers;
        private System.Windows.Forms.RadioButton radFullBar;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.CheckBox chkWaiters;
        private System.Windows.Forms.ComboBox cmbCaterType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudNoPeople;
    }
}