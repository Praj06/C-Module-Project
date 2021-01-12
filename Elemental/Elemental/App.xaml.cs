using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Elemental
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application


    {
        public static ObservableCollection<PT> _pt;
        public static ObservableCollection<GL> _gl;
        public static ObservableCollection<VE> _vi;
        public static ObservableCollection<BL> _bl;
        //public static string _fileName;
        public static List<QuizQC> list_questions;
        public static List<QuizAC> list_answers;
        public static ObservableCollection<QuizAC> temp_answers;

        public object Storage_Serialization { get; private set; }




        private ObservableCollection<GL> GenerateMembers(int cnt)
        {
            var list = new ObservableCollection<GL>();

            for (int i = 0; i < cnt; i++)
            {
                list.Add(new GL { name = "na" + i, atomicweight = "aw" + i, });
            }

            return list;
        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            //_gl = GenerateMembers(20);
            _pt = MyStorage.ReadXml<ObservableCollection<PT>>("Elemental1.xml");
            _gl = MyStorage.ReadXml<ObservableCollection<GL>>("Elemental2.xml");
            _vi = MyStorage.ReadXml<ObservableCollection<VE>>("Elemental3.xml");
            _bl = MyStorage.ReadXml<ObservableCollection<BL>>("Elemental4.xml");

            generate_QC_object();
            generate_AC_object();
        }
        private List<QuizQC> Create_instances_of_QC()
        {
            List<QuizQC> temp_list = new List<QuizQC>();


            QuizQC f1 = new QuizQC();
            //f1.questionText

            temp_list.Add(f1);




            return temp_list;
        }

        private void generate_AC_object()
        {
            list_answers = new List<QuizAC>();

            QuizAC a1 = new QuizAC();
            a1.primKey = 0;
            a1.answerText = "Atomic Number";
            list_answers.Add(a1);

            QuizAC a2 = new QuizAC();
            a2.primKey = 1;
            a2.answerText = "Atomic Weight";
            list_answers.Add(a2);

            QuizAC a3 = new QuizAC();
            a3.primKey = 2;
            a3.answerText = "Density";
            list_answers.Add(a3);

            QuizAC a4 = new QuizAC();
            a4.primKey = 3;
            a4.answerText = "Electrons";
            list_answers.Add(a4);

            QuizAC a5 = new QuizAC();
            a5.primKey = 4;
            a5.answerText = "H";
            list_answers.Add(a5);

            QuizAC a6 = new QuizAC();
            a6.primKey = 5;
            a6.answerText = "He";
            list_answers.Add(a6);

            QuizAC a7 = new QuizAC();
            a7.primKey = 6;
            a7.answerText = "Li";
            list_answers.Add(a7);

            QuizAC a8 = new QuizAC();
            a8.primKey = 7;
            a8.answerText = "K";
            list_answers.Add(a8);

            QuizAC a9 = new QuizAC();
            a9.primKey = 8;
            a9.answerText = "Group";
            list_answers.Add(a9);

            QuizAC a10 = new QuizAC();
            a10.primKey = 9;
            a10.answerText = "Row";
            list_answers.Add(a10);

            QuizAC a11 = new QuizAC();
            a11.primKey = 10;
            a11.answerText = "Period";
            list_answers.Add(a11);

            QuizAC a12 = new QuizAC();
            a12.primKey = 11;
            a12.answerText = "Zig-Zag";
            list_answers.Add(a12);

            QuizAC a13 = new QuizAC();
            a13.primKey = 12;
            a13.answerText = "Nitrogen";
            list_answers.Add(a13);

            QuizAC a14 = new QuizAC();
            a14.primKey = 13;
            a14.answerText = "Oxygen";
            list_answers.Add(a14);

            QuizAC a15 = new QuizAC();
            a15.primKey = 14;
            a15.answerText = "Magnesium";
            list_answers.Add(a15);

            QuizAC a16 = new QuizAC();
            a16.primKey = 15;
            a16.answerText = "Sodium";
            list_answers.Add(a16);

            QuizAC a17 = new QuizAC();
            a17.primKey = 16;
            a17.answerText = "Electrons";
            list_answers.Add(a17);

            QuizAC a18 = new QuizAC();
            a18.primKey = 17;
            a18.answerText = "Protons";
            list_answers.Add(a18);

            QuizAC a19 = new QuizAC();
            a19.primKey = 18;
            a19.answerText = "Neutrons";
            list_answers.Add(a19);

            QuizAC a20 = new QuizAC();
            a20.primKey = 19;
            a20.answerText = "Quark";
            list_answers.Add(a20);

            QuizAC a21 = new QuizAC();
            a21.primKey = 20;
            a21.answerText = "Murray Robertson";
            list_answers.Add(a21);

            QuizAC a22 = new QuizAC();
            a22.primKey = 21;
            a22.answerText = "Stephan Hawking";
            list_answers.Add(a22);

            QuizAC a23 = new QuizAC();
            a23.primKey = 22;
            a23.answerText = "Dmitri Mendeleev";
            list_answers.Add(a23);

            QuizAC a24 = new QuizAC();
            a24.primKey = 23;
            a24.answerText = "John Dalton";
            list_answers.Add(a24);

            QuizAC a25 = new QuizAC();
            a25.primKey = 24;
            a25.answerText = "S, P, D, F";
            list_answers.Add(a25);

            QuizAC a26 = new QuizAC();
            a26.primKey = 25;
            a26.answerText = "A, B, C, D";
            list_answers.Add(a26);

            QuizAC a27 = new QuizAC();
            a27.primKey = 26;
            a27.answerText = "98";
            list_answers.Add(a27);

            QuizAC a28 = new QuizAC();
            a28.primKey = 27;
            a28.answerText = "64";
            list_answers.Add(a28);

            QuizAC a29 = new QuizAC();
            a29.primKey = 28;
            a29.answerText = "883 degree celcius";
            list_answers.Add(a29);

            QuizAC a30 = new QuizAC();
            a30.primKey = 29;
            a30.answerText = "753 degree celcius";
            list_answers.Add(a30);



        }
        private void generate_QC_object()
        {

            list_questions = new List<QuizQC>();

            QuizQC f1 = new QuizQC();
            //f1.difficulty_level = 1;
            f1.questionText = "Elements in the Periodic Table are listed in order of their";
            List<int> mp_list_correct_response_f1 = new List<int> { 0 };
            f1.listRightAnswer = mp_list_correct_response_f1;
            List<int> tmp_list_meaningful_response_f1 = new List<int> { 1, 2, 3, 4, 10 };
            f1.listWrongAnswer = tmp_list_meaningful_response_f1;
            list_questions.Add(f1);

            QuizQC f2 = new QuizQC();
            //f2.difficulty_level = 1;
            f2.questionText = "Which of the following is the abbreviation for the element Hydrogen?";
            List<int> tmp_list_correct_response_f2 = new List<int> { 4 };
            f2.listRightAnswer = tmp_list_correct_response_f2;
            List<int> tmp_list_meaningful_response_f2 = new List<int> { 0, 2, 3, 4, 10 };
            f2.listWrongAnswer = tmp_list_meaningful_response_f2;
            list_questions.Add(f2);

            QuizQC f3 = new QuizQC();
            // f3.difficulty_level = 1;
            f3.questionText = "What is each vertical column of elements in the periodic table called?";
            List<int> tmp_list_correct_response_f3 = new List<int> { 8 };
            f3.listRightAnswer = tmp_list_correct_response_f3;
            List<int> tmp_list_meaningful_response_f3 = new List<int> { 0, 1, 2, 4, 10 };
            f3.listWrongAnswer = tmp_list_meaningful_response_f3;
            list_questions.Add(f3);

            QuizQC f4 = new QuizQC();
            // f4.difficulty_level = 1;
            f4.questionText = "Which of the following elements is in the same family as phosphorus?";
            List<int> tmp_list_correct_response_f4 = new List<int> { 12 };
            f4.listRightAnswer = tmp_list_correct_response_f4;
            List<int> tmp_list_meaningful_response_f4 = new List<int> { 0, 1, 2, 3, 10 };
            f4.listWrongAnswer = tmp_list_meaningful_response_f4;
            list_questions.Add(f4);

            QuizQC f5 = new QuizQC();
            // f5.difficulty_level = 1;
            f5.questionText = "Which subatomic particle plays the greatest role in determining the physical and chemical properties of an element?";
            List<int> tmp_list_correct_response_f5 = new List<int> { 16 };
            f5.listRightAnswer = tmp_list_correct_response_f5;
            List<int> tmp_list_meaningful_response_f5 = new List<int> { 0, 1, 3, 4, 10 };
            f5.listWrongAnswer = tmp_list_meaningful_response_f5;
            list_questions.Add(f5);

            QuizQC f6 = new QuizQC();
            // f6.difficulty_level = 1;
            f6.questionText = "Who was resposible for Visual Representation of Elements?";
            List<int> tmp_list_correct_response_f6 = new List<int> { 20 };
            f6.listRightAnswer = tmp_list_correct_response_f6;
            List<int> tmp_list_meaningful_response_f6 = new List<int> { 8, 9, 11, 12, 13, 14 };
            f6.listWrongAnswer = tmp_list_meaningful_response_f6;
            list_questions.Add(f6);

            QuizQC f7 = new QuizQC();
            // f7.difficulty_level = 1;
            f7.questionText = "Who invented Periodic Table";
            List<int> tmp_list_correct_response_f7 = new List<int> { 22 };
            f7.listRightAnswer = tmp_list_correct_response_f7;
            List<int> tmp_list_meaningful_response_f7 = new List<int> { 0, 1, 2, 3, 4, 8, 9, 11, 12, 13, 14 };
            f7.listWrongAnswer = tmp_list_meaningful_response_f7;
            list_questions.Add(f7);

            QuizQC f8 = new QuizQC();
            //f8.difficulty_level = 1;
            f8.questionText = "Which of the following is the abbreviation for the element Lithium?";
            List<int> tmp_list_correct_response_f8 = new List<int> { 6 };
            f8.listRightAnswer = tmp_list_correct_response_f8;
            List<int> tmp_list_meaningful_response_f8 = new List<int> { 9, 11, 12, 13, 14 };
            f8.listWrongAnswer = tmp_list_meaningful_response_f8;
            list_questions.Add(f8);

            QuizQC f9 = new QuizQC();
            //f9.difficulty_level = 1;
            f9.questionText = "Which of the following is the abbreviation for the element Helium?";
            List<int> tmp_list_correct_response_f9 = new List<int> { 5 };
            f9.listRightAnswer = tmp_list_correct_response_f9;
            List<int> tmp_list_meaningful_response_f9 = new List<int> { 8, 9, 11, 12 };
            f9.listWrongAnswer = tmp_list_meaningful_response_f9;
            list_questions.Add(f9);

            QuizQC f10 = new QuizQC();
            //f10.difficulty_level = 1;
            f10.questionText = "The elements are divided into four blocks, what are they?";
            //f10.img_path = "/Bilder/while1.png";
            List<int> tmp_list_correct_response_f10 = new List<int> { 24 };
            f10.listRightAnswer = tmp_list_correct_response_f10;
            List<int> tmp_list_meaningful_response_f10 = new List<int> { 10, 16, 17, 18, 24 };
            f10.listWrongAnswer = tmp_list_meaningful_response_f10;
            list_questions.Add(f10);

            QuizQC f11 = new QuizQC();
            //f11.difficulty_level = 1;
            f11.questionText = "What is the Atomic Number of Helium?";
            // f11.img_path = "/Bilder/while1.png";
            List<int> tmp_list_correct_response_f11 = new List<int> { 28 };
            f11.listRightAnswer = tmp_list_correct_response_f11;
            List<int> tmp_list_meaningful_response_f11 = new List<int> { 3, 4, 20, 21, 22, 23, 24, 25 };
            f11.listWrongAnswer = tmp_list_meaningful_response_f11;
            list_questions.Add(f11);

            QuizQC f12 = new QuizQC();
            //f12.difficulty_level = 1;
            f12.questionText = "Which of the following is the abbreviation for the element Potassium?";
            // f12.img_path = "/Bilder/while1.png";
            List<int> tmp_list_correct_response_f12 = new List<int> { 7 };
            f12.listRightAnswer = tmp_list_correct_response_f12;
            List<int> tmp_list_meaningful_response_f12 = new List<int> { 19, 21, 22, 23, 24, 25 };
            f12.listWrongAnswer = tmp_list_meaningful_response_f12;
            list_questions.Add(f12);

            QuizQC f13 = new QuizQC();
            //f13.difficulty_level = 1;
            f13.questionText = "What is the Atomic Number of Lithium?";
            //f13.img_path = "/Bilder/while1.png";
            List<int> tmp_list_correct_response_f13 = new List<int> { 25 };
            f13.listRightAnswer = tmp_list_correct_response_f13;
            List<int> tmp_list_meaningful_response_f13 = new List<int> { 19, 20, 21, 22, 23, 24 };
            f13.listWrongAnswer = tmp_list_meaningful_response_f13;
            list_questions.Add(f13);

            QuizQC f14 = new QuizQC();
            //f14.difficulty_level = 1;
            f14.questionText = "Boiling Point of Sodium?";
            //f14.img_path = "/Bilder/while2.png";
            List<int> tmp_list_correct_response_f14 = new List<int> { 26 };
            f14.listRightAnswer = tmp_list_correct_response_f14;
            List<int> tmp_list_meaningful_response_f14 = new List<int> { 15, 16, 17, 18, 27 };
            f14.listWrongAnswer = tmp_list_meaningful_response_f14;
            list_questions.Add(f14);

            QuizQC f15 = new QuizQC();
            //f15.difficulty_level = 1;
            f15.questionText = "Boiling Point of Potasssium?";
            //f15.img_path = "/Bilder/while2.png";
            List<int> tmp_list_correct_response_f15 = new List<int> { 27 };
            f15.listRightAnswer = tmp_list_correct_response_f15;
            List<int> tmp_list_meaningful_response_f15 = new List<int> { 19, 20, 21, 22, 23, 24, 25 };
            f15.listWrongAnswer = tmp_list_meaningful_response_f15;
            list_questions.Add(f15);

            QuizQC f16 = new QuizQC();
            //f16.difficulty_level = 1;
            f16.questionText = "Melting Point of Sodium?";
            //f16.img_path = "/Bilder/while2.png";
            List<int> tmp_list_correct_response_f16 = new List<int> { 29 };
            f16.listRightAnswer = tmp_list_correct_response_f16;
            List<int> tmp_list_meaningful_response_f16 = new List<int> { 19, 20, 21, 22, 23, 24, 25, 28 };
            f16.listWrongAnswer = tmp_list_meaningful_response_f16;
            list_questions.Add(f16);

            QuizQC f17 = new QuizQC();
            // f17.difficulty_level = 1;
            f17.questionText = "Melting Point of Potassium?";
            //f17.img_path = "/Bilder/while2.png";
            List<int> tmp_list_correct_response_f17 = new List<int> { 28 };
            f17.listRightAnswer = tmp_list_correct_response_f17;
            List<int> tmp_list_meaningful_response_f17 = new List<int> { 20, 21, 22, 23, 24, 25, 28, 29 };
            f17.listWrongAnswer = tmp_list_meaningful_response_f17;
            list_questions.Add(f17);



        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MyStorage.WriteXml<ObservableCollection<PT>>(_pt, "Elemental1.xml");
            MyStorage.WriteXml<ObservableCollection<GL>>(_gl, "Elemental2.xml");
            MyStorage.WriteXml<ObservableCollection<VE>>(_vi, "Elemental3.xml");
            MyStorage.WriteXml<ObservableCollection<BL>>(_bl, "Elemental4.xml");
        }
    }
}
