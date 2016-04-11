using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace XiaoGiy.Utils {
    class IntToLeftVisibilityConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return (value as int? ?? C.ME) == C.ME ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return (value as Visibility? ?? Visibility.Collapsed) == Visibility.Collapsed ? C.ME : C.GIY;
        }
    }

    class IntToRightVisibilityConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return (value as int? ?? C.ME) == C.ME ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return (value as Visibility? ?? Visibility.Visible) == Visibility.Visible ? C.ME : C.GIY;
        }
    }

    class IntToBackgroundConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return new SolidColorBrush((value as int? ?? C.ME) == C.ME ? Color.FromArgb(255, 255, 255, 255) : Color.FromArgb(255, 112, 8, 178));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    class IntToForegroundConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return new SolidColorBrush((value as int? ?? C.ME) == C.ME ? Color.FromArgb(255, 112, 8, 178) : Color.FromArgb(255, 255, 255, 255));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    class StringTrimConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return (value as int? ?? C.ME) == C.ME ? App.MeVM.Me.Nickname.Substring(0, 1) : "基";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }

    class IntToHorizontalAlignmentConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return (value as int? ?? C.ME) == C.ME ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
