using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class PostImageInheritence : PostInheritence
    {

        public string ImageUrl { get; set; }
            //= @"C:\Users\kiran\Downloads\Dhoni.jpeg";
         public PostImageInheritence(string title,string sendername,string imageUrl,bool isPublic)
        {
            //The following are derived from the base class
            this.Id = GetID();
            this.Title = title;
            this.SenderName = sendername;
            this.IsPublic = isPublic;
            //This is the property from the derived class
            this.ImageUrl = imageUrl;

        }
        public override string ToString()
        {
            //return base.ToString();
            return String.Format("{0}. {1} - {2} URL:{3}", this.Id, this.Title, this.SenderName,this.ImageUrl);
        }
    }
}
