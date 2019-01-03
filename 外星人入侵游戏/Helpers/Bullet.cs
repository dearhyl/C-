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
    public class Bullet:Alien
    {
        private int speed = 30;
        public Bullet(Form canvaasHost, Point point)  //Bullet 的形参和实参 
          : base(canvaasHost, point)
        {
            Location = point; // 将当前位置进行保存
            Size = new Size(7, 16);//初始化子弹的大小
        }
        
        public override UserControl CreateAlien()
        {
            return new ucBullet(); // 返回一个子弹
        }
        /// <summary>
        /// 子弹向上移动
        /// </summary>
        #region 子弹向上
        public void GoUp()
        {
            if (Location.Y < 0)//如果子弹，飞到屏幕之外
            {
                IsAlive = false;
                this.alien.Visible = false;// 隐藏子弹，原值为true；
                return;
            }
            // 减小Y轴坐标的值，即子弹向上移动
            alien.Location = new Point(this.Location.X, Location.Y-speed);
            //更新子弹的位置
            Location = new Point(Location.X, Location.Y - speed);
        }
        #endregion
    }
}
