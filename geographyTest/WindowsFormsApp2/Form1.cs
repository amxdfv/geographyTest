using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using geographyTest.Properties;


namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public string[,] answers = { { "Россия", "США", "Китай", "Канада" },
                                        { "Китай", "Индия", "Россия","США"},
                                              { "США", "Россия", "Австралия","Индонезия"},
                                                  { "Нил", "Амазонка", "Волга","Мисcисипи"},
                                                      { "Эльбрус", "Килиманджаро", "Агунг","Эверест"},
                                                        { "Монако", "Париж", "Берлин","Лондон"},
                                                            { "Тихий", "Индийский", "Атлантический","Северно-Ледовитый"},
                                                                { "Африка", "Северная Америка", "Евразия","Австралия"},
                                                                     { "Вашингтон", "Нью-Йорк", "Чикаго","Лос-Ажелес"},
                                                                      { "Монако", "Мальта", "Бруней","Ватикан"}
                                                                                                                     };             // массив ответов уровень легкий
        public string[] questions = { "Назовите самую большу страну в мире",
                                        "Назовите самую населенную страну в мире",
                                             "Какая страна в мире занимает целый континент",
                                                "Назовите самую длинную реку мира",
                                                    "Назовите самую высокую гору в мире",
                                                          "В каком городе находится Эйфелева башня",
                                                            "Назовите самый большой океан на планете",
                                                                "Назовите самый большой континент на платене",
                                                                    "Назовите столицу США",
                                                                        "Назовите самую маленькую страну в мире"};              // массив вопросов уровень легкий

        public string[,] answersmid = { { "Канберра", "Йоханнесбург", "Веллингтон", "Сантьяго" },
                                            { "Бангладеш", "Индия", "Китай", "Япония" },
                                                 { "США", "Австралия", "Китай", "Англия" },
                                                     { "Германия", "Великобритания", "Франция", "Италия" },
                                                        { "Тайланд", "Конго", "Тунис", "Вьетнам" },
                                                             { "Килиманджаро", "Везувий", "Фудзияма", "Йеллоустон" },
                                                                 { "Южная Америка", "Северная Америка", "Азия", "Австралия" },
                                                                      { "Мадагаскар", "Ява", "Шри-Ланка", "Гренландия" },
                                                                        { "Тайланд", "Люксембург", "Голландия", "Словения" },
                                                                             { "Токио", "Шанхай", "Пекин", "Дели" },};              // массив ответов уровень средний

        public string[] questionsmid = { "Назовите самую южную столицу" ,
                                            "Назовите страну с самой высокой плотностью населения",
                                               "В какой стране находится это сооружение",
                                                    "Назовите европейскую страну с самой высокой численностью населения",
                                                        "Назовите страну в которой не водятся слоны",
                                                             "Назовите самый крупный вулкан",
                                                                 "На каком контитенте растет это дерево" ,
                                                                      "Назовите самый большой остров в мире" ,
                                                                         "Флаг какой страны изображен на рисунке",
                                                                            "Назовите город мира с самой большой численностью населения"};       // массив вопросов уровень средний

        public string[,] answershig = { { "Саудовская Аравия", "Венесуэла", "Иран", "Россия" },
                                            { "Саудовская Аравия", "Судан", "Ливия", "Алжир" },
                                                { "Англия", "Голландия", "Франция", "Испания" },
                                                     { "Чукотка", "Якутия", "Камчатка", "Сахалин" },
                                                        { "США", "Эквадор", "Индия", "Польша" },
                                                            { "Сингапур", "Малайзия", "Индонезия", "Индия" },
                                                                { "Тайланд", "Италия", "Индия", "Ирак" },
                                                                    { "Австралия", "Фиджи", "Новая Зеландия", "Новая каледония" },
                                                                      { "Парагвай", "Эритрея", "Конго", "Бирма" },
                                                                            { "Байкал", "Верхнее", "Гурон", "Виктория" },}; 

        public string[] questionshig = { "Назовите страну с самыми большими разведанными запасами нефти",
                                            "Назовите страну с самым большим процентом пустынных территорий (относительно её площади)",
                                                "Герб какой страны изображен на рисунке",
                                                   "В каком регионе России отсутсвуют города с населением выше 50 тысяч человек",
                                                        "В какой из перечисленных стран не обитают медведи",
                                                             "Валюта какой страны изображена на рисунке",
                                                                  "В какой из перечисленных стран протекает река Ефрат",
                                                                      "Флаг какой страны изображен на рисунке",
                                                                        "Какая из перечисленных стран не имеет выхода к морю",
                                                                            "Назовите крупнейшее (по площади) озеро на платене"};


        public int qq = 1; // счетчик вопросов
        public int ra = 0; // счетчик верных ответов
        public int rc = 0; // номер выбранного пункта
        public int lc = 0; // количество выбранных уроней сложности

        public int lvl = 0; // номер выбранного уровня сложности

        public int[] arrayRa = { 1, 1, 3, 2, 4, 2,1,3,1,4 };    // массив номеров правильных ответов уровень легкий
        public int[] arrayRamid = { 3,1,2,1,3,4,2,4,3,1};   // массив номеров правильных ответов уровень средний
        public int[] arrayRahig = { 2,3,1,1,4,2,4,3,1,2};  // массив номеров правильных ответов уровень сложный

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "Выберите уровень сложности" ;
            button2.Visible = true;
            button1.Visible = false;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox3.Visible = true;
        }

        
        void levelCheck ()                                  // проверка правильности выбора уровня
        {
            if (checkBox1.Checked == true)
            {
                lc = lc + 1;
                lvl = 1;
            }
            if (checkBox2.Checked == true)
            {
                lc = lc + 1;
                lvl = 2;
            }
            if (checkBox3.Checked == true)
            {
                lc = lc + 1;
                lvl = 3;
            }
           switch (lc)
            {
                case 0:
                    MessageBox.Show(
                              "Выберите один уровень сложности",
                              "Предупреждение",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning,
                              MessageBoxDefaultButton.Button1,
                              MessageBoxOptions.DefaultDesktopOnly);
                    break;
                case 1:
                    break;
                default:
                    MessageBox.Show(
                    "Можно выбрать только один уровень сложности",
                     "Предупреждение",
                        MessageBoxButtons.OK,
                         MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                    break;

            }
        }

        void showPicture()                       //функция вывода изображения
        {
          //  pictureBox1.Visible = true;

            switch (lvl) {

                case 2:

                switch (qq) {
                case 2:
                            pictureBox1.Visible = true;
                            pictureBox1.Image = Resources.Syd;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                            pictureBox1.Visible = true;
                            pictureBox1.Image = Resources.seq;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                            pictureBox1.Visible = true;
                            pictureBox1.Image = Resources.holla;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    break;
                }
                    break;
                case 3:
                    switch (qq)
                    {
                        case 2:
                            pictureBox1.Visible = true;
                            pictureBox1.Image = Resources.eng;
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 5:
                            pictureBox1.Visible = true;
                            pictureBox1.Image = Resources.mal;
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        case 7:
                            pictureBox1.Visible = true;
                            pictureBox1.Image = Resources.Nz;
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        void startTest ()
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)  // начало теста
        {
            levelCheck();
            
            if (lc == 1)
            {
                startTest ();
                switch (lvl)
                {
                    case 1:
                    
                    radioButton1.Text = answers[0, 0];
                    radioButton2.Text = answers[0, 1];
                    radioButton3.Text = answers[0, 2];
                    radioButton4.Text = answers[0, 3];
                    label1.Text = questions[0];
                    break;

                    case 2:
                        
                        radioButton1.Text = answersmid[0, 0];
                        radioButton2.Text = answersmid[0, 1];
                        radioButton3.Text = answersmid[0, 2];
                        radioButton4.Text = answersmid[0, 3];
                        label1.Text = questionsmid[0];
                        break;

                    case 3:

                        radioButton1.Text = answershig[0, 0];
                        radioButton2.Text = answershig[0, 1];
                        radioButton3.Text = answershig[0, 2];
                        radioButton4.Text = answershig[0, 3];
                        label1.Text = questionshig[0];
                        break;
                    default:
                        break;

                }
            }
            
            
            lc = 0;
        }

        void answerCheck ()                           // функция проверки выбранного ответа
        {
            if (radioButton1.Checked == true)
            {
                rc = 1;
            }
            if (radioButton2.Checked == true)
            {
                rc = 2;
            }
            if (radioButton3.Checked == true)
            {
                rc = 3;
            }
            if (radioButton4.Checked == true)
            {
                rc = 4;
            }
            switch (lvl)
            {
                case 1:
                    int a = qq - 1;
                    if (rc == arrayRa[a])
                    { ra++; }
                    break;
                case 2:
                    a = qq - 1;
                    if (rc == arrayRamid[a])
                    { ra++; }
                    break;
                case 3:
                    a = qq - 1;
                    if (rc == arrayRahig[a])
                    { ra++; }
                    break;

                default:
                    break;

            }
        }

        void testRun()                    // обновление вопросов теста
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            rc = 0;
            switch (lvl)
            {
                case 1:
            radioButton1.Text = answers[qq, 0];
            radioButton2.Text = answers[qq, 1];
            radioButton3.Text = answers[qq, 2];
            radioButton4.Text = answers[qq, 3];
            label1.Text = questions[qq];
                    break;

                    case 2:

                    radioButton1.Text = answersmid[qq, 0];
                    radioButton2.Text = answersmid[qq, 1];
                    radioButton3.Text = answersmid[qq, 2];
                    radioButton4.Text = answersmid[qq, 3];
                    label1.Text = questionsmid[qq];

                    showPicture();
                  
                    break;

                case 3:

                    radioButton1.Text = answershig[qq, 0];
                    radioButton2.Text = answershig[qq, 1];
                    radioButton3.Text = answershig[qq, 2];
                    radioButton4.Text = answershig[qq, 3];
                    label1.Text = questionshig[qq];
                    showPicture();
                    break;

                    
                    

                default:
                    break;
            }
            qq = qq+1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                answerCheck(); // проверям, что выбрал пользователь
               
            if (qq > 9)
            {
                label3.Visible = true;
                string ras = ra.ToString();
                label2.Text = ras;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                label2.Visible = true;
                button3.Visible = false;
                label1.Visible = false;
            }
            else
            {

                pictureBox1.Visible = false;
                
                testRun();
            }
        }
    }
}
