namespace 外星人入侵游戏.Controll
{
    partial class ucGreenSprite
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
            this.picGreenSprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // picGreenSprite
            // 
            this.picGreenSprite.Image = global::外星人入侵游戏.Properties.Resources.ALIEN_03_01;
            this.picGreenSprite.Location = new System.Drawing.Point(0, 0);
            this.picGreenSprite.Name = "picGreenSprite";
            this.picGreenSprite.Size = new System.Drawing.Size(122, 66);
            this.picGreenSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGreenSprite.TabIndex = 0;
            this.picGreenSprite.TabStop = false;
            // 
            // ucGreenSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picGreenSprite);
            this.Name = "ucGreenSprite";
            this.Size = new System.Drawing.Size(125, 68);
            ((System.ComponentModel.ISupportInitialize)(this.picGreenSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGreenSprite;
    }
}
