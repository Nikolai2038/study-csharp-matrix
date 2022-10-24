namespace Matrix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDown_rows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_columns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_randomize = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_sort_ascend = new System.Windows.Forms.Button();
            this.button_sort_descend = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_matrix_values = new System.Windows.Forms.DataGridView();
            this.dataGridView_matrix_sums = new System.Windows.Forms.DataGridView();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_columns)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matrix_values)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matrix_sums)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_rows
            // 
            this.numericUpDown_rows.Location = new System.Drawing.Point(18, 58);
            this.numericUpDown_rows.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown_rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_rows.Name = "numericUpDown_rows";
            this.numericUpDown_rows.Size = new System.Drawing.Size(223, 26);
            this.numericUpDown_rows.TabIndex = 1;
            this.numericUpDown_rows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_rows.ValueChanged += new System.EventHandler(this.numericUpDown_rows_ValueChanged);
            // 
            // numericUpDown_columns
            // 
            this.numericUpDown_columns.Location = new System.Drawing.Point(18, 126);
            this.numericUpDown_columns.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown_columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_columns.Name = "numericUpDown_columns";
            this.numericUpDown_columns.Size = new System.Drawing.Size(223, 26);
            this.numericUpDown_columns.TabIndex = 2;
            this.numericUpDown_columns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_columns.ValueChanged += new System.EventHandler(this.numericUpDown_columns_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество строк (N):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество столбцов (M):";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сумма элементов в каждой строчке:";
            // 
            // button_randomize
            // 
            this.button_randomize.BackColor = System.Drawing.Color.White;
            this.button_randomize.Location = new System.Drawing.Point(265, 58);
            this.button_randomize.Name = "button_randomize";
            this.button_randomize.Size = new System.Drawing.Size(205, 94);
            this.button_randomize.TabIndex = 7;
            this.button_randomize.Text = "Заполнить матрицу случайными целыми числами  в интервале [-100; 100]";
            this.button_randomize.UseVisualStyleBackColor = false;
            this.button_randomize.Click += new System.EventHandler(this.button_randomize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.данныеToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem,
            this.сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.данныеToolStripMenuItem.Text = "Сортировка матрицы";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(416, 22);
            this.сортировкаToolStripMenuItem.Text = "Сортировать матрицу по убыванию сумм элементов строк";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem
            // 
            this.сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem.Name = "сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem";
            this.сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem.Size = new System.Drawing.Size(416, 22);
            this.сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem.Text = "Сортировать матрицу по возрастанию сумм элементов строк";
            this.сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem.Click += new System.EventHandler(this.сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // button_sort_ascend
            // 
            this.button_sort_ascend.BackColor = System.Drawing.Color.White;
            this.button_sort_ascend.Location = new System.Drawing.Point(363, 160);
            this.button_sort_ascend.Name = "button_sort_ascend";
            this.button_sort_ascend.Size = new System.Drawing.Size(330, 66);
            this.button_sort_ascend.TabIndex = 14;
            this.button_sort_ascend.Text = "Сортировать матрицу по возрастанию сумм элементов строк";
            this.button_sort_ascend.UseVisualStyleBackColor = false;
            this.button_sort_ascend.Click += new System.EventHandler(this.button_sort_ascend_Click);
            // 
            // button_sort_descend
            // 
            this.button_sort_descend.BackColor = System.Drawing.Color.White;
            this.button_sort_descend.Location = new System.Drawing.Point(18, 160);
            this.button_sort_descend.Name = "button_sort_descend";
            this.button_sort_descend.Size = new System.Drawing.Size(330, 66);
            this.button_sort_descend.TabIndex = 15;
            this.button_sort_descend.Text = "Сортировать матрицу по убыванию сумм элементов строк";
            this.button_sort_descend.UseVisualStyleBackColor = false;
            this.button_sort_descend.Click += new System.EventHandler(this.button_sort_descend_Click);
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(362, 477);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(160, 33);
            this.button_print.TabIndex = 17;
            this.button_print.Text = "Печать";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_exit.Location = new System.Drawing.Point(533, 477);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(160, 33);
            this.button_exit.TabIndex = 18;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(190, 477);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(160, 33);
            this.button_save.TabIndex = 19;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Матрица N * M:";
            // 
            // dataGridView_matrix_values
            // 
            this.dataGridView_matrix_values.AllowUserToAddRows = false;
            this.dataGridView_matrix_values.AllowUserToDeleteRows = false;
            this.dataGridView_matrix_values.AllowUserToResizeColumns = false;
            this.dataGridView_matrix_values.AllowUserToResizeRows = false;
            this.dataGridView_matrix_values.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_matrix_values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_matrix_values.ColumnHeadersVisible = false;
            this.dataGridView_matrix_values.Location = new System.Drawing.Point(192, 287);
            this.dataGridView_matrix_values.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_matrix_values.Name = "dataGridView_matrix_values";
            this.dataGridView_matrix_values.RowHeadersVisible = false;
            this.dataGridView_matrix_values.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_matrix_values.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_matrix_values.Size = new System.Drawing.Size(501, 179);
            this.dataGridView_matrix_values.TabIndex = 5;
            this.dataGridView_matrix_values.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_matrix_values_CellValueChanged);
            this.dataGridView_matrix_values.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_matrix_values_ColumnRemoved);
            this.dataGridView_matrix_values.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_matrix_values_EditingControlShowing);
            this.dataGridView_matrix_values.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_matrix_values_RowsRemoved);
            this.dataGridView_matrix_values.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView_matrix_values_Scroll);
            // 
            // dataGridView_matrix_sums
            // 
            this.dataGridView_matrix_sums.AllowUserToAddRows = false;
            this.dataGridView_matrix_sums.AllowUserToDeleteRows = false;
            this.dataGridView_matrix_sums.AllowUserToResizeColumns = false;
            this.dataGridView_matrix_sums.AllowUserToResizeRows = false;
            this.dataGridView_matrix_sums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_matrix_sums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_matrix_sums.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_matrix_sums.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_matrix_sums.Location = new System.Drawing.Point(18, 287);
            this.dataGridView_matrix_sums.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_matrix_sums.Name = "dataGridView_matrix_sums";
            this.dataGridView_matrix_sums.ReadOnly = true;
            this.dataGridView_matrix_sums.RowHeadersVisible = false;
            this.dataGridView_matrix_sums.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_matrix_sums.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_matrix_sums.Size = new System.Drawing.Size(164, 179);
            this.dataGridView_matrix_sums.TabIndex = 20;
            this.dataGridView_matrix_sums.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView_matrix_sums_Scroll);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(488, 58);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(205, 94);
            this.button_clear.TabIndex = 22;
            this.button_clear.Text = "Очистить матрицу";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_open
            // 
            this.button_open.BackColor = System.Drawing.Color.White;
            this.button_open.Location = new System.Drawing.Point(18, 477);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(160, 33);
            this.button_open.TabIndex = 23;
            this.button_open.Text = "Открыть";
            this.button_open.UseVisualStyleBackColor = false;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(713, 524);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_matrix_sums);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_sort_descend);
            this.Controls.Add(this.button_sort_ascend);
            this.Controls.Add(this.button_randomize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_matrix_values);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_columns);
            this.Controls.Add(this.numericUpDown_rows);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Сортировка матрицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_columns)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matrix_values)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matrix_sums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown_rows;
        private System.Windows.Forms.NumericUpDown numericUpDown_columns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_randomize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem;
        private System.Windows.Forms.Button button_sort_ascend;
        private System.Windows.Forms.Button button_sort_descend;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_matrix_values;
        private System.Windows.Forms.DataGridView dataGridView_matrix_sums;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.Button button_open;
    }
}

