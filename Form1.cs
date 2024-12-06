using Backprop;
using System.Data;

namespace Backpropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nnOr, nnAnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OR
            nnOr = new NeuralNet(2, 100, 1); //(input layer, hidden layer, output layer)
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //train OR

            for (int i = 0; i < 1000; i++)
            {
                nnOr.setInputs(0, 0.0);
                nnOr.setInputs(1, 0.0);
                nnOr.setDesiredOutput(0, 0.0);
                nnOr.learn();

                nnOr.setInputs(0, 0.0);
                nnOr.setInputs(1, 1.0);
                nnOr.setDesiredOutput(0, 1.0);
                nnOr.learn();

                nnOr.setInputs(0, 1.0);
                nnOr.setInputs(1, 0.0);
                nnOr.setDesiredOutput(0, 1.0);
                nnOr.learn();

                nnOr.setInputs(0, 1.0);
                nnOr.setInputs(1, 1.0);
                nnOr.setDesiredOutput(0, 1.0);
                nnOr.learn();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //test OR
            nnOr.setInputs(0, Convert.ToDouble(textBox1.Text));
            nnOr.setInputs(1, Convert.ToDouble(textBox10.Text));
            nnOr.run();
            textBox3.Text = Math.Round(nnOr.getOuputData(0)).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //nnAnd = new NeuralNet(4, 6, 1);
            nnAnd = new NeuralNet(4, 5, 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //train AND
            double[,] data = new double[16, 5]
            {
                {0, 0, 0, 0, 0 },
                {0, 0, 0, 1, 0 },
                {0, 0, 1, 0, 0 },
                {0, 0, 1, 1, 0 },
                {0, 1, 0, 0, 0 },
                {0, 1, 1, 1, 0 },
                {0, 1, 1, 0, 0 },
                {0, 1, 0, 1, 0 },
                {1, 0, 1, 0, 0 },
                {1, 0, 1, 1, 0 },
                {1, 0, 0, 0, 0 },
                {1, 0, 1, 1, 0 },
                {1, 1, 1, 0, 0 },
                {1, 1, 0, 1, 0 },
                {1, 1, 1, 0, 0 },
                {1, 1, 1, 1, 1 }
            };

            String res = "";

            //for (int j = 0; j<1000; j++) 
            for (int j = 0; j<500; j++) 
            {
                res += $"Epoch {j + 1}:\r\n";
                for (int i = 0; i < 16; i++)
                {
                    nnAnd.setInputs(0, data[i, 0]);
                    nnAnd.setInputs(1, data[i, 1]);
                    nnAnd.setInputs(2, data[i, 2]);
                    nnAnd.setInputs(3, data[i, 3]);
                    nnAnd.setDesiredOutput(0, data[i, 4]);
                    nnAnd.learn();
                }
                for (int i = 0; i < 16; i++)
                {
                    nnAnd.setInputs(0, data[i, 0]);
                    nnAnd.setInputs(1, data[i, 1]);
                    nnAnd.setInputs(2, data[i, 2]);
                    nnAnd.setInputs(3, data[i, 3]);
                    nnAnd.run();
                    double output = nnAnd.getOuputData(0);
                    res += $" [ {data[i, 0]}, {data[i, 1]}, {data[i, 2]}, {data[i, 3]} ] => {output.ToString("#.####")}\r\n";
                }
                res += "\r\n";
            }
            textBox9.Text = res;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //test AND
            nnAnd.setInputs(0, Convert.ToDouble(textBox6.Text));
            nnAnd.setInputs(1, Convert.ToDouble(textBox5.Text));
            nnAnd.setInputs(2, Convert.ToDouble(textBox8.Text));
            nnAnd.setInputs(3, Convert.ToDouble(textBox7.Text));
            nnAnd.run();
            //textBox4.Text = Math.Round(nnAnd.getOuputData(0)).ToString();
            double output = nnAnd.getOuputData(0);
            textBox4.Text = (output >= 0.5 ? 1 : 0).ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            nnOr.setInputs(0, Convert.ToDouble(textBox1.Text));
            nnOr.setInputs(1, Convert.ToDouble(textBox10.Text));
            nnOr.run();
            //textBox3.Text = Math.Round(nnOr.getOuputData(0)).ToString();
            double output = nnOr.getOuputData(0);
            textBox3.Text = (output >= 0.5 ? 1 : 0).ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //train OR

            for (int i = 0; i < 1000; i++)
            {
                nnOr.setInputs(0, 0.0);
                nnOr.setInputs(1, 0.0);
                nnOr.setDesiredOutput(0, 0.0);
                nnOr.learn();

                nnOr.setInputs(0, 0.0);
                nnOr.setInputs(1, 1.0);
                nnOr.setDesiredOutput(0, 1.0);
                nnOr.learn();

                nnOr.setInputs(0, 1.0);
                nnOr.setInputs(1, 0.0);
                nnOr.setDesiredOutput(0, 1.0);
                nnOr.learn();

                nnOr.setInputs(0, 1.0);
                nnOr.setInputs(1, 1.0);
                nnOr.setDesiredOutput(0, 1.0);
                nnOr.learn();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //OR
            nnOr = new NeuralNet(2, 4, 1); //(input layer, hidden layer, output layer)
        }
    }
}
