using System.Collections.ObjectModel;
using XiaoGiy.Models;

namespace XiaoGiy.ViewModels {
    public class ChatViewModel {
        public ObservableCollection<MessageModel> ChatMessages {
            get {
                return chatMessages;
            }
        }

        private ObservableCollection<MessageModel> chatMessages = new ObservableCollection<MessageModel>();
    }
}
