using JSONWPF;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JsonForm
{
      /// <summary>
      /// Interaction logic for MainWindow.xaml
      /// </summary>
      public partial class MainWindow : Window
      {
            HttpClient client = new HttpClient();

            public MainWindow()
            {
                  InitializeComponent();
            }

            private async void Button_Click(object sender, RoutedEventArgs e)
            {
                  client.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/posts/1/comments");

                  HttpResponseMessage httpResponseMessage = await client.GetAsync("posts");

                  var content = await httpResponseMessage.Content.ReadAsStringAsync();

                  var posts = JsonConvert.DeserializeObject<List<ClassPost>>(content);

                  string json = JsonConvert.SerializeObject(posts);

                  jsonlabel.Content = json;
            }
      }
}
