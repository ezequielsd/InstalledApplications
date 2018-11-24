using CFSqlCe.Dal;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstalledApplications.BLL;

namespace InstalledApplications
{
    public partial class frmMain : Form
    {

        CultureInfo culturaAtual;

        public frmMain()
        {
            InitializeComponent();
            culturaAtual = CultureInfo.CurrentCulture;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AjustaIdioma(culturaAtual.Name);
            listViewProgramas.View = View.Details;
            listViewProgramas.Columns.Add("Programas", 400, HorizontalAlignment.Left);
            listViewProgramas.Columns.Add("Editor", 200, HorizontalAlignment.Left);
            listViewProgramas.Columns.Add("Data Instalacao", 120, HorizontalAlignment.Left);
            listViewProgramas.Columns.Add("Versão", 130, HorizontalAlignment.Left);
            listViewProgramas.Columns.Add("Local Instalacao", 500, HorizontalAlignment.Left);
            AjustaIdiomaListView(culturaAtual.Name);

            var teste = InstalledApplications.Idiomas.pt_BR.perfilSalvo;
        }

        /// <summary>
        /// Change language to PT-br
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLanguagePTbr_Click(object sender, EventArgs e)
        {
            AjustaIdioma("pt-BR");
            AjustaIdiomaListView("pt-BR");
        }

        /// <summary>
        /// Change language to EN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLanguageEN_Click(object sender, EventArgs e)
        {
            AjustaIdioma("en-US");
            AjustaIdiomaListView("en-US");
        }

        /// <summary>
        /// Botão lista programas instalados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarProgramasLocal_Click(object sender, EventArgs e)
        {
            InsertItemsListView();
        }

        /// <summary>
        /// Salvar os itens selecionados no listview em um profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProgramas.Items.Count > 0)
                {
                    Profile profile = new Profile();
                    List<Aplicacao> listAplicacoes = new List<Aplicacao>();

                    foreach (ListViewItem item in listViewProgramas.Items)
                    {
                        if (item.Checked)
                        {
                            Aplicacao aplicacao = new Aplicacao();
                            aplicacao.DisplayName = item.Text;
                            aplicacao.DisplayVersion = item.SubItems[3].Text;
                            aplicacao.InstallSource = item.SubItems[4].Text;
                            aplicacao.Publisher = item.SubItems[1].Text;

                            listAplicacoes.Add(aplicacao);
                        }
                    }

                    profile.Nome = cmbProfile.Text;
                    profile.DataCriacao = DateTime.Now;
                    ProfileBLL.Criar(profile);

                    MessageBox.Show("Perfil salvo com sucesso!", "Perfil salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        /// <summary>
        /// Evento do check do Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkSelecionarTudo_CheckedChanged(object sender, EventArgs e)
        {
            if (listViewProgramas.Items.Count > 0)
            {
                bool check = false;
                if (chkSelecionarTudo.Checked)
                    check = true;

                foreach (ListViewItem item in listViewProgramas.Items)
                    item.Checked = check;
            }
        }

        /// <summary>
        /// Insert list of applications
        /// </summary>
        private void InsertItemsListView()
        {
            var dados = RegistryFunctionsBLL.GetListAllApplications();
         
            foreach (var dado in dados)
            {
                ListViewItem item = new ListViewItem();
               
                item.Text = dado.DisplayName;                                            
                item.SubItems.Add(dado.Publisher);
                item.SubItems.Add(dado.InstallDate);
                item.SubItems.Add(dado.DisplayVersion);
                item.SubItems.Add(dado.InstallSource);

                listViewProgramas.Items.Add(item);
            }
        }
        
        /// <summary>
        /// Método ajusta o idioma da UI
        /// </summary>
        /// <param name="culturaName">Nome da cultura ativa na thread</param>
        private void AjustaIdioma(string culturaName)
        {
            Idioma.AjustaCultura(this, culturaName);

            switch (culturaName)
            {
                case "pt-BR":
                    btnLanguageEN.Enabled = true;
                    btnLanguagePTbr.Enabled = false;
                    break;
                case "en-US":
                    btnLanguageEN.Enabled = false;
                    btnLanguagePTbr.Enabled = true;
                    break;
                default:
                    break;
            }

            //ResourceManager rm = new ResourceManager("InstalledApplications.Resouces.Resource1",
            //Assembly.GetExecutingAssembly());
            //String strWebsite = rm.GetString("Website", CultureInfo.CurrentCulture);
            //String strName = rm.GetString("Name");
        }

        /// <summary>
        /// Método ajusta o idioma do listview
        /// </summary>
        /// <param name="culturaName">Nome da cultura ativa na thread</param>
        private void AjustaIdiomaListView(string culturaName)
        {
            switch (culturaName)
            {
                case "pt-BR":                  
                    listViewProgramas.Columns[0].Text = "Programas";                    
                    listViewProgramas.Columns[1].Text = "Editor";
                    listViewProgramas.Columns[2].Text = "Data Instalação";
                    listViewProgramas.Columns[3].Text = "Versão";
                    listViewProgramas.Columns[4].Text = "Local Instalacao";
                    break;
                case "en-US":
                    listViewProgramas.Columns[0].Text = "Program";
                    listViewProgramas.Columns[1].Text = "Version";                    
                    break;
                default:
                    break;
            }
        }
        
    }
}
;