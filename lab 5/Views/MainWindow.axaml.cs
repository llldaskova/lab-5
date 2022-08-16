using Avalonia.Controls;
using Avalonia.Interactivity;
using lab_5.ViewModels;
namespace lab_5.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Find<Button>("OpenFile").Click += async delegate
             {
                 var taskPath = new OpenFileDialog()
                 {
                     Title = "Open file",
                     Filters = null
                 }.ShowAsync((Window)this.VisualRoot);
                 string[]? path = await taskPath;
                 var context = this.DataContext as MainWindowViewModel;
                 try
                 {
                     context.Path = string.Join(@"\", path);
                 }
                 catch
                 {
                     context.Path = "";
                 }
             };


            this.Find<Button>("SaveFile").Click += async delegate
            {
                var taskPath = new OpenFileDialog()
                {
                    Title = "Open file",
                    Filters = null
                }.ShowAsync((Window)this.VisualRoot);
                string[]? path = await taskPath;
                var context = this.DataContext as MainWindowViewModel;
                try
                {
                    context.PathWrite = string.Join(@"\", path);
                }
                catch
                {
                    context.PathWrite = "";
                }
            };
        }
        private async void RegClickButton(object sender, RoutedEventArgs e)
        {
            string? str=await new Regex().ShowDialog<string?>((Window)this.VisualRoot);
           // var context = this.DataContext as MainWindowViewModel;
            //if (flag == 1)
               //context.TreatmentRegex();
             if (str!=null)
             {
                 var context = this.DataContext as MainWindowViewModel;
                 context.RegexInput = str;
             }
        }
        
    }
}
