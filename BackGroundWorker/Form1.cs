namespace BackGroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bwHilo_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i <= 150; i++)
            {
                double porcentaje = ((double) i / 150 )*100;
                simularTrabajoPesado();
                bwHilo.ReportProgress((int)porcentaje);
            }

        }

        private void simularTrabajoPesado()
        {
            Thread.Sleep(500);
        }

        private void bwHilo_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pbProgreso.Value = e.ProgressPercentage;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bwHilo.RunWorkerAsync();
        }
    }
}