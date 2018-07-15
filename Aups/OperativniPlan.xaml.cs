using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Aups
{
    /// <summary>
    /// Interaction logic for OperativniPlan.xaml
    /// </summary>
    public partial class OperativniPlan : Page
    {
        public OperativniPlan()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Code for refreshing
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void myDataGried_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void DodajBtnClick(object sender, RoutedEventArgs e)
        {

        }

        private void IzmeniBtnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ObrisiBtnClick(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlanClick(object sender, RoutedEventArgs e)
        {
            //Otvoriti novi window
        }

        private void lblKreirajClick(object sender, MouseButtonEventArgs e)
        {
            btnDodaj.IsEnabled = false;
        }
    }
}
