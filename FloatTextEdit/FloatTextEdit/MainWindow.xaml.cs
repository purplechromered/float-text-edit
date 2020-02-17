using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web;

namespace FloatTextEdit
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        FWikipedia wiki;

        public MainWindow()
        {
            InitializeComponent();
            wiki = new FWikipedia();
        }

        private void TextEdit_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState != MouseButtonState.Pressed) return;

            this.DragMove();
        }

        public bool IsPositionMode()
        {
            return this.ResizeMode == ResizeMode.CanResizeWithGrip;
        }

        public void SetPositionMode(bool toPositionMode)
        {
            if (toPositionMode)
            {
                this.MouseLeave -= this.Window_MouseLeave;
                this.ResizeMode = ResizeMode.CanResizeWithGrip;
                this.PreviewMouseLeftButtonDown += this.TextEdit_PreviewMouseLeftButtonDown;
                textEdit.Background = Brushes.FloralWhite;
            }
            else
            {
                this.MouseLeave += this.Window_MouseLeave;
                this.ResizeMode = ResizeMode.NoResize;
                this.PreviewMouseLeftButtonDown -= this.TextEdit_PreviewMouseLeftButtonDown;
                textEdit.Background = Brushes.White;
            }
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        public void Load()
        {
            string text = new TextRange(textEdit.Document.ContentStart, textEdit.Document.ContentEnd).Text.Trim();
            if (text != "")
            {
                this.textEdit.Document.Blocks.Clear();
                List<string> nodes = wiki.LoadContent(text);
                Paragraph para = new Paragraph();
                foreach (string node in nodes)
                {
                    if (node.StartsWith("[["))
                    {
                        Hyperlink link = new Hyperlink();
                        link.IsEnabled = true;
                        string nameAndKey = node.Substring(2, node.Length - 4);
                        string[] sp = nameAndKey.Split(new string[] { "|" }, StringSplitOptions.None);
                        if (sp.Length == 1)
                        {
                            link.Inlines.Add(sp[0]);
                            link.NavigateUri = new Uri("http://a.a.a?" + sp[0]);
                        } else
                        {
                            link.Inlines.Add(sp[0]);
                            link.NavigateUri = new Uri("http://a.a.a?" + sp[1]);
                        }
                        link.MouseLeftButtonDown += (sender, args) =>
                        {
                            this.textEdit.Document.Blocks.Clear();
                            string title = ((Hyperlink)sender).NavigateUri.Query.Substring(1);
                            this.textEdit.AppendText(HttpUtility.UrlDecode(title));
                            Load();
                        };
                        para.Inlines.Add(link);
                    }
                    else
                    {
                        para.Inlines.Add(new Run(node));
                    }
                }
                textEdit.Document.Blocks.Add(para);
            }
        }
    }
}
