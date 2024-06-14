using System.Diagnostics;

namespace ProjectJsonToCsvConverter
{
    public partial class JsonToCsvForm : Form
    {
        public JsonToCsvForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            var api = textBoxAPI.Text;
            var userIntput = $"{textBoxUserInput.Text}/";

            try
            {
                JsonToCsv.CheckUserInput(api);
                JsonToCsv.CheckUserInput(userIntput);
                textBoxJson.Text = JsonToCsv.GetJson(api, userIntput);
            }
            catch (Exception ex)
            {
                DisplayInvalidInputMessage(ex.Message, "Error");
                return;
            }


        }

        private void DisplayInvalidInputMessage(string message, string v)
        {
            MessageBox.Show(message, v);
        }

        private void textBoxJson_TextChanged(object sender, EventArgs e)
        {
            btnConvert.Visible = true;
            btnConvert.Focus();
            textBoxCsv.Clear();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            textBoxCsv.Text = JsonToCsv.GetCsv();
        }

        private void textBoxCsv_TextChanged(object sender, EventArgs e)
        {
            textBoxUserInput.Focus();
        }

        private void btnRequest_Click_1(object sender, EventArgs e)
        {

        }
    }
}
