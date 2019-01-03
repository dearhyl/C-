namespace 外星人入侵游戏.Controll
{
    partial class ucRedSprite
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
            this.picRedSprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRedSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // picRedSprite
            // 
            this.picRedSprite.Image = global::外星人入侵游戏.Properties.Resources.ALIEN_02_01;
            this.picRedSprite.Location = new System.Drawing.Point(0, 0);
            this.picRedSprite.Name = "picRedSprite";
            this.picRedSprite.Size = new System.Drawing.Size(122, 69);
            this.picRedSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRedSprite.TabIndex = 0;
            this.picRedSprite.TabStop = false;
            // 
            // ucRedSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picRedSprite);
            this.Name = "ucRedSprite";
            this.Size = new System.Drawing.Size(124, 71);
            ((System.ComponentModel.ISupportInitialize)(this.picRedSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRedSprite;
    }
}
