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
using Classes;

namespace AsyncWPF
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

            public async void PrimeFinder(int n, TextBox txtbox)
            {
                  var primenumber = new Class1();

                  var result = await Class1.AsyncWPF(n);

                  txtbox.Text = result.ToString();
            }

            private void PrimeFinderBtn_Click(object sender, RoutedEventArgs e)
            {
                  PrimeFinder(int.Parse(input.Text), resultofsearchertxtbox);
            }

      }
}
