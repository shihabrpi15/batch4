using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinApp
{
    public partial class ManyExampleForm : Form
    {
        List<int> numbers = new List<int>();
        //const int size=0;
        //private static int inputData;
        //private int[] numbersSets;
        public ManyExampleForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            
            numbers.Add(Convert.ToInt32(textBoxInputData.Text));
            
            
            
        }

        private void buttonShowDisplay_Click(object sender, EventArgs e)
        {
            string message = "For\n";

            for (int i = 0; i < numbers.Count; i++)
            {
                message += numbers[i] + "\n";

            }

            message += "Forech\n";

            foreach (int item in numbers)
            {
                message += item+ "\n";
            }
            richTextBoxShowDisplay.Text = message;
        }
    }
}
