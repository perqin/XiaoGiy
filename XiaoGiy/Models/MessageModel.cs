using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XiaoGiy.Models {
    public class MessageModel : INotifyPropertyChanged {
        public string Content {
            get {
                return content;
            }
            set {
                content = value;
                OnPropertyChanged();
            }
        }

        public int Type {
            get {
                return type;
            }
            set {
                type = value;
                OnPropertyChanged();
            }
        }

        public string Url {
            get {
                return url;
            }
            set {
                url = value;
                OnPropertyChanged();
            }
        }

        public int Who {
            get {
                return who;
            }
            set {
                who = value;
                OnPropertyChanged();
            }
        }

        private string content = "";
        private int type = 0;
        private string url = "";
        private int who = 0;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
