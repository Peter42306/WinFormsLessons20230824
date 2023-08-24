using System.Data.Common;

namespace WinFormsApp20230824
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // массив кнопок

            int buttonWidth = 50;
            int buttonHeight = 50;
            int distanceBetweenButtons = 10;
            int distanceFirstButtonFromLeft = 10;

            int numberOfButtons = 12;

            for (int i = 0; i < numberOfButtons; i++)
            {
                // Создание экземпляра Button
                Button button = new Button();

                // Настройка размеров кнопки
                button.Size = new Size(buttonWidth, buttonHeight);

                // Расположение кнопки на форме, в зависимости от индекса i
                button.Location = new Point(
                    distanceFirstButtonFromLeft + i * (buttonWidth + distanceBetweenButtons),
                    distanceBetweenButtons
                    );

                // Текст кнопки
                button.Text = (i + 1).ToString();

                // Подписка на событие "MouseDown"
                button.MouseDown += B_MouseDown; 

                button.Parent = this;
            }
        }

        private void B_MouseDown(object? sender, MouseEventArgs e)
        {
            Button? button = sender as Button; // Преобразование отправителя в тип Button
            button.Visible = false; // Скрытие кнопки при нажатии на неё
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}