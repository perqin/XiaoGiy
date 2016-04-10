namespace XiaoGiy.Models {
    public class MessageModel {
        public string Content {
            get {
                return content;
            }
            set {
                content = value;
            }
        }

        public int Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }

        public string Url {
            get {
                return url;
            }
            set {
                url = value;
            }
        }

        public int Who {
            get {
                return who;
            }
            set {
                who = value;
            }
        }

        private string content = "";
        private int type = 0;
        private string url = "";
        private int who = 0;
    }
}
