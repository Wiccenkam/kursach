using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace kursach.models
{
    [Serializable]
    //Класс журнал
    public class Journal
    {
        public List<Group> groups = new List<Group>();
        //Вписывание начальных оценок
        public static Journal GetTestJournal()
        {
            return new Journal
            {
                groups = new List<Group>
                {
                    new Group()
                    {
                        name = "751003",
                        students = new List<Student>
                        {
                            new Student
                            {
                                name = "Pasha Milun",

                                MathCreditation = true,
                                PeCreditation = true,
                                HistoryCreditation = true,
                                EnglishCreditation = true,
                                ObzCreditation = true,

                                ProgrammingExam = 7,
                                PhilosophyExam = 7,
                                PhysicsExam = 7,
                                PoliticalExam = 7,
                                EconomicExam = 7
                            },
                            new Student
                            {
                                name = "Vlad Vezhonec",

                                MathCreditation = true,
                                PeCreditation = true,
                                HistoryCreditation = true,
                                EnglishCreditation = true,
                                ObzCreditation = true,

                                ProgrammingExam = 7,
                                PhilosophyExam = 7,
                                PhysicsExam = 7,
                                PoliticalExam = 7,
                                EconomicExam = 7
                            },
                            new Student
                            {
                                name = "Leha Kozlov",

                                MathCreditation = true,
                                PeCreditation = true,
                                HistoryCreditation = true,
                                EnglishCreditation = true,
                                ObzCreditation = true,

                                ProgrammingExam = 7,
                                PhilosophyExam = 7,
                                PhysicsExam = 7,
                                PoliticalExam = 7,
                                EconomicExam = 7
                            }
                        }
                    },
                    new Group()
                    {
                        name = "751001",
                        students = new List<Student>
                        {
                            new Student
                            {
                                name = "Pasha Milun",

                                MathCreditation = true,
                                PeCreditation = true,
                                HistoryCreditation = true,
                                EnglishCreditation = true,
                                ObzCreditation = true,

                                ProgrammingExam = 7,
                                PhilosophyExam = 7,
                                PhysicsExam = 7,
                                PoliticalExam = 7,
                                EconomicExam = 7
                            },
                            new Student
                            {
                                name = "Vlad Vezhonec",

                                MathCreditation = true,
                                PeCreditation = true,
                                HistoryCreditation = true,
                                EnglishCreditation = true,
                                ObzCreditation = true,

                                ProgrammingExam = 7,
                                PhilosophyExam = 7,
                                PhysicsExam = 7,
                                PoliticalExam = 7,
                                EconomicExam = 7
                            },
                            new Student
                            {
                                name = "Leha Kozlov",

                                MathCreditation = true,
                                PeCreditation = true,
                                HistoryCreditation = true,
                                EnglishCreditation = true,
                                ObzCreditation = true,

                                ProgrammingExam = 7,
                                PhilosophyExam = 7,
                                PhysicsExam = 7,
                                PoliticalExam = 7,
                                EconomicExam = 7
                            }
                        }
                    }
                }
            };
        }

        public static void SaveTolocalFile(Journal journal, string fileName)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {

                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fs, journal);
                }
            }
            catch
            {

            }
        }
        public static Journal GetFromLocalFile(string fileName)
        {
            


            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Journal journal;

            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    journal = (Journal)binaryFormatter.Deserialize(fs);
                }
            }
            catch
            {
                journal = new Journal();
            }
            return journal;
        }
    }
}
