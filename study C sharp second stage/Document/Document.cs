using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Document
    {
        Part title = null;
        Part body = null;
        Part footer = null;

        void InitializDocument()
        {
            title = new Title();
            body = new Body();
            footer = new Footer();
        }

        public Document(string title)
        {
            InitializDocument();
                this.title.Content = title;
        }
        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }
        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }
        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }
    }
}
