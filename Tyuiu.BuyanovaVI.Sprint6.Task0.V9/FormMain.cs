using Tyuiu.BuyanovaVI.Sprint6.Task0.V9.Lib;
namespace Tyuiu.BuyanovaVI.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        DataService service1 = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDo_VA_Click(object sender, EventArgs e)
        {
            try
            {

                textBoxRezulting_VA.Text = service1.Calculate(Convert.ToInt32(textBoxZnach_VA.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("x = 3");
                textBoxRezulting_VA.Text = service1.Calculate(3).ToString();
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� �������� ������� ������ ����-23-2 ��������� �.�.", "���������");
        }
    }
}
