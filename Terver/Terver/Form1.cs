using System.Numerics;
using System.Text;
using System.Linq;

namespace Terver
{
    public partial class Form1 : Form
    {
        Base_Logic bs = new Base_Logic();
        
        public Form1()
        {
            InitializeComponent();                                                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(InputN.Text.Split(' ').Length > 1 || InputK.Text.Split(' ').Length > 1 || InputK.Text == "" || InputN.Text == "")
            {
                MessageBox.Show("Неверно вписали n/k");
            }
            else
            {
                BigInteger result;

                if (Accommodation.Checked)
                {
                    result = bs.Accommodation_WithRepeat(BigInteger.Parse(InputN.Text),
                                                   BigInteger.Parse(InputK.Text));
                    Answer.Text = "Ответ " + result.ToString();
                }
                else
                {
                    result = bs.Accommodation(BigInteger.Parse(InputN.Text),
                                       BigInteger.Parse(InputK.Text));
                    Answer.Text = "Ответ " + result.ToString();
                }
            }                      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InputN.Text.Split(' ').Length > 1 || InputK.Text.Split(' ').Length > 1 || InputK.Text == "" || InputN.Text == "")
            {
                MessageBox.Show("Неверно вписали n/k");
            }
            else
            {
                BigInteger result;

                if (Combination.Checked)
                {
                    result = bs.Combination_WithRepeat(BigInteger.Parse(InputN.Text),
                                                   BigInteger.Parse(InputK.Text));
                    Answer.Text = "Ответ " + result.ToString();
                }
                else
                {
                    result = bs.Combination(BigInteger.Parse(InputN.Text),
                                       BigInteger.Parse(InputK.Text));
                    Answer.Text = "Ответ " + result.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputN.Text.Split(' ').Length > 1 || InputK.Text == "" || InputN.Text == "")
            {
                MessageBox.Show("Неверно вписали n/k");
            }
            else
            {
                BigInteger result;
                List<BigInteger> k = new List<BigInteger>();

                if (Permutation.Checked)
                {
                    foreach(var el in InputK.Text.Split(' ')) { k.Add(BigInteger.Parse(el)); }
                    result = bs.Permutations_WithRepeat(BigInteger.Parse(InputN.Text), k);
                    Answer.Text = "Ответ " + result.ToString();
                }
                else
                {
                    result = bs.Permutations(BigInteger.Parse(InputN.Text));
                    Answer.Text = "Ответ " + result.ToString();
                }
            }
        }
    }
}