using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.myControl;



namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            //UCText uct = new UCText()
            //{
            //    Location = new Point(20, 20),
            //    Size = new Size(340, 190)
            //};
            ////// 添加到界面
            ////this.Controls.Add(uct);
            ///

            //UCText uct = new UCText()
            //{
            //    Location = new Point(20, 20),
            //    Size = new Size(340, 190),                
            //};
            //// 添加到界面
            //this.Controls.Add(uct);

            bookList.ForEach(item =>
            {
                UCText uct = new UCText(item["书名"], item["作者"], item["简介"]);
                
                // 添加到布局容器
                flowLayoutPanel1.Controls.Add(uct);
            });

        }




        // 20本经典书籍，List里面存放字典
        private List<Dictionary<string, string>> bookList = new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>()
                {
                    {"书名","三国演义"},
                    {"作者","罗贯中"},
                    {"简介","东汉末年分三国，讲述魏蜀吴三国之间政治军事斗争的长篇历史小说。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","红楼梦"},
                    {"作者","曹雪芹"},
                    {"简介","以贾史王薛四大家族兴衰为背景，描写宝黛钗爱情悲剧，是古典小说巅峰之作。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","水浒传"},
                    {"作者","施耐庵"},
                    {"简介","讲述北宋末年一百零八位好汉聚义梁山，反抗压迫的英雄故事。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","西游记"},
                    {"作者","吴承恩"},
                    {"简介","唐僧师徒四人历经九九八十一难西天取经的神魔浪漫小说。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","平凡的世界"},
                    {"作者","路遥"},
                    {"简介","记录陕北普通人在时代浪潮下奋斗、苦难与坚守的长篇现实主义小说。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","活着"},
                    {"作者","余华"},
                    {"简介","讲述福贵一生历经苦难，在重重悲剧之中依旧顽强活下去的故事。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","我与地坛"},
                    {"作者","史铁生"},
                    {"简介","作者在地坛思索生死命运，抒发对母亲、生命的感悟与思考。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","骆驼祥子"},
                    {"作者","老舍"},
                    {"简介","旧北平人力车夫祥子努力挣扎，梦想一步步破灭的悲剧故事。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","朝花夕拾"},
                    {"作者","鲁迅"},
                    {"简介","鲁迅回忆童年、少年、青年生活经历的回忆性散文集。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","围城"},
                    {"作者","钱钟书"},
                    {"简介","描写知识分子方鸿渐的人生境遇，讽刺婚姻与世俗人情。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","百年孤独"},
                    {"作者","加西亚·马尔克斯"},
                    {"简介","魔幻现实主义经典，书写布恩迪亚家族七代人百年兴衰与孤独。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","悲惨世界"},
                    {"作者","维克多·雨果"},
                    {"简介","围绕冉阿让一生，揭露社会不公，歌颂善良与人性光辉。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","巴黎圣母院"},
                    {"作者","维克多·雨果"},
                    {"简介","发生在巴黎圣母院，讲述美与丑、善与恶强烈对比的浪漫悲剧。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","老人与海"},
                    {"作者","海明威"},
                    {"简介","老渔夫桑地亚哥与大鱼搏斗，展现人可以被毁灭但不能被打败的精神。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","简·爱"},
                    {"作者","夏洛蒂·勃朗特"},
                    {"简介","孤女简爱追求平等尊严，坚守人格独立的爱情成长故事。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","钢铁是怎样炼成的"},
                    {"作者","奥斯特洛夫斯基"},
                    {"简介","保尔柯察金在苦难中磨练意志，为理想奉献一生的励志小说。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","战争与和平"},
                    {"作者","列夫·托尔斯泰"},
                    {"简介","以拿破仑战争为背景，展现俄国社会广阔画卷的史诗巨著。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","小王子"},
                    {"作者","安托万·德·圣‑埃克苏佩里"},
                    {"简介","童话外壳下探讨爱、孤独与本心，写给成年人的哲理故事。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","堂吉诃德"},
                    {"作者","塞万提斯"},
                    {"简介","讲述沉迷骑士小说的堂吉诃德的冒险，理想与现实碰撞的喜剧悲剧。"}
                },
                new Dictionary<string, string>()
                {
                    {"书名","红与黑"},
                    {"作者","司汤达"},
                    {"简介","描写青年于连向上攀爬，在阶级社会中挣扎毁灭的故事。"}
                }
            };
    }

}
