using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RBSlav_Checked(object sender, RoutedEventArgs e)  // выбран треугольник
        {
            Slav.Visibility = Visibility.Visible;
            JP.Visibility = Visibility.Collapsed;
            Slav.IsEnabled = true;
        }

        private void RBJP_Checked(object sender, RoutedEventArgs e)  // выбран параллелограмм
        {
            Slav.Visibility = Visibility.Collapsed;
            JP.Visibility = Visibility.Visible;
            JP.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)  // событие для кнопки рассчета площади
        {
            try
            {

                if (RB_Slav.IsChecked == true)
                {
                    int d = Convert.ToInt32(Birthday.Text);
                    int m = Convert.ToInt32(CB_Мonths.SelectedIndex);

                    if (d >= 21 && d <= 30 && m <= 8 && m >= 8 || d >= 1 && d <= 1 && m <= 9 && m >= 9) //Чертог Вепря – с 21.09 по 12.10
                    {
                        string un0 = "Вепрь или кабан приходят в этот мир, чтобы под покровительством Рахмата выполнять великую миротворческую \n" +
                            "миссию. Страшным преступлением считается жертвоприношения, нанесение увечий, не говоря уж об убийствах. Вепри \n" +
                            "стремятся к справедливости. Они рассудительны и предусмотрительны. Их цель – постичь законы бытия."; 
                        TBlResult.Text = un0;
                        imgZn.Source = new BitmapImage(new Uri("img/1_slav.jpg", UriKind.Relative));
                    }
                    
                    if (d >= 13 && d <= 31 && m <= 9 && m >= 9 || d >= 1 && d <= 3 && m <= 10 && m >= 10) //Чертог Щуки – с 13.10 по 03.11
                    {
                        string un1 = "Чертог Щуки сказывается на характере рожденных людей таким образом, что главным предназначением для них \n" +
                            "является продолжение рода, сохранение традиций и богатства Рода, истинных семейных ценностей, а также воспитание детей."; //исправил
                        TBlResult.Text = un1;
                        imgZn.Source = new BitmapImage(new Uri("img/2_slav.jpg", UriKind.Relative));
                    }

                    if (d >= 4 && d <= 24 && m <= 10 && m >= 10) //Чертог Лебедя – с 04.11 по 24.11
                    {
                        string un2 = "Лебедь - спокойный, уравновешенный, мудрый от природы. Он способен проникать в самую сущность явления,\n " +
                            "понимает других людей на уровне интуиции. Любит порядок во всем, знает цену себе и свое предназначение. Это очень\n " +
                            "хозяйственный человек.";
                        TBlResult.Text = un2;
                        imgZn.Source = new BitmapImage(new Uri("img/3_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 29 && d <= 31 && m <= 7 && m >= 7 || d >= 1 && d <= 20 && m <= 8 && m >= 8) //Чертог Девы – с 29.08 по 20.09
                    {
                        string un3 = "Девы стремятся достичь духовного совершенства. Они обладают исключительно развитым чувством интуиции и \n " +
                            "эмоционального сопереживания близкому человеку. Способны уловить душевное состояние близкого им человека даже на \n " +
                            "далеком расстоянии от него."; 
                        TBlResult.Text = un3;
                        imgZn.Source = new BitmapImage(new Uri("img/4_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 25 && d <= 30 && m <= 10 && m >= 10 || d >= 1 && d <= 17 && m <= 11 && m >= 11) //Чертог Змея – с 25.11 по 17.12
                    {
                        string un4 = "Змей - в первую очередь, это очень умные и эмоциональные люди. Им от природы дана высокая духовная\n " +
                            "чувствительность. В то же время они обладают и холодной рассудительностью. Эти качества могут и не проявиться,\n " +
                            "если Змей не будет заниматься самосовершенствованием."; 
                        TBlResult.Text = un4;
                        imgZn.Source = new BitmapImage(new Uri("img/5_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 18 && d <= 31 && m <= 11 && m >= 11 || d >= 1 && d <= 8 && m <= 0 && m >= 0) //Чертог Ворона – для родившихся с 18.12 по 08.01.
                    {
                        string un5 = "Ворон - это любознательные, добродушные люди. Это творческие натуры, философы и мечтатели.";
                        TBlResult.Text = un5;
                        imgZn.Source = new BitmapImage(new Uri("img/6_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 2 && d <= 25 && m <= 1 && m >= 1) //Чертог Бусла – с 02.02 по 25.02.
                    {
                        string un6 = "Бусл - это умный, но почему-то не всегда мудрый человек. Ему присуще быть себе на уме, а переубедить\n" +
                            "в чем-нибудь человека-Бусла практически невозможно. Отличаются мягкостью,  и при этом физической выносливостью.\n " +
                            "Любят порядок во всем их окружающем, учиться и  трудиться."; 
                        TBlResult.Text = un6;
                        imgZn.Source = new BitmapImage(new Uri("img/7_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 26 && d <= 28 && m <= 1 && m >= 1 || d >= 1 && d <= 22 && m <= 2 && m >= 2) //Чертог Волка – с 26.02 по 22.03.
                    {
                        string un7 = "Волк - c одной стороны, это люди, которым никто не нужен. Это интроверты, ценящие одиночество.\n" +
                            "С другой стороны, они способны на искреннюю дружбу и любовь. Создают прекрасные семьи и умеют передавать\n " +
                            "свои знания и ценности своим детям."; 
                        TBlResult.Text = un7;
                        imgZn.Source = new BitmapImage(new Uri("img/8_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 9 && d <= 31 && m <= 0 && m >= 0 || d >= 1 && d <= 1 && m <= 1 && m >= 1) // Чертог Медведя —  с 09.01 по 01.02.
                    {
                        string un8 = "Люди, рожденные в период Медведя – сильные духом, целеустремленные и справедливые. Это добрые труженики, \n " +
                            "для которых важно благополучие семьи и рода."; 
                        TBlResult.Text = un8;
                        imgZn.Source = new BitmapImage(new Uri("img/9_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 23 && d <= 31 && m <= 2 && m >= 2 || d >= 1 && d <= 15 && m <= 3 && m >= 3) //Чертог Лиса – с 23.03 по 15.04
                    {
                        string un9 = "Лиса - 'то мудрые люди, способные познать предвечную истину. Они щедро наделены талантами и способностями.\n " +
                            "Видимо для равновесия в мироздании, Лисам ниспосланы трудности и проблемы, которые постоянно встают у них на пути.\n " +
                            "Чтобы реализоваться и раскрыть свой потенциал в полной мере, им необходим солидный запас внутренней энергии.";
                        TBlResult.Text = un9;
                        imgZn.Source = new BitmapImage(new Uri("img/10_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 16 && d <= 30 && m <= 3 && m >= 3 || d >= 1 && d <= 7 && m <= 4 && m >= 4) //Чертог Тура – с 16.04 по 07.05
                    {
                        string un10 = "Люди, рожденные под знаком Тура – упрямые и сильные. Они спокойные, но терпение их не бесконечно и в гневе\n" +
                            " нет страшнее, чем Тур. Бык – он такой. Люди-Туры трудолюбивы, они привыкли доводить всё до конца. В то же время у\n " +
                            "них хорошо развита интуиция и дар предвидения, они тонко чувствуют окружающих их людей и ситуацию."; 
                        TBlResult.Text = un10;
                        imgZn.Source = new BitmapImage(new Uri("img/11_slav.jpeg", UriKind.Relative));
                    }
                    if (d >= 8 && d <= 30 && m <= 4 && m >= 4) //Чертог Лося – с 08.05 по 30.05
                    {
                        string un11 = "Лоси – это трудолюбивые и выносливые люди. Прирожденные лидеры, умеющие вести за собой. Ставят цели и упрямо\n" +
                            " добиваются их. Цену себе и к чему стремиться они знают с раннего детства. Умные и  старательные Лоси добиваются очень\n" +
                            " многого. Это прекрасные ораторы и верные друзья. Они готовы отдать последнюю рубашку нуждающемуся. Помощь ближнему для\n" +
                            " них стоит на первом месте."; 
                        TBlResult.Text = un11;
                        imgZn.Source = new BitmapImage(new Uri("img/12_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 31 && d <= 31 && m <= 4 && m >= 4 || d >= 1 && d <= 21 && m <= 5 && m >= 5) //Чертог Финиста – с 30.05 по 21.06
                    {
                        string un12 = "Финиста - смелые, энергичные, умеющие делать сразу несколько дел; идеализируют мир, поэтому часто одиноки;\n " +
                            "ставят перед собой недостижимые цели и упорно стремятся к ним, не отступая при неудачах; обладают талантами и\n " +
                            "экстрасенсорными способностями, из них выходят замечательные художники, музыканты, маги; "; 
                        TBlResult.Text = un12;
                        imgZn.Source = new BitmapImage(new Uri("img/13_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 22 && d <= 30 && m <= 5 && m >= 5|| d >= 1 && d <= 13 && m <= 6 && m >= 6) //Чертог Коня – с 22.06 по 13.07
                    {
                        string un13 = "Конь - это жизнерадостные, энергичные и эмоциональные люди. Не случайно чертог назвали в честь коня. Характер\n" +
                            " летнего человека как нельзя лучше описывает это животное. Кони трудолюбивые, они всегда готовы взять на себя самую\n " +
                            "тяжелую и трудную работу. Они выносливые. Их эмоциональность проявляется в том, что они быстро «загораются» и так же\n " +
                            "быстро «остывают». В целом они непостоянны, не любят монотонность.";
                        TBlResult.Text = un13;
                        imgZn.Source = new BitmapImage(new Uri("img/14_slav.jpeg", UriKind.Relative));
                    }
                    if (d >= 14 && d <= 31 && m <= 6 && m >= 6 || d >= 1 && d <= 4 && m <= 7 && m >= 7) //Чертог Орла – с 14.07 по 04.08
                    {
                        string un14 = "Люди, рожденные в чертог Орла под покровительством Перуна, отличаются бодростью и силой духа. Это отважные\n" +
                            " и добрые, целеустремленные и гордые, умные и проницательные люди. Они добиваются поставленной цели, а цель их всегда\n" +
                            " связана со служением обществу."; 
                        TBlResult.Text = un14;
                        imgZn.Source = new BitmapImage(new Uri("img/15_slav.jpg", UriKind.Relative));
                    }
                    if (d >= 5 && d <= 28 && m <= 7 && m >= 7) //Чертог Раса – с 05.08 по 28.08
                    {
                        string un15 = "Люди, родившиеся в Чертоге Раса – любознательные, импульсивные, и в то же время, рассудительные и терпеливые.\n " +
                            "Характер Пардуса, сказывающийся на рожденных в августе (сравните со Львами по привычному гороскопу) – это эмоциональность\n " +
                            "и одновременно умение затаиться и выждать, прежде чем прыгнуть.";
                        TBlResult.Text = un15;
                        imgZn.Source = new BitmapImage(new Uri("img/16_slav.jpg", UriKind.Relative));
                    }

                }
        }
            catch
            {
                MessageBox.Show("Пожалуйста, проверьте верность введенных данных");
            }
                
            
            
            
            if (RB_JP.IsChecked == true)
            {
                switch (CB_Year.SelectedIndex)
                {
                    case 0:
                        string square0 = " Крыса - рожденные под этим знаком обладают приятной внешностью, привлекательны, целеустремленны, трудолюбивы,\n" +
                            "стремятся к приобретению богатств. Бережливы, любят экономить деньги. За6ыть о бережливости они могут лишь при увлеченности\n " +
                            "или большом чувстве. Щедры только с теми, кого любят. Аккуратны до педантичности. Во многом нелогичны.\n" +
                            "Честолюбивы. Как правило, преуспевают Обычно честны и открыты, и добиваются своего. Не умеют сохранять внешнее \n" +
                            "cамообладание, легко впадают в гнев. но многие из них не прочь посплетничать. Вам идеально подходят\n" +
                            "как друзья или спутники жизни Дракон, Обезьяна, Вол. В большей или меньшей \n" +
                            "степени Вам подходят Змея, Тигр, Собака, Кабан, Крыса. Абсолютно противопоказаны, решительно не подходит Лошадь ";
                        TBlResult.Text = square0;
                        break;
                    case 1:
                        string square1 = " Бык - излучает уверенность в себе и своих силах. Он идет по жизни очень спокойно, как будто не принимая всерьез заботы и \n" +
                            "проблемы других людей: его волнует только собственный путь, чужие дела ему неинтересны. Бык не любит совершать ошибок, поэтому\n " +
                            "к каждому значимому шагу готовится очень серьезно, оценивая возможные последствия, а также усилия, которые придется\n" +
                            "приложить для достижения результата.";
                        TBlResult.Text = square1;
                        break;
                    case 2:
                        string square2 = " Тигр - «горячее сердце» вот, пожалуй, лучшее описание характера человека, родившегося в год Тигра. Он чаще\n " +
                            "прислушивается к эмоциям, чем к логическим аргументам, бесконечно искренен в чувствах и не признает полумер. Увы, способностью\n " +
                            "хладнокровно рассуждать Тигры не могут похвастать. Хуже того, они настолько упрямы, что игнорируют не только добрые советы,\n " +
                            "но и приказы.";
                        TBlResult.Text = square2;
                        break;
                    case 3:
                        string square3 = " Кролик - человек, родившийся в год Кролика, всегда очень мил в общении, трогательно сентиментален.\n " +
                            "К тому же это милый консерватор, симпатию которого легко завоевать, заявив о своей приверженности традициям, законопослушности\n" +
                            "и настороженном отношении к рискованным проектам";
                        TBlResult.Text = square3;
                        break;
                    case 4:
                        string square4 = " Дракон - умный и одаренный от природы Дракон всегда стремится к совершенству, предъявляя к себе столь\n " +
                            "же высокие требования, что и к другим. Из-за этого Дракон постоянно испытывает внутреннее напряжение и даже в компании\n " +
                            "близких друзей не позволяет себе расслабиться.";
                        TBlResult.Text = square4;
                        break;
                    case 5:
                        string square5 = " Змея - мудрость Змеи не зря вошла в пословицы: у таких людей есть удивительная способность пользоваться\n " +
                            "одновременно знаниями, логикой и интуицией. Даже наиболее рассудительная Змея не бывает чужда романтики, отличаясь редкой\n " +
                            "гармонией ума и чувств. Однако она склонна ко всему относиться слишком серьезно и редко бывает наделена чувством юмора.\n " +
                            "Впрочем, скорее всего, этого никто не заметит — Змея посмеется над вашей шуткой, даже если не поймет, в чем ее «соль»,\n " +
                            "а также удивит вас парадоксальными умозаключениями, которые нельзя воспринимать иначе, как остроты.";
                        TBlResult.Text = square5;
                        break;
                    case 6:
                        string square6 = " Лошадь - выражение «работать как лошадь» определенно придумал кто-то, хорошо знакомый с японским\n " +
                            "гороскопом. Согласно ему, Лошадь не только трудолюбива, но и независима, поэтому предпочитает работать в одиночку,\n " +
                            "а не в команде. Оно и к лучшему, поскольку эгоизм Лошади делает ее не слишком приятным коллегой.";
                        TBlResult.Text = square6;
                        break;
                    case 7:
                        string square7 = " Овца - овце не откажешь в очаровании, элегантности и артистическом даре, однако она бывает\n " +
                            "необыкновенной пессимисткой и очень любит пожаловаться на жизнь. Впрочем, у нее доброе сердце, так что люди согласны\n " +
                            "терпеть плохое настроение Овцы, зная, что, окажись они в трудной ситуации, Овца не замедлит прийти на помощь.";
                        TBlResult.Text = square7;
                        break;
                    case 8:
                        string square8 = " Обезьяны — натуры необыкновенно занятные и неугомонные, которые не дают покоя ни себе, ни другим.\n" +
                            "Они всегда чем-то заняты, увлечены одновременно тысячей идей и втягивают в свой круг общения все новых и новых людей.";
                        TBlResult.Text = square8;
                        break;
                    case 9:
                        string square9 = " Петух - хвастун и мечтатель, который сразу выделяется из толпы благодаря экстравагантной одежде\n " +
                            "и необычному поведению — вот каков Петух. Между тем, как ни удивительно, он отличается еще и трудолюбием,\n" +
                            "а также целеустремленностью.";
                        TBlResult.Text = square9;
                        break;
                    case 10:
                        string square10 = " Собака - преданность и честность — вот черты, свойственные Собаке. Кроме того, она умеет любить\n " +
                            "по-настоящему, искренне и безоглядно отдаваясь чувству. Собака хороший друг и верный возлюбленный, достойный абсолютного\n " +
                            "доверия помощник и настоящий альтруист. Желание помогать людям проявляется у Собаки в сравнительно раннем возрасте,\n " +
                            "поэтому она и будущую профессию выбирает, ориентируясь в большей степени не на доходность ее, а на социальную значимость";
                        TBlResult.Text = square10;
                        break;
                    case 11:
                        string square11 = " Кабан - человек, родившийся в год Кабана, обычно наделен достаточным умом и целеустремленностью,\n " +
                            "чтобы достичь целей, которые другим не по силам. Он всегда честен с окружающими от них ждет того же. Склонен всем доверять,\n " +
                            "поэтому кажется наивным, а порой и глуповатым.";
                        TBlResult.Text = square11;
                        break;
                }
            }

        }

    }

   
}
