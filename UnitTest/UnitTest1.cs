using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramCerification;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public Problems problems = new Problems();

        /// <summary>
        /// �� 1 �D �V �^���r�� ASCII �s�X�p��
        /// </summary>
        [TestMethod]
        public void EnChar2AsciiCaculateTest()
        {
            Assert.AreEqual(problems.EnChar2AsciiCaculate("famiLy"), "101.667");
            Assert.AreEqual(problems.EnChar2AsciiCaculate("About"), "101.400");
            Assert.AreEqual(problems.EnChar2AsciiCaculate("ASCII"), "72.200");
            Assert.AreEqual(problems.EnChar2AsciiCaculate("GitRemote"), "101.333");
            Assert.AreEqual(problems.EnChar2AsciiCaculate("USIDOGOSIDGHFJGJHSDOIFHGSDKLS:JJCIXOJ"), "��J�榡�Τ��e���~");
        }

        /// <summary>
        /// �� 2 �D �V ���B�Ʀr��j�g��r
        /// </summary>
        [TestMethod]
        public void Price2Chinese()
        {
            Assert.AreEqual(problems.Price2Chinese("1308792465"), "���B�ѻ��s�èլm�B�h�U�L�a�v�ճ��B���");
            Assert.AreEqual(problems.Price2Chinese("6534278109"), "���B����ѥa�v�նL�B�m�U�åa���չs�h����");
            Assert.AreEqual(problems.Price2Chinese("1845692730"), "���B�û��v�a��ճ��B�h�U�L�a�m�հѬB����");
            Assert.AreEqual(problems.Price2Chinese("0852764319"), "�û���a�L�լm�B���U�v�a�Ѩճ��B�h����");
            Assert.AreEqual(problems.Price2Chinese("6385710942"), "���B�ѻ��åa��լm�B���U�s�h�ոv�B�L����");
            Assert.AreEqual(problems.Price2Chinese("���Q"), "��J�榡���O�¼Ʀr�ή榡����10���");
            Assert.AreEqual(problems.Price2Chinese("65151654"), "��J�榡���O�¼Ʀr�ή榡����10���");
        }

        /// <summary>
        /// �� 3 �D �V �q�Ʀr�C��
        /// </summary>
        [TestMethod]
        public void GuessNumber()
        {
            Assert.AreEqual(problems.GuessNumber("1235 4385"), "1A1B");
            Assert.AreEqual(problems.GuessNumber("4801 0123"), "0A2B");
            Assert.AreEqual(problems.GuessNumber("8894 0548"), "0A2B");
            Assert.AreEqual(problems.GuessNumber("7423 4723"), "2A2B");
            Assert.AreEqual(problems.GuessNumber("4516,4567"), "��J�榡���~�A�ХΤ@�Ӫťզr���j�}���4��Ʀr");
            Assert.AreEqual(problems.GuessNumber("4164 56AB"), "��J�榡���~");
        }

        ///// <summary>
        ///// �� 6 �D �V �l���~���̤j�԰��O�`�M
        ///// </summary>
        //[TestMethod]
        //public void GetSummon()
        //{
        //    Assert.AreEqual(problems.GetSummon("3,200,1,1,1,1,1,1,1,1,1,1"), "5");
        //    Assert.AreEqual(problems.GetSummon("45,100,1,3,1,5,1,10,1,50,1,1"), "228");
        //}
    }
}
