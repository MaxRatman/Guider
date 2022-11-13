namespace Guider
{
    public partial class Form1 : Form
    {
        TableLayoutPanel panel;
        TreeView treeView;
        ListView listView;
        public Form1()
        {
            InitializeComponent();
            panel = new TableLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.ColumnCount = 2;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,50));
            panel.ColumnStyles.Add( new ColumnStyle(SizeType.Percent, 50));
            panel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            Controls.Add(panel);

            treeView = new TreeView();
            treeView.Dock = DockStyle.Fill;
            panel.Controls.Add(treeView,0,0);

            listView = new ListView();
            listView.Dock = DockStyle.Fill;
            panel.Controls.Add(listView, 1, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
    }
}