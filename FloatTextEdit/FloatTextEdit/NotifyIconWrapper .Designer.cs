﻿namespace FloatTextEdit
{
    partial class NotifyIconWrapper
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconWrapper));
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_Load = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Position = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Back = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "FloatTextEdit";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Load,
            this.toolStripMenuItem_Back,
            this.toolStripMenuItem_Position,
            this.toolStripMenuItem_Open,
            this.toolStripMenuItem_Exit});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(118, 114);
			// 
			// toolStripMenuItem_Load
			// 
			this.toolStripMenuItem_Load.Name = "toolStripMenuItem_Load";
			this.toolStripMenuItem_Load.Size = new System.Drawing.Size(117, 22);
			this.toolStripMenuItem_Load.Text = "Load";
			// 
			// toolStripMenuItem_Position
			// 
			this.toolStripMenuItem_Position.Name = "toolStripMenuItem_Position";
			this.toolStripMenuItem_Position.Size = new System.Drawing.Size(117, 22);
			this.toolStripMenuItem_Position.Text = "Position";
			// 
			// toolStripMenuItem_Open
			// 
			this.toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
			this.toolStripMenuItem_Open.Size = new System.Drawing.Size(117, 22);
			this.toolStripMenuItem_Open.Text = "Show";
			// 
			// toolStripMenuItem_Exit
			// 
			this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
			this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(117, 22);
			this.toolStripMenuItem_Exit.Text = "Exit";
			// 
			// toolStripMenuItem_Back
			// 
			this.toolStripMenuItem_Back.Name = "toolStripMenuItem_Back";
			this.toolStripMenuItem_Back.Size = new System.Drawing.Size(117, 22);
			this.toolStripMenuItem_Back.Text = "Back";
			this.contextMenuStrip1.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Position;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Load;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Back;
	}
}
