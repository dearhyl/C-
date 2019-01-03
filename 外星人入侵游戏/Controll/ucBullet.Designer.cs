namespace 外星人入侵游戏.Controll
{
    partial class ucBullet
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picBullet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).BeginInit();
            this.SuspendLayout();
            // 
            // picBullet
            // 
            this.picBullet.Image = global::外星人入侵游戏.Properties.Resources.Bullet_01_01;
            this.picBullet.Location = new System.Drawing.Point(0, 0);
            this.picBullet.Name = "picBullet";
            this.picBullet.Size = new System.Drawing.Size(18, 27);
            this.picBullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBullet.TabIndex = 0;
            this.picBullet.TabStop = false;
            // 
            // ucBullet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBullet);
            this.Name = "ucBullet";
            this.Size = new System.Drawing.Size(20, 30);
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBullet;
    }
}
