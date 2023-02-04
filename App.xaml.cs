using ChatAppClientSide.ViewModels;
using ChatAppClientSide.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace ChatAppClientSide
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindowViewModel MainWindowViewModel;

        public static bool ServerIsLastSender = true;

        public static bool firstTime { get; set; } = true;

        internal static void IntegrateMessageToView(string message)
        {
            App.Current.Dispatcher.Invoke(new Action(() =>
            {
                if (firstTime)
                {
                    ServerIsLastSender = false;
                    firstTime = false;
                }

                if (!ServerIsLastSender)
                {
                    var item = new Item();
                    item.name.Text = "Server";
                    MainWindowViewModel.Messages.Add(item);
                }

                var messageUC = new MessageUC();
                messageUC.tb.Text = message;
                MainWindowViewModel.Messages.Add(messageUC);
                ServerIsLastSender = true;
            }));
        }
    }
}
