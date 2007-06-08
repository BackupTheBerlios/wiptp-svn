using System;
using System.Collections.Generic;
using System.Text;

namespace TerminplanungTechnischerPrototyp.Calculation
{
    class TeacherPlan:Teacher
    {
        private List<Exam> _exams = new List<Exam>();

        public List<Exam> Exams
        {
            get { return _exams; }
            set { _exams = value; }
        }
    }
}
