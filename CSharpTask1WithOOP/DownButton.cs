using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTask1WithOOP
{
    public class DownButton : IButton
    {
        public async void printStars(MainWindow mw)
        {
            IButton.isPrinting = true;

            int row, space, star;
            for (row = 1; row <= 5; row++)
            {
                for (space = 1; space <= 5 - row; space++)
                {
                    await Task.Delay(100);
                    mw.TxtField.Text += " ";
                }

                for (star = 1; star <= space * 2 - 1; star++)
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
