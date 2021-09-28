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


namespace CS155Homework5Part1
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int BMI_GOOD_RANGE_LOW  = 15;
        const int BMI_GOOD_RANGE_HIGH = 26;
        public MainWindow()
        {
            InitializeComponent();

            this.Title = "BMI Calculator";

            txtWeight.Focus();

        }


        private void txtHeight_GotFocus(object sender, RoutedEventArgs e)
        {
            txtHeight.SelectAll();
        }

        private void txtWeight_GotFocus(object sender, RoutedEventArgs e)
        {
            txtWeight.SelectAll();
        }

        private void cmdCalcBMI_OnClick(object sender, RoutedEventArgs e)
        {
            double dWeight, dHeight, dBMI;
            bool bResult;

            bResult = Double.TryParse(txtWeight.Text, out dWeight);
            if (!bResult)
            {
                MessageBox.Show("Please enter a valid Weight!");
                return;
            }

            bResult = Double.TryParse(txtHeight.Text, out dHeight);
            if (!bResult)
            {
                MessageBox.Show("Please enter a valid Height!");
                return;
            }

            dBMI = dWeight * 720.0 / (dHeight * dHeight);
            String sdBMI = String.Format("{0:F1}", dBMI);

            if (dBMI >= BMI_GOOD_RANGE_LOW && dBMI <= BMI_GOOD_RANGE_HIGH)
            {
                lblBMIOutput.Content = "Your BMI : " + sdBMI + " is excellent!";
                lblBMIOutput.Background = Brushes.Green;
            }
            else if(dBMI < BMI_GOOD_RANGE_LOW)
            {
                lblBMIOutput.Content = "Your BMI : " + sdBMI + " is LOW!";
                lblBMIOutput.Background = Brushes.Blue;

            }
            else 
            {
                lblBMIOutput.Content = "Your BMI : " + sdBMI + " is HIGH!";
                lblBMIOutput.Background = Brushes.Yellow;

                                                                                                                    }
        }

        private void txtWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lblBMIOutput != null)
            {
                lblBMIOutput.Content = "";
                lblBMIOutput.Background = Brushes.White; // canvasMain.Background;
            }

        }

        private void txtHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lblBMIOutput != null)
            { 
                lblBMIOutput.Content = "";
                lblBMIOutput.Background =  Brushes.White; // canvasMain.Background;
            }
        }
    }
}
