using System.Windows.Forms;

namespace InsuranceSummaryMaker.CustomControls
{
    public partial class CustomPanel : ListBox
    {
        public CustomPanel()
        {
            InitializeComponent();
        }

        /*        protected override void OnMouseDown(MouseEventArgs e)
                {
                    if (this.SelectedItem == null) return;
                    this.DoDragDrop(this.SelectedItem, DragDropEffects.Move);
                }*/

        /*        protected override void OnDragOver(DragEventArgs drgevent)
                {
                    drgevent.Effect = DragDropEffects.Move;
                }

                protected override void OnDragDrop(DragEventArgs drgevent)
                {
                    Point point = this.PointToClient(new Point(drgevent.X, drgevent.Y));
                    int index = this.IndexFromPoint(point);
                    if (index < 0) index = this.Items.Count - 1;
                    object data = drgevent.Data!.GetData(typeof(string));
                    this.Items.Remove(data);
                    this.Items.Insert(index, data);
                }*/
    }
}
