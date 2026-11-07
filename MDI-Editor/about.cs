using System;
using System.Drawing;
using System.Windows.Forms;

namespace MDI_Editor
{
    public class aboutBox : Form
    {
        public aboutBox()
        {
            this.Text = "About";
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterParent;

            Label lblInfo = new Label();

            lblInfo.Text =
                "Хөгжүүлсэн\n\n" +
                "Нэр: Б.Баатарцогт\n" +
                "Код: M.SW23D067 ";

            lblInfo.Dock = DockStyle.Fill;
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(lblInfo);
        }
    }
}
