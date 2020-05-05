namespace WindowsFormsApp1
{
    partial class Form5
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
            System.Windows.Forms.Label date_purchaseLabel;
            System.Windows.Forms.Label pb_countLabel;
            System.Windows.Forms.Label pb_priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.booksDataSet = new WindowsFormsApp1.booksDataSet();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTableAdapter = new WindowsFormsApp1.booksDataSetTableAdapters.purchaseTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.booksDataSetTableAdapters.TableAdapterManager();
            this.purch_bookTableAdapter = new WindowsFormsApp1.booksDataSetTableAdapters.purch_bookTableAdapter();
            this.purchaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purchaseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.date_purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purch_bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pb_countTextBox = new System.Windows.Forms.TextBox();
            this.pb_priceTextBox = new System.Windows.Forms.TextBox();
            date_purchaseLabel = new System.Windows.Forms.Label();
            pb_countLabel = new System.Windows.Forms.Label();
            pb_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingNavigator)).BeginInit();
            this.purchaseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purch_bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_purchaseLabel
            // 
            date_purchaseLabel.AutoSize = true;
            date_purchaseLabel.Location = new System.Drawing.Point(125, 122);
            date_purchaseLabel.Name = "date_purchaseLabel";
            date_purchaseLabel.Size = new System.Drawing.Size(99, 17);
            date_purchaseLabel.TabIndex = 2;
            date_purchaseLabel.Text = "Дата покупки";
            // 
            // pb_countLabel
            // 
            pb_countLabel.AutoSize = true;
            pb_countLabel.Location = new System.Drawing.Point(74, 213);
            pb_countLabel.Name = "pb_countLabel";
            pb_countLabel.Size = new System.Drawing.Size(86, 17);
            pb_countLabel.TabIndex = 4;
            pb_countLabel.Text = "Количество";
            // 
            // pb_priceLabel
            // 
            pb_priceLabel.AutoSize = true;
            pb_priceLabel.Location = new System.Drawing.Point(359, 213);
            pb_priceLabel.Name = "pb_priceLabel";
            pb_priceLabel.Size = new System.Drawing.Size(43, 17);
            pb_priceLabel.TabIndex = 6;
            pb_priceLabel.Text = "Цена";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(170, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Заказы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "booksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "purchase";
            this.purchaseBindingSource.DataSource = this.booksDataSet;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.autorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookTableAdapter = null;
            this.tableAdapterManager.buyersTableAdapter = null;
            this.tableAdapterManager.publishTableAdapter = null;
            this.tableAdapterManager.purch_bookTableAdapter = this.purch_bookTableAdapter;
            this.tableAdapterManager.purchaseTableAdapter = this.purchaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.booksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purch_bookTableAdapter
            // 
            this.purch_bookTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseBindingNavigator
            // 
            this.purchaseBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseBindingNavigator.BindingSource = this.purchaseBindingSource;
            this.purchaseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.purchaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchaseBindingNavigatorSaveItem});
            this.purchaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseBindingNavigator.Name = "purchaseBindingNavigator";
            this.purchaseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseBindingNavigator.Size = new System.Drawing.Size(567, 31);
            this.purchaseBindingNavigator.TabIndex = 1;
            this.purchaseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // purchaseBindingNavigatorSaveItem
            // 
            this.purchaseBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseBindingNavigatorSaveItem.Image")));
            this.purchaseBindingNavigatorSaveItem.Name = "purchaseBindingNavigatorSaveItem";
            this.purchaseBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.purchaseBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.purchaseBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseBindingNavigatorSaveItem_Click);
            // 
            // date_purchaseDateTimePicker
            // 
            this.date_purchaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseBindingSource, "date_purchase", true));
            this.date_purchaseDateTimePicker.Location = new System.Drawing.Point(230, 122);
            this.date_purchaseDateTimePicker.Name = "date_purchaseDateTimePicker";
            this.date_purchaseDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_purchaseDateTimePicker.TabIndex = 3;
            // 
            // purch_bookBindingSource
            // 
            this.purch_bookBindingSource.DataMember = "purch_book";
            this.purch_bookBindingSource.DataSource = this.booksDataSet;
            // 
            // pb_countTextBox
            // 
            this.pb_countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purch_bookBindingSource, "pb_count", true));
            this.pb_countTextBox.Location = new System.Drawing.Point(166, 210);
            this.pb_countTextBox.Name = "pb_countTextBox";
            this.pb_countTextBox.Size = new System.Drawing.Size(100, 22);
            this.pb_countTextBox.TabIndex = 5;
            // 
            // pb_priceTextBox
            // 
            this.pb_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purch_bookBindingSource, "pb_price", true));
            this.pb_priceTextBox.Location = new System.Drawing.Point(408, 210);
            this.pb_priceTextBox.Name = "pb_priceTextBox";
            this.pb_priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.pb_priceTextBox.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 394);
            this.Controls.Add(pb_priceLabel);
            this.Controls.Add(this.pb_priceTextBox);
            this.Controls.Add(pb_countLabel);
            this.Controls.Add(this.pb_countTextBox);
            this.Controls.Add(date_purchaseLabel);
            this.Controls.Add(this.date_purchaseDateTimePicker);
            this.Controls.Add(this.purchaseBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Таблица \"Заказы\"";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingNavigator)).EndInit();
            this.purchaseBindingNavigator.ResumeLayout(false);
            this.purchaseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purch_bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private booksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private booksDataSetTableAdapters.purchaseTableAdapter purchaseTableAdapter;
        private booksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchaseBindingNavigatorSaveItem;
        private booksDataSetTableAdapters.purch_bookTableAdapter purch_bookTableAdapter;
        private System.Windows.Forms.DateTimePicker date_purchaseDateTimePicker;
        private System.Windows.Forms.BindingSource purch_bookBindingSource;
        private System.Windows.Forms.TextBox pb_countTextBox;
        private System.Windows.Forms.TextBox pb_priceTextBox;
    }
}