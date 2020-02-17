using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FloatTextEdit
{
    public partial class NotifyIconWrapper : Component
    {
        MainWindow mainWindow;

        public NotifyIconWrapper()
        {
            InitializeComponent();

            // コンテキストメニューのイベントを設定
            this.toolStripMenuItem_Open.Click += this.toolStripMenuItem_Open_Click;
            this.toolStripMenuItem_Exit.Click += this.toolStripMenuItem_Exit_Click;
            this.toolStripMenuItem_Position.Click += this.toolStripMenuItem_Position_Click;
            this.toolStripMenuItem_Load.Click += this.toolStripMenuItem_Load_Click;

            mainWindow = new MainWindow();
            mainWindow.Show();
        }

        public NotifyIconWrapper(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// コンテキストメニュー "表示" を選択したとき呼ばれます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void toolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            mainWindow.Show();
        }

        /// <summary>
        /// コンテキストメニュー "終了" を選択したとき呼ばれます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            // 現在のアプリケーションを終了
            Application.Current.Shutdown();
        }

        /// <summary>
        /// コンテキストメニュー "移動" を選択したとき呼ばれます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void toolStripMenuItem_Position_Click(object sender, EventArgs e)
        {
            if (mainWindow.IsPositionMode())
            {
                mainWindow.SetPositionMode(false);
            }
            else
            {
                mainWindow.SetPositionMode(true);
            }
        }

        /// <summary>
        /// コンテキストメニュー "Load" を選択したとき呼ばれます。
        /// </summary>
        /// <param name="sender">呼び出し元オブジェクト</param>
        /// <param name="e">イベントデータ</param>
        private void toolStripMenuItem_Load_Click(object sender, EventArgs e)
        {
            mainWindow.Load();
        }

        private void notifyIcon1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left) return;

            mainWindow.Show();
        }
    }
}
