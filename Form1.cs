namespace Chuck_Jokes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var apiHandler = new ApiHandler();
            Fact? fact = await apiHandler.GetFact();

            
            if (fact != null)
            {
                if (!string.IsNullOrEmpty(fact.icon_url))
                {
                    pictureBox1.Load(fact.icon_url);
                }

                label2.Text = $"{fact.value}";
            }
            else
            {
                MessageBox.Show("Nepodaøilo se naèíst informace o kryptomìnì.");
            }
        }
    }
}
