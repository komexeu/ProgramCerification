using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramCerification
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problems p = new Problems();
            //string input = Console.ReadLine();

            //p.EnChar2AsciiCaculate(input);
            //////Price2Chinese(input);
            ////GuessNumber(input);
            //////GetSummon(input);

            //Console.ReadKey();
            //return;
        }
    }

    public class Problems
    {
        /// <summary>
        /// 第 1 題 – 英文單字之 ASCII 編碼計算
        /// <para>using System;</para>
        /// </summary>
        /// <param name="input"></param>
        public string EnChar2AsciiCaculate(string input)
        {
            int ascii_sum = 0;
            try
            {
                if (input.Length <= 0 || input.Length >= 32)
                    throw new ArgumentException("輸入格式或內容錯誤");

                foreach (var ch in input)
                    ascii_sum += Convert.ToInt32(ch);

                double result = Math.Round((float)ascii_sum / (float)input.Length, 3);
                // Console.WriteLine(string.Format("{0:0.000}", result));
                return string.Format("{0:0.000}", result);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                return e.Message;
            }
        }

        /// <summary>
        /// 第 2 題 – 金額數字轉大寫國字
        /// <para>using System;</para>
        /// <para>using System.Collections.Generic;</para>
        /// </summary>
        /// <param name="input"></param>
        public string Price2Chinese(string input)
        {
            try
            {
                if (!long.TryParse(input, out _) || input.Length != 10)
                    throw new ArgumentException("輸入格式不是純數字或格式不為10位數");

                Dictionary<char, string> dic_num_chinese = new Dictionary<char, string>();
                dic_num_chinese.Add('0', "零,拾");
                dic_num_chinese.Add('1', "壹,億");
                dic_num_chinese.Add('2', "貳,仟");
                dic_num_chinese.Add('3', "參,佰");
                dic_num_chinese.Add('4', "肆,拾");
                dic_num_chinese.Add('5', "伍,萬");
                dic_num_chinese.Add('6', "陸,仟");
                dic_num_chinese.Add('7', "柒,佰");
                dic_num_chinese.Add('8', "捌,拾");
                dic_num_chinese.Add('9', "玖,");

                string result = "";
                for (int i = 0; i < input.Length; ++i)
                {
                    if ((i == 9 || i == 0) && input[i] == '0') continue;
                    //Console.Write(dic_num_chinese[input[i]].Split(',')[0]);
                    result += dic_num_chinese[input[i]].Split(',')[0];
                    if (input[i] == '0') continue;
                    //Console.Write(dic_num_chinese[i.ToString().ToCharArray()[0]].Split(',')[1]);
                    result += dic_num_chinese[i.ToString().ToCharArray()[0]].Split(',')[1];
                }
                //Console.WriteLine("元整");
                return result += "元整";
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                return e.Message;
            }
        }

        /// <summary>
        /// 第 3 題 – 猜數字遊戲
        /// <para>using System;</para>
        /// </summary>
        /// <param name="input"></param>
        public string GuessNumber(string input)
        {
            try
            {
                if (input.Length != 9 || input[4] != ' ')
                    throw new ArgumentException("輸入格式錯誤，請用一個空白字元隔開兩個4位數字");
                if (input.Split(' ')[0].Length != 4 || input.Split(' ')[1].Length != 4||
                    !int.TryParse( input.Split(' ')[0],out _)|| !int.TryParse(input.Split(' ')[1],out _))
                    throw new ArgumentException("輸入格式錯誤");

                string Ans = input.Split(' ')[0];
                string user_guess = input.Split(' ')[1];

                int A = 0;
                int B = 0;
                for (int i = 0; i < 4; ++i)
                {
                    if (Ans.ToList().Exists(x => x == user_guess[i]))
                        B++;
                    if (user_guess[i] == Ans[i])
                    {
                        A++;
                        B--;
                    }
                }
                //Console.WriteLine($"{A}A{B}B");
                return $"{A}A{B}B";
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                return e.Message;
            }
        }

        /// <summary>
        /// 第 6 題 – 召喚獸之最大戰鬥力總和
        /// <para>using System;</para>
        /// <para>using System.Collections.Generic;</para>
        /// </summary>
        /// <param name="input"></param>
        public string GetSummon(string input)
        {
            try
            {
                var splited_input = input.Split(',');
                if (splited_input.Length != 12)
                    throw new ArgumentException("輸入錯誤");

                //2->A,3->B,4->C...11->J
                //"X,Y"->"戰鬥力,花費比特幣數"
                Dictionary<int, string> summon_dic = new Dictionary<int, string>();
                summon_dic.Add(2, "X,30");
                summon_dic.Add(3, "75,18");
                summon_dic.Add(4, "45,8");
                summon_dic.Add(5, "20,5");
                summon_dic.Add(6, "2,1");
                summon_dic.Add(7, "300,50");
                summon_dic.Add(8, "70,16");
                summon_dic.Add(9, "50,10");
                summon_dic.Add(10, "25,4");
                summon_dic.Add(11, "3,1");

                int summoner_cost = 0;
                List<(int id, double avg_cost)> sorted_summon_data = new List<(int id, double avg_cost)>();

                //持有彼特幣數
                summoner_cost = Convert.ToInt32(splited_input[0]);
                //A戰鬥力
                summon_dic[2] = $"{splited_input[1]},30";

                foreach (var s in summon_dic)
                {
                    var data = s.Value.Split(',');
                    sorted_summon_data.Add((s.Key, Convert.ToDouble(data[1]) / Convert.ToDouble(data[0])));
                }
                sorted_summon_data.Sort((x, y) => x.avg_cost.CompareTo(y.avg_cost));

                int sum_combat_effectiveness = 0;
                foreach (var current_summon in sorted_summon_data)
                {
                    if (summoner_cost <= 0) break;
                    var current_dic_value = summon_dic[current_summon.id];
                    var data = current_dic_value.Split(',');

                    int current_summon_num = 0;
                    while (summoner_cost >= Convert.ToInt32(data[1]) && current_summon_num < Convert.ToInt32(splited_input[current_summon.id]))
                    {
                        summoner_cost -= Convert.ToInt32(data[1]);
                        sum_combat_effectiveness += Convert.ToInt32(data[0]);
                        current_summon_num++;
                    }
                }
                //Console.WriteLine(sum_combat_effectiveness);
                return sum_combat_effectiveness.ToString();
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.Message);
                return e.Message;
            }
        }
    }
}
