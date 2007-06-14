using System;
using System.Collections.Generic;
using System.Text;

namespace TerminplanungTechnischerPrototyp.CSV_Handling
{
    class CSVStructure
    {
        #region Members
        private String _Surname;
        private String _FirstName;
        private String _class;
        private String _SubjectLongName;
        private String _SubjectShortName;
        private String _ExaminerSurName;
        private String _ExaminerFirstName;
        private bool _clause;
        private bool _oral;
        private bool _written;
        private bool _practical;
        private String _AssessorSurname;
        private String _AssessorFirstName;
        private DateTime _Date;
        private Time _TimeOral;
        private Time _TimeWritten;
        private Time _TimePractical;
        private String _RoomOral;
        private String _RoomWritten;
        private String _RoomPractical;
        private String _Comment;
        #endregion

        #region properties definition
        public String Comment
        {
            get { return _Comment; }
            set { _Comment = value; }
        }

        public String PracticalRoom
        {
            get { return _RoomPractical; }
            set { _RoomPractical = value; }
        }
	
        public String WrittenRoom
        {
            get { return _RoomWritten; }
            set { _RoomWritten = value; }
        }
	
        public String OralRoom
        {
            get { return _RoomOral; }
            set { _RoomOral = value; }
        }
	
        public Time PracticalTime
        {
            get { return _TimePractical; }
            set { _TimePractical = value; }
        }
	
        public Time WrittenTime
        {
            get { return _TimeWritten; }
            set { _TimeWritten = value; }
        }
	
        public Time OralTime
        {
            get { return _TimeOral; }
            set { _TimeOral = value; }
        }
	
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
	
        public String AssessorFirstName
        {
            get { return _AssessorFirstName; }
            set { _AssessorFirstName = value; }
        }
	
        public String AssessorSurname
        {
            get { return _AssessorSurname; }
            set { _AssessorSurname = value; }
        }
	
        public bool PracticalExam
        {
            get { return _practical; }
            set { _practical = value; }
        }
	
        public bool WrittenExam
        {
            get { return _written; }
            set { _written = value; }
        }

        public bool OralExam
        {
            get { return _oral; }
            set { _oral = value; }
        }

        public bool Clause
        {
            get { return _clause; }
            set { _clause = value; }
        }

        public String ExaminerFirstName
        {
            get { return _ExaminerFirstName; }
            set { _ExaminerFirstName = value; }
        }

        public String ExaminerSurName
        {
            get { return _ExaminerSurName; }
            set { _ExaminerSurName = value; }
        }

        public String SubjectShortName
        {
            get { return _SubjectShortName; }
            set { _SubjectShortName = value; }
        }

        public String Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public String Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public String SubjectLongName
        {
            get { return _SubjectLongName; }
            set { _SubjectLongName = value; }
        }
        #endregion
    }
}