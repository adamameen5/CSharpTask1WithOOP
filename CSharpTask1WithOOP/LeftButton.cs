using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask1WithOOP
{
    public class LeftButton : IButton
    {
        public async void printStars(MainWindow mw)
        {
            IButton.isPrinting = true;

            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 5 - i; j++)
                {
                    await Task.Delay(100);
                    mw.TxtField.Text += "";
                }
                for (k = 1; k <= i; k++)
                {
                    await Task.Delay(100);
                    mw.TxtField.Text += "* ";
                }
                await Task.Delay(100);
                mw.TxtField.Text += "\n";
            }
            IButton.isPrinting = false;
        }
    }
}
