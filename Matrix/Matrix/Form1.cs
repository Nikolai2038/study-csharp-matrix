using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Matrix
{
    /// <summary>Основная форма</summary>
    public partial class Form1 : Form
    {
        /// <summary>Матрица</summary>
        private MatrixTable matrix;

        private bool can_program_resize_matrix = true;

        /// <summary>Конструктор формы</summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>Событие загрузки формы</summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            matrix = new MatrixTable(3, 3);
            matrix.DrawInDataGridView(dataGridView_matrix_values);
            matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
        }

        /// <summary>Событие нажатия на кнопку заполнения матрицы случайными числами</summary>
        private void button_randomize_Click(object sender, EventArgs e)
        {
            matrix.Randomize();
            matrix.DrawInDataGridView(dataGridView_matrix_values);
            matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
        }

        /// <summary>Событие нажатия на кнопку очистки матрицы</summary>
        private void button_clear_Click(object sender, EventArgs e)
        {
            matrix.Clear();
            matrix.DrawInDataGridView(dataGridView_matrix_values);
            matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
        }

        /// <summary>Событие нажатия на кнопку сортировки матрицы по убыванию сумм в строчках</summary>
        private void button_sort_descend_Click(object sender, EventArgs e)
        {
            matrix.SortDescend(); // сортировка матрицы по убыванию
            matrix.DrawInDataGridView(dataGridView_matrix_values); // обновление таблицы со значениями
            matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
        }

        /// <summary>Событие нажатия на кнопку сортировки матрицы по возрастанию сумм в строчках</summary>
        private void button_sort_ascend_Click(object sender, EventArgs e)
        {
            matrix.SortAscend(); // сортировка матрицы по возрастанию
            matrix.DrawInDataGridView(dataGridView_matrix_values); // обновление таблицы со значениями
            matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
        }

        /// <summary>Событие нажатия на кнопку "Сохранить"</summary>
        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog(); // инициализация диалога сохранения файла
            dialog.Title = "Сохранение файла"; // заголовок окна сохранения файла
            dialog.InitialDirectory = @"C:\Users\" + Environment.UserName + @"\Desktop";
            dialog.FileName = "Новый документ";
            dialog.DefaultExt = "txt"; // расширение файла
            dialog.OverwritePrompt = true; // выводить сообщение о перезаписи файла
            dialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"; // задаём фильтр файлов - текстовые или любые другие

            DialogResult dialogResult = dialog.ShowDialog(); // показ диалога сохранения файла
            if (dialogResult == DialogResult.Cancel) // если отменили сохранение файла
            {
                return;
            }
            else
            {
                matrix.SaveInFile(dialog.FileName);
            }
        }

        /// <summary>Событие нажатия на кнопку "Печать"</summary>
        private void button_print_Click(object sender, EventArgs e)
        {
            if (matrix.PrintResult(dataGridView_matrix_values.Font))
            {
                MessageBox.Show("Успешная печать!");
            }
            else
            {
                MessageBox.Show("Ошибка печати!");
            }
        }

        /// <summary>Событие нажатия на кнопку "Выход"</summary>
        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>Событие изменения счётчика количества строк</summary>
        private void numericUpDown_rows_ValueChanged(object sender, EventArgs e)
        {
            ResizeMatrix();
        }

        /// <summary>Событие изменения счётчика количества столбцов</summary>
        private void numericUpDown_columns_ValueChanged(object sender, EventArgs e)
        {
            ResizeMatrix();
        }

        private void ResizeMatrix()
        {
            if (can_program_resize_matrix)
            {
                matrix.SetNewSize(Convert.ToInt16(numericUpDown_rows.Value), Convert.ToInt16(numericUpDown_columns.Value));
                matrix.DrawInDataGridView(dataGridView_matrix_values); // обновление таблицы со значениями
                matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
            }
        }

        /// <summary>Событие прокрутки в левой таблице</summary>
        private void dataGridView_matrix_sums_Scroll(object sender, ScrollEventArgs e)
        {
            PropertyInfo vertical_offset = dataGridView_matrix_sums.GetType().GetProperty("VerticalOffset", BindingFlags.NonPublic | BindingFlags.Instance);
            vertical_offset.SetValue(dataGridView_matrix_values, dataGridView_matrix_sums.VerticalScrollingOffset, null);
        }

        /// <summary>Событие изменения значения в ячейке (правая таблица)</summary>
        private void dataGridView_matrix_values_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView_matrix_values.Rows[e.RowIndex].Cells[e.ColumnIndex]; // ячейка
            try
            {
                if (Convert.ToInt16(cell.Value) > 100) // если значение в ячейке > 100
                {
                    cell.Value = 100; // устанавливаем значение ячейки = 100
                }
                else if (Convert.ToInt16(cell.Value) < -100) // если значение в ячейке < -100
                {
                    cell.Value = -100; // устанавливаем значение ячейки = -100
                }
            }
            catch // в случае ошибки при конвертации текста в ячейке в число
            {
                cell.Value = 0; // обнуляем значение ячейки
            }

            matrix.Set(e.RowIndex, e.ColumnIndex, Convert.ToInt32(cell.Value)); // занесение изменения в матрицу
            matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
        }

        /// <summary>Событие удаления строк (правая таблица)</summary>
        private void dataGridView_matrix_values_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
        }

        /// <summary>Событие удаления стролбцов (правая таблица)</summary>
        private void dataGridView_matrix_values_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)
        }

        /// <summary>Событие прокрутки в правой таблице</summary>
        private void dataGridView_matrix_values_Scroll(object sender, ScrollEventArgs e)
        {
            PropertyInfo vertical_offset = dataGridView_matrix_values.GetType().GetProperty("VerticalOffset", BindingFlags.NonPublic | BindingFlags.Instance);
            vertical_offset.SetValue(dataGridView_matrix_sums, dataGridView_matrix_values.VerticalScrollingOffset, null);
        }

        /// <summary>Событие, возникающее при редактировании ячейки</summary>
        private void dataGridView_matrix_values_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox cell = (TextBox)e.Control;
            cell.KeyPress += new KeyPressEventHandler(dataGridView_matrix_values_EditingControlShowing_KeyPress);
        }

        /// <summary>Событие нажатия клавиши в ячейке</summary>
        private void dataGridView_matrix_values_EditingControlShowing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) // цифры разрешены
            {
                return;
            }
            else if (e.KeyChar == 8) // backspace разрешён
            {
                return;
            }
            else if (e.KeyChar == '-') // проверка на минус
            {
                string text = ((TextBox)sender).Text;
                if (!text.Contains('-')) // если минуса не было
                {
                    if (text == "") // если в ячейке ничего нет
                    {
                        return; // разрешаем минус
                    }
                    else if (text == "0") // если в ячейке нуль
                    {
                        ((TextBox)sender).Text = ""; // очищаем ячейку
                        return; // разрешаем минус
                    }
                }
            }

            e.KeyChar = '\0'; // остальные символы запрещены (игнорировать)
        }

        /// <summary>Событие выбора в строке меню пункта "Файл - Сохранить"</summary>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_save.PerformClick();
        }

        /// <summary>Событие выбора в строке меню пункта "Файл - Печать"</summary>
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_print.PerformClick();
        }

        /// <summary>Событие выбора в строке меню пункта "Файл - Выход"</summary>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_exit.PerformClick();
        }

        /// <summary>Событие выбора в строке меню пункта "Сортировка матрицы - Сортировать матрицу по убыванию сумм элементов строк"</summary>
        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_sort_descend.PerformClick();
        }

        /// <summary>Событие выбора в строке меню пункта "Сортировка матрицы - Сортировать матрицу по возрастанию сумм элементов строк"</summary>
        private void сортировкаПоВозрастаниюСуммЭлементовСтрокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_sort_ascend.PerformClick();
        }

        /// <summary>Событие нажатия на кнопку "Открыть"</summary>
        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog(); // инициализация диалога
                dialog.Title = "Открытие файла"; // заголовок окна
                dialog.FileName = ""; // название файла (без расширения)
                dialog.DefaultExt = "txt"; // расширение файла
                dialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"; // задаём фильтр файлов - текстовые или любые другие

                DialogResult dialogResult = dialog.ShowDialog(); // показ диалога
                if (dialogResult != DialogResult.Cancel)
                {
                    can_program_resize_matrix = false;
                    matrix.OpenFromFile(dialog.FileName);

                    matrix.DrawInDataGridView(dataGridView_matrix_values); // обновление таблицы со значениями
                    matrix.UpdateTableWithSums(dataGridView_matrix_sums); // обновляем левую таблицу (таблица сумм)

                    // обновление счётчиков
                    numericUpDown_rows.Value = matrix.RowCount;
                    numericUpDown_columns.Value = matrix.ColumnCount;

                    can_program_resize_matrix = true;
                }
            }
            catch // если возникла какая-либо ошибка
            {
                MessageBox.Show("Ошибка открытия файла!");
            }
        }

        /// <summary>Событие выбора в строке меню пункта "Файл - Открыть"</summary>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_open.PerformClick();
        }


        /// <summary>Событие выбора в строке меню пункта "Справка - О программе"</summary>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа \"Сортировка матрицы N * M по возрастанию (убыванию) сумм элементов строк\".\n\nВерсия программы: 1.0\n\n2020 г.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
