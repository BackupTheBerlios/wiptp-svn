using System;
using System.Collections.Generic;
using System.Text;

namespace TerminplanungTechnischerPrototyp.Calculation
{
    class Schedule
    {
        private List<TeacherPlan> _teacherlist = new List<TeacherPlan>();

        public List<TeacherPlan> TeacherList
        {
            get { return _teacherlist; }
            set { _teacherlist = value; }
        }

        public TeacherPlan this[int index]
        {
            get { return _teacherlist[index]; }
            set { _teacherlist[index] = value; }
        }

    }
}
