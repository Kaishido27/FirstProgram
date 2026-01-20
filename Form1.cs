using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private List<Class1> classList = new List<Class1>(){
                new Class1 {Id = 2, Name = "Juan Dela Cruz" },
                new Class1 { Id = 5, Name = "Juan Luna" },
                new Class1 { Id = 7, Name = "Andres Bonifacio" },
                new Class1 { Id = 11, Name = "Emilio Aguinaldo" },
                new Class1 { Id = 13, Name = "Jose Rizal" }
            };
        public Form1()
        {
            InitializeComponent();
            LoadClassList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var class1 = new Class1();
            MessageBox.Show(class1.Name, class1.Id.ToString());
        }

        private void LoadClassList()
        {
            dataGridView1.DataSource = classList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var class1 = new Class1();
            textBox1.Text = class1.Id.ToString();
            textBox2.Text = class1.Name;
        }
    }
}
