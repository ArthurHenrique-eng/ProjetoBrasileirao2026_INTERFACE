using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBrasileirao
{
    public partial class frmTelaConsultar : Form
    {
        public frmTelaConsultar()
        {
            InitializeComponent();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            frmTelaAtualizar novaJanela = new frmTelaAtualizar();
            novaJanela.FormClosed += (s, args) => Application.Exit();
            novaJanela.Show();
            this.Hide();
        }

        private void btn_paginaPrincipal_Click(object sender, EventArgs e)
        {
            frmPrincipal novaJanela = new frmPrincipal();
            novaJanela.FormClosed += (s, args) => Application.Exit();
            novaJanela.Show();
            this.Hide();
        }

        private async void btn_consultar_Click(object sender, EventArgs e)
        {
            string SerieSelecionada = cbox_series.Text;

            switch (SerieSelecionada)
            {
                case "Série A":
                    await ConsultarSerie_A();
                    break;

                case "Série B":
                    await ConsultarSerie_B();
                    break;
                case "Série C":
                    await ConsultarSerie_C();
                    break;
                case "Série D":
                    await ConsultarSerie_D();
                    break;
                default:
                    MessageBox.Show("Selecione uma série válida.");
                    break;
            }
        }

        private async Task ConsultarSerie_D()
        {
            string apiUrl = ApiRotasController.ConsultarSerie_D;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSeriaDModel>>(jsonString);

                        dvgConsultar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task ConsultarSerie_C()
        {
            string apiUrl = ApiRotasController.ConsultarSerie_C;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieCModel>>(jsonString);

                        dvgConsultar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task ConsultarSerie_B()
        {
            string apiUrl = ApiRotasController.ConsultarSerie_B;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieBAModel>>(jsonString);

                        dvgConsultar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task ConsultarSerie_A()
        {
            string apiUrl = ApiRotasController.ConsultarSerie_A;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSeriaAModel>>(jsonString);

                        dvgConsultar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }
    }
}