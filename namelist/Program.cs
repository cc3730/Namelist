using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namelist
{
    class Program
    {
        static void Main(string[] args)
        {
            // 項目列出
            string[] names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] males = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] blood = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] type = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            // 變數設定
            int min = 200;
            int max = 0;
            int sum = 0;
            int girl = 0;
            int sum2 = 0;
            int boy = 0;
            int all=0;
            int all2 = 0;

            int count = 0;
            int countA = 0;
            int countB = 0;
            int countAB = 0;
            int countO = 0;

            int sky = 0;
           
            // 計算各血型
            for (int i=0;i<blood.Length;i++)
            {
                if (blood[i] == "O")
                {
                    countO += 1;
                }
                if (blood[i] == "B")
                {
                    countB += 1;
                }
                if (blood[i] == "A")
                {
                    countA++;
                }
                if (blood[i] == "AB")
                {
                    countAB += 1;
                }
                if(blood[i] == "O" && type[i] == "天蠍")
                {
                    sky += 1;
                }
                else
                    count += 1;
            }

            // 計算各身高
            for(int i=0; i<heights.Length;i++)
            {
                if (heights[i] > 100 && heights[i] < 200)
                {
                    if(heights[i]<min)
                    {
                        min = heights[i];
                    }
                    if(heights[i]>max)
                    {
                        max = heights[i];
                    }
                    if (males[i] == "女")
                    {
                        sum = sum + heights[i];
                        girl += 1;
                    }
                    if (males[i] == "男")
                    {
                        sum2 = sum2 + heights[i];
                        boy += 1;
                    }
                }
            }
            
            // 總數和平均計算
            double average = (double)sum / (double)girl;
            double average2 = (double)sum2 / (double)boy;
            all = sum + sum2;
            all2 = boy + girl;
            double average3 = (double)all / (double)(boy + girl);
            

            double precentA = (double)countA / (double)blood.Length * 100;
            double precentAB = (double)countAB / (double)blood.Length * 100;
            double precentB = (double)countB / (double)blood.Length * 100;
            double precentO = (double)countO / (double)blood.Length * 100;
            double precent = (double)count / (double)blood.Length * 100;
            double gprecent = (double)girl / (double)all2 * 100;
            double bprecent = (double)boy / (double)all2 * 100;

            // 螢幕顯示

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("女生總人數:" + girl+"位  "+gprecent+"%");
            Console.WriteLine("男生總人數:" + boy + "位  " + bprecent + "%" + "\n");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("血型為O的人有: " + countO + "位  " + precentO + "%");
            Console.WriteLine("血型為A的人有: " + countA + "位  "+precentA+"%");
            Console.WriteLine("血型為B的人有: " + countB + "位  " + precentB + "%");
            Console.WriteLine("血型為AB的人有: " + countAB + "位  " + precentAB + "%");
            Console.WriteLine("不明血型的有: " + count + "位  " + precent + "%" + "\n");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("女生身高總合: " + sum);
            Console.WriteLine("女生身高平均: " + average + "\n");

            Console.WriteLine("男生身高總合: " + sum2);
            Console.WriteLine("男生身高平均: " + average2 + "\n");

            Console.WriteLine("全班身高總合: " + all);
            Console.WriteLine("全班身高平均: " + average3 + "\n");

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("全班最矮的身高: " + min);
            Console.WriteLine("全班最高的身高: " + max + "\n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("好運到!");
            Console.WriteLine("最好運的天蠍O型有:" + sky + "人");

            Console.ReadLine();
        }
    }
}
