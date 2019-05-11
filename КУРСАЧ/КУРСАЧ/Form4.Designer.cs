namespace КУРСАЧ
{
    partial class Form4
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
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.sport_ShopDataSet = new КУРСАЧ.Sport_ShopDataSet();
            this.спортивные_товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спортивные_товарыTableAdapter = new КУРСАЧ.Sport_ShopDataSetTableAdapters.Спортивные_товарыTableAdapter();
            this.tableAdapterManager = new КУРСАЧ.Sport_ShopDataSetTableAdapters.TableAdapterManager();
            this.таблицаСтоимостьTableAdapter = new КУРСАЧ.Sport_ShopDataSetTableAdapters.ТаблицаСтоимостьTableAdapter();
            this.тип_товараTableAdapter = new КУРСАЧ.Sport_ShopDataSetTableAdapters.Тип_товараTableAdapter();
            this.спортивные_товарыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.спортивные_товарыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.спортивные_товарыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблицаСтоимостьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_товараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sport_ShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыBindingNavigator)).BeginInit();
            this.спортивные_товарыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаСтоимостьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_товараBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(-3, 229);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 3;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Чек";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sport_ShopDataSet
            // 
            this.sport_ShopDataSet.DataSetName = "Sport_ShopDataSet";
            this.sport_ShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // спортивные_товарыBindingSource
            // 
            this.спортивные_товарыBindingSource.DataMember = "Спортивные товары";
            this.спортивные_товарыBindingSource.DataSource = this.sport_ShopDataSet;
            // 
            // спортивные_товарыTableAdapter
            // 
            this.спортивные_товарыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = КУРСАЧ.Sport_ShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказыTableAdapter = null;
            this.tableAdapterManager.Ид_клиентаTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.Спортивные_товарыTableAdapter = this.спортивные_товарыTableAdapter;
            this.tableAdapterManager.ТаблицаСтоимостьTableAdapter = this.таблицаСтоимостьTableAdapter;
            this.tableAdapterManager.Тип_товараTableAdapter = this.тип_товараTableAdapter;
            // 
            // таблицаСтоимостьTableAdapter
            // 
            this.таблицаСтоимостьTableAdapter.ClearBeforeFill = true;
            // 
            // тип_товараTableAdapter
            // 
            this.тип_товараTableAdapter.ClearBeforeFill = true;
            // 
            // спортивные_товарыBindingNavigator
            // 
            this.спортивные_товарыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.спортивные_товарыBindingNavigator.BindingSource = this.спортивные_товарыBindingSource;
            this.спортивные_товарыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.спортивные_товарыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.спортивные_товарыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.спортивные_товарыBindingNavigatorSaveItem});
            this.спортивные_товарыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.спортивные_товарыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.спортивные_товарыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.спортивные_товарыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.спортивные_товарыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.спортивные_товарыBindingNavigator.Name = "спортивные_товарыBindingNavigator";
            this.спортивные_товарыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.спортивные_товарыBindingNavigator.Size = new System.Drawing.Size(692, 25);
            this.спортивные_товарыBindingNavigator.TabIndex = 1;
            this.спортивные_товарыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // спортивные_товарыBindingNavigatorSaveItem
            // 
            this.спортивные_товарыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.спортивные_товарыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("спортивные_товарыBindingNavigatorSaveItem.Image")));
            this.спортивные_товарыBindingNavigatorSaveItem.Name = "спортивные_товарыBindingNavigatorSaveItem";
            this.спортивные_товарыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.спортивные_товарыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.спортивные_товарыBindingNavigatorSaveItem.Click += new System.EventHandler(this.Спортивные_товарыBindingNavigatorSaveItem_Click_1);
            // 
            // спортивные_товарыDataGridView
            // 
            this.спортивные_товарыDataGridView.AutoGenerateColumns = false;
            this.спортивные_товарыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.спортивные_товарыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.спортивные_товарыDataGridView.DataSource = this.спортивные_товарыBindingSource;
            this.спортивные_товарыDataGridView.Location = new System.Drawing.Point(0, 28);
            this.спортивные_товарыDataGridView.Name = "спортивные_товарыDataGridView";
            this.спортивные_товарыDataGridView.Size = new System.Drawing.Size(261, 168);
            this.спортивные_товарыDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_спортивных_товаров";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_спортивных_товаров";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименования";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименования";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_типа";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_типа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // таблицаСтоимостьBindingSource
            // 
            this.таблицаСтоимостьBindingSource.DataMember = "Спортивные товарыСтоимость";
            this.таблицаСтоимостьBindingSource.DataSource = this.спортивные_товарыBindingSource;
            // 
            // тип_товараBindingSource
            // 
            this.тип_товараBindingSource.DataMember = "Тип товара";
            this.тип_товараBindingSource.DataSource = this.sport_ShopDataSet;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.таблицаСтоимостьBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(68, 226);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.стоимостьTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Посчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 366);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 464);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(this.спортивные_товарыDataGridView);
            this.Controls.Add(this.спортивные_товарыBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спортивные Товары";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sport_ShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыBindingNavigator)).EndInit();
            this.спортивные_товарыBindingNavigator.ResumeLayout(false);
            this.спортивные_товарыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.спортивные_товарыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблицаСтоимостьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тип_товараBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Sport_ShopDataSet sport_ShopDataSet;
        private System.Windows.Forms.BindingSource спортивные_товарыBindingSource;
        private Sport_ShopDataSetTableAdapters.Спортивные_товарыTableAdapter спортивные_товарыTableAdapter;
        private Sport_ShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator спортивные_товарыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton спортивные_товарыBindingNavigatorSaveItem;
        private Sport_ShopDataSetTableAdapters.ТаблицаСтоимостьTableAdapter таблицаСтоимостьTableAdapter;
        private System.Windows.Forms.DataGridView спортивные_товарыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource таблицаСтоимостьBindingSource;
        private Sport_ShopDataSetTableAdapters.Тип_товараTableAdapter тип_товараTableAdapter;
        private System.Windows.Forms.BindingSource тип_товараBindingSource;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}