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

namespace CSharpTask1WithOOP
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

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            ShowTextArea();
        }

        private void ShowTextArea()
        {
            this.TxtField.Visibility = Visibility.Visible;
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            DownButton db = new DownButton();
            if (!IButton.isPrinting)
            {
                ClearTextArea();
                db.printStars(this);
            } else
            {
                ShowWaitMessage();
            }
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            RightButton rb = new RightButton();
            if (!IButton.isPrinting)
            {
                ClearTextArea();
                rb.printStars(this);
            } else
            {
                ShowWaitMessage();
            }
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            LeftButton lb = new LeftButton();
            if (!IButton.isPrinting)
            {
                ClearTextArea();
                lb.printStars(this);
            } else
            {
                ShowWaitMessage();
            }
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            UpButton ub = new UpButton();
            if (!IButton.isPrinting)
            {
                ClearTextArea();
                ub.printStars(this);
            } else
            {
                ShowWaitMessage();
            }
        }

        private void ShowWaitMessage()
        {
            MessageBox.Show("Please wait until ongoing print completes.");
        }

        private void ClearTextArea()
        {
            TxtField.Clear();
        }
    }
}
