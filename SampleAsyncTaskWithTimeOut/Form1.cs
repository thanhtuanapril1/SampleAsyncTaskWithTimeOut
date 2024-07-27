using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = $"Processing...";
                int timeout = int.Parse(tbxTimeout.Text);
                int num = int.Parse(tbxNumberInput.Text);

                var cts = new CancellationTokenSource();
                cts.CancelAfter(timeout);

                textBox1.Text = await HeavyTask(cts.Token);
            }
            catch (FormatException ex)
            {
                textBox1.Text = $"Error parsing input: {ex.Message}";
            }
        }
        public async Task<string> HeavyTask(CancellationToken cancellationToken)
        {
            int num = int.Parse(tbxNumberInput.Text);

            var result = await Task.Run( async () =>
            {
                for (int i = 0; i < num; i++)
                {
                    if (cancellationToken.IsCancellationRequested) return $"Timeout cancelled"; // Use If want to detect cancelled
                    
                    await Task.Yield(); // Allow other tasks to run or run an asynchronous task

                    Console.WriteLine(i.ToString());
                }
                return $"Done: {num} loop";
            }, cancellationToken);
            
            return result;
        }

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    var cts = new CancellationTokenSource();

        //    Task timeoutTask = Task.Delay(1000, cts.Token);  //Timeout after 1s
        //    Task<string> task = GetValue(1000000000000, cts.Token);

        //    if (await Task.WhenAny(task, timeoutTask) == task)
        //    {
        //        string value = task.Result;
        //        textBox1.Text = value;
        //    }
        //    else
        //    {
        //        cts.Cancel();
        //        textBox1.Text = "failed";
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
