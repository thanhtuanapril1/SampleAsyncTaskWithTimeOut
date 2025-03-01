using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Example 1
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"Processing...";

                int timeout = int.Parse(tbxTimeout.Text);
                int num = int.Parse(tbxNumberInput.Text);

                Task timeoutTask = Task.Delay(timeout);     // Set desired connection timeout in milliseconds
                Task<string> task = HeavyTask(num);


                if (await Task.WhenAny(task, timeoutTask) == task)
                {
                    textBox1.Text = task.Result;
                }
                else
                {
                    textBox1.Text = "Timeout.";
                }
            }
            catch (FormatException ex)
            {
                textBox1.Text = $"Error parsing input: {ex.Message}";
            }
        }
        public async Task<string> HeavyTask(int num)
        {
            await Task.Delay(num);

            return $"Done: {num} loop";
        }

        ////Example 2
        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        textBox1.Text = $"Processing...";
        //        int timeout = int.Parse(tbxTimeout.Text);
        //        int num = int.Parse(tbxNumberInput.Text);

        //        var cts = new CancellationTokenSource();
        //        cts.CancelAfter(timeout);

        //        textBox1.Text = await HeavyTask(cts.Token);
        //    }
        //    catch (FormatException ex)
        //    {
        //        textBox1.Text = $"Error parsing input: {ex.Message}";
        //    }
        //}
        //public async Task<string> HeavyTask(CancellationToken cancellationToken)
        //{
        //    int num = int.Parse(tbxNumberInput.Text);

        //    var result = await Task.Run(async () =>
        //    {
        //        try
        //        {
        //            await Task.Delay(num,cancellationToken);    //This will throw an exception when cancellationToken active

        //            return $"Done: {num} loop";
        //        }
        //        catch (OperationCanceledException cancelException)
        //        {
        //            return cancelException.Message;
        //        }
        //    }, cancellationToken);

        //    return result;
        //}


        ////Example 3
        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = "Processing...";
        //    var cts = new CancellationTokenSource();

        //    Task timeoutTask = Task.Delay(int.Parse(tbxTimeout.Text));  //Timeout after 1s
        //    Task<string> task = GetValue(int.Parse(tbxNumberInput.Text), cts.Token);

        //    if (await Task.WhenAny(task, timeoutTask) == task)
        //    {
        //        string value = task.Result;
        //        textBox1.Text = value;
        //    }
        //    else
        //    {
        //        cts.Cancel();
        //        textBox1.Text = "Timeout";
        //    }
        //}

        //public async Task<string> GetValue(double num, CancellationToken token)
        //{
        //    for (int i = 0; i < num; i++)
        //    {
        //        await Task.Yield(); // Allow other tasks to run
        //        Console.WriteLine(i.ToString());

        //        token.ThrowIfCancellationRequested();
        //    }

        //    return $"Done {num}";
        //}
    }
}
