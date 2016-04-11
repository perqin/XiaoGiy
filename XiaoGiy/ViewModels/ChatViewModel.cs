using System.Collections.ObjectModel;
using XiaoGiy.Models;
using XiaoGiy.Utils;

namespace XiaoGiy.ViewModels {
    public class ChatViewModel {
        /// <summary>
        /// TODO: Only for debugging.
        /// </summary>
        public ChatViewModel() {
            ChatMessages.Add(new MessageModel() {
                Content = "Hello",
                Who = C.ME,
                Type = C.MSG_TYPE_TEXT
            });
            ChatMessages.Add(new MessageModel() {
                Content = "Thank you!",
                Who = C.GIY,
                Type = C.MSG_TYPE_TEXT
            });
        }

        public ObservableCollection<MessageModel> ChatMessages {
            get {
                return chatMessages;
            }
        }

        private ObservableCollection<MessageModel> chatMessages = new ObservableCollection<MessageModel>();
    }
}
