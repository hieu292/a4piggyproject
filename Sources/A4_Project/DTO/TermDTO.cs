using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TermDTO
    {
          protected  int _TermID ;
        protected  DateTime _StartDay ;
        protected  DateTime _FinishDay ;
        protected  string _Name ;
        public  TermDTO()
        {
        }
        public  TermDTO( int _TermID ,DateTime _StartDay ,DateTime _FinishDay ,string _Name  )
        {
           this.TermID = _TermID ;
           this.StartDay = _StartDay ;
           this.FinishDay = _FinishDay ;
           this.Name = _Name ;
        }
        public int TermID
        {
            get { return _TermID ; }
            set { _TermID = value ; }
        }
        public DateTime StartDay
        {
            get { return _StartDay ; }
            set { _StartDay = value ; }
        }
        public DateTime FinishDay
        {
            get { return _FinishDay ; }
            set { _FinishDay = value ; }
        }
        public string Name
        {
            get { return _Name ; }
            set { _Name = value ; }
        }
    }
}
