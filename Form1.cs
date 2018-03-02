using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiffMatchPatch;

namespace begtodiffer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get inputLeft and inputRight
            string left = inputLeft.Text;
            string right = inputRight.Text;

            // store differences in the displaytext, and line number
            string diffs = "";

            //            for (int line = 1; line <= left.Length; line++) {

            //            }

            diff_match_patch dmp = new diff_match_patch();

            List<Diff> diff = dmp.diff_main(left, right);

            dmp.diff_cleanupSemantic(diff);

            
            for (int i = 0; i < diff.Count; i++)
            {
                Console.WriteLine(diff[i]);
                diffs = diffs + diff[i] + Environment.NewLine;
            }



            // display in display box
            resultText.Text = diffs;
            Console.Read();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
