using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thirtysix_app.Model.Requests;

namespace Thirtysix_app.WinUI
{
    public partial class frmPretraga : Form
    {
        APIService _bicikliService = new APIService("Bicikli");
        public frmPretraga()
        {
            InitializeComponent();
        }
        private async void frmPretraga_Load(object sender, EventArgs e)
        {
            await LoadBicikli();
            
        }

        private async Task LoadBicikli()
        {
            var lista = await _bicikliService.Get<List<Model.Bicikli>>(null);
            dgvPretraga.DataSource = lista;
            dgvPretraga.Refresh();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            BicikliSearchRequest search = new BicikliSearchRequest();
            search.Naziv = txtPretraga.Text;
            var li = await _bicikliService.Get<List<Model.Bicikli>>(search);
            dgvPretraga.DataSource = li;
            dgvPretraga.Refresh();
        }

        
    }
}
