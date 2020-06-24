using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTask17122019
{
    class VideoPostInheritence : PostInheritence
    {
        protected string VideoUrl { get; set; }
        protected int Length { get; set; }

        public VideoPostInheritence()
        {

        }

        public VideoPostInheritence(string title, string senderName, string videourl, bool ispublic, int length )
        {
            this.IsPublic = ispublic;
            this.Id = GetID();
            this.Title = title;
            this.VideoUrl = videourl;
            this.Length = length;

        }
        public override string ToString()
        {
            //return base.ToString();
            return String.Format("{5}. The title:{0},sender:{1}, ispublic:{2},VideoUrL:{3},Length:{4}",
                this.Title,this.SenderName,this.IsPublic,this.VideoUrl,this.Length, this.Id);
        }


    }
}
