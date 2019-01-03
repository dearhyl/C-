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
    public class Fighter : Alien
    {
        private int speed = 30;

        public Fighter(Form canvaasHost, Point point)  //Fighter 的形参和实参  
          : base(canvaasHost, point)
        {
            Location = point;
            Size = new Size(57, 94);
        }

        public override UserControl CreateAlien()
        {
            return new ucFighter();
        }

        #region 战斗机的移动
        /// <summary>
        /// 向上移动
        /// </summary>
        public void GoUp()
        {
            // 更新战斗机的位置
            Location = new Point(Location.X, Location.Y - speed);
            //Y轴减小，战斗机向上移动
            this.alien.Location = Location;
        }
        /// <summary>
        /// 向下移动
        /// </summary>
        public void GoDown()
        {
            Location = new Point(Location.X, Location.Y + speed);
            //Y轴增大，战斗机向下移动
            this.alien.Location = Location;
        }
        /// <summary>
        /// 向左移动
        /// </summary>
        public void GoLeft()
        {
            Location = new Point(Location.X - speed, Location.Y );
            //X轴减小，战斗机向左移动
            this.alien.Location = Location;
        }
        /// <summary>
        /// 向右移动
        /// </summary>
        public void GoRight()
        {
            Location = new Point(Location.X + speed, Location.Y);
            //X轴增大，战斗机向右移动
            this.alien.Location = Location;
        }
        #endregion
    }
}
