namespace WinFormsApp20230824
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Создание и настройка кнопки
            Button b = new Button();
            b.Width = 50;
            b.Height = 50;
            b.Location = new Point(10, 10);
            b.Text = "1";            
            b.Parent = this; // Установка текущей формы в качестве родительского элемента кнопки
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}