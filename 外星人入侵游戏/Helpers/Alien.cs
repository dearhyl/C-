using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 外星人入侵游戏.Helpers
{
    public abstract class Alien
    {
        // 标识当前对象是否“活的”，false 为 “死”，ture 为“活”
        private bool isAlive;
        public UserControl alien;

        public bool IsAlive
        {
            get { return isAlive; }
            set
            {
                isAlive = value;
                //设置当前对象死亡则当前对象设置为不可见，
                if (isAlive == false)
                {
                    alien.Visible = false;
                }
            }
        }
        public Point Location { get; set; } // 对象的坐标
        public Size Size { get; set; } //对象的大小

        public Alien(Form canvasHost, Point point)
        {
            IsAlive = true;
            alien = CreateAlien();
            Location = point;
            SetObjectLocation(); 
            canvasHost.Controls.Add(alien);//将BlueAlien添加到屏幕中；
        }
        protected void SetObjectLocation()//设置点的坐标
        {
            alien.Location = new Point(this.Location.X, this.Location.Y);
        }
        public abstract UserControl CreateAlien();

        // 创建一个矩阵
        public virtual Rectangle CreateRect()
        {
            // 根据对象的坐标和对象的大小创建一个矩形
            return new Rectangle(Location, Size);
        }

        #region 判断是否相撞
        public bool CheakCollision(Alien wraper)
        {
            //获取当前对象的矩形区域
            Rectangle rect = CreateRect();
            //获取入参对象的矩形区域
            Rectangle rectCheck = wraper.CreateRect();
            // 检查2个矩形是否有交叉，如果没有交叉则
            //rect的值是empty
            rect.Intersect(rectCheck);
            // 如果rect是empty，则返回false，否则返回ture；
            return (rect != Rectangle.Empty);
        }
        #endregion 
    }
}
