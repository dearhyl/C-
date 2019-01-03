using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 外星人入侵游戏.Helpers
{
    public class Sprite : Alien
    {
        public double rotateSpeed = 2; //外星人旋转的速度
        public double Angle { get; set; } // 获得外星人的角度
        public int locationSpeed = 2; // 设置外星人的位置偏移量
        public int VSpeed = 2; // 下落速度

        //构造时同时构造基类
        public Sprite(Form canvaasHost, Point point)  //Sprite 的形参和实参 
           : base(canvaasHost, point)
        {}

        public override UserControl CreateAlien()  
        {
            return null;  // 返回一个空值，因为没有指定具体的alien类型，所以返回一个空值
        }
        public virtual void Rotate()
        {
            this.Angle += rotateSpeed; // 使外星人的旋转角度按照rotate来转
        }
        /// <summary>
        /// 左右移动(Move)
        /// </summary>
        #region Move 为 X方向移动
        public void Move()
        {
            this.Location = new Point(this.Location.X + locationSpeed, this.Location.Y);
            SetObjectLocation();
        }
        #endregion
        /// <summary>
        /// 上下移动(Down)
        /// </summary>
        #region Move 为 Y方向移动
        public void Down()
        {
            this.Location = new Point(this.Location.X + this.Location.Y + locationSpeed);
            SetObjectLocation();
        }
        #endregion
    }
}