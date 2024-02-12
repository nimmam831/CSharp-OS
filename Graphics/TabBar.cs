using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosKernel2.Graphics
{
    public class TabBar
    {
        private Pen pen;
        public Int32 rows, columns;
        public TabBar(Canvas canvas)
        {
            this.pen = new Pen(Color.White);
            this.rows = canvas.Mode.Rows;
            this.columns = canvas.Mode.Columns;

            canvas.DrawRectangle(this.pen, 0, this.rows-100, this.columns-2, 98);
            canvas.DrawRectangle(this.pen, 0, this.rows - 100, 100, 98);
            canvas.DrawLine(this.pen, 25, this.rows - 90, 75, this.rows - 11);
        }
        public void tryProcessTabBarClick(Int32 mouseX, Int32 mouseY)
        {
            if (new Rectangle(mouseX,mouseY,1,1).IntersectsWith(new Rectangle(0,this.rows-100,100,98)))
            {
                Console.Beep(800, 100);
            }
        }

    }
}
