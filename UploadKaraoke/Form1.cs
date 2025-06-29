namespace UploadKaraoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selecionarPastaLida_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pastaParaLer.Text = dialog.SelectedPath;
            }
        }

        private void selecionarPastaDestino_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog dialog = new();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pastaDestino.Text = dialog.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string diretorioAtual = pastaParaLer.Text;
            string diretorioDestino = pastaDestino.Text;

            int contador = int.Parse(contadorInput.Text);

            List<string> arquivosRenomeados = [];

            if (!Directory.Exists(diretorioAtual))
            {
                MessageBox.Show("O diretorio selecionado não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(diretorioDestino))
            {
                MessageBox.Show("O diretorio selecionado não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DirectoryInfo diretorioParaSerLido = new(diretorioAtual);
            FileInfo[] arquivos = diretorioParaSerLido.GetFiles();

            foreach (FileInfo arquivo in arquivos)
            {
                string nomeCompleto = Path.Combine(diretorioDestino, $"{contador}{arquivo.Extension}");

                string nomeLista = $"{contador} - {arquivo.Name}";

                arquivosRenomeados.Add(nomeLista);

                arquivo.MoveTo(nomeCompleto);

                contador++;
            }

            string caminhoDoArquivo = Path.Combine(diretorioDestino, "arquivo_gerado_listagem.txt");

            using StreamWriter writer = new(caminhoDoArquivo);

            foreach (var musica in arquivosRenomeados)
            {
                writer.WriteLine(musica);
            }

            MessageBox.Show("Processo realizado com sucesso!", "Sucesso");
        }
    }
}
