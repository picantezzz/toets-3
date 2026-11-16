namespace toets_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnfactuurmaken_Click(object sender, EventArgs e)
        {
            if (txtfactuurid.Text != "" && txtnaamklant.Text != "")
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnfactuurmaken=true)
            {
                
            }
        }

        private void btnfactuurlijn_Click(object sender, EventArgs e)
        {


            if (txtproduct.Text != "" && txtaantal.Text != "")
            {

            }
        }

        private void txtnaamklant_TextChanged(object sender, EventArgs e)
        {
            txtnaamklant.Text = Convert.ToString(txtnaamklant.Text);
        }

        

        private void txtproduct_TextChanged(object sender, EventArgs e)
        {
            txtproduct.Text = Convert.ToString(txtproduct.Text);
        }
    }
}
