using System;
using System.Collections.Generic;
using System.Text;

namespace TerminplanungTechnischerPrototyp.Calculation
{
    class Exam
    {
        #region members
        private Time _beginTime;
        private TimeSpan _duration;
        private String _student;
        private Teacher _teacher;
        private String _subject;
        private Teacher _assesor;
        private String _room;
        private ExamType _type;
        #endregion 

        #region properties
        public ExamType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public String Room
        {
            get { return _room; }
            set { _room = value; }
        }
        public Teacher Assesor
        {
            get { return _assesor; }
            set { _assesor = value; }
        }
        public String Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public Teacher Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public String Student
        {
            get { return _student; }
            set { _student = value; }
        }
        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        public Time BeginTime
        {
            get { return _beginTime; }
            set { _beginTime = value; }
        }
        #endregion

        public Exam(TimeSpan dur,String student, Teacher teacher, String subject, ExamType type)
        {
            _duration = dur;
            _teacher = teacher;
            _subject = subject;
            _type=type;
            _student=student;
        }
        public Exam(Time begin, TimeSpan dur, String student, Teacher teacher, String subject,
            ExamType type, Teacher assesor, String room)
        {
            _beginTime = begin;
            _duration = dur;
            _teacher = teacher;
            _subject = subject;
            _type = type;
            _student = student;
            _type = type;
            _assesor = assesor;
            _room = room;
        }

    }
}
