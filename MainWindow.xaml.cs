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

namespace EnhancedNotepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SearchBox.Text = "....";
        }

        private void MainTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             Console.WriteLine(".");

            TextRange textRange = new TextRange(MainTextBox.Document.ContentStart, MainTextBox.Document.ContentEnd);

            List<string> keyWordList = KeyWordFactory.GetKeyWordList(textRange.Text, "most used");
            foreach (string word in keyWordList)
                SearchBox.Text = SearchBox.Text + " " + word.Trim();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("GO");
            
        }
    }
}
