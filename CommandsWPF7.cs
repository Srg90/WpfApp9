using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp9
{
    class CommandsWPF7
    {
        public static RoutedUICommand Close { get; set; }
        public static RoutedCommand Bold { get; set; }
        public static RoutedCommand Italic { get; set; }
        public static RoutedCommand Underline { get; set; }
        public static RoutedCommand Color { get; set; }
        static CommandsWPF7()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Close = new RoutedUICommand("Выход", "Выход", typeof(CommandsWPF7), inputs);
            Bold = new RoutedCommand();
            Italic = new RoutedCommand();
            Underline = new RoutedCommand();
            Color = new RoutedCommand();
        }
    }
}
