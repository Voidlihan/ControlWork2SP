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
using System.Windows.Shapes;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ControlWork2SP
{
    /// <summary>
    /// Interaction logic for WithdrawWindow.xaml
    /// </summary>
    public partial class WithdrawWindow : Window
    {
        public WithdrawWindow()
        {
            InitializeComponent();
        }

        private void WithdrawInputButton(object sender, RoutedEventArgs e)
        {
            var input = new Account()
            {
                Phonenumber = textBoxWithdrawPhonenumberInput.Text,
                Balance = Convert.ToDouble(textBoxWithdrawPhonenumberInput.Text)
            };
        }

        private static void Change()
        {
        }

        private static void MessageWithdraw(IAsyncResult res)
        {
            const string accountSid = "ACa4cec7c1c6cbcd6182f33717e5702381";
            const string authToken = "987ad962ecf6e5b0e2f36818aed7a264";
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                body: $"На вашем счету было снято: {MainWindow.action.EndInvoke(res)}",
                from: new Twilio.Types.PhoneNumber("+15017122661"),
                to: new Twilio.Types.PhoneNumber("+77473117378")
            );
        }
    }
}
