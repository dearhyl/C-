namespace 外星人入侵游戏.Controll
{
    partial class ucTent
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
            this.picTent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTent)).BeginInit();
            this.SuspendLayout();
            // 
            // picTent
            // 
            this.picTent.Image = global::外星人入侵游戏.Properties.Resources.TENT_01_01;
            this.picTent.Location = new System.Drawing.Point(0, 0);
            this.picTent.Name = "picTent";
            this.picTent.Size = new System.Drawing.Size(100, 69);
            this.picTent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTent.TabIndex = 0;
            this.picTent.TabStop = false;
            // 
            // ucTent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picTent);
            this.Name = "ucTent";
            this.Size = new System.Drawing.Size(103, 71);
            ((System.ComponentModel.ISupportInitialize)(this.picTent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTent;
    }
}
