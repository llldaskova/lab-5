using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using lab_5.ViewModels;
namespace lab_5.Views
{
    public partial class Regex : Window
    {
        public Regex()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("OK").Click +=  delegate
              {
                  // var context = this.Owner.DataContext as MainWindowViewModel;
                  var input = this.FindControl<TextBox>("RegexInput");
                  Close(input.Text);
              };
            this.FindControl<Button>("Cancel").Click +=  delegate
            {
                Close();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
