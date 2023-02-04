using ChatAppClientSide.Commands;
using ChatAppClientSide.Services.NetworkServices;
using ChatAppClientSide.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ChatAppClientSide.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public RelayCommand SendMessageCommand { get; set; }

        private ObservableCollection<UIElement> messages = new ObservableCollection<UIElement>();

        public ObservableCollection<UIElement> Messages
        {
            get { return messages; }
            set { messages = value; OnPropertyChanged(); }
        }

        private string currentMessage;

        public string CurrentMessage
        {
            get { return currentMessage; }
            set { currentMessage = value; OnPropertyChanged(); }
        }

        public ScrollViewer ScrollViewer { get; internal set; }

        public MainWindowViewModel()
        {
            Task.Run(() =>
            {
                NetworkServices.ConnectToServer();
            });

            SendMessageCommand = new RelayCommand((msg) =>
            {
                var message = CurrentMessage.Trim();
                if (message == String.Empty)
                    return;

                if (App.firstTime)
                {
                    
                    App.ServerIsLastSender = true;
                    App.firstTime = false;
                }

                if (App.ServerIsLastSender)
                {
                    var item = new Item();
                    item.name.Text = "Me";
                    Messages.Add(item);
                }

                App.ServerIsLastSender = false;
                NetworkServices.Message = message;
                var messageUC = new MessageUC();
                messageUC.tb.Text = message;
                Messages.Add(messageUC);
                CurrentMessage = String.Empty;
                ScrollViewer.ScrollToBottom();
            });
        }
    }
}
