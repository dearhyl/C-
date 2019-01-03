namespace 外星人入侵游戏.Controll
{
    partial class ucFighter
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
            this.picFighter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFighter)).BeginInit();
            this.SuspendLayout();
            // 
            // picFighter
            // 
            this.picFighter.Image = global::外星人入侵游戏.Properties.Resources.SHIP_01_01;
            this.picFighter.Location = new System.Drawing.Point(0, 0);
            this.picFighter.Name = "picFighter";
            this.picFighter.Size = new System.Drawing.Size(90, 80);
            this.picFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFighter.TabIndex = 0;
            this.picFighter.TabStop = false;
            // 
            // ucFighter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFighter);
            this.Name = "ucFighter";
            this.Size = new System.Drawing.Size(89, 77);
            ((System.ComponentModel.ISupportInitialize)(this.picFighter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFighter;
    }
}
