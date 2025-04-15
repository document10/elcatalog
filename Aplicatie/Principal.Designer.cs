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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.afisare = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specificatii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unelte = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtCauta = new System.Windows.Forms.ToolStripTextBox();
            this.btnRem = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.afisare)).BeginInit();
            this.unelte.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // afisare
            // 
            this.afisare.AllowUserToAddRows = false;
            this.afisare.AllowUserToDeleteRows = false;
            this.afisare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.afisare.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.afisare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afisare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.afisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afisare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Tip,
            this.Specificatii});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afisare.DefaultCellStyle = dataGridViewCellStyle6;
            this.afisare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afisare.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.afisare.Location = new System.Drawing.Point(3, 28);
            this.afisare.MultiSelect = false;
            this.afisare.Name = "afisare";
            this.afisare.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.afisare.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F);
            this.afisare.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.afisare.Size = new System.Drawing.Size(554, 461);
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
            this.toolStripLabel1,
            this.txtCauta,
            this.btnRem});
            this.unelte.Location = new System.Drawing.Point(0, 0);
            this.unelte.Name = "unelte";
            this.unelte.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.unelte.Size = new System.Drawing.Size(560, 25);
            this.unelte.TabIndex = 2;
            this.unelte.Text = "unelte";
            // 
            // toolAdd
            // 
            this.toolAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.toolAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAdd.Image = global::Aplicatie.Properties.Resources.plus;
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Margin = new System.Windows.Forms.Padding(0);
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(82, 25);
            this.toolAdd.Text = "Adaugare";
            this.toolAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::Aplicatie.Properties.Resources.search;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(118, 22);
            this.toolStripLabel1.Text = "Cauta dupa cod:";
            // 
            // txtCauta
            // 
            this.txtCauta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCauta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(150, 25);
            this.txtCauta.TextChanged += new System.EventHandler(this.txtCauta_TextChanged);
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
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.unelte, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.afisare, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 370);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
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
        private System.Windows.Forms.ToolStripTextBox txtCauta;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnRem;
    }
}