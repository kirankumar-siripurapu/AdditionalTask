using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class PostInheritence
    {
        private static int postCounterNumber;
        protected int Id { set; get; }
        protected string SenderName { set; get; }
        protected string Title { set; get; }
        protected bool IsPublic { set; get; }
        public PostInheritence()
        {
            //this.Id = 0;
            this.Title = "My First Post";
            this.IsPublic = true;
            this.SenderName = "kiran Kumar";
        }
        public PostInheritence(string title, string senderName,bool isPublic)
        {
            this.Id = GetID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SenderName = senderName;
            //this.Length = GetLength()
        }
        protected int GetID()
        {
            return ++postCounterNumber;
        }
        public void Update(string title,bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            //return base.ToString();
            return String.Format("{0}. {1} - {2}", this.Id, this.Title, this.SenderName);
        }
    }
}
