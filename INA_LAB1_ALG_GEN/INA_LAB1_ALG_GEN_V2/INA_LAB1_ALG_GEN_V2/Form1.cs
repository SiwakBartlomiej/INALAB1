using System;
using System.Collections;

namespace INA_LAB1_ALG_GEN_V2
{
    public partial class Form1 : Form
    {
        private int leftBoundary;
        private int rightBoundary;
        private double precision;
        private int populationSize;
        private int numberOfGenes;
        private int numberOfIndividuals;
        private int outputIndex = 0;
        private double[] individuals;
        private double[] chosenIndividualsReal; //xReal
        private int[] chosenIndividualsInteger; //xInt
        private string[] chosenIndivudialsBinary; //xBin
        private int[] chosenIndividualsInteger2; //xInt
        private double[] chosenIndividualsReal2; //xReal
        private double[] ratedIndividuals; //F(x)

        public Form1()
        {
            InitializeComponent();
            MinimumSize = new Size(this.Width, this.Height);
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            Text = "INA Lab1 SiwakB";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            FetchData();
            CodeIndividual();
        }

        private void FetchData()
        {
            leftBoundary = int.Parse(txtBoundaryLeft.Text);
            rightBoundary = int.Parse(txtBoundaryRight.Text);
            precision = double.Parse(cmbPrecision.Text);
            populationSize = int.Parse(txtPopulationSize.Text);
        }

        private void CodeIndividual()
        {
            numberOfIndividuals = (int)((rightBoundary - leftBoundary) / precision) + 1;
            numberOfGenes = (int)Math.Ceiling(Math.Log2(numberOfIndividuals));

            individuals = new double[numberOfIndividuals];

            for (int i = 0; i < numberOfIndividuals; i++)
            {
                individuals[i] = Math.Round(leftBoundary + (i * precision),
                    (int)Math.Abs(Math.Log10(precision)));
            }

            PickRandomIndividuals();
            Calculate();
        }

        private void PickRandomIndividuals()
        {
            chosenIndividualsReal = new double[populationSize];

            Random random = new Random();
            HashSet<int> indexesHashSet = new HashSet<int>();
            while (indexesHashSet.Count < populationSize)
            {
                indexesHashSet.Add(random.Next(0, numberOfIndividuals));
            }

            int[] indexesArray = indexesHashSet.ToArray();

            for (int i = 0; i < indexesArray.Length; i++)
            {
                chosenIndividualsReal[i] = individuals[indexesArray[i]];
            }
        }

        private void Calculate()
        {
            chosenIndividualsInteger = RealToInt();
            chosenIndivudialsBinary = IntToBin(chosenIndividualsInteger);
            chosenIndividualsInteger2 = BinToInt(chosenIndivudialsBinary);
            chosenIndividualsReal2 = IntToReal(chosenIndividualsInteger2);
            Rate();

            for (int i = 0; i < populationSize; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = ++outputIndex });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chosenIndividualsReal[i] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chosenIndividualsInteger[i] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chosenIndivudialsBinary[i] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chosenIndividualsInteger2[i] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = chosenIndividualsReal2[i] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = ratedIndividuals[i] });
                dataGridView1.Rows.Add(row);
            }

            Prettify();
        }

        private int[] RealToInt()
        {
            var output = new int[populationSize];

            for (int i = 0; i < populationSize; i++)
            {
                output[i] = (int)(1d / (rightBoundary - leftBoundary) *
                    (chosenIndividualsReal[i] - leftBoundary) *
                    (Math.Pow(2, numberOfGenes) - 1));
            }

            return output;
        }

        private string[] IntToBin(int[] chosenIndividualsInt)
        {
            string[] binaryStrings = new string[chosenIndividualsInt.Length];

            for (int i = 0; i < chosenIndividualsInt.Length; i++)
            {
                binaryStrings[i] = IntToBinaryString(chosenIndividualsInt[i]);
            }

            return binaryStrings;
        }

        private string IntToBinaryString(int number)
        {
            if (number == 0)
            {
                return "0";
            }

            string binary = string.Empty;

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;
                number = number / 2;
            }

            if (binary.Length < numberOfGenes)
            {
                int missingBits = numberOfGenes - binary.Length;

                for (int i = 0; i < missingBits ; i++)
                {
                    binary = '0' + binary;
                }
            }

            return binary;
        }

        private int[] BinToInt(string[] chosenIndividualsBinary)
        {
            int[] output = new int[chosenIndividualsBinary.Length];

            for (int i = 0; i < chosenIndividualsBinary.Length; i++)
            {
                int power = 1;

                for (int j = chosenIndividualsBinary[i].Length - 1; j >= 0; j--)
                {
                    if (chosenIndividualsBinary[i][j] == '1')
                    {
                        output[i] += power;
                    }
                    power *= 2;
                }
            }

            return output;
        }

        private double[] IntToReal(int[] chosenIndividualInt)
        {
            var output = new double[populationSize];
            for (int i = 0; i < populationSize; i++)
            {
                output[i] = Math.Round(
                    (chosenIndividualInt[i] * (rightBoundary - leftBoundary) / (Math.Pow(2, numberOfGenes) - 1)) + leftBoundary,
                    (int)Math.Abs(Math.Log10(precision))
                    );   
            }

            return output;
        }

        private void Rate()
        {
            ratedIndividuals = new double[populationSize];

            for (int i = 0; i < populationSize; i++)
            {
                ratedIndividuals[i] = chosenIndividualsReal2[i] 
                    % (Math.Cos(20*Math.PI*chosenIndividualsReal2[i]) - Math.Sin(chosenIndividualsReal2[i]));
            }
        }

        private void Prettify()
        {
            for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                int colw = dataGridView1.Columns[i].Width;
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[i].Width = colw;
            }
        }
    }
}