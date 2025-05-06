using System.Security.Cryptography.X509Certificates;

namespace Chuck_Jokes
{
    public partial class Form1 : Form
    {
        SaveData saveData = new SaveData();
        LoadData loadData = new LoadData();

        public Form1()
        {
            InitializeComponent();
            LoadLastSearch();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var apiHandler = new ApiHandler();
            Fact? fact = await apiHandler.GetFact();

            
            if (fact != null)
            {
                if (!string.IsNullOrEmpty(fact.icon_url))
                {
                    pictureBox1.Load(fact.icon_url);                }

                label2.Text = $"{fact.value}";



                saveData.Save("chuck_facts.txt", fact.value, fact.icon_url);
            }
            else
            {
                MessageBox.Show("Nepodaøilo se naèíst informace o kryptomìnì.");
            }
        }
        private void LoadLastSearch()
        {
            loadData.Load("chuck_facts.txt", label2, pictureBox1);
        }

    }
}
