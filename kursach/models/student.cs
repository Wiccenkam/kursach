using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.models
{//Определение родительского класса Student
    [Serializable]
    public class Student
    {
        public string name;

        public bool MathCreditation;
        public bool PeCreditation;
        public bool HistoryCreditation;
        public bool EnglishCreditation;
        public bool ObzCreditation;

        public short ProgrammingExam;
        public short PhilosophyExam;
        public short PhysicsExam;
        public short PoliticalExam;
        public short EconomicExam;
    }
}