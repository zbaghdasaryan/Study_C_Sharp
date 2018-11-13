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
        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }

    }
}
