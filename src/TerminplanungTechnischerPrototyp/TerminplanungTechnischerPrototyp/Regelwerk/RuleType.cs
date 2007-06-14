using System;
using System.Collections.Generic;
using System.Text;

namespace TerminplanungTechnischerPrototyp.Regelwerk
{
    class RuleType
    {
        #region members
        private byte _NumberOfExamDays = 2;
        private byte _NumberOfExamsPerPupilDay = 1;
        private Time[] _ExamDayEndurance = new Time[]{new Time(8,0),new Time(18,0)};
        private TimeSpan WrittenExamEnduranceD=new TimeSpan();
        private TimeSpan WrittenExamEnduranceAM=new TimeSpan();
        private TimeSpan WrittenExamEnduranceE = new TimeSpan();
        private TimeSpan OralExamEnduranceD = new TimeSpan();
        private TimeSpan OralExamEnduranceAM = new TimeSpan();
        private TimeSpan OralExamEnduranceE = new TimeSpan();
        private TimeSpan NormalExamEndurance = new TimeSpan();
        //TeacherAttributes object ????????
        #endregion

        #region Properties
        public Time[] ExamDayEndurance
        {
            get { return _ExamDayEndurance; }
            set { _ExamDayEndurance = value; }
        }

        public byte NumberOfExamsPerPupilDay
        {
            get { return _NumberOfExamsPerPupilDay; }
            set { _NumberOfExamsPerPupilDay = value; }
        }

        public byte NumberOfExamDays
        {
            get { return _NumberOfExamDays; }
            set { _NumberOfExamDays = value; }
        }
	
        #endregion

        //#region Methods
        //public Boolean TeacherAvailable(DateTime fromDate, DateTime untilDate, string teachername)
        //{
        //}
        //public Boolean TeacherAssesorAtSubject(String teacherName, String subject)
        //{
        //}
        //public byte SubjectCorrectionEnduration(String subject)
        //{
        //}

        //public TimeSpan SubjectExamEnduration(String subject, byte year){
        //}
        //public /*????*/ void SubjectTyp(String subject)
        //{
        //}
        //public  /*????*/ void SubjectRoomTyp(String subject)
        //{
        //}
        //public  /*????*/ void RuleQuery()
        //{
        //}
        //#endregion

        #region Singleton
        private RuleType(){
        }

        private static RuleType instance = null;

        public static RuleType getInstance()
        {
            if (instance == null)
                instance = new RuleType();
            return instance;
        }
        #endregion
    }
}
