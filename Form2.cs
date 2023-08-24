using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp20230824
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // двумерный массив кнопок

            int buttonWidth = 50;
            int buttonHeight = 50;
            int distanceBetweenButtons = 10;
            int distanceFirstButtonFromLeft = 10;
            int distanceFromTop = 10;

            int x, y;
            int numberOfRows = 8;
            int numberOfColumns = 14;

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int column = 0; column < numberOfColumns; column++)
                {
                    Button button = new Button();
                    button.Size = new Size(buttonWidth, buttonHeight);

                    x = distanceFirstButtonFromLeft + column * (buttonWidth + distanceBetweenButtons);
                    y = distanceFromTop + row * (buttonHeight + distanceBetweenButtons);

                    button.Location = new Point(x, y);
                    button.Text = ((row * numberOfColumns) + column + 1).ToString();
                    button.Parent = this;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
