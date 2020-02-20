using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Web;

namespace FloatTextEdit
{
    class FWikipedia
    {
		public string currentTitle;
        XDocument root;

        public List<string> LoadContent(string title)
        {
			currentTitle = "";
			root = XDocument.Load(String.Format("http://ja.wikipedia.org/w/api.php?format=xml&action=query&prop=revisions&titles={0}&rvprop=content",
              HttpUtility.UrlEncode(title)));
            XElement rev = root.Element("api").Element("query").Element("pages").Element("page").Element("revisions").Elements("rev").First();
            string text = rev.Value;

            List<string> nodes = new List<string>();
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("\\[\\[.*?\\]\\]",
                System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Singleline);
            int befEnd = 0;
            foreach (System.Text.RegularExpressions.Match m in reg.Matches(text))
            {
                nodes.Add(text.Substring(befEnd, m.Index - befEnd));
                nodes.Add(m.Value);
                befEnd = m.Index + m.Length;
            }
            nodes.Add(text.Substring(befEnd, text.Length - befEnd));
			currentTitle = title;
			return nodes;
        }
    }
}
