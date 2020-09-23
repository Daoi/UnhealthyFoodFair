namespace WindowsFormsApp11
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemKey = new System.Windows.Forms.TextBox();
            this.btnEnterItemKey = new System.Windows.Forms.Button();
            this.btnEnterItemCount = new System.Windows.Forms.Button();
            this.txtItemOrderCount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnMoreToOrder = new System.Windows.Forms.Button();
            this.btnAllDone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(235, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(62, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "lblWelcome";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(142, 77);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(90, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Order ->";
            // 
            // txtItemKey
            // 
            this.txtItemKey.Location = new System.Drawing.Point(142, 138);
            this.txtItemKey.Name = "txtItemKey";
            this.txtItemKey.Size = new System.Drawing.Size(100, 20);
            this.txtItemKey.TabIndex = 3;
            // 
            // btnEnterItemKey
            // 
            this.btnEnterItemKey.Location = new System.Drawing.Point(127, 109);
            this.btnEnterItemKey.Name = "btnEnterItemKey";
            this.btnEnterItemKey.Size = new System.Drawing.Size(125, 23);
            this.btnEnterItemKey.TabIndex = 4;
            this.btnEnterItemKey.Text = "Enter Item Key Below";
            this.btnEnterItemKey.UseVisualStyleBackColor = true;
            // 
            // btnEnterItemCount
            // 
            this.btnEnterItemCount.Location = new System.Drawing.Point(332, 108);
            this.btnEnterItemCount.Name = "btnEnterItemCount";
            this.btnEnterItemCount.Size = new System.Drawing.Size(141, 23);
            this.btnEnterItemCount.TabIndex = 5;
            this.btnEnterItemCount.Text = "Enter Item Order Count Below";
            this.btnEnterItemCount.UseVisualStyleBackColor = true;
            // 
            // txtItemOrderCount
            // 
            this.txtItemOrderCount.Location = new System.Drawing.Point(348, 137);
            this.txtItemOrderCount.Name = "txtItemOrderCount";
            this.txtItemOrderCount.Size = new System.Drawing.Size(100, 20);
            this.txtItemOrderCount.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // btnMoreToOrder
            // 
            this.btnMoreToOrder.Location = new System.Drawing.Point(159, 320);
            this.btnMoreToOrder.Name = "btnMoreToOrder";
            this.btnMoreToOrder.Size = new System.Drawing.Size(75, 23);
            this.btnMoreToOrder.TabIndex = 8;
            this.btnMoreToOrder.Text = "Order More";
            this.btnMoreToOrder.UseVisualStyleBackColor = true;
            this.btnMoreToOrder.Click += new System.EventHandler(this.btnMoreToOrder_Click);
            // 
            // btnAllDone
            // 
            this.btnAllDone.Location = new System.Drawing.Point(261, 320);
            this.btnAllDone.Name = "btnAllDone";
            this.btnAllDone.Size = new System.Drawing.Size(75, 23);
            this.btnAllDone.TabIndex = 9;
            this.btnAllDone.Text = "All Done";
            this.btnAllDone.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(474, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Item to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAllDone);
            this.Controls.Add(this.btnMoreToOrder);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtItemOrderCount);
            this.Controls.Add(this.btnEnterItemCount);
            this.Controls.Add(this.btnEnterItemKey);
            this.Controls.Add(this.txtItemKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemKey;
        private System.Windows.Forms.Button btnEnterItemKey;
        private System.Windows.Forms.Button btnEnterItemCount;
        private System.Windows.Forms.TextBox txtItemOrderCount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnMoreToOrder;
        private System.Windows.Forms.Button btnAllDone;
        private System.Windows.Forms.Button btnAdd;
    }
}

