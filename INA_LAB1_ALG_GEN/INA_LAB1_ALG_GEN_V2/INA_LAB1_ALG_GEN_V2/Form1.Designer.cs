using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace INA_LAB1_ALG_GEN_V2
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
            txtBoundaryLeft = new TextBox();
            lblBoundary = new Label();
            txtBoundaryRight = new TextBox();
            lblPrecision = new Label();
            cmbPrecision = new ComboBox();
            txtPopulationSize = new TextBox();
            lblPopulationSize = new Label();
            lblNumberOfGenerations = new Label();
            txtNumberOfGenerations = new TextBox();
            btnCalculate = new Button();
            dataGridView1 = new DataGridView();
            Identifier = new DataGridViewTextBoxColumn();
            xReal = new DataGridViewTextBoxColumn();
            xInt = new DataGridViewTextBoxColumn();
            xBin = new DataGridViewTextBoxColumn();
            xInt2 = new DataGridViewTextBoxColumn();
            xReal2 = new DataGridViewTextBoxColumn();
            ObjectiveFunction = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBoundaryLeft
            // 
            txtBoundaryLeft.Location = new Point(23, 64);
            txtBoundaryLeft.Name = "txtBoundaryLeft";
            txtBoundaryLeft.Size = new Size(137, 47);
            txtBoundaryLeft.TabIndex = 0;
            // 
            // lblBoundary
            // 
            lblBoundary.AutoSize = true;
            lblBoundary.Location = new Point(123, 9);
            lblBoundary.Name = "lblBoundary";
            lblBoundary.Size = new Size(137, 41);
            lblBoundary.TabIndex = 1;
            lblBoundary.Text = "Przedział";
            // 
            // txtBoundaryRight
            // 
            txtBoundaryRight.Location = new Point(225, 64);
            txtBoundaryRight.Name = "txtBoundaryRight";
            txtBoundaryRight.Size = new Size(137, 47);
            txtBoundaryRight.TabIndex = 2;
            // 
            // lblPrecision
            // 
            lblPrecision.AutoSize = true;
            lblPrecision.Location = new Point(479, 9);
            lblPrecision.Name = "lblPrecision";
            lblPrecision.Size = new Size(175, 41);
            lblPrecision.TabIndex = 3;
            lblPrecision.Text = "Dokładność";
            // 
            // cmbPrecision
            // 
            cmbPrecision.FormattingEnabled = true;
            cmbPrecision.Items.AddRange(new object[] { "0,1", "0,01", "0,001", "0,0001" });
            cmbPrecision.Location = new Point(434, 64);
            cmbPrecision.Name = "cmbPrecision";
            cmbPrecision.Size = new Size(274, 49);
            cmbPrecision.TabIndex = 5;
            // 
            // txtPopulationSize
            // 
            txtPopulationSize.Location = new Point(816, 64);
            txtPopulationSize.Name = "txtPopulationSize";
            txtPopulationSize.Size = new Size(137, 47);
            txtPopulationSize.TabIndex = 6;
            // 
            // lblPopulationSize
            // 
            lblPopulationSize.AutoSize = true;
            lblPopulationSize.Location = new Point(769, 9);
            lblPopulationSize.Name = "lblPopulationSize";
            lblPopulationSize.Size = new Size(254, 41);
            lblPopulationSize.TabIndex = 7;
            lblPopulationSize.Text = "Rozmiar populacji";
            // 
            // lblNumberOfGenerations
            // 
            lblNumberOfGenerations.AutoSize = true;
            lblNumberOfGenerations.Location = new Point(1098, 9);
            lblNumberOfGenerations.Name = "lblNumberOfGenerations";
            lblNumberOfGenerations.Size = new Size(217, 41);
            lblNumberOfGenerations.TabIndex = 8;
            lblNumberOfGenerations.Text = "Liczba pokoleń";
            // 
            // txtNumberOfGenerations
            // 
            txtNumberOfGenerations.Location = new Point(1140, 64);
            txtNumberOfGenerations.Name = "txtNumberOfGenerations";
            txtNumberOfGenerations.Size = new Size(137, 47);
            txtNumberOfGenerations.TabIndex = 9;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(1441, 58);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(374, 58);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Oblicz";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Identifier, xReal, xInt, xBin, xInt2, xReal2, ObjectiveFunction });
            dataGridView1.Location = new Point(23, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 49;
            dataGridView1.Size = new Size(1854, 514);
            dataGridView1.TabIndex = 11;
            // 
            // Identifier
            // 
            Identifier.HeaderText = "Lp.";
            Identifier.MinimumWidth = 12;
            Identifier.Name = "Identifier";
            // 
            // xReal
            // 
            xReal.HeaderText = "xReal";
            xReal.MinimumWidth = 12;
            xReal.Name = "xReal";
            // 
            // xInt
            // 
            xInt.HeaderText = "xInt";
            xInt.MinimumWidth = 12;
            xInt.Name = "xInt";
            // 
            // xBin
            // 
            xBin.HeaderText = "xBin";
            xBin.MinimumWidth = 12;
            xBin.Name = "xBin";
            // 
            // xInt2
            // 
            xInt2.HeaderText = "xInt";
            xInt2.MinimumWidth = 12;
            xInt2.Name = "xInt2";
            // 
            // xReal2
            // 
            xReal2.HeaderText = "xReal";
            xReal2.MinimumWidth = 12;
            xReal2.Name = "xReal2";
            // 
            // ObjectiveFunction
            // 
            ObjectiveFunction.HeaderText = "F(x)";
            ObjectiveFunction.MinimumWidth = 12;
            ObjectiveFunction.Name = "ObjectiveFunction";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 685);
            Controls.Add(dataGridView1);
            Controls.Add(btnCalculate);
            Controls.Add(txtNumberOfGenerations);
            Controls.Add(lblNumberOfGenerations);
            Controls.Add(lblPopulationSize);
            Controls.Add(txtPopulationSize);
            Controls.Add(cmbPrecision);
            Controls.Add(lblPrecision);
            Controls.Add(txtBoundaryRight);
            Controls.Add(lblBoundary);
            Controls.Add(txtBoundaryLeft);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoundaryLeft;
        private Label lblBoundary;
        private TextBox txtBoundaryRight;
        private Label lblPrecision;
        private ComboBox cmbPrecision;
        private TextBox txtPopulationSize;
        private Label lblPopulationSize;
        private Label lblNumberOfGenerations;
        private TextBox txtNumberOfGenerations;
        private Button btnCalculate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Identifier;
        private DataGridViewTextBoxColumn xReal;
        private DataGridViewTextBoxColumn xInt;
        private DataGridViewTextBoxColumn xBin;
        private DataGridViewTextBoxColumn xInt2;
        private DataGridViewTextBoxColumn xReal2;
        private DataGridViewTextBoxColumn ObjectiveFunction;
    }
}