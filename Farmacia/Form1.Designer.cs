namespace Farmacia
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
            txtMedicationName = new TextBox();
            txtMedicationAmount = new TextBox();
            txtMedicationPrice = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            label5 = new Label();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMedicationName
            // 
            txtMedicationName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicationName.Location = new Point(325, 58);
            txtMedicationName.Margin = new Padding(4, 2, 4, 2);
            txtMedicationName.Name = "txtMedicationName";
            txtMedicationName.Size = new Size(201, 50);
            txtMedicationName.TabIndex = 1;
            // 
            // txtMedicationAmount
            // 
            txtMedicationAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicationAmount.Location = new Point(325, 160);
            txtMedicationAmount.Margin = new Padding(4, 2, 4, 2);
            txtMedicationAmount.Name = "txtMedicationAmount";
            txtMedicationAmount.Size = new Size(201, 50);
            txtMedicationAmount.TabIndex = 2;
            // 
            // txtMedicationPrice
            // 
            txtMedicationPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicationPrice.Location = new Point(949, 160);
            txtMedicationPrice.Margin = new Padding(4, 2, 4, 2);
            txtMedicationPrice.Name = "txtMedicationPrice";
            txtMedicationPrice.Size = new Size(201, 50);
            txtMedicationPrice.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(949, 53);
            txtDescription.Margin = new Padding(4, 2, 4, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(201, 50);
            txtDescription.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 7;
            label1.Text = "Medication Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(227, 32);
            label2.TabIndex = 8;
            label2.Text = "Medication Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(637, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 9;
            label3.Text = "Medication Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(637, 64);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(262, 32);
            label4.TabIndex = 10;
            label4.Text = "Medication Description";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(152, 798);
            btnAdd.Margin = new Padding(4, 2, 4, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(219, 45);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Medication";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(495, 798);
            btnUpdate.Margin = new Padding(4, 2, 4, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(240, 45);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update Medication";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(818, 798);
            btnDelete.Margin = new Padding(4, 2, 4, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(219, 45);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Medication";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(152, 434);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(885, 320);
            dataGridView1.TabIndex = 16;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(256, 369);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 39);
            txtSearch.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 372);
            label5.Name = "label5";
            label5.Size = new Size(97, 32);
            label5.TabIndex = 18;
            label5.Text = "Search :";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(477, 365);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 898);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtMedicationPrice);
            Controls.Add(txtMedicationAmount);
            Controls.Add(txtMedicationName);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Farmacia";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMedicationName;
        private TextBox txtMedicationAmount;
        private TextBox txtMedicationPrice;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Label label5;
        private Button btnSearch;
    }
}