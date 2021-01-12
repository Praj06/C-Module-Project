using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Elemental
{
    /// <summary>
    /// Interaction logic for Quiz.xaml
    /// </summary>
    public partial class Quiz : Window
    {
        public int count_quiz_rounds = 10;
        public int index_chosen_right_answer = 0;
        public int i7;
        public Quiz()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Btn_Quiz_Click(object sender, RoutedEventArgs e)
        {
            if ((string)Btn_Quiz.Content == "Play Quiz!")
            {
                Btn_Quiz.Content = "Quit Quiz";
                Lbx_ans.IsEnabled = true;


                //comb_levels.IsEnabled = false;

                run_quiz();

            }
            else if ((string)Btn_Quiz.Content == "Quit Quiz")
            {
                Btn_Quiz.Content = "Play Quiz!";
                Lbx_ans.IsEnabled = false;

                //comb_levels.IsEnabled = true;

            }

        }
        private void run_quiz()
        {


            App.temp_answers = new ObservableCollection<QuizAC>();

            //img_quizz.Source = null; //falls noch ein bild geladen ist wird es hier gelöscht
            //choosen_difficulty_level = (int)comb_levels.SelectedIndex + 1;    //gewählte schwierigkeitsgrad wird als int gespeichert

            List<QuizQC> lst_questions = new List<QuizQC>();
            foreach (QuizQC item in App.list_questions)   //die ganze collection wird durchlaufen und nach allen elementen mit dem ausgewählten schwierigkeitsgrad durchsucht
                                                          //{
                                                          //  if (item.difficulty_level == choosen_difficulty_level)
            {
                lst_questions.Add(item);           //all jene objekte kommen in die liste lst_questions
            }
            //}

            int number_questions_in_lst_questions = lst_questions.Count();   //summe aller vom schwierigkeitsgrad her passenden fragen in der collection

            Random r = new Random();
            int i = (r.Next(0, number_questions_in_lst_questions - 1));  //i ist ein zufällig gewähltes int - genutzt um eine frage in der observablecollection auszuwählen

            QuizQC picked_item_from_lst_questions = new QuizQC();
            picked_item_from_lst_questions = lst_questions[i];

            Tblock_qtn.Text = picked_item_from_lst_questions.questionText;

            //if (picked_item_from_lst_questions.img_path != null)  //check ob ein imagepath(string) vorhanden ist 
            //{
            //    Uri u = new Uri(picked_item_from_lst_questions.img_path, UriKind.Relative);    //wenn ein string vorhanden ist, dann wird mit dessen hilfe ein bitmapimage erstellt
            //    BitmapImage imgSource = new BitmapImage(u);
            //    img_quizz.Source = imgSource;    //das bitmapimage object wird dem image object zugewiesen
            //}



            int available_correct_answers_for_choosen_question = picked_item_from_lst_questions.listRightAnswer.Count();  //wie viele kkorrekte antworten sind für das frageobjekt vorhanden?
            int available_wrong_answers_for_choosen_question = picked_item_from_lst_questions.listWrongAnswer.Count(); //wie viele sinnvolle(aber falsche) antworten sind für das frageobjekt vorhanden?



            if (available_correct_answers_for_choosen_question == 1)
            {
                index_chosen_right_answer = 0;
            }
            else if (available_correct_answers_for_choosen_question >= 2)
            {
                Random r2 = new Random();
                index_chosen_right_answer = (r2.Next(0, (available_correct_answers_for_choosen_question - 1)));  //...wähle zufällig eine der potentiellen richtigen antworten. die -1 ist wichtig, da ein element in der sammlung bedeutet dsass nur der 0.index existiert. wären 2 elemente in .count() dann wäre index 0 und 1 belegt
            }




            int index_for_first_wrong_answer_from_list_meaningful_answers = 0;
            int index_for_second_incorrect_answer_from_list_meaningful_answers = 0;
            int index_for_third_wrong_answer_from_list_meaningful_answers = 0;

            Random r4 = new Random();
            int i4 = (r4.Next(0, available_wrong_answers_for_choosen_question - 1));
            index_for_first_wrong_answer_from_list_meaningful_answers = picked_item_from_lst_questions.listWrongAnswer[i4];                                //die erste falsche antwort wird festgelegt
            index_for_second_incorrect_answer_from_list_meaningful_answers = index_for_first_wrong_answer_from_list_meaningful_answers;    //die zweite bekommt den wert der ertsen ebenfalls
            index_for_third_wrong_answer_from_list_meaningful_answers = index_for_first_wrong_answer_from_list_meaningful_answers;     //die dritte bekommt den wert ebenfalls

            while (index_for_second_incorrect_answer_from_list_meaningful_answers == index_for_first_wrong_answer_from_list_meaningful_answers) //so lange die zweite die gleiche ist wie di erste wird neu gewürfelt....so lange bis die zweite ungleich der ersten ist
            {
                Random r5 = new Random();
                int i5 = (r4.Next(0, available_wrong_answers_for_choosen_question - 1));  //wähle zufällig einen index in der liste der sinnvollen(aber falschen) antworten.

                index_for_second_incorrect_answer_from_list_meaningful_answers = picked_item_from_lst_questions.listWrongAnswer[i5];  //den zufällig ausgewählten index in der liste der sinnvollen(aber falschen) antworten auslesen
            }

            while ((index_for_third_wrong_answer_from_list_meaningful_answers == index_for_second_incorrect_answer_from_list_meaningful_answers) || (index_for_third_wrong_answer_from_list_meaningful_answers == index_for_first_wrong_answer_from_list_meaningful_answers))  //so lange die dritte zahl wie die erste ist oder die dritte zahl wie die zweite ist wird gewürfelt
            {
                Random r6 = new Random();
                int i6 = (r6.Next(0, available_wrong_answers_for_choosen_question - 1));
                index_for_third_wrong_answer_from_list_meaningful_answers = picked_item_from_lst_questions.listWrongAnswer[i6];
            }




            // etwas verwirrend daher zum merken: das ist der integer...der prim_key der gewählten antwort    "picked_item_in_lst_questions.liste_richtiger_antworten[index_ausgewählte_richtige_antwort]"

            string selected_correct_response_text = "";
            string text_for_first_wrong_response = "";
            string text_for_second_wrong_response = "";
            string text_for_third_wrong_answer = "";
            int number_of_the_selected_index_in_a_list_of_correct_answers = picked_item_from_lst_questions.listRightAnswer[index_chosen_right_answer];
            foreach (QuizAC item in App.list_answers) //die ganze liste mit antworten durchlaufne und das objekt mit passendem primärschlüssel suchen und dessen text abspeichern
            {
                if (item.primKey == number_of_the_selected_index_in_a_list_of_correct_answers)
                {
                    selected_correct_response_text = item.answerText;
                }
                if (item.primKey == index_for_first_wrong_answer_from_list_meaningful_answers)
                {
                    text_for_first_wrong_response = item.answerText;
                }
                if (item.primKey == index_for_second_incorrect_answer_from_list_meaningful_answers)
                {
                    text_for_second_wrong_response = item.answerText;
                }
                if (item.primKey == index_for_third_wrong_answer_from_list_meaningful_answers)
                {
                    text_for_third_wrong_answer = item.answerText;
                }
            }

            Random r7 = new Random();   //es wird gewürfelt an welcher position die richtige nun antwort sein soll in der listbox(position 0 bis 3 stehn zur auswahl)
            i7 = (r7.Next(0, 3));


            string answer_for_index_0 = "";
            string answer_for_index_1 = "";
            string answer_for_index_2 = "";
            string answer_for_index_3 = "";


            if (i7 == 0)
            {
                answer_for_index_0 = selected_correct_response_text;
                answer_for_index_1 = text_for_first_wrong_response;
                answer_for_index_2 = text_for_second_wrong_response;
                answer_for_index_3 = text_for_third_wrong_answer;
            }
            else if (i7 == 1)
            {
                answer_for_index_0 = text_for_first_wrong_response;
                answer_for_index_1 = selected_correct_response_text;
                answer_for_index_2 = text_for_second_wrong_response;
                answer_for_index_3 = text_for_third_wrong_answer;
            }
            else if (i7 == 2)
            {
                answer_for_index_0 = text_for_first_wrong_response;
                answer_for_index_1 = text_for_second_wrong_response;
                answer_for_index_2 = selected_correct_response_text;
                answer_for_index_3 = text_for_third_wrong_answer;
            }
            else if (i7 == 3)
            {
                answer_for_index_0 = text_for_first_wrong_response;
                answer_for_index_1 = text_for_second_wrong_response;
                answer_for_index_2 = text_for_third_wrong_answer;
                answer_for_index_3 = selected_correct_response_text;
            }



            QuizAC instanz_answer_for_index_0 = new QuizAC { answerText = answer_for_index_0 };
            QuizAC instanz_answer_for_index_1 = new QuizAC { answerText = answer_for_index_1 };
            QuizAC instanz_answer_for_index_2 = new QuizAC { answerText = answer_for_index_2 };
            QuizAC instanz_answer_for_index_3 = new QuizAC { answerText = answer_for_index_3 };

            App.temp_answers.Add(instanz_answer_for_index_0);
            App.temp_answers.Add(instanz_answer_for_index_1);
            App.temp_answers.Add(instanz_answer_for_index_2);
            App.temp_answers.Add(instanz_answer_for_index_3);


            Lbx_ans.ItemsSource = App.temp_answers;

        }

        private void listbox_quizz_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (i7 == 0)
            {
                if (Lbx_ans.SelectedIndex == 0)
                {
                    MessageBox.Show("Right answer!");
                }
                if (Lbx_ans.SelectedIndex == 1)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[0].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 2)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[0].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 3)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[0].answerText + " !");
                }

            }

            if (i7 == 1)
            {
                if (Lbx_ans.SelectedIndex == 0)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[1].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 1)
                {
                    MessageBox.Show("Right answer!");
                }
                if (Lbx_ans.SelectedIndex == 2)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[1].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 3)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[1].answerText + " !");
                }

            }

            if (i7 == 2)
            {
                if (Lbx_ans.SelectedIndex == 0)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[2].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 1)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[2].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 2)
                {
                    MessageBox.Show("Right answer!");
                }
                if (Lbx_ans.SelectedIndex == 3)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[2].answerText + " !");
                }

            }

            if (i7 == 3)
            {
                if (Lbx_ans.SelectedIndex == 0)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[3].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 1)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[3].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 2)
                {
                    MessageBox.Show("Unfortunately, wrong answer. The right answer is : " + App.temp_answers[3].answerText + " !");
                }
                if (Lbx_ans.SelectedIndex == 3)
                {
                    MessageBox.Show("Right answer!");
                }

            }
            run_quiz();
        }

    }
}

