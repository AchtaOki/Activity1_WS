using System.Data;

namespace ClientSoap_DotNet2
{
    public partial class Form1 : Form
    {
        private ServiceReference1.BanqueServiceClient stub;
        public Form1()
        {
            InitializeComponent();
            stub= new ServiceReference1.BanqueServiceClient();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            double mt = Double.Parse(textBoxMt.Text);
            double res=stub.Convert(mt);
            textBoxRes.Text = res.ToString();
            
        }

        private void btnComptes_Click(object sender, EventArgs e)
        {
            ServiceReference1.compte[] cptes = stub.listComptes();
            DataTable dt =new DataTable("comptes");
            dt.Columns.Add("code");
            dt.Columns.Add("solde");
            for(int i =0; i<cptes.Length; i++)
            {
                dt.Rows.Add(cptes[i].code, cptes[i].solde);
            }
            dataGridView1.DataSource = dt;

        }
    }
}