using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using 外星人入侵游戏.Controll;

namespace 外星人入侵游戏.Helpers
{
    class Tent : Alien
    {
        public int hidedCount = 0;
        //构造时同时构造基类 
        public Tent(Form from, Point point)  //Fighter 的形参和实参  
          : base(from, point)
        {
            Size = new Size(93, 78);
        }
        public override UserControl CreateAlien()
        {
            return new ucTent();
        }

        public void Hited()
        {
            hidedCount++;
            if (hidedCount >= 3)
            {
               
                alien.Visible = false;
            }
        }

    }
}
