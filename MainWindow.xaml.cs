namespace Szamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tetszoleges(object sender, RoutedEventArgs e) {
          String eredmeny = $"{txtAszam.Text} + {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text)}";
          MessageBox.Show("Az összeadás eredménye:" + eredmeny);
          lbEredmenyek.Items.Add(eredmeny);
        }

        private void btnKivon_Click(object sender, RoutedEventArgs e) {
          String eredmeny = $"{txtAszam.Text} - {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text)}";
          MessageBox.Show("A kivonás eredménye:" + eredmeny);
          lbEredmenyek.Items.Add(eredmeny);
        }

        private void btnSzoroz_Click(object sender, RoutedEventArgs e) {
          String eredmeny = $"{txtAszam.Text} * {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text)}";
          MessageBox.Show("A szorzás eredménye:" + eredmeny);
          lbEredmenyek.Items.Add(eredmeny);
        }

        private void btnOszt_Click(object sender, RoutedEventArgs e) {
          if((Convert.ToDouble(txtBszam.Text) ==0)) {
            MessageBox.Show("0-val nem osztunk!");
          } else {
          String eredmeny = $"{txtAszam.Text} / {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text)}";
          MessageBox.Show("Az osztás eredménye:" + eredmeny);
          lbEredmenyek.Items.Add(eredmeny);
          }
        }
    }
}
