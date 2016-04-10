using XiaoGiy.Models;

namespace XiaoGiy.ViewModels {
    public class MeViewModel {
        public UserModel Me {
            get {
                return me;
            }
        }

        private UserModel me = new UserModel();
    }
}
