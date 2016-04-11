using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XiaoGiy.Models {
    public class UserModel : INotifyPropertyChanged {
        public string Nickname {
            get {
                return nickname;
            }
            set {
                nickname = value;
                OnPropertyChanged();
            }
        }

        public string Id {
            get {
                if (id == "") id = Guid.NewGuid().ToString();
                return id;
            }
            set {
                id = value;
                OnPropertyChanged();
            }
        }

        private string nickname = "";
        private string id = "";

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
