using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ReplyThreadDTO
    {
        protected  int _ReplyThreadID ;
        protected  string _Content ;
        protected  DateTime _Time ;
        protected  int _ThreadID ;
        protected  int _StudentID ;
        public  ReplyThreadDTO()
        {
        }
        public  ReplyThreadDTO( int _ReplyThreadID ,string _Content ,DateTime _Time ,int _ThreadID ,int _StudentID  )
        {
           this.ReplyThreadID = _ReplyThreadID ;
           this.Content = _Content ;
           this.Time = _Time ;
           this.ThreadID = _ThreadID ;
           this.StudentID = _StudentID ;
        }
        public int ReplyThreadID
        {
            get { return _ReplyThreadID ; }
            set { _ReplyThreadID = value ; }
        }
        public string Content
        {
            get { return _Content ; }
            set { _Content = value ; }
        }
        public DateTime Time
        {
            get { return _Time ; }
            set { _Time = value ; }
        }
        public int ThreadID
        {
            get { return _ThreadID ; }
            set { _ThreadID = value ; }
        }
        public int StudentID
        {
            get { return _StudentID ; }
            set { _StudentID = value ; }
        }
    }
}
