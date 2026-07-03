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
    public partial class frmTelaAtualizar : Form
    {
        private int idSelecionado;
        public frmTelaAtualizar()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frmTelaConsultar novaJanela = new frmTelaConsultar();
            novaJanela.FormClosed += (s, args) => Application.Exit();
            novaJanela.Show();
            this.Hide();
        }

        private async void cBox_Atualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SerieSelecionada = cBox_Atualizar.Text;

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

                        dgvAtualizar.DataSource = dados;
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

                        dgvAtualizar.DataSource = dados;
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

                        dgvAtualizar.DataSource = dados;
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

                        dgvAtualizar.DataSource = dados;
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


        private async void btn_inserir_Click(object sender, EventArgs e)
        {
            string apiUrl = "http://127.0.0.1:5000/";

            switch (cBox_Atualizar.Text)
            {
                case "Série A":
                    apiUrl = ApiRotasController.InserirSerie_A;
                    break;

                case "Série B":
                    apiUrl = ApiRotasController.InserirSerie_B;
                    break;

                case "Série C":
                    apiUrl = ApiRotasController.InserirSerie_C;
                    break;

                case "Série D":
                    apiUrl = ApiRotasController.InserirSerie_D;
                    break;

                default:
                    MessageBox.Show("Selecione uma série.");
                    return;
            }

            var clube = new
            {
                NomeClube = txt_nomeTime.Text,
                PontosClube = int.Parse(txt_pontos.Text),
                PosicaoClube = int.Parse(txt_posicao.Text),
                JogosClube = int.Parse(txt_jogosTime.Text),
                VitoriasClube = int.Parse(txt_vitorias.Text),
                EmpatesClube = int.Parse(txt_empates.Text),
                DerrotasClube = int.Parse(txt_derrotas.Text),
                GolsProClube = int.Parse(txt_golsTime.Text),
                GolsContraClube = int.Parse(txt_golsSofridos.Text),
                SaldoGolsClube = int.Parse(txt_saldoTime.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    string json = JsonConvert.SerializeObject(clube);

                    StringContent conteudo = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, conteudo);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Clube inserido com sucesso!");

                        // Atualiza a tabela automaticamente
                        cBox_Atualizar_SelectedIndexChanged(null, null);
                    }
                    else
                    {
                        MessageBox.Show(await response.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private async void btn_apagar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um clube.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este clube?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string apiUrl = "";

            switch (cBox_Atualizar.Text)
            {
                case "Série A":
                    apiUrl = ApiRotasController.ExcluirSerie_A(idSelecionado);
                    break;

                case "Série B":
                    apiUrl = ApiRotasController.ExcluirSerie_B(idSelecionado);
                    break;

                case "Série C":
                    apiUrl = ApiRotasController.ExcluirSerie_C(idSelecionado);
                    break;

                case "Série D":
                    apiUrl = ApiRotasController.ExcluirSerie_D(idSelecionado);
                    break;

                default:
                    MessageBox.Show("Selecione uma série.");
                    return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Clube excluído com sucesso!");

                        switch (cBox_Atualizar.Text)
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
                        }
                    }
                    else
                    {
                        MessageBox.Show(await response.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void btn_atualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ID no botão: {idSelecionado}");

            if (idSelecionado == 0)
            {
                MessageBox.Show("Selecione um clube.");
                return;
            }

            string apiUrl = "";

            switch (cBox_Atualizar.Text)
            {
                case "Série A":
                    apiUrl = ApiRotasController.AtualizarSerie_A(idSelecionado);
                    break;

                case "Série B":
                    apiUrl = ApiRotasController.AtualizarSerie_B(idSelecionado);
                    break;

                case "Série C":
                    apiUrl = ApiRotasController.AtualizarSerie_C(idSelecionado);
                    break;

                case "Série D":
                    apiUrl = ApiRotasController.AtualizarSerie_D(idSelecionado);
                    break;

                default:
                    MessageBox.Show("Selecione uma série.");
                    return;
            }

            var clube = new
            {
                NomeClube = txt_nomeTime.Text,
                PontosClube = int.Parse(txt_pontos.Text),
                PosicaoClube = int.Parse(txt_posicao.Text),
                JogosClube = int.Parse(txt_jogosTime.Text),
                VitoriasClube = int.Parse(txt_vitorias.Text),
                EmpatesClube = int.Parse(txt_empates.Text),
                DerrotasClube = int.Parse(txt_derrotas.Text),
                GolsProClube = int.Parse(txt_golsTime.Text),
                GolsContraClube = int.Parse(txt_golsSofridos.Text),
                SaldoGolsClube = int.Parse(txt_saldoTime.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    string json = JsonConvert.SerializeObject(clube);

                    StringContent conteudo = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response =
                        await client.PutAsync(apiUrl, conteudo);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Clube atualizado com sucesso!");

                        switch (cBox_Atualizar.Text)
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
                        }
                    }
                    else
                    {
                        MessageBox.Show(await response.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvAtualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            DataGridViewRow linhaSelecionada = dgvAtualizar.Rows[e.RowIndex];

            switch (cBox_Atualizar.Text)
            {
                case "Série A":
                    idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["idSerieA"].Value);
                    MessageBox.Show($"Selecionou o ID: {idSelecionado}");
                    break;

                case "Série B":
                    idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["idSerieB"].Value);
                    MessageBox.Show($"Selecionou o ID: {idSelecionado}");
                    break;

                case "Série C":
                    idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["idSerieC"].Value);
                    MessageBox.Show($"Selecionou o ID: {idSelecionado}");
                    break;

                case "Série D":
                    idSelecionado = Convert.ToInt32(linhaSelecionada.Cells["idSerieD"].Value);
                    MessageBox.Show($"Selecionou o ID: {idSelecionado}");
                    break;
            }

            txt_nomeTime.Text = linhaSelecionada.Cells["NomeClube"].Value?.ToString() ?? "";
            txt_jogosTime.Text = linhaSelecionada.Cells["JogosClube"].Value?.ToString() ?? "";
            txt_vitorias.Text = linhaSelecionada.Cells["VitoriasClube"].Value?.ToString() ?? "";
            txt_derrotas.Text = linhaSelecionada.Cells["DerrotasClube"].Value?.ToString() ?? "";
            txt_empates.Text = linhaSelecionada.Cells["EmpatesClube"].Value?.ToString() ?? "";
            txt_pontos.Text = linhaSelecionada.Cells["PontosClube"].Value?.ToString() ?? "";
            txt_posicao.Text = linhaSelecionada.Cells["PosicaoClube"].Value?.ToString() ?? "";
            txt_golsTime.Text = linhaSelecionada.Cells["GolsproClube"].Value?.ToString() ?? "";
            txt_golsSofridos.Text = linhaSelecionada.Cells["GolscontraClube"].Value?.ToString() ?? "";
            txt_saldoTime.Text = linhaSelecionada.Cells["SaldoGolsClube"].Value?.ToString() ?? "";
        }
    }
}


