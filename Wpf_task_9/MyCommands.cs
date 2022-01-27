using System.Windows.Input;

namespace Wpf_task_9
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Open { get; set; }
        public static RoutedCommand Save { get; set; }
        static MyCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MyCommands));
            Open = new RoutedCommand("Open", typeof(MyCommands));
            Save = new RoutedCommand("Save", typeof(MyCommands));
        }
    }
}