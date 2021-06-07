using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramCerification;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public Problems problems = new Problems();

        /// <summary>
        /// 第 1 題 – 英文單字之 ASCII 編碼計算
        /// </summary>
        [TestMethod]
        public void EnChar2AsciiCaculateTest()
        {
            Assert.AreEqual(problems.EnChar2AsciiCaculate("famiLy"), "101.667");
            Assert.AreEqual(problems.EnChar2AsciiCaculate("About"), "101.400");
            Assert.AreEqual(problems.EnChar2AsciiCaculate("ASCII"), "72.200");
            Assert.AreEqual(problems.EnChar2AsciiCaculate("GitRemote"), "101.333");
            Assert.AreEqual(problems.EnChar2AsciiCaculate("USIDOGOSIDGHFJGJHSDOIFHGSDKLS:JJCIXOJ"), "輸入格式或內容錯誤");
        }

        /// <summary>
        /// 第 2 題 – 金額數字轉大寫國字
        /// </summary>
        [TestMethod]
        public void Price2Chinese()
        {
            Assert.AreEqual(problems.Price2Chinese("1308792465"), "壹拾參億零捌佰柒拾玖萬貳仟肆佰陸拾伍元整");
            Assert.AreEqual(problems.Price2Chinese("6534278109"), "陸拾伍億參仟肆佰貳拾柒萬捌仟壹佰零玖元整");
            Assert.AreEqual(problems.Price2Chinese("1845692730"), "壹拾捌億肆仟伍佰陸拾玖萬貳仟柒佰參拾元整");
            Assert.AreEqual(problems.Price2Chinese("0852764319"), "捌億伍仟貳佰柒拾陸萬肆仟參佰壹拾玖元整");
            Assert.AreEqual(problems.Price2Chinese("6385710942"), "陸拾參億捌仟伍佰柒拾壹萬零玖佰肆拾貳元整");
            Assert.AreEqual(problems.Price2Chinese("五十"), "輸入格式不是純數字或格式不為10位數");
            Assert.AreEqual(problems.Price2Chinese("65151654"), "輸入格式不是純數字或格式不為10位數");
        }

        /// <summary>
        /// 第 3 題 – 猜數字遊戲
        /// </summary>
        [TestMethod]
        public void GuessNumber()
        {
            Assert.AreEqual(problems.GuessNumber("1235 4385"), "1A1B");
            Assert.AreEqual(problems.GuessNumber("4801 0123"), "0A2B");
            Assert.AreEqual(problems.GuessNumber("8894 0548"), "0A2B");
            Assert.AreEqual(problems.GuessNumber("7423 4723"), "2A2B");
            Assert.AreEqual(problems.GuessNumber("4516,4567"), "輸入格式錯誤，請用一個空白字元隔開兩個4位數字");
            Assert.AreEqual(problems.GuessNumber("4164 56AB"), "輸入格式錯誤");
        }

        ///// <summary>
        ///// 第 6 題 – 召喚獸之最大戰鬥力總和
        ///// </summary>
        //[TestMethod]
        //public void GetSummon()
        //{
        //    Assert.AreEqual(problems.GetSummon("3,200,1,1,1,1,1,1,1,1,1,1"), "5");
        //    Assert.AreEqual(problems.GetSummon("45,100,1,3,1,5,1,10,1,50,1,1"), "228");
        //}
    }
}
