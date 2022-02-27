namespace Generador_de_numeros_aleatotios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            var code = new char[6];
            var nums = "123456789";
            var numr = new Random();
            for (int i = 0; i <code.Length; i++)
                {
                code[i] = nums[numr.Next(code.Length)];
                }
            var result = new string(code);
            txt.Text = result;
        }
    }
}