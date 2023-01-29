namespace IceCream
{
    partial class Form1
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
            this.comBox_Cone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddToOrder = new System.Windows.Forms.Button();
            this.lstbox_Order = new System.Windows.Forms.ListBox();
            this.checkListBox_Sprinkles = new System.Windows.Forms.CheckedListBox();
            this.comBox_Icecream = new System.Windows.Forms.ComboBox();
            this.comBox_Topping = new System.Windows.Forms.ComboBox();
            this.btn_ConfirmOrder = new System.Windows.Forms.Button();
            this.btn_ClearOrder = new System.Windows.Forms.Button();
            this.lstbox_Confirmation = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comBox_Cone
            // 
            this.comBox_Cone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox_Cone.FormattingEnabled = true;
            this.comBox_Cone.Location = new System.Drawing.Point(191, 111);
            this.comBox_Cone.Name = "comBox_Cone";
            this.comBox_Cone.Size = new System.Drawing.Size(121, 21);
            this.comBox_Cone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(32, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a cone type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(32, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select an icecream:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(32, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select a topping:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(32, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select sprinkles:";
            // 
            // btn_AddToOrder
            // 
            this.btn_AddToOrder.Location = new System.Drawing.Point(36, 365);
            this.btn_AddToOrder.Name = "btn_AddToOrder";
            this.btn_AddToOrder.Size = new System.Drawing.Size(89, 23);
            this.btn_AddToOrder.TabIndex = 7;
            this.btn_AddToOrder.Text = "Add to Order";
            this.btn_AddToOrder.UseVisualStyleBackColor = true;
            this.btn_AddToOrder.Click += new System.EventHandler(this.btn_AddToOrder_Click);
            // 
            // lstbox_Order
            // 
            this.lstbox_Order.BackColor = System.Drawing.Color.MintCream;
            this.lstbox_Order.FormattingEnabled = true;
            this.lstbox_Order.Location = new System.Drawing.Point(347, 111);
            this.lstbox_Order.Name = "lstbox_Order";
            this.lstbox_Order.Size = new System.Drawing.Size(193, 277);
            this.lstbox_Order.TabIndex = 9;
            // 
            // checkListBox_Sprinkles
            // 
            this.checkListBox_Sprinkles.BackColor = System.Drawing.Color.SeaShell;
            this.checkListBox_Sprinkles.FormattingEnabled = true;
            this.checkListBox_Sprinkles.Location = new System.Drawing.Point(192, 288);
            this.checkListBox_Sprinkles.Name = "checkListBox_Sprinkles";
            this.checkListBox_Sprinkles.Size = new System.Drawing.Size(120, 49);
            this.checkListBox_Sprinkles.TabIndex = 13;
            // 
            // comBox_Icecream
            // 
            this.comBox_Icecream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox_Icecream.FormattingEnabled = true;
            this.comBox_Icecream.Location = new System.Drawing.Point(191, 169);
            this.comBox_Icecream.Name = "comBox_Icecream";
            this.comBox_Icecream.Size = new System.Drawing.Size(121, 21);
            this.comBox_Icecream.TabIndex = 14;
            // 
            // comBox_Topping
            // 
            this.comBox_Topping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox_Topping.FormattingEnabled = true;
            this.comBox_Topping.Location = new System.Drawing.Point(191, 227);
            this.comBox_Topping.Name = "comBox_Topping";
            this.comBox_Topping.Size = new System.Drawing.Size(121, 21);
            this.comBox_Topping.TabIndex = 15;
            // 
            // btn_ConfirmOrder
            // 
            this.btn_ConfirmOrder.Location = new System.Drawing.Point(131, 365);
            this.btn_ConfirmOrder.Name = "btn_ConfirmOrder";
            this.btn_ConfirmOrder.Size = new System.Drawing.Size(89, 23);
            this.btn_ConfirmOrder.TabIndex = 17;
            this.btn_ConfirmOrder.Text = "Confirm Order";
            this.btn_ConfirmOrder.UseVisualStyleBackColor = true;
            this.btn_ConfirmOrder.Click += new System.EventHandler(this.btn_ConfirmOrder_Click);
            // 
            // btn_ClearOrder
            // 
            this.btn_ClearOrder.Location = new System.Drawing.Point(226, 365);
            this.btn_ClearOrder.Name = "btn_ClearOrder";
            this.btn_ClearOrder.Size = new System.Drawing.Size(89, 23);
            this.btn_ClearOrder.TabIndex = 18;
            this.btn_ClearOrder.Text = "Clear Order";
            this.btn_ClearOrder.UseVisualStyleBackColor = true;
            this.btn_ClearOrder.Click += new System.EventHandler(this.btn_ClearOrder_Click);
            // 
            // lstbox_Confirmation
            // 
            this.lstbox_Confirmation.BackColor = System.Drawing.Color.MintCream;
            this.lstbox_Confirmation.FormattingEnabled = true;
            this.lstbox_Confirmation.Location = new System.Drawing.Point(546, 112);
            this.lstbox_Confirmation.Name = "lstbox_Confirmation";
            this.lstbox_Confirmation.Size = new System.Drawing.Size(413, 277);
            this.lstbox_Confirmation.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(33, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(581, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Make the four selections below and press \"Add to Order\" for each icecream cone.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(28, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = " Once you\'re done, place your order by selecting \"Confirm Order\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(994, 436);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstbox_Confirmation);
            this.Controls.Add(this.btn_ClearOrder);
            this.Controls.Add(this.btn_ConfirmOrder);
            this.Controls.Add(this.comBox_Topping);
            this.Controls.Add(this.comBox_Icecream);
            this.Controls.Add(this.checkListBox_Sprinkles);
            this.Controls.Add(this.lstbox_Order);
            this.Controls.Add(this.btn_AddToOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBox_Cone);
            this.Name = "Form1";
            this.Text = "I Scream, We Scream Ice Cream Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBox_Cone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddToOrder;
        private System.Windows.Forms.ListBox lstbox_Order;
        private System.Windows.Forms.CheckedListBox checkListBox_Sprinkles;
        private System.Windows.Forms.ComboBox comBox_Icecream;
        private System.Windows.Forms.ComboBox comBox_Topping;
        private System.Windows.Forms.Button btn_ConfirmOrder;
        private System.Windows.Forms.Button btn_ClearOrder;
        private System.Windows.Forms.ListBox lstbox_Confirmation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

