
using System.Data;
namespace Calculator_in_C_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            textBox1.ReadOnly = true;
            textBox1.Font = new(textBox1.Font.FontFamily, 18);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Leave the main function empty or display any message when the screen load
        }

        private void equal_button(object sender, EventArgs e)
        {
            var result = new DataTable();
            var evaluatedResult = result.Compute(textBox1.Text, "");

            // Ensure the result is a valid numeric value and set it as a string
            textBox1.Text = evaluatedResult.ToString();

        }

        private void button_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            textBox1.Text += clickedButton.Text;

        }

        private void clear_button(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
