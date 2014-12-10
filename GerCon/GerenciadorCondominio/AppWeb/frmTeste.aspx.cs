using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;

namespace AppWeb.Views
{

    public partial class frmTeste : System.Web.UI.Page
    {
        dalMorador m = new dalMorador();
        clsMorador mr = new clsMorador();
        clsFuncionario fr = new clsFuncionario();
        dalFuncionario f = new dalFuncionario();
        protected void Page_Load(object sender, EventArgs e)
        {
            
           GridView1.DataSource = f.LerRegistros();
            GridView1.DataBind();
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {                     
                //Button1.Attributes.Add("OnClick", "poptastic('"+TextBox1.Text+"');");
            clsFuncionario fr1 = new clsFuncionario();
            int aux = Convert.ToInt32(GridView1.SelectedIndex.ToString());
            fr = f.LerRegistros().ElementAt<clsFuncionario>(aux);
            fr1.Nome = TextBox1.Text;
            fr1.CPF = TextBox2.Text;
            fr1.RG = TextBox3.Text;
            fr1.ID = fr.ID;
            fr1.Lotacao.ID = fr.Lotacao.ID;
            fr1.Lotacao.Nome = fr.Lotacao.Nome;
            fr1.Lotacao.Endereco = fr.Lotacao.Endereco;
            fr1.Lotacao.Sindico = fr.Lotacao.Sindico;
            f.Excluir(fr1);
             
            GridView1.DataSource = f.LerRegistros();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux= Convert.ToInt32(GridView1.SelectedIndex.ToString());
            fr = f.LerRegistros().ElementAt<clsFuncionario>(aux);
            Label1.Text = Convert.ToString(fr.ID);
            Label2.Text = Convert.ToString(fr.Lotacao.ID);
            TextBox1.Text = fr.Nome;
            TextBox2.Text = fr.CPF;
            TextBox3.Text = fr.RG;

        }

       
    }
}