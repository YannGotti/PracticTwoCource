using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolkovFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            int selected = actionComboBox.SelectedIndex;

            switch (selected)
            {
                case 0: // Показать сообщение
                    {
                        string text = messageTextBox.Text;
                        MessageBox.Show(text, "Сообщение");
                    }
                    break;
                case 1: // Записать сообщение в поле
                    {
                        if (rusCheckBox.Checked)
                            messageTextBox.Text = "Привет, Мир!";
                        else
                            messageTextBox.Text = "Hello, World!";
                    }
                    break;
                case 2: // Добавить сообщение в список
                    {
                        string text = messageTextBox.Text;
                        if (!string.IsNullOrEmpty(text))
                            messagesListBox.Items.Add(text);
                    }
                    break;
                case 3: // Удалить выбранное сообщение
                    {
                        // номер выделенного сообщения
                        int selectedItem = messagesListBox.SelectedIndex;
                        if (selectedItem >= 0)
                        {
                            // само выделенное сообщение
                            string text = messagesListBox.Items[selectedItem] as string;
                            // запрос удаления
                            DialogResult res = MessageBox.Show(
                                "Желаете удалить сообщение " + text + "?",
                                "Удаление сообщения", MessageBoxButtons.YesNo);
                            if (res == DialogResult.Yes)
                                messagesListBox.Items.RemoveAt(selectedItem);
                        }
                    }
                    break;
                case 4: // Очистить список
                    {
                        // запрос очистки списка
                        DialogResult res = MessageBox.Show(
                            "Желаете очистить список сообщений?",
                            "Очистка списка сообщения", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                            messagesListBox.Items.Clear();
                    }
                    break;
                case 5: // Записать все сообщения в текстовое поле
                    {
                        // Собрать все сообщения в один текст
                        StringBuilder text = new StringBuilder();
                        for (int i = 0; i < messagesListBox.Items.Count; i++)
                        {
                            text.AppendLine(messagesListBox.Items[i].ToString());
                        }
                        // Записать текст в текстовое поле
                        textRichTextBox.Text = text.ToString();
                    }
                    break;
                case 6: // Показать изображение
                    {
                        // Диалог выбора файла
                        OpenFileDialog dlg = new OpenFileDialog();
                        // Настройка фильтра файлов
                        dlg.Filter = "Файлы PNG|*.png|Файлы JPEG|*.jpg";
                        dlg.FilterIndex = 1;
                        // Показать диалог
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            // задать имя файла изображения
                            pictureBox.ImageLocation = dlg.FileName;
                        }
                    }
                    break;
            }
        }
    }
}
