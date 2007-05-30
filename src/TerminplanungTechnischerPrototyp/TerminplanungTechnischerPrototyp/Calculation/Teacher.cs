using System;
using System.Collections.Generic;
using System.Text;

namespace TerminplanungTechnischerPrototyp.Calculation
{
    class Teacher
    {
        #region members
        protected String _Name;
        protected String[] _Subjects;
        #endregion

        #region properties
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public String[] Subjects
        {
            get { return _Subjects; }
            set { _Subjects = value; }
        }
        #endregion

        public Teacher(String name, String[] subjects)
        {
            _Name = name;
            _Subjects = subjects;
        }

    }
}
