namespace MyApp
{
    partial class ProductInfo
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
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPrice = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(114, 25);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 28);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 1;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "จำนวน";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(114, 68);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(125, 27);
            tbPrice.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(128, 120);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 271);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(tbPrice);
            Controls.Add(label1);
            Controls.Add(tbName);
            Name = "ProductInfo";
            Text = "ProductInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Label label2;
        private TextBox tbPrice;
        private Button button1;
    }
}