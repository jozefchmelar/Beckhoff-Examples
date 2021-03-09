using System.Windows;
using System.Windows.Controls;

namespace Plc
{
    public partial class CSharpMethodView : UserControl
    {
        public CSharpMethodView()
        {
            InitializeComponent();
            DataContextChanged += OnDataContextChanged;
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            CommandButton.Content = PlcInstance.AttributeName;
        }

        private void CommandButton_Click(object sender, RoutedEventArgs e)
        {
            PlcInstance.InvokeRequested.Synchron = true;
        }

        // RenderableContentControl will set the DataContext automatically to the correct instance.
        private CSharpMethod PlcInstance => DataContext as CSharpMethod;
    }
}
