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
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ControlWork2SP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Func<int> action;
        public MainWindow()
        {
            InitializeComponent();
            using(var context = new Context())
            {
            }
        }

        private static void Add()
        {

            using(var context = new Context())
            {
                Account account = new Account()
                {
                    Name = "Alihan",
                    Phonenumber = "+77473117378",
                    Balance = 10000
                };                
                context.Accounts.Add(account);
                context.SaveChanges();
            }
        }
        
        private static void Change()
        {
            //string token[1];
            //foreach()
            //{
            //    action = new Func<int, int>;
            //}
        }

        private void AddToSum(object sender, RoutedEventArgs e)
        {
            AddToSumWindow addToSumWindow = new AddToSumWindow();
            addToSumWindow.ShowDialog();
        }

        private void Withdraw(object sender, RoutedEventArgs e)
        {
            WithdrawWindow withdrawWindow = new WithdrawWindow();
            withdrawWindow.ShowDialog();
        }
    }
}
//не судите строго