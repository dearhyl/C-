﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using 外星人入侵游戏.Controll;

namespace 外星人入侵游戏.Helpers
{
    public  class RedSprite:Sprite
    {
        public RedSprite(Form canvaasHost, Point point)  //RedSprite 的形参和实参 
              : base(canvaasHost, point)
        {
            Size = new Size(100, 61); //初始化RedSprite的大小
        }
        
        public override UserControl CreateAlien()
        {
            return  new ucRedSprite();  // 返回一个ucRedSprite的控件
        }
        public override void Rotate()
        {
            base.Rotate();//调用基类的rotate方法（使角度发生变化）
            //使用变化后的Angle设置界面上外星人的旋转角度
        }

    }
}
