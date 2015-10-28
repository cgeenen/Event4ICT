using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event4ICT
{
    class Message
    {
        private Account account;
        private DateTime messageNumber;
        private int order;
        private string message;
        private int report;
        private int like;
        private int dislike;
        public int test { get; set; }
        public int Dislike
        {
            get { return dislike; }
            set { dislike = value; }
        }

        public int Like
        {
            get { return like; }
            set { like = value; }
        }

        public int Report
        {
            get { return report; }
            set { report = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public int Order
        {
            get { return order; }
            set { order = value; }
        }

        public DateTime MessageNumber
        {
            get { return messageNumber; }
            set { messageNumber = value; }
        }

        public Message(DateTime MessageNumber, int Order, string MessageContent)
        {

        }

        public Message(DateTime MessageNumber, int Order, string Message, string FilePath, string FileType)
        {

        }
    }
}
