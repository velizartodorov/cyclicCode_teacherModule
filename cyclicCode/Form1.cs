using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace cyclicCode

{
    public partial class Form1 : Form
    {
        public string inputValue;
        public string binaryBitStream = null;

        public Form1()
        {
           
            // escape button

            this.KeyPreview = true;

            // variables
   
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
        //    skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue100, TextShade.WHITE);

        }

        public void polynomialRepresentation(string inputValue, string generatingPolynom, string binaryBitStream)
        {
            string generatingPolynomView = null;
            string remainderPolynomial = null;
            string generatingPolynomInput = generatingPolynom;
            var isAllZeros = false;

            // calculate generating polynom ot triple error

            if (tripleErrorRadioButton.Checked)
            {
                char[] generatingPolynomArrayLeadingZero = (generatingPolynom.PadLeft(generatingPolynom.Length + 1, '0')).ToCharArray();
                char[] generatingPolynomArrayPadedZero = (generatingPolynom.PadRight(generatingPolynom.Length + 1, '0')).ToCharArray();

                generatingPolynom = null;

                for (int i = 0; i < generatingPolynomArrayPadedZero.Length; i++)
                {
                    generatingPolynom += (generatingPolynomArrayLeadingZero[i] ^ generatingPolynomArrayPadedZero[i]).ToString();
                }
            }

            generatingPolynomView = generatingPolynom;

            for (int i = generatingPolynom.Length; i < inputValue.Length; i++)
            {
                generatingPolynomView += "0";
            }

            binaryToPolynomial(inputValue);
           

            richTextBox1.Clear();

            richTextBox1.Find("\n" + "\t" + inputValue);
            richTextBox1.SelectionColor = Color.LimeGreen;

            richTextBox1.AppendText("\n" + "\t" + binaryToPolynomial(inputValue));

            richTextBox1.Find("\n" + "\t" + generatingPolynomView + "\n" + "\t" + "——————" + "\n");
            richTextBox1.SelectionColor = Color.White;

            richTextBox1.AppendText("\n" + "\t" + binaryToPolynomial(generatingPolynomView) + "\n" + "\t" + "——————" + "\n");

            remainderPolynomial += "x" + (inputValue.Length - 1 - k).ToString() + " + ";

            groupBox2.Visible = true;

            label6.Text = null;


                label6.Text += "xᵏ.G(x) = x" + letterToSuperscript(k.ToString()) + " . " + "(" + binaryToPolynomial(binaryBitStream);
                label6.Text += ")" + " = " + binaryToPolynomial(inputValue);

            if (tripleErrorRadioButton.Checked)
            {
                groupBox3.Visible = true;
                label2.Text = null;
                label2.Text += "P(x) = (1+x).P₁(x) = (1+x).(" + binaryToPolynomial(generatingPolynomInput); 
                label2.Text += ") = " + binaryToPolynomial(generatingPolynom);
            }

            while (inputValue.Length >= generatingPolynom.Length)
            {

                // put values from string to array

                char[] inputValueArray = inputValue.ToCharArray();
                char[] generatingPolynomArray = generatingPolynom.ToCharArray();

                string remainder = null;

                // XOR inputValue & generatingPolynom
 
                for (int i = 0; i < generatingPolynom.Length; i++)
                {
                    remainder += (inputValueArray[i] ^ generatingPolynomArray[i]).ToString();
                }
                
                // adding remainder to result

                inputValue = (remainder + inputValue.Substring(generatingPolynom.Length));

                // trim leading zeros

                isAllZeros = inputValue.All(c => c == '0');

                if (!isAllZeros)
                {
                    inputValue = inputValue.TrimStart(new Char[] { '0' });
                }

                richTextBox1.Visible = true;
                polynomStepenLabel.Visible = false;
                chooseButton.Visible = false;
                generatingPolynomListView.Visible = false;

                if (!isAllZeros)
                {
                    richTextBox1.AppendText("\t" + binaryToPolynomial(inputValue) + "\n");  
                }
                else
                {
                    richTextBox1.AppendText("\t\t 0");
                    break;
                }


                if (inputValue.Length >= generatingPolynom.Length)
                {
                    remainderPolynomial += "x" + (inputValue.Length - 1 - k).ToString() + " + ";

                    // x0 - > 1
                    // x1 - > x

                    char[] remainderValueArray = remainderPolynomial.ToCharArray();

                    for (int i = 0; i < remainderPolynomial.Length; i++)
                    {

                        // if x0 -> 1

                        if (i > (remainderPolynomial.Length - 8) && remainderValueArray[i] == 'x' && remainderValueArray[i + 1] == '0')

                        {
                            remainderValueArray[i] = '1';
                            remainderValueArray[i + 1] = '\0';
                        }


                        // if x1 -> x

                        else if (i > (remainderPolynomial.Length - 12) && remainderValueArray[i] == 'x' && remainderValueArray[i + 1] == '1' && remainderValueArray[i + 2] == ' ')
                        {
                            remainderValueArray[i + 1] = ' ';
                        }

                    }

                    remainderPolynomial = letterToSuperscript(new string(remainderValueArray));

                }

                generatingPolynomView = generatingPolynom;

                // apendd zeros to generatingPolynom;


                for (int i = generatingPolynom.Length; i < inputValue.Length; i++)
                {
                    generatingPolynomView += "0";
                }
                
                if (inputValue.Length >= generatingPolynom.Length)
                {
                    richTextBox1.AppendText("\t" + binaryToPolynomial(generatingPolynomView));
                    richTextBox1.AppendText("\n" + "\t" + "——————" + "\n");
                }

            }

            richTextBox1.AppendText("\n \n" + "\t" + "R(x) = ");
            richTextBox1.Find(inputValue);
            richTextBox1.SelectionColor = Color.Red;


            if (!isAllZeros)
            {

                richTextBox1.Find(inputValue);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText(binaryToPolynomial(inputValue));
                richTextBox1.Find(" -> ");
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.AppendText(" -> ");
                richTextBox1.Find(inputValue);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText(inputValue);
            }
            else
            {
                richTextBox1.AppendText("0");
                richTextBox1.Find(" -> ");
                richTextBox1.SelectionColor = Color.White;
                richTextBox1.AppendText(" -> ");
                richTextBox1.Find(inputValue);
                richTextBox1.SelectionColor = Color.Red;
                inputValue = null;
                for (int i = 0; i < k; i++)
                {
                    inputValue += "0";
                }
                richTextBox1.AppendText(inputValue + "\n");                
            }

            richTextBox1.Find("F(x) = xᵏ.G(x) + R(x) = ");
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.AppendText("\n" + "\t" + "F(x) = xᵏ . G(x) + R(x) = " + binaryBitStream + " ");
            richTextBox1.Find(inputValue + "\n");
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText(inputValue + "\n");
            richTextBox1.SelectionColor = Color.Violet;
            richTextBox1.AppendText("\n \tРезултат:\n");
            richTextBox1.AppendText("\n" + "\t" + remainderPolynomial.Substring(0, remainderPolynomial.Length - 2) + "\n");
            richTextBox1.Find(binaryBitStream);
            richTextBox1.SelectionColor = Color.Aqua;
            richTextBox1.Find(inputValue);
            richTextBox1.SelectionColor = Color.Red;
        }
        public string letterToSuperscript(string polynomialValue)
        {
            // convert numbers to supersripts

            StringBuilder sb = new StringBuilder(polynomialValue);

            for (int i = 0; i < polynomialValue.Length; i++)
            {
                if (polynomialValue[i] == '0')
                {
                    sb[i] = '⁰';
                    polynomialValue = sb.ToString();
                }

                if (polynomialValue[i] == '1' && polynomialValue[i + 1] != '\0')
                {
                    sb[i] = '¹';
                    polynomialValue = sb.ToString();
                }

                if (polynomialValue[i] == '2')
                {
                    sb[i] = '²';
                    polynomialValue = sb.ToString();
                }


                if (polynomialValue[i] == '3')
                {
                    sb[i] = '³';
                    polynomialValue = sb.ToString();
                }


                if (polynomialValue[i] == '4')
                {
                    sb[i] = '⁴';
                    polynomialValue = sb.ToString();
                }

                if (polynomialValue[i] == '5')
                {
                    sb[i] = '⁵';
                    polynomialValue = sb.ToString();
                }

                if (polynomialValue[i] == '6')
                {
                    sb[i] = '⁶';
                    polynomialValue = sb.ToString();
                }

                if (polynomialValue[i] == '7')
                {
                    sb[i] = '⁷';
                    polynomialValue = sb.ToString();
                }

                if (polynomialValue[i] == '8')
                {
                    sb[i] = '⁸';
                    polynomialValue = sb.ToString();
                }

                if (polynomialValue[i] == '9')
                {
                    sb[i] = '⁹';
                    polynomialValue = sb.ToString();
                }

            }

            return polynomialValue;
        }

        public string binaryToPolynomial(string inputValue)
        {
            string polynomialValue = null;

            char[] inputValueArray2 = inputValue.ToCharArray();

            for (int i = 0; i < inputValue.Length; i++)
            {
                if (inputValueArray2[i] == '1')

                {
                    polynomialValue += "x" + (inputValue.Length - 1 - i).ToString() + " + ";

                }
            }

            // cut the last "+" sign

                polynomialValue = polynomialValue.Substring(0, polynomialValue.Length - 2);
            
            // x0 - > 1
            // x1 - > x

           char [] inputValueArray = polynomialValue.ToCharArray();

            for (int i = 0; i < polynomialValue.Length; i++)
            {

                // if x0 -> 1

                if (i > (polynomialValue.Length - 8) && inputValueArray[i] == 'x' && inputValueArray[i + 1] == '0')

                {
                    inputValueArray[i] = '1';
                    inputValueArray[i + 1] = '\0';
                }


                // if x1 -> x

                else if (i > (polynomialValue.Length - 12) && inputValueArray[i] == 'x' && inputValueArray[i + 1] == '1' && inputValueArray[i + 2] == ' ')
                {
                    inputValueArray[i + 1] = ' ';
                }

            }
     
            return polynomialValue = letterToSuperscript(new string(inputValueArray));
        }


        public void addToListView(int k)
        {
            generatingPolynomListView.Items.Clear();

            ListViewItem item1 = new ListViewItem("1");
            item1.SubItems.Add("x+1");
            item1.SubItems.Add("1");

            ListViewItem item2 = new ListViewItem("2");
            item2.SubItems.Add("x²+x+1");
            item2.SubItems.Add("3");

            ListViewItem item3 = new ListViewItem("3");
            item3.SubItems.Add("x³+x+1");
            item3.SubItems.Add("7");

            ListViewItem item31 = new ListViewItem("");
            item31.SubItems.Add("x³+x²+1");
            item31.SubItems.Add("");

            ListViewItem item4 = new ListViewItem("4");
            item4.SubItems.Add("x⁴+x+1");
            item4.SubItems.Add("15");

            ListViewItem item41 = new ListViewItem("");
            item41.SubItems.Add("x⁴+x³+1");
            item41.SubItems.Add("");

            ListViewItem item5 = new ListViewItem("5");
            item5.SubItems.Add("x⁵+x²+1");
            item5.SubItems.Add("31");

            ListViewItem item51 = new ListViewItem("");
            item51.SubItems.Add("x⁵+x³+1");
            item51.SubItems.Add("");

            ListViewItem item6 = new ListViewItem("6");
            item6.SubItems.Add("x⁶+x+1");
            item6.SubItems.Add("63");

            ListViewItem item61 = new ListViewItem("");
            item61.SubItems.Add("x⁶+x⁵+1");
            item61.SubItems.Add("");

            ListViewItem item7 = new ListViewItem("7");
            item7.SubItems.Add("x⁷+x+1");
            item7.SubItems.Add("127");

            ListViewItem item71 = new ListViewItem("");
            item71.SubItems.Add("x⁷+x³+1");
            item71.SubItems.Add("");

            ListViewItem item8 = new ListViewItem("8");
            item8.SubItems.Add("x⁸+x⁴+x³+x²+1");
            item8.SubItems.Add("255");

        
            ListViewItem item81 = new ListViewItem("");
            item81.SubItems.Add("x⁸+x⁶+x⁵+x⁴+1");
            item81.SubItems.Add("");

            ListViewItem item9 = new ListViewItem("9");
            item9.SubItems.Add("x⁹+x⁵+1");
            item9.SubItems.Add("511");

            ListViewItem item91 = new ListViewItem("");
            item91.SubItems.Add("x⁹+x⁴+1");
            item91.SubItems.Add("");

            ListViewItem item10 = new ListViewItem("10");
            item10.SubItems.Add("x¹⁰+x⁷+1");
            item10.SubItems.Add("1023");

            ListViewItem item101 = new ListViewItem("");
            item101.SubItems.Add("x¹⁰+x³+1");
            item101.SubItems.Add("");


            if (k == 1)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item1 });
            }


            else if (k == 2)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item2 });
            }

            else if (k == 3)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item3, item31 });
            }

            else if (k == 4)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] {item4, item41});
            }

            else if (k == 5)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item5, item51});
            }

            else if (k == 6)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item6, item61 });
            }

            else if (k == 7)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item7, item71 });
            }

            else if (k == 8)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item8, item81 });
            }

            else if (k == 9)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item9, item91 });
            }

            else if (k == 10)
            {
                generatingPolynomListView.Items.AddRange(new ListViewItem[] { item10, item101 });
            }

        }

        private bool buttonChooseWasClicked = false;

        int k = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            richTextBox1.Visible = false;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorLabel.Visible = true;
                errorLabel.Text = null;
                errorLabel.Text = "Въведете входна последователност!";

            }
            else
            {
                errorLabel.Visible = false;
                groupBox1.Visible = true;
                
                polynomStepenLabel.Visible = false;
                generatingPolynomListView.Visible = false;
                polynomLength.Visible = true;
                kInfoLabel.Visible = true;
                polynomLength.Text = null;
                kInfoLabel.Text = null;
                polynomLength.Text = "m = " + textBox.Text.Length.ToString() + ";";
                kInfoLabel.Text = "2ᵏ – k ≥ m + 1 = " + (int)(textBox.Text.Length + 1) + ";";
                kLabel.Visible = true;
                kLabel.Text = null;

                // calculating k

                for (k = 0; k < 10; k++)
                {
                    if ((Math.Pow(2, k) - k) >= (int)(textBox.Text.Length + 1))
                    {
                        break;
                    }
                }

                addToListView(k);

                polynomStepenLabel.Visible = true;
                generatingPolynomListView.Visible = true;
                chooseButton.Visible = true;

                if (doubleErrorRadioButton.Checked == true)
                {
                    nLabel.Visible = false;
                    lzeroLabel.Visible = true;
                    dLabel.Visible = true;
                    lzeroLabel.Text = null;
                    dLabel.Text = null;
                    lzeroLabel.Text = "l₀ = 2;";
                    dLabel.Text = "d ≥ l₀ + 1;   d = 3;";
                    kLabel.Text = "k = " + k.ToString() + ";";
                }

                else if (tripleErrorRadioButton.Checked == true)
                {
                    
                    kInfoLabel.Visible = false;
                    lzeroLabel.Visible = true;
                    dLabel.Visible = true;
                    lzeroLabel.Text = null;
                    dLabel.Text = null;
                    lzeroLabel.Text = "l₀ = 3;";
                    dLabel.Text += "d ≥ l₀ + 1;  d ≥ 4;";
                    nLabel.Visible = true;
                    nLabel.Text = "n = " + (textBox.Text.Length + k).ToString() + ";";
                    k++;
                    kLabel.Text = "k = s + 1 = " + k + " + 1 = " + k.ToString() + ";";
                }

                // multiplying input by "k"

                inputValue = textBox.Text;

                binaryBitStream = inputValue;

                for (int i = 0; i < k; i++)
                {
                    inputValue += "0";
                }
            }
        }
        
        private void zeroButton_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            if (textBox != null)
            {

                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void chooseButton_Click_1(object sender, EventArgs e)
        {
            buttonChooseWasClicked = true;

            int kLocal = 0;

            if (tripleErrorRadioButton.Checked)
            {
                kLocal = k - 1;
            }
            if (doubleErrorRadioButton.Checked)
            {
                kLocal = k;
            }


            if (kLocal == 1)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "11", binaryBitStream);
                }
            }

            if (kLocal == 2)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "111", binaryBitStream);
                }
            }

            if (kLocal == 3)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "1011", binaryBitStream);
                }
                else if (generatingPolynomListView.Items[1].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "1101", binaryBitStream);
                }
            }

            else if (kLocal == 4)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "10011", binaryBitStream);
                }
                else if(generatingPolynomListView.Items[1].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "11001", binaryBitStream);
                }
            }

            else if (kLocal == 5)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "100101", binaryBitStream);
                }
                else if (generatingPolynomListView.Items[1].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "101001", binaryBitStream);
                }
            }

            else if (kLocal == 6)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "1000011", binaryBitStream);
                }
                else if (generatingPolynomListView.Items[1].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "1100001", binaryBitStream);
                }
            }

            else if (kLocal == 7)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "10000011", binaryBitStream);
                }
                else if (generatingPolynomListView.Items[1].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "10001001", binaryBitStream);
                }
            }

            else if (kLocal == 8)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "100011101", binaryBitStream);
                }
                else if (generatingPolynomListView.Items[1].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "101110001", binaryBitStream);
                }
            }

            else if (kLocal == 9)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "1000100001", binaryBitStream);
                }
                else if (generatingPolynomListView.Items[1].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "1000010001", binaryBitStream);
                }
            }

            else if (kLocal == 10)
            {
                if (generatingPolynomListView.Items[0].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "10010000001", binaryBitStream);
                }
                else if (generatingPolynomListView.Items[1].Selected && buttonChooseWasClicked)
                {
                    polynomialRepresentation(inputValue, "10000001001", binaryBitStream);
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            } 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closingDialog = MessageBox.Show("Сигурни ли сте, че искате да излезете?", "Изход", MessageBoxButtons.YesNo);
            if(closingDialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (closingDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            errorLabel.Visible = false;

            if (!(e.KeyChar == (char)8) && !(e.KeyChar == (char)48) && !(e.KeyChar == (char)49))
            {
                errorLabel.Visible = true;
                errorLabel.Text = null;
                errorLabel.Text = "Въведи 0 или 1!";
                e.KeyChar = (char)0;
            }

            if (!(e.KeyChar == (char)8) && textBox.TextLength > 1000)
            {
                errorLabel.Visible = true;
                errorLabel.Text = null;
                errorLabel.Text = "Дълга входна последователност!";
                e.KeyChar = (char)0;

            } 
                
        }
    
    }
}