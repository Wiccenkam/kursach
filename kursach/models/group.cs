using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.models
{ 
    [Serializable]
   public class Group
    {
        public string name;
        public List<Student> students = new List<Student>();
    }
}
