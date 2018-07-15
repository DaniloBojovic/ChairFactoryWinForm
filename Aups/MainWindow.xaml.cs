using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aups
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

        private void BtnOperativniPlanClick(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new OperativniPlan();
        }

        private void BtnPredmetRadaClick(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new PredmetRada();
        }

        private void BtnOperacijaRadaClick(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new OperacijaRada();
        }

        private void BtnHomeClick(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new Home();
        }

        private void BtnMasinaClick(object sender, RoutedEventArgs e)
        {
            frmMain.Content = new Masina();
        }
    }
}
