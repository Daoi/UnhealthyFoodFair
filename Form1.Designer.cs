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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnMoreToOrder = new System.Windows.Forms.Button();
            this.btnAllDone = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnName = new System.Windows.Forms.Button();
            this.pnlControlButtons = new System.Windows.Forms.Panel();
            this.pnlOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(194, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(265, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Not-So-Good-For-You Food Fair \r\nPlease tell us your name and then comp" +
    "lete your order!";
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // btnMoreToOrder
            // 
            this.btnMoreToOrder.Enabled = false;
            this.btnMoreToOrder.Location = new System.Drawing.Point(140, 11);
            this.btnMoreToOrder.Name = "btnMoreToOrder";
            this.btnMoreToOrder.Size = new System.Drawing.Size(75, 23);
            this.btnMoreToOrder.TabIndex = 8;
            this.btnMoreToOrder.Text = "Order More";
            this.btnMoreToOrder.UseVisualStyleBackColor = true;
            this.btnMoreToOrder.Click += new System.EventHandler(this.btnMoreToOrder_Click);
            // 
            // btnAllDone
            // 
            this.btnAllDone.Location = new System.Drawing.Point(221, 11);
            this.btnAllDone.Name = "btnAllDone";
            this.btnAllDone.Size = new System.Drawing.Size(75, 23);
            this.btnAllDone.TabIndex = 9;
            this.btnAllDone.Text = "All Done";
            this.btnAllDone.UseVisualStyleBackColor = true;
            this.btnAllDone.Click += new System.EventHandler(this.btnAllDone_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 97);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(584, 39);
            this.lblInstructions.TabIndex = 14;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            this.lblInstructions.Visible = false;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(345, 71);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 16;
            this.btnName.Text = "Enter";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // pnlControlButtons
            // 
            this.pnlControlButtons.Controls.Add(this.btnMoreToOrder);
            this.pnlControlButtons.Controls.Add(this.btnAllDone);
            this.pnlControlButtons.Location = new System.Drawing.Point(487, 412);
            this.pnlControlButtons.Name = "pnlControlButtons";
            this.pnlControlButtons.Size = new System.Drawing.Size(301, 37);
            this.pnlControlButtons.TabIndex = 17;
            this.pnlControlButtons.Visible = false;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Location = new System.Drawing.Point(15, 139);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(773, 267);
            this.pnlOrder.TabIndex = 18;
            this.pnlOrder.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.pnlControlButtons);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnMoreToOrder;
        private System.Windows.Forms.Button btnAllDone;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Panel pnlControlButtons;
        private System.Windows.Forms.FlowLayoutPanel pnlOrder;
    }
}

