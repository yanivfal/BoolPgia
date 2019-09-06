using System.Windows.Forms;

namespace BoolPgiaUI
{
    class UIRunner
    {
        internal void RunUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new StartForm().ShowDialog();    
        }
    }
}
