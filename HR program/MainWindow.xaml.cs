using System.Windows;

namespace HR_program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != string.Empty && txtSurname.Text != string.Empty)
            {
                lstw.Items.Add(new { Name = txtName.Text, Surname = txtSurname.Text, BirthDate = txtDate.Text });
                txtName.Clear();
                txtSurname.Clear();
                txtDate.Text = string.Empty;
            }
            else
                MessageBox.Show("You can not enter empty name or surname", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            lstw.Items.Remove(lstw.SelectedItem);
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtDate.Text = string.Empty;
            lstw.Items.Clear();
        }
    }
}
