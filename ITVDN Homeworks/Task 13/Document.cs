using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Document
    {
        Title title = new Title();
        Body body = new Body();
        Footer footer = new Footer();

        //void InitializeDocument()
        //{
        //    title = new Title();
        //    body = new Body();
        //    footer = new Footer();
        //}

        public Document(string title, string body, string footer)
        {
           // InitializeDocument();
            this.title.Content = title;
            this.body.Content = body;
            this.footer.Content = footer;

        }
        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }
        //public string Body
        //{
        //    set
        //    {
        //        body.Content = value;
        //    }
        //}
        //public string Footer
        //{
        //    set
        //    {
        //        footer.Content = value;
        //    }
        //}


    }
}
