using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winwink.LearnCsharpCollection.chapter1_Collection;

namespace Winwink.LeanCsharpCollection.Ex1_StudentTurnInTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _submittedTests = new MyCollection();
            _outForChecking = new MyCollection();
        }
        private MyCollection _submittedTests;
        private MyCollection _outForChecking;
        private void BtnTrunIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtName.Text)) return;
            _submittedTests.Add(new Test(TxtName.Text, int.Parse(TxtNumber.Text)));
            Flush();
        }

        private void BtnLookTest_Click(object sender, EventArgs e)
        {
            var selectTest = listBoxSubmitted.SelectedItem;
            _submittedTests.Remove(selectTest);
            _outForChecking.Add(selectTest);
            Flush();
        }



        private void BtnReturnTest_Click(object sender, EventArgs e)
        {
            var selectTest = listBoxOutForChecking.SelectedItem;
            _outForChecking.Remove(selectTest);
            _submittedTests.Add(selectTest);

            Flush();
        }

        private void BtnExitTest_Click(object sender, EventArgs e)
        {
            while (_outForChecking.Count() > 0)
            {
                var test = _outForChecking[0];
                _outForChecking.Remove(test);
                _submittedTests.Add(test);
            }


            Flush();
        }

        private void Flush()
        {
            listBoxSubmitted.DataSource = null;
            listBoxSubmitted.DataSource = _submittedTests;
            if (_submittedTests.Count() > 0)
            {
                listBoxSubmitted.DisplayMember = "Name";
                listBoxSubmitted.ValueMember = "Name";
            }

            listBoxOutForChecking.DataSource = null;
            listBoxOutForChecking.DataSource = _outForChecking;
            if (_outForChecking.Count() > 0)
            {
                listBoxOutForChecking.DisplayMember = "Name";
                listBoxOutForChecking.ValueMember = "Name";
            }
        }
    }
}
