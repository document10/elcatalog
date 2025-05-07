namespace Aplicatie
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.afisare = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specificatii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unelte = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRem = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.rdbCod = new MetroFramework.Controls.MetroRadioButton();
            this.rdbVal = new MetroFramework.Controls.MetroRadioButton();
            this.rdbVmax = new MetroFramework.Controls.MetroRadioButton();
            this.rdbPmax = new MetroFramework.Controls.MetroRadioButton();
            this.txtCrit = new MetroFramework.Controls.MetroTextBox();
            this.btnLook = new MetroFramework.Controls.MetroButton();
            this.lblErr = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.afisare)).BeginInit();
            this.unelte.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // afisare
            // 
            this.afisare.AllowUserToAddRows = false;
            this.afisare.AllowUserToDeleteRows = false;
            this.afisare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.afisare.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.afisare.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.afisare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afisare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.afisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afisare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Tip,
            this.Specificatii});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afisare.DefaultCellStyle = dataGridViewCellStyle2;
            this.afisare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afisare.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.afisare.Location = new System.Drawing.Point(3, 28);
            this.afisare.MultiSelect = false;
            this.afisare.Name = "afisare";
            this.afisare.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afisare.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F);
            this.afisare.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.afisare.Size = new System.Drawing.Size(498, 450);
            this.afisare.TabIndex = 0;
            this.afisare.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.afisare_CellMouseDoubleClick);
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 58;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Width = 53;
            // 
            // Specificatii
            // 
            this.Specificatii.HeaderText = "Specificatii";
            this.Specificatii.Name = "Specificatii";
            this.Specificatii.ReadOnly = true;
            // 
            // unelte
            // 
            this.unelte.BackColor = System.Drawing.Color.Transparent;
            this.unelte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unelte.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.unelte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.btnRem});
            this.unelte.Location = new System.Drawing.Point(0, 0);
            this.unelte.Name = "unelte";
            this.unelte.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.unelte.Size = new System.Drawing.Size(504, 25);
            this.unelte.TabIndex = 2;
            this.unelte.Text = "unelte";
            // 
            // toolAdd
            // 
            this.toolAdd.BackColor = System.Drawing.Color.Lime;
            this.toolAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAdd.ForeColor = System.Drawing.Color.Black;
            this.toolAdd.Image = global::Aplicatie.Properties.Resources.plus;
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Margin = new System.Windows.Forms.Padding(0);
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(82, 25);
            this.toolAdd.Text = "Adaugare";
            this.toolAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRem
            // 
            this.btnRem.BackColor = System.Drawing.Color.Red;
            this.btnRem.ForeColor = System.Drawing.Color.White;
            this.btnRem.Image = global::Aplicatie.Properties.Resources.trash;
            this.btnRem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(66, 22);
            this.btnRem.Text = "Elimina";
            this.btnRem.Click += new System.EventHandler(this.btnRem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.unelte, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.afisare, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(507, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(250, 475);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cautare";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.rdbCod, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdbVal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.rdbVmax, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rdbPmax, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtCrit, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnLook, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblErr, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 456);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(125, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Curata";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdbCod
            // 
            this.rdbCod.AutoSize = true;
            this.rdbCod.Checked = true;
            this.tableLayoutPanel2.SetColumnSpan(this.rdbCod, 2);
            this.rdbCod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbCod.Location = new System.Drawing.Point(3, 3);
            this.rdbCod.Name = "rdbCod";
            this.rdbCod.Size = new System.Drawing.Size(238, 15);
            this.rdbCod.TabIndex = 0;
            this.rdbCod.TabStop = true;
            this.rdbCod.Text = "Cod";
            this.rdbCod.UseVisualStyleBackColor = true;
            // 
            // rdbVal
            // 
            this.rdbVal.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.rdbVal, 2);
            this.rdbVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbVal.Location = new System.Drawing.Point(3, 24);
            this.rdbVal.Name = "rdbVal";
            this.rdbVal.Size = new System.Drawing.Size(238, 15);
            this.rdbVal.TabIndex = 1;
            this.rdbVal.Text = "Valoare";
            this.rdbVal.UseVisualStyleBackColor = true;
            // 
            // rdbVmax
            // 
            this.rdbVmax.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.rdbVmax, 2);
            this.rdbVmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbVmax.Location = new System.Drawing.Point(3, 45);
            this.rdbVmax.Name = "rdbVmax";
            this.rdbVmax.Size = new System.Drawing.Size(238, 15);
            this.rdbVmax.TabIndex = 2;
            this.rdbVmax.Text = "Tensiune maxima";
            this.rdbVmax.UseVisualStyleBackColor = true;
            // 
            // rdbPmax
            // 
            this.rdbPmax.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.rdbPmax, 2);
            this.rdbPmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbPmax.Location = new System.Drawing.Point(3, 66);
            this.rdbPmax.Name = "rdbPmax";
            this.rdbPmax.Size = new System.Drawing.Size(238, 15);
            this.rdbPmax.TabIndex = 3;
            this.rdbPmax.Text = "Putere maxima";
            this.rdbPmax.UseVisualStyleBackColor = true;
            // 
            // txtCrit
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtCrit, 2);
            this.txtCrit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCrit.Location = new System.Drawing.Point(3, 87);
            this.txtCrit.Name = "txtCrit";
            this.txtCrit.Size = new System.Drawing.Size(238, 23);
            this.txtCrit.TabIndex = 4;
            // 
            // btnLook
            // 
            this.btnLook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLook.Location = new System.Drawing.Point(3, 116);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(116, 23);
            this.btnLook.TabIndex = 5;
            this.btnLook.Text = "Cauta";
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblErr, 2);
            this.lblErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblErr.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblErr.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(3, 142);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(238, 15);
            this.lblErr.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErr.TabIndex = 8;
            this.lblErr.Text = "Eroare";
            this.lblErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErr.UseStyleColors = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Principal";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Catalog Componente";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.afisare)).EndInit();
            this.unelte.ResumeLayout(false);
            this.unelte.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView afisare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specificatii;
        private System.Windows.Forms.ToolStrip unelte;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton btnRem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroRadioButton rdbCod;
        private MetroFramework.Controls.MetroRadioButton rdbVal;
        private MetroFramework.Controls.MetroRadioButton rdbVmax;
        private MetroFramework.Controls.MetroRadioButton rdbPmax;
        private MetroFramework.Controls.MetroTextBox txtCrit;
        private MetroFramework.Controls.MetroButton btnLook;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroLabel lblErr;
    }
}