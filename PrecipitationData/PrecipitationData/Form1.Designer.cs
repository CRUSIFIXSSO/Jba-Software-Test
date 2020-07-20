namespace PrecipitationData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label xrefLabel;
            System.Windows.Forms.Label yrefLabel;
            System.Windows.Forms.Label start_DateLabel;
            System.Windows.Forms.Label end_DateLabel;
            System.Windows.Forms.Label totalLabel;
            this.rainFallDataSet1 = new PrecipitationData.RainFallDataSet1();
            this.rainFallDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rainFallDataTableAdapter = new PrecipitationData.RainFallDataSet1TableAdapters.RainFallDataTableAdapter();
            this.tableAdapterManager = new PrecipitationData.RainFallDataSet1TableAdapters.TableAdapterManager();
            this.rainFallDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.rainFallDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.xrefTextBox = new System.Windows.Forms.TextBox();
            this.yrefTextBox = new System.Windows.Forms.TextBox();
            this.start_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.rainFallDataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            xrefLabel = new System.Windows.Forms.Label();
            yrefLabel = new System.Windows.Forms.Label();
            start_DateLabel = new System.Windows.Forms.Label();
            end_DateLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rainFallDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainFallDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainFallDataBindingNavigator)).BeginInit();
            this.rainFallDataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rainFallDataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rainFallDataSet1
            // 
            this.rainFallDataSet1.DataSetName = "RainFallDataSet1";
            this.rainFallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rainFallDataBindingSource
            // 
            this.rainFallDataBindingSource.DataMember = "RainFallData";
            this.rainFallDataBindingSource.DataSource = this.rainFallDataSet1;
            // 
            // rainFallDataTableAdapter
            // 
            this.rainFallDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RainFallDataTableAdapter = this.rainFallDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrecipitationData.RainFallDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rainFallDataBindingNavigator
            // 
            this.rainFallDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rainFallDataBindingNavigator.BindingSource = this.rainFallDataBindingSource;
            this.rainFallDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rainFallDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rainFallDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rainFallDataBindingNavigatorSaveItem});
            this.rainFallDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rainFallDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rainFallDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rainFallDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rainFallDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rainFallDataBindingNavigator.Name = "rainFallDataBindingNavigator";
            this.rainFallDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rainFallDataBindingNavigator.Size = new System.Drawing.Size(814, 25);
            this.rainFallDataBindingNavigator.TabIndex = 0;
            this.rainFallDataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // rainFallDataBindingNavigatorSaveItem
            // 
            this.rainFallDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rainFallDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rainFallDataBindingNavigatorSaveItem.Image")));
            this.rainFallDataBindingNavigatorSaveItem.Name = "rainFallDataBindingNavigatorSaveItem";
            this.rainFallDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.rainFallDataBindingNavigatorSaveItem.Text = "Save Data";
            this.rainFallDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.rainFallDataBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(37, 64);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rainFallDataBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(72, 57);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(132, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // xrefLabel
            // 
            xrefLabel.AutoSize = true;
            xrefLabel.Location = new System.Drawing.Point(37, 92);
            xrefLabel.Name = "xrefLabel";
            xrefLabel.Size = new System.Drawing.Size(29, 13);
            xrefLabel.TabIndex = 3;
            xrefLabel.Text = "Xref:";
            // 
            // xrefTextBox
            // 
            this.xrefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rainFallDataBindingSource, "Xref", true));
            this.xrefTextBox.Location = new System.Drawing.Point(72, 115);
            this.xrefTextBox.Name = "xrefTextBox";
            this.xrefTextBox.Size = new System.Drawing.Size(132, 20);
            this.xrefTextBox.TabIndex = 4;
            // 
            // yrefLabel
            // 
            yrefLabel.AutoSize = true;
            yrefLabel.Location = new System.Drawing.Point(37, 118);
            yrefLabel.Name = "yrefLabel";
            yrefLabel.Size = new System.Drawing.Size(29, 13);
            yrefLabel.TabIndex = 5;
            yrefLabel.Text = "Yref:";
            // 
            // yrefTextBox
            // 
            this.yrefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rainFallDataBindingSource, "Yref", true));
            this.yrefTextBox.Location = new System.Drawing.Point(72, 83);
            this.yrefTextBox.Name = "yrefTextBox";
            this.yrefTextBox.Size = new System.Drawing.Size(132, 20);
            this.yrefTextBox.TabIndex = 6;
            // 
            // start_DateLabel
            // 
            start_DateLabel.AutoSize = true;
            start_DateLabel.Location = new System.Drawing.Point(8, 145);
            start_DateLabel.Name = "start_DateLabel";
            start_DateLabel.Size = new System.Drawing.Size(58, 13);
            start_DateLabel.TabIndex = 7;
            start_DateLabel.Text = "Start Date:";
            // 
            // start_DateDateTimePicker
            // 
            this.start_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rainFallDataBindingSource, "Start Date", true));
            this.start_DateDateTimePicker.Location = new System.Drawing.Point(72, 145);
            this.start_DateDateTimePicker.Name = "start_DateDateTimePicker";
            this.start_DateDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.start_DateDateTimePicker.TabIndex = 8;
            // 
            // end_DateLabel
            // 
            end_DateLabel.AutoSize = true;
            end_DateLabel.Location = new System.Drawing.Point(11, 177);
            end_DateLabel.Name = "end_DateLabel";
            end_DateLabel.Size = new System.Drawing.Size(55, 13);
            end_DateLabel.TabIndex = 9;
            end_DateLabel.Text = "End Date:";
            // 
            // end_DateDateTimePicker
            // 
            this.end_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rainFallDataBindingSource, "End Date", true));
            this.end_DateDateTimePicker.Location = new System.Drawing.Point(72, 177);
            this.end_DateDateTimePicker.Name = "end_DateDateTimePicker";
            this.end_DateDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.end_DateDateTimePicker.TabIndex = 10;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(32, 211);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 11;
            totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rainFallDataBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(72, 211);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(132, 20);
            this.totalTextBox.TabIndex = 12;
            // 
            // rainFallDataDataGridView
            // 
            this.rainFallDataDataGridView.AutoGenerateColumns = false;
            this.rainFallDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rainFallDataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.rainFallDataDataGridView.DataSource = this.rainFallDataBindingSource;
            this.rainFallDataDataGridView.Location = new System.Drawing.Point(210, 28);
            this.rainFallDataDataGridView.Name = "rainFallDataDataGridView";
            this.rainFallDataDataGridView.Size = new System.Drawing.Size(592, 220);
            this.rainFallDataDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Xref";
            this.dataGridViewTextBoxColumn2.HeaderText = "Xref";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Yref";
            this.dataGridViewTextBoxColumn3.HeaderText = "Yref";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Start Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "End Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 384);
            this.Controls.Add(this.rainFallDataDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(xrefLabel);
            this.Controls.Add(this.xrefTextBox);
            this.Controls.Add(yrefLabel);
            this.Controls.Add(this.yrefTextBox);
            this.Controls.Add(start_DateLabel);
            this.Controls.Add(this.start_DateDateTimePicker);
            this.Controls.Add(end_DateLabel);
            this.Controls.Add(this.end_DateDateTimePicker);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.rainFallDataBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rainFallDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainFallDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainFallDataBindingNavigator)).EndInit();
            this.rainFallDataBindingNavigator.ResumeLayout(false);
            this.rainFallDataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rainFallDataDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RainFallDataSet1 rainFallDataSet1;
        private System.Windows.Forms.BindingSource rainFallDataBindingSource;
        private RainFallDataSet1TableAdapters.RainFallDataTableAdapter rainFallDataTableAdapter;
        private RainFallDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rainFallDataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rainFallDataBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox xrefTextBox;
        private System.Windows.Forms.TextBox yrefTextBox;
        private System.Windows.Forms.DateTimePicker start_DateDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_DateDateTimePicker;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridView rainFallDataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

