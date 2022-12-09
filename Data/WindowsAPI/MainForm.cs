using WindowsFormsApp1.DataBaseEditor;

namespace WindowsAPI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditorTable1 table1 = new FormEditorTable1();
            table1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditorTable2 table2 = new FormEditorTable2();
            table2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEditorTable3 table3 = new FormEditorTable3();
            table3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormEditorTable4 table4 = new FormEditorTable4();
            table4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEditorTable5 table5 = new FormEditorTable5();
            table5.ShowDialog();
        }
    }
}