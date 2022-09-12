using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask1WithOOP
{
    public class UpButton : IButton
    {
        public async void printStars(MainWindow mw)
        {

            IButton.isPrinting = true;

            int temp = 5;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= temp - 1; j++)
                {
                    await Task.Delay(100);
                    mw.TxtField.Text += " ";
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    await Task.Delay(100);
                    mw.TxtField.Text += "* ";
                }
                temp--;
                await Task.Delay(100);
                mw.TxtField.Text += "\n";
            }

            IButton.isPrinting = false ;
        }
    }
}
