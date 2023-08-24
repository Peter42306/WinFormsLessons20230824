using System.Data.Common;

namespace WinFormsApp20230824
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // двумерный массив кнопок

            Random random = new Random(); // Генератор случайных чисел для случайных цветов кнопок

            int buttonWidth = 50;
            int buttonHeight = 50;
            int distanceBetweenButtons = 10;
            int distanceFirstButtonFromLeft = 10;
            int distanceFromTop = 10;


            int x, y; // координаты кнопки в массиве на форме
            int numberOfRows = 15;
            int numberOfColumns = 30;


            for (int row = 0; row < numberOfRows; row++)
            {
                for (int column = 0; column < numberOfColumns; column++)
                {
                    // Создание экземпляра Button
                    Button button = new Button();

                    // Настройка размеров кнопки
                    button.Size = new Size(buttonWidth, buttonHeight);

                    // Координаты кнопки на форме
                    x = distanceFirstButtonFromLeft + column * (buttonWidth + distanceBetweenButtons);
                    y = distanceFromTop + row * (buttonHeight + distanceBetweenButtons);
                    
                    button.Location = new Point(x, y);

                    // Цвет кнопки
                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    button.BackColor = randomColor;

                    // Текст кнопки
                    button.Text = ((row * numberOfColumns) + column + 1).ToString();

                    button.Parent = this;
                }
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