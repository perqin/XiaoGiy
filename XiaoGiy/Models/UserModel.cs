using System;

namespace XiaoGiy.Models {
    public class UserModel {
        public string Nickname {
            get {
                return nickname;
            }
            set {
                nickname = value;
            }
        }

        public string Id {
            get {
                if (id == "") id = Guid.NewGuid().ToString();
                return id;
            }
            set {
                id = value;
            }
        }

        private string nickname = "";
        private string id = "";
    }
}
