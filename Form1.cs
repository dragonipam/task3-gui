namespace task3_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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