namespace TRPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    richTextBox1.Text = ReadFile("Расписание.txt");
                    break;
                case 1:
                    richTextBox1.Text = ReadFile("Задачи.txt");
                    break;
                case 2:
                    richTextBox1.Text = ReadFile("Книги.txt");
                    break;
            }
        }
        private string ReadFile(string name)
        {
            string line;
            using (var fileStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    line = streamReader.ReadToEnd();
                }
            }
            return line;
        }
        private void SaveFile(string name, string text)
        {
            using (var fileStream = new FileStream(name, FileMode.Create, FileAccess.Write))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    SaveFile("Расписание.txt", richTextBox1.Text);
                    break;
                case 1:
                    SaveFile("Задачи.txt", richTextBox1.Text);
                    break;
                case 2:
                    SaveFile("Книги.txt", richTextBox1.Text);
                    break;
            }
        }
    }
}