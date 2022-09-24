namespace task3_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSentence.Text = Properties.Settings.Default.sentence.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence = this.txtSentence.Text;
            Properties.Settings.Default.sentence = sentence;
            Properties.Settings.Default.Save();
            MessageBox.Show($"Начальная строка: {sentence}\n Конечная строка: {Logic.Compare(sentence)}", "Ответ", MessageBoxButtons.OK);
        }
    }
    public class Logic
    {
        public static string Compare(string sentence)
        {
            string[] initialString = sentence.Split(' ');
            List<string> finiteString = new(initialString.Length);
            for (int i = 0; i < initialString.Length; i++)
            {
                if (initialString[i].Length % 2 == 0)
                {
                    finiteString.Add(initialString[i].Replace('d', 't'));
                    finiteString.Add(initialString[i].Replace('d', 't'));
                }
            }
            string outMessage = string.Join(" ", finiteString);
            return outMessage;
        }
    }
}