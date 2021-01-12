using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemental
{
    public class QuizQC
    {
        public string questionText { get; set; }

        //public string img_path { get; set; }

        public List<int> listRightAnswer { get; set; }

        public List<int> listWrongAnswer { get; set; }
    }
}
