using AutoSuite.Conexao;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;


namespace AutoSuite
{
    public partial class Form1 : Form
    {
        private List<Tuple<int, string, string>> listaDeValores = new List<Tuple<int, string, string>>();
        List<Commands> commands = new List<Commands>();
        private bool start_mapeamento = false;
        public int stepe = 1;
       
        private Thread processThread;

        public Form1()
        {
            InitializeComponent();
            CarregarNomesAutomacao();
            CenterToScreen();

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            new DraggableForm(this);
                               
        }       

        private void btn_importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*",
                Title = "Selecione um arquivo Excel"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);

                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;

                        Console.WriteLine($"Número de linhas: {rowCount}");

                        for (int row = 2; row <= rowCount; row++) // Começar a partir da segunda linha, pois a primeira linha é geralmente cabeçalho
                        {
                           
                            string tipo = worksheet.Cells[row, 2].Value.ToString();
                            string valor = worksheet.Cells[row, 3].Value.ToString();
                            

                            if (tipo == "Click")
                            {
                                // Verifica se o valor pode ser convertido para uma instância de System.Drawing.Point
                                if (!TryParsePoint(valor, out System.Drawing.Point point))
                                {
                                    MessageBox.Show($"Valor inválido para Click na linha {row}");
                                    continue; // Pula para o próximo comando
                                }
                                // Adiciona o comando de click com o valor convertido para a lista de comandos
                                commands.Add(new Commands { Type = tipo, Value = point });
                            }
                            else
                            {
                                // Adiciona os comandos que não precisam de tratamento especial diretamente à lista
                                commands.Add(new Commands { Type = tipo, Value = valor });
                            }
                        }
                    }

                    for (int i = 0; i < commands.Count; i++)
                    {
                        commands[i].Step = i + 1;
                    }

                    // Exibir os valores importados na ListView
                    ExibirComandosNaListView();
                    Console.WriteLine($"Número de comandos na lista: {commands.Count}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro durante a importação do arquivo Excel: {ex.Message}");
                }

            }
        }

        private bool TryParsePoint(string value, out System.Drawing.Point point)
        {
            point = new System.Drawing.Point();

            // Divida a string em coordenadas X e Y
            string[] coordinates = value.Split(',');
            if (coordinates.Length != 2)
                return false;

            // Tenta converter as coordenadas para inteiros
            if (!int.TryParse(coordinates[0], out int x) || !int.TryParse(coordinates[1], out int y))
                return false;

            // Define as coordenadas do ponto
            point.X = x;
            point.Y = y;

            return true;
        }

        private void ExibirComandosNaListView()
        {
            lv_itens.Items.Clear(); // Limpar itens existentes na ListView

            foreach (var command in commands)
            {
                string[] values;
                if (command.Type == "Click")
                {
                    // Se o comando for um clique, exiba as coordenadas X e Y
                    System.Drawing.Point point = (System.Drawing.Point)command.Value;
                    values = new string[] { command.Step.ToString(), "Click", $"{point.X}, {point.Y}" };
                }
                else
                {
                    // Para outros tipos de comandos, exiba o número, o tipo e o valor
                    values = new string[] { command.Step.ToString(), command.Type, command.Value.ToString() };
                }

                lv_itens.Items.Add(new ListViewItem(values));
            }
        }

        private void btn_mapear_Click(object sender, EventArgs e)
        {
            start_mapeamento = true;
            btn_mapear.Enabled  = false;
            btn_start.Enabled  = false;
            btn_parar.Enabled  = true;
            btn_importar.Enabled  = false;
            btn_exportar.Enabled  = false;
            btn_limpar.Enabled  = false;
            btn_add_text.Enabled  = false;
            btn_add_enter.Enabled  = false;
            btn_limpa1.Enabled  = false;
            new Thread(new ThreadStart(Mapear)).Start();
        }

        private void Mapear()
        {
            while (start_mapeamento)
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;

                this.Invoke((MethodInvoker)delegate
                {
                    this.lab_x.Text = "X:" + x.ToString();
                    this.lab_y.Text = "Y:" + y.ToString();
                });
                             
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (start_mapeamento)
            {
                new Thread(new ThreadStart(CallFormAgain)).Start();
                int lastStep = commands.Any() ? commands.Max(c => c.Step) : 0;
                int nextStep = lastStep + 1;
                commands.Add(new Commands { Step = nextStep, Type = "Click", Value = MousePosition });
                lv_itens.Items.Add(new ListViewItem(new string[] { nextStep.ToString(), "Click", string.Concat(MousePosition.X.ToString(), ',', MousePosition.Y.ToString()) }));               
            }
        }

        private void CallFormAgain()
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (WindowState == FormWindowState.Minimized)
                    WindowState = FormWindowState.Normal;
                else
                {
                    WindowState = FormWindowState.Normal;
                    TopMost = true;
                    BringToFront();
                }

                Activate();
            });
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            start_mapeamento = false;
            btn_mapear.Enabled  = true;
            btn_parar.Enabled  = false;
            btn_start.Enabled  = true;
            btn_importar.Enabled  = true;
            btn_exportar.Enabled  = true;
            btn_add_text.Enabled  = true;
            btn_add_enter.Enabled  = true;
            btn_limpa1.Enabled  = true;
            btn_limpar.Enabled  = true;

        }

        private void btn_add_text_Click(object sender, EventArgs e)
        {
            if (start_mapeamento)
            {
                start_mapeamento = false;
            }
            string promptValue = ShowDialog("Informa um valor", "RPA");
            if (!string.IsNullOrEmpty(promptValue))
            {
                int lastStep = commands.Any() ? commands.Max(c => c.Step) : 0;
                int nextStep = lastStep + 1;

                commands.Add(new Commands { Step = nextStep, Type = "Text", Value = promptValue });
                lv_itens.Items.Add(new ListViewItem(new string[] { nextStep.ToString(), "Text", promptValue }));
           
            }
        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 160,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,                
                StartPosition = FormStartPosition.CenterScreen,
                TopMost = true
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sneder, e) =>
            {
                prompt.Close();
            };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void btn_start_Click(object sender, EventArgs e)
        {    
            if (commands.Count == 0)
            {
                MessageBox.Show("Nenhum comando foi carregado. Por favor, importe ou adicione comandos antes de iniciar o processo.");
                return;
            }
         

            Hide();       

            new Thread(new ThreadStart(StartProcess)).Start();
        }

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        [DllImport("user32.dll")]

        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private void StartProcess()
        {
           
            try
            {

                if (commands.Count == 0)
                {
                    MessageBox.Show("Nenhum comando disponível para execução. Por favor, importe ou adicione comandos antes de iniciar o processo.");
                    return;
                }

                foreach (var command in commands)
                {
                    if (command.Type == "Click")
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            this.Cursor = new Cursor(Cursor.Current.Handle);
                            Thread.Sleep(3000);
                            if (command.Value is System.Drawing.Point point)
                            {
                                Cursor.Position = point;

                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                Thread.Sleep(1000);
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            }
                            else
                            {
                                // Se o valor não puder ser convertido, exibe uma mensagem de erro
                                MessageBox.Show("Valor do comando inválido para Click.");                              

                            }
                        });
                    }
                    else if (command.Type == "KeyPress")
                    {
                        SendKeys.SendWait("{ENTER}");
                        Thread.Sleep(7000);
                    }
                    else
                    {
                        SendKeys.SendWait(command.Value);
                        Thread.Sleep(5000);
                    }
                }           

                MessageBox.Show("Processo concluído com sucesso!");
                this.Invoke((MethodInvoker)delegate
                {
                    btn_mapear.Enabled  = true;
                    btn_parar.Enabled  = false;
                    btn_start.Enabled  = true;
                    btn_importar.Enabled  = true;
                    btn_exportar.Enabled  = true;
                    btn_add_text.Enabled  = true;
                    btn_add_enter.Enabled  = true;
                    btn_limpa1.Enabled  = true;
                    btn_limpar.Enabled  = true;                  
                           
                    // Exibe o formulário novamente
                    ShowForm();

                });
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro
                MessageBox.Show($"Ocorreu um erro durante a execução do processo: {ex.Message}");

                // Registra os detalhes do erro em um arquivo de log
                string logFilePath = "error_log.txt";
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"Data/hora do erro: {DateTime.Now}");
                    writer.WriteLine($"Exceção: {ex.ToString()}");
                    writer.WriteLine(); // Adiciona uma linha em branco para separar os registros
                }

                // Encerra o processo
                return;
            }

         

        }


        private void ShowForm()
        {
            // Exibe o formulário
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { Show(); }));
            }
            else
            {
                Show();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Garante que a thread do processo é encerrada ao fechar o formulário
            if (processThread != null && processThread.IsAlive)
            {
                processThread.Abort();
            }
            base.OnFormClosing(e);
        }


        private void btn_limpar_Click(object sender, EventArgs e)
        {
            commands.Clear();
            lv_itens.Items.Clear();
        }

        private void btn_add_enter_Click(object sender, EventArgs e)
        {
            if (start_mapeamento)
            {
                start_mapeamento = false;
            }
            // Adicionando o Enter como um comando separado
            int lastStep = commands.Any() ? commands.Max(c => c.Step) : 0;
            int nextStep = lastStep + 1;

            commands.Add(new Commands { Step = nextStep, Type = "KeyPress", Value = "{ENTER}" });
            lv_itens.Items.Add(new ListViewItem(new string[] { nextStep.ToString(), "KeyPress", "{ENTER}" }));
         
        }

        private void btn_limpa1_Click(object sender, EventArgs e)
        {
            if (lv_itens.Items.Count > 0)
            {
                // Remove o último item da lista
                lv_itens.Items.RemoveAt(lv_itens.Items.Count - 1);

                // Remove o último comando da lista
                if (commands.Count > 0)
                {
                    commands.RemoveAt(commands.Count - 1);
                }
            }
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*",
                Title = "Salvar como arquivo Excel"
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFileDialog1.FileName);

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Dados");

                    // Adicionar cabeçalhos
                    worksheet.Cells[1, 1].Value = "Etapa";
                    worksheet.Cells[1, 2].Value = "Tipo";
                    worksheet.Cells[1, 3].Value = "Valor";

                    // Adicionar os dados da lista ao arquivo Excel
                    int row = 2;
                    foreach (var command in commands)
                    {
                        string valor = (command.Type == "Click" && command.Value is System.Drawing.Point point)
                           ? $"{point.X}, {point.Y}"
                           : command.Value.ToString();

                        worksheet.Cells[row, 1].Value = row - 1; // Etapa
                        worksheet.Cells[row, 2].Value = command.Type; // Tipo
                        worksheet.Cells[row, 3].Value = valor; // Valor
                        row++;
                    }

                    // Salvar o arquivo Excel
                    package.SaveAs(fileInfo);
                }

                MessageBox.Show("Dados exportados para Excel com sucesso!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string nomeAutomacao = insert_nameauto.Text;

            bool sucessoTotal = true;

            TableAutomation tableAutomation = new TableAutomation();
            foreach (var command in commands)
            {
                Commands automacao = new Commands
                {
                    Type = command.Type,
                    Value = command.Value,
                    Step = command.Step
                };

                bool sucesso = tableAutomation.Add(automacao, nomeAutomacao);

                if (!sucesso)
                {
                    sucessoTotal = false;
                }             

            }

            if (sucessoTotal)
            {
                MessageBox.Show("Salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao salvar!");
            }

            CarregarNomesAutomacao();
        }

       

        private void select_automacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            insert_nameauto.Clear();

            if (select_automacao.SelectedItem != null)
            {
                string nomeAutomacao = select_automacao.SelectedItem.ToString();
                // Chama o método Get da classe TableAutomation para obter os comandos para a automação selecionada
                var tableAutomation = new TableAutomation();
                var Comandos = tableAutomation.Get(nomeAutomacao);

                // Exibe os comandos na ListView
                ExibirComandosNaListView(Comandos);
            }
            
        }

        private void ExibirComandosNaListView(List<Commands> Comandos)
        {
            lv_itens.Items.Clear(); // Limpar itens existentes na ListView

            
            foreach (var command in Comandos)
            {
                string[] values;
                string tipo = command.Type.ToString();
                string valor = command.Value.ToString();

                if (command.Type == "Click")
                {
                    // Se o comando for um clique, exiba as coordenadas X e Y
                    string[] coordinates = command.Value.Split(',');

                    int x = int.Parse(coordinates[0].Trim());
                    int y = int.Parse(coordinates[1].Trim());
                    System.Drawing.Point point = new System.Drawing.Point(x, y);
                    values = new string[] { command.Step.ToString(), "Click", $"{point.X}, {point.Y}" };
                    commands.Add(new Commands { Step = command.Step, Type = tipo, Value = point });

                }
                else
                {
                    // Para outros tipos de comandos, exiba o número, o tipo e o valor
                    values = new string[] { command.Step.ToString(), command.Type, command.Value.ToString() };
                    commands.Add(new Commands { Step = command.Step, Type = tipo, Value = valor });
                }

               
           
                // Adiciona os comandos que não precisam de tratamento especial diretamente à lista
              

                lv_itens.Items.Add(new ListViewItem(values));
            }
        }

        private void CarregarNomesAutomacao()
        {

            var tableAutomation = new TableAutomation();
            // Obtém os nomes distintos de automação

            List<string> NomeAutomacao = tableAutomation.GetDistinctNames();

            select_automacao.Items.Clear();

            foreach (var nomeAutomacao in NomeAutomacao)
            {
                select_automacao.Items.Add(nomeAutomacao);
            }

            select_automacao.Refresh();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (select_automacao.SelectedItem != null)
            {
                string nomeAutomacao = select_automacao.SelectedItem.ToString();
                // Chama o método Get da classe TableAutomation para obter os comandos para a automação selecionada
                var tableAutomation = new TableAutomation();
                tableAutomation.Delete(nomeAutomacao);

            }

            lv_itens.Items.Clear();
            insert_nameauto.Clear();
            select_automacao.SelectedItem = null;
            CarregarNomesAutomacao();
            MessageBox.Show("Automação Excluída!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carrega os nomes de automação no campo de seleção
            CarregarNomesAutomacao();
        }

       
    }
}
