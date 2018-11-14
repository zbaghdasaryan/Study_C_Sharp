using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Book
    {
        Title title;
        Awthor name;
        Content content;


        public Book(string title, string name, string content)
        {
            this.title = new Title(title);
            this.name =new Awthor(name);
            this.content = new Content(content);
        }
        public void Show()
        {
            title.Show();
            name.Show();
            content.Show();
        }

    }
}
