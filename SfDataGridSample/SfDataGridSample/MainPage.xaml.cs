using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            sfGrid.UnboundRowCellRenderers.Remove("Unbound");
            sfGrid.UnboundRowCellRenderers.Add("Unbound", new CustomUnboundRenderer());
        }
    }

    public class CustomUnboundRenderer : DataGridUnboundRowCellRenderer
    {
        public override void OnInitializeEditView(DataColumnBase dataColumn, SfDataGridEntry view)
        {
            base.OnInitializeEditView(dataColumn, view);
            if (view != null && view is Entry entry)
            {
                entry.Background = Colors.SkyBlue;
                entry.TextColor = Colors.Blue;
            }
        }
    }
}
