using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 外星人入侵游戏.Helpers;

namespace 外星人入侵游戏
{
    public partial class InvadeGame : Form
    {
        IList<Alien>  listAlien  = new List<Alien>();  //存放外星人
        IList<Bullet> listBullet = new List<Bullet>(); //存放子弹
        IList<Tent>   listTent   = new List<Tent>();   //存放障碍物
        Fighter fighter;//存放飞机

        SoundPlayer bulletSound = new SoundPlayer(); //实例化一个多媒体  子弹的音效
        SoundPlayer bossSound   = new SoundPlayer(); //实例化一个多媒体    怪兽的音效
        SoundPlayer tentSound   = new SoundPlayer(); //实例化一个多媒体   障碍物的音效

        public InvadeGame()
        {
            InitializeComponent();
            CreateAlien();   //生成外星人
            CreateTent();    //生成障碍物
            CreateFighter(); //生成飞机  
        }
        /// <summary>
        /// 生成子弹
        /// </summary>
       
        private void CreateBullet()
        {
            Point point = new Point(775, fighter.Location.Y-30);  // 子弹的横坐标是775，纵坐标为飞机的位置-30
            listBullet.Add(new Bullet(this, point));              //添加一颗子弹
        }
        

        #region 生成飞机
        private void CreateFighter()
        {
            Point point = new Point(750,this.Height+300); // 飞机的初始位置，
            fighter = new Fighter(this, point);           // 添加一个飞机
        }
        #endregion

        #region 生成障碍物
        private void CreateTent()
        {
            for (int i = 0; i < 6; i++)
            {
                Point point = new Point(70 + 250 * i, 415);  // 障碍物的初始位置
                this.listTent.Add(new Tent(this,point));     //循环添加6个障碍物
              
            }
        }
        #endregion

        #region 生成外星人
        private void CreateAlien()
        {
            Point point = new Point();  //实例化
            for (int j = 0; j < 3; j++)
            {
                Alien wraper = null;      
                switch ( j )
                {
                    case 0:  // BlueSprite的添加
                        {
                            for (int i = 0 ; i < 10 ; i++)
                            {
                                point  = new Point(50 + 150 * i, 0);
                                wraper = new BlueSprite(this, point); 
                                listAlien.Add(wraper);
                                point  = new Point(50 + 150 * i, 70);
                                wraper = new BlueSprite(this, point);
                            }
                        }
                        break;

                    case 1:         // RedSprite的添加
                        {
                            for (int i = 0 ; i < 10 ; i++)
                            {
                                point  = new Point(50 + 150 * i, 140);
                                wraper = new RedSprite(this, point);
                                listAlien.Add(wraper);
                                point  = new Point(50 + 150 * i, 210);
                                wraper = new RedSprite(this, point);
                            }
                        }
                        break;

                    case 2:          // GreenSprite的添加
                        {
                            for (int i = 0 ; i < 10 ; i++)
                            {
                                point  = new Point(50 + 150 * i, 280);
                                wraper = new GreenSprite(this, point);
                                listAlien.Add(wraper);
                                point  = new Point(50 + 150 * i, 350);
                                wraper = new GreenSprite(this, point);
                            }
                        }
                        break;
                }
            }
        }
        #endregion

        #region 按键事件
        private void InvadeGame_KeyDown(object sender, KeyEventArgs e)
        {
           //按下空格键，产生一颗子弹
            if (e.KeyCode == Keys.Space) 
            {
                CreateBullet();          // 创建一颗子弹
                bossSound.PlaySync();    //子弹的声音
            }
        }
        #endregion

        #region 计时器
        private void Timer1_Tick(object sender, EventArgs e) 
        {
            try
            {

            }

            catch
            {

            }

        }
        #endregion
    }
}
