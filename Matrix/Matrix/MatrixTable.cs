using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Matrix
{
    /// <summary>Матрица с числами</summary>
    public class MatrixTable
    {
        /// <summary>Шрифт для печати файла</summary>
        private Font printFont;

        /// <summary>Количество строк</summary>
        private int m_row_count;

        /// <summary>Количество строк</summary>
        public int RowCount
        {
            get
            {
                return m_row_count;
            }
        }

        /// <summary>Количество столбцов</summary>
        private int m_column_count;

        /// <summary>Количество столбцов</summary>
        public int ColumnCount
        {
            get
            {
                return m_column_count;
            }
        }

        /// <summary>Элементы матрицы</summary>
        private int[,] m_values;

        /// <summary>Конструктор матрицы</summary>
        /// <param name="N">Количество строк</param>
        /// <param name="M">Количество столбцов</param>
        public MatrixTable(int row_count = 1, int column_count = 1)
        {
            m_row_count = row_count;
            m_column_count = column_count;
            m_values = new int[m_row_count, m_column_count];

            Clear(); // очищаем матрицу
        }

        /// <summary>Очищает матрицу</summary>
        public void Clear()
        {
            for (int i = 0; i < m_row_count; i++) // для каждой строчки
            {
                for (int i2 = 0; i2 < m_column_count; i2++) // для каждой ячейки в строчке
                {
                    m_values[i, i2] = 0; // обнуляем значение ячейки
                }
            }
        }

        /// <summary>Заполняет матрицу случайными числами</summary>
        public void Randomize()
        {
            Random random = new Random(); // переменная для генерации случайных чисел

            for (int i = 0; i < m_row_count; i++) // для каждой строчки
            {
                for (int i2 = 0; i2 < m_column_count; i2++) // для каждой ячейки в строчке
                {
                    m_values[i, i2] = random.Next(-100, 101); // значение ячейки - случайное целое число из интервала [-100; 100]
                }
            }
        }

        /// <summary>Изменяет значение указанного элемента матрицы</summary>
        /// <param name="row_id">ID строчки</param>
        /// <param name="column_id">ID столбца</param>
        /// <param name="value">Новое значение</param>
        /// <returns>True - в случае успешного завершения операции, false - в случае ошибки</returns>
        public bool Set(int row_id, int column_id, int value)
        {
            if (row_id >= 0 && row_id < m_row_count && column_id >= 0 && column_id < m_column_count) // если ID строчки и столбца указаны верно
            {
                m_values[row_id, column_id] = value; // замена значения в матрице
                return true;
            }
            else return false;
        }

        /// <summary>Занесение элементов матрицы в таблицу</summary>
        /// <param name="data_grid_view">Таблица</param>
        public void DrawInDataGridView(DataGridView data_grid_view)
        {
            data_grid_view.RowCount = m_row_count;
            data_grid_view.ColumnCount = m_column_count;

            for (int i = 0; i < m_row_count; i++) // для каждой строчки
            {
                for (int i2 = 0; i2 < m_column_count; i2++) // для каждой ячейки в строчке
                {
                    data_grid_view.Rows[i].Cells[i2].Value = m_values[i, i2]; // занесение значения из матрицы в ячейку таблицы
                }
            }
        }

        /// <summary>Возвращает сумму элементов указанной строчки матрицы</summary>
        /// <param name="row_id">ID строчки</param>
        /// <returns>Сумма элементов в строчке</returns>
        private int GetRowSum(int row_id)
        {
            int sum = 0; // сумма элементов строчки
            for (int i2 = 0; i2 < m_column_count; i2++) // для каждой ячейки в строчке
            {
                sum += m_values[row_id, i2];
            }
            return sum;
        }

        /// <summary>Заносит в указанную таблицу список сумм строк матрицы</summary>
        /// <param name="data_grid_view">Таблица, в которой должны отображаться суммы</param>
        public void UpdateTableWithSums(DataGridView data_grid_view)
        {
            data_grid_view.RowCount = m_row_count;
            data_grid_view.ColumnCount = 1;

            for (int i = 0; i < m_row_count; i++) // для каждой строчки
            {
                data_grid_view.Rows[i].Cells[0].Value = GetRowSum(i); // занесение в ячейку
            }
        }

        /// <summary>Сортировка по убыванию</summary>
        public void SortDescend()
        {
            for (int i = 0; i < m_row_count; i++) // для всех строк
            {
                int sum = GetRowSum(i); // сумма элементов в строке

                // находим строчку, которая содержит сумму, большую суммы в текущей строчке
                int next_max_sum = 0; // сохраняемая сумма
                int next_max_sum_row_id = -1; // сохраняемый id строчки
                for (int i2 = i + 1; i2 < m_row_count; i2++) // для всех строк после текущей
                {
                    int sum2 = GetRowSum(i2); // сумма элементов в строке
                    if ((next_max_sum_row_id != -1 && sum2 > next_max_sum) || (next_max_sum_row_id == -1 && sum2 > sum)) // если это - не первая проверяемая строчка и у неё сумма больше сохраняемой суммы, или это - первая проверяемая строчка и у неё сумма больше суммы текущей строчки
                    {
                        next_max_sum = sum2;
                        next_max_sum_row_id = i2;
                    }
                }

                // меняем местами значения ячеек в строках
                if (next_max_sum_row_id != -1) // если была найдена строчка с суммой элементов больше, чем сумма элементов в этой строчке
                {
                    for (int i2 = 0; i2 < m_column_count; i2++) // для всех ячеек текущей строки
                    {
                        int value = m_values[i, i2]; // сохраняем значение ячейки текущей строки
                        m_values[i, i2] = m_values[next_max_sum_row_id, i2]; // заменяем значение ячейки текущей строки на значение ячейки во второй строке
                        m_values[next_max_sum_row_id, i2] = value;// заменяем значение ячейки во второй строке на сохранённое значение
                    }
                }
            }
        }

        /// <summary>Сортировка по возрастанию</summary>
        public void SortAscend()
        {
            for (int i = 0; i < m_row_count; i++) // для всех строк
            {
                int sum = GetRowSum(i); // сумма элементов в строке

                // находим строчку, которая содержит сумму, меньшую суммы в текущей строчке
                int next_min_sum = 0; // сохраняемая сумма
                int next_min_sum_row_id = -1; // сохраняемый id строчки
                for (int i2 = i + 1; i2 < m_row_count; i2++) // для всех строк после текущей
                {
                    int sum2 = GetRowSum(i2); // сумма элементов в строке
                    if ((next_min_sum_row_id != -1 && sum2 < next_min_sum) ||
                        (next_min_sum_row_id == -1 && sum2 < sum)) // если это - не первая проверяемая строчка и у неё сумма меньше сохраняемой суммы, или это - первая проверяемая строчка и у неё сумма меньше суммы текущей строчки
                    {
                        next_min_sum = sum2;
                        next_min_sum_row_id = i2;
                    }
                }

                // меняем местами значения ячеек в строках
                if (next_min_sum_row_id != -1) // если была найдена строчка с суммой элементов меньше, чем сумма элементов в этой строчке
                {
                    for (int i2 = 0; i2 < m_column_count; i2++) // для всех ячеек текущей строки
                    {
                        int value = m_values[i, i2]; // сохраняем значение ячейки текущей строки
                        m_values[i, i2] = m_values[next_min_sum_row_id, i2]; // заменяем значение ячейки текущей строки на значение ячейки во второй строке
                        m_values[next_min_sum_row_id, i2] = value;// заменяем значение ячейки во второй строке на сохранённое значение
                    }
                }
            }
        }

        /// <summary>Возвращает текст, содержащий все числа в указанной строчке через пробел</summary>
        /// <param name="row_id">ID строчки</param>
        /// <returns>Текст</returns>
        private string GetRowAsString(int row_id)
        {
            if (row_id >= 0 && row_id < m_row_count) // если ID строчки указан верно
            {
                string result = "";
                for (int i = 0; i < m_column_count; i++)
                {
                    result += m_values[row_id, i];
                    if (i != m_column_count - 1) result += " ";
                }
                return result;
            }
            else return null;
        }

        // Сохранение матрицы в файл
        public bool SaveInFile(string path)
        {
            try
            {
                string text = ""; // текст, который будет записан в файл
                for (int i = 0; i < m_row_count; i++) // для каждой строчки
                {
                    text += GetRowAsString(i); // генерируем текст из элементов строчки и добавляем его к общему тексту
                    if (i != m_row_count - 1) // если строчка не последняя
                    {
                        text += "\n"; // добавляем перенос на новую строчку
                    }
                }
                System.IO.File.WriteAllText(path, text); // запись в файл
                return true;
            }
            catch // в случае ошибки
            {
                return false;
            }
        }

        /// <summary> Отправляет документ принтеру на печать</summary>
        /// <param name="pF">Стиль шрифта</param>
        /// <returns>Возвращает true, если файл был отправлен принтеру успешно</returns>
        public bool PrintResult(Font pF)
        {
            try
            {
                printFont = pF;
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                pd.Print();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>Событие для печати каждой страницы</summary>
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics); // количество строк на странице

            float yPos = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Печатаем каждую строку файла
            int i = 0;
            while (i < linesPerPage && ((line = GetRowAsString(i)) != null))
            {
                yPos = topMargin + (i * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                leftMargin, yPos, new StringFormat());
                i++;
            }

            // если строки не закончились, распечатаем еще одну страницу
            if (line != null)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }

        /// <summary>Установка нового размера матрицы (если матрица стала больше, новые ячейки заполняются нулями)</summary>
        /// <param name="new_row_count">Новое количество строк</param>
        /// <param name="new_column_count">Новое количество столбцов</param>
        public void SetNewSize(int new_row_count, int new_column_count)
        {
            int old_row_count = m_row_count; // старое количество строчек
            int old_column_count = m_column_count; // старое количество столбцов

            int[,] new_values = new int[new_row_count, new_column_count]; // новая матрица
            for (int i = 0; i < new_row_count; i++) // для всех строк
            {
                for (int i2 = 0; i2 < new_column_count; i2++) // для каждой ячейки в строке
                {
                    new_values[i, i2] = 0; // значение ячейки = 0
                }
            }

            int min_row_count = old_row_count;
            if (new_row_count < min_row_count) min_row_count = new_row_count;

            int min_column_count = old_column_count;
            if (new_column_count < min_column_count) min_column_count = new_column_count;

            for (int i = 0; i < min_row_count; i++) // для всех новых строк
            {
                for (int i2 = 0; i2 < min_column_count; i2++) // для каждой ячейки в строке
                {
                    new_values[i, i2] = m_values[i, i2]; // значение ячейки = 0
                }
            }

            m_row_count = new_row_count; // изменение числа строк таблицы
            m_column_count = new_column_count; // изменение числа строк таблицы

            m_values = new_values;
        }

        // Открытие матрицы из файла 
        public bool OpenFromFile(string path)
        {
            try
            {
                string text = ""; // текст файла
                text = System.IO.File.ReadAllText(path); // чтение из файла
                if (text != "") // если файл не пустой
                {
                    string[] lines = text.Split(new char[] { '\n' }); // создаём массив из текстовых строчек - разбиваем весь текстовый файл на фрагменты, разделённые символом '\n'
                    int rows = lines.Length; // количество строк в матрице
                    int columns = lines[0].Split(new char[] { ' ' }).Length; // находим количество колонок - разбиваем первую строчку на фрагменты, разделённые пробелом

                    m_row_count = rows; // изменяем количество строк в таблице
                    m_column_count = columns; // изменяем количество колонок в таблице

                    m_values = new int[m_row_count, m_column_count];
                    Clear(); // очистка матрицы

                    for (int i = 0; i < rows; i++) // для всех строк
                    {
                        string[] values_in_line = lines[i].Split(new char[] { ' ' }); // создаём массив из чисел (в виде текста) - разбиваем текущую строчку на фрагменты, разделённые пробелом
                        for (int i2 = 0; i2 < columns; i2++) // для каждой колонки в строчке
                        {
                            m_values[i, i2] = Convert.ToInt32(values_in_line[i2]); // заносим число в ячейку таблицы
                        }
                    }
                }
                else // если файл пустой
                {
                    throw new Exception("Файл пустой!");
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
