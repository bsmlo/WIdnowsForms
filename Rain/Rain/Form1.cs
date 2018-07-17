using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Rain
{
    public partial class Rain : Form
    {
        //Rain properties
        private int windowHeight;
        private int windowWidth;

        private int numberOfDrops;

        private int rainStartPoint;
        private int rainStopPoint;

        private int speed;

        private List<Drop> Drops = new List<Drop>();

        //Counter properties
        private int manX;
        private int manY;
        private int manHeight;
        private int manWIdth;
        DateTime timeNow;
        DateTime timeNowVelocity;


        //Drops Counter
        private int counter;
        private int countAll;
        private float aveCounts;
        private float velocity;
        private int countVelocity;

        //Man walk control
        private int startPoint;
        private int manVelocity;
        private int manDistande;
        DateTime startTimeTime;
        private int manTime;
        private int countDistance;
        bool manIsSet;


        public DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode { get; set; }


        public Rain()
        {
            InitializeComponent();
            timeNow = DateTime.Now;
            timeNowVelocity = DateTime.Now;

            counter = 0;
            countAll = 0;
            aveCounts = 0;
            countVelocity = 0;
            velocity = 0;

            speed = 33;

            windowWidth = pictureBox1.Width;
            windowHeight = pictureBox1.Height;

            rainStartPoint = 100;
            rainStopPoint = 1300;

            numberOfDrops = 60;

            manWIdth = 60;
            manHeight = 300;
            manX = 20;
            manY = pictureBox1.Height - pictureBox1.Location.Y - manHeight;

            speedBar.Value = speed;
            trackBar1.Value = manX;
            dropsBar.Value = numberOfDrops;

            manIsSet = false;

            // InitializeDataset();

            textBox1.ReadOnly = true;
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            ActualPositon();
            CountRainVelocity();

            if (manIsSet)
            {
                if (timeBox.Checked)
                {
                    ActualManPositionTime();
                    CountTimeDistance(true);
                }
                if (distanceBox.Checked)
                {
                    ActualManPositionTime();
                    CountTimeDistance(false);
                }

            }

            this.Refresh();
        }

        private void ActualPositon()
        {
            allDrops.Text = String.Format("All drops: {0}", Drops.Count());
            countLabel.Text = String.Format("Counts: {0}, Counts/10sec: {1}, V px/sec {2}", counter, aveCounts, velocity);

            if (Drops.Count != 0)
            {
                if (Drops.Count > numberOfDrops)
                {
                    try
                    {
                        for (int i = numberOfDrops - 1; i <= Drops.Count - 1; i++)
                        {
                            Drops.Remove(Drops[i]);
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        if (numberOfDrops == 0)
                        {
                            Drops.Clear();
                        }
                    }

                }

                for (int i = 0; i <= Drops.Count() - 1; i++)
                {
                    Drops[i].Location.Y += speed;

                    if (Drops[i].Location.Y >= pictureBox1.Height - pictureBox1.Location.Y - 10)
                    {
                        countAll++;
                        AddOneDrop(i);
                    }

                    if (Drops[i].Location.Y >= manY && Drops[i].Location.X >= manX && Drops[i].Location.X < manX + manWIdth)
                    {
                        countAll++;
                        counter++;
                        countLabel.Text = String.Format("Counts: {0}, Counts/10sec: {1}, V px/sec {2}", counter, aveCounts, velocity);
                        AddOneDrop(i);
                    }

                    long miliseconds = (DateTime.Now - timeNow).Ticks / TimeSpan.TicksPerMillisecond;

                    if (miliseconds >= 10000)
                    {
                        aveCounts = 10 * countAll / (miliseconds / 1000);
                        countLabel.Text = String.Format("Counts: {0}, Counts/10sec: {1}", counter, aveCounts);
                        countAll = 0;
                        timeNow = DateTime.Now;
                    }

                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            windowWidth = Width;
            windowHeight = Height;
        }

        static Random getrandom = new Random();

        private void AddDrops()
        {
            int posNumberx = getrandom.Next(rainStartPoint, rainStopPoint);
            int posNumbery = getrandom.Next(20, 50);

            Drops.Add(new Drop(new Point(posNumberx, posNumbery)));
        }

        private void AddOneDrop(int position)
        {
            int posNumberx = getrandom.Next(rainStartPoint, rainStopPoint);
            int posNumbery = getrandom.Next(20, 50);

            Drops[position] = new Drop(new Point(posNumberx, posNumbery));
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {


            if (Drops.Count() < numberOfDrops)
            {
                AddDrops();
            }

            foreach (Drop drop in Drops)
            {
                drop.Paint(e.Graphics);
            }

            e.Graphics.FillRectangle(Brushes.Black, manX, manY, manWIdth, manHeight);

            timer1.Enabled = true;
            timer1.Interval = 10;
        }

        private void SpeedBar_ValueChanged(object sender, EventArgs e)
        {
            speed = speedBar.Value;
            speedLabel.Text = string.Format("Speed value: {0}", speedBar.Value);
        }

        private void SpeedBar_Scroll(object sender, EventArgs e)
        {

        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            manX = trackBar1.Value;
            positionVal.Text = string.Format("Position: {0}", trackBar1.Value);
        }

        private void DropsBar_ValueChanged(object sender, EventArgs e)
        {
            numberOfDrops = dropsBar.Value;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            counter = 0;
            countAll = 0;
            aveCounts = 0;
            countVelocity = 0;
            velocity = 0;

            speed = 33;
            numberOfDrops = 60;

            Drops.Clear();

            manX = 20;
            manY = pictureBox1.Height - pictureBox1.Location.Y - manHeight;

            speedBar.Value = speed;
            trackBar1.Value = manX;
            dropsBar.Value = numberOfDrops;

            manIsSet = false;
        }

        private void CountRainVelocity()
        {
            countVelocity += speed;
            try
            {
                long miliseconds = (DateTime.Now - timeNowVelocity).Ticks / TimeSpan.TicksPerMillisecond;

                if (miliseconds >= 5000)
                {
                    velocity = 1000 * countVelocity / miliseconds;
                    timeNowVelocity = DateTime.Now;
                    countVelocity = 0;
                    countLabel.Text = String.Format("Counts: {0}, Counts/10sec: {1}, V px/sec {2}", counter, aveCounts, velocity);
                }
            }
            catch (Exception)
            {

            }
        }

        private void CounterReset_Click(object sender, EventArgs e)
        {
            counter = 0;

            speed = 33;
            manX = 20;

            manIsSet = false;
        }

        bool changeDirection = false;


        private void ActualManPositionTime()
        {
            if (changeDirection == false)
            {
                manX += manVelocity;
                countDistance += manVelocity;
                if (manX + manVelocity > rainStopPoint - manWIdth)
                {
                    changeDirection = true;
                }
            }
            else if (changeDirection == true)
            {
                manX -= manVelocity;
                countDistance += manVelocity;
                if (manX - manVelocity < rainStartPoint)
                {
                    changeDirection = false;
                }
            }
        }
        

        private void CountTimeDistance(bool timeDistance)
        {
            if (timeDistance)
            {
                long walkingTime = ((DateTime.Now - startTimeTime).Ticks) / TimeSpan.TicksPerSecond;
                if (walkingTime >= manTime && manIsSet)
                {
                    speed = 0;
                    manIsSet = false;
                    string message = String.Format("Time's up! Time spend on rain {0}, Dtops counted {1}", walkingTime, counter);

                    var messageQuestion = MessageBox.Show(message, "Finnished!", MessageBoxButtons.YesNo);

                    if (messageQuestion == DialogResult.Yes)
                    {
                        SaveMeasure();
                    }
                    else
                    {
                        MessageBox.Show("Data hasn't been saved!");
                    }

                    InitializeDataset();
                    counter = 0;
                    countDistance = 0;
                    changeDirection = false;
                }
            }

            else if (timeDistance == false)
            {
                if (countDistance >= manDistande)
                {
                    long walkingTime = ((DateTime.Now - startTimeTime).Ticks) / TimeSpan.TicksPerSecond;
                    manIsSet = false;
                    speed = 0;
                    string message = String.Format("I'm here! \n Time: {0}, Dtops counted: {1}, distance {2}, ave valuecity px/s {3} \n {4}",
                    walkingTime, counter, countDistance, countDistance / walkingTime, "Do you want to save?");

                    var messageQuestion = MessageBox.Show(message, "Finnished!", MessageBoxButtons.YesNo);


                    if (messageQuestion == DialogResult.Yes)
                    {

                        SaveMeasure();
                    }
                    else
                    {
                        MessageBox.Show("Data hasn't been saved!");
                    }

                    InitializeDataset();
                    counter = 0;
                    countDistance = 0;
                    changeDirection = false;
                }
            }

        }

        private void SaveMeasure()
        {

            bool alreadySaved = false;

            foreach (CountedDots counted in countedDotslist)
            {
                if (counted.chosedVelocity == manVelocity)
                {
                    counted.AddCounted(counter);
                    alreadySaved = true;
                }
            }

            if (alreadySaved == false)
            {
                CountedDots counted = new CountedDots(manVelocity, counter);
                countedDotslist.Add(counted);
            }
        }

        private List<String> measureListString = new List<String>();
        private List<CountedDots> countedDotslist = new List<CountedDots>();


        private void InitializeDataset()
        {
            countedDotslist = countedDotslist.OrderBy(o => o.chosedVelocity).ToList();

            string message;
            message = "";

            measureListString.Clear();

            measureListString.Add("Velocity Set, Average Counted, Number of runs \n");
            foreach (CountedDots obj in countedDotslist)
            {
                measureListString.Add(
                    String.Format("{0}, {1}, {2} \n",
                    obj.chosedVelocity, obj.countedDrops.Sum() / obj.countedDrops.Count(),
                    obj.countedDrops.Count()));
            }


            foreach (String str in measureListString)
            {
                message += str;
            }

            textBox1.Text = string.Join(Environment.NewLine, measureListString);
        }



        private void Start_Click(object sender, EventArgs e)
        {
            speed = speedBar.Value;

            if (timeBox.Checked && manTime > 0)
            {
                try
                {
                    startTimeTime = DateTime.Now;
                    manX = startPoint;
                    manIsSet = true;
                }
                catch
                {
                    MessageBox.Show("Something goes wrong!");
                }
            }
            else if (distanceBox.Checked && manDistande > 0)
            {
                try
                {
                    startTimeTime = DateTime.Now;
                    manX = startPoint;
                    manIsSet = true;
                }
                catch
                {
                    MessageBox.Show("Something goes wrong!");
                }

            }

        }

        private void StartPositionTime_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(startPositionTime.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter only numbers.");
                startPositionTime.Text = startPositionTime.Text.Remove(startPositionTime.Text.Length - 1);
            }

            if (startPositionTime.Text.Length > 0)
            {
                startPoint = Convert.ToInt32(startPositionTime.Text);

                if (startPoint < 0 || (startPoint > pictureBox1.Width - manWIdth))
                {
                    MessageBox.Show(String.Format("Start point value between 0-{0}", pictureBox1.Width - manWIdth));
                    startPoint = 20;
                    startPositionTime.Text = "20";
                }
            }

            else
            {
                startPositionTime.Text = "";
            }
        }

        private void VelocityTIme_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(velocityTIme.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter only numbers.");
                velocityTIme.Text = velocityTIme.Text.Remove(velocityTIme.Text.Length - 1);
            }

            else if (velocityTIme.Text.Length > 0)
            {

                manVelocity = Convert.ToInt32(velocityTIme.Text);

                if (manVelocity < 0 || (manVelocity > 200))
                {
                    MessageBox.Show(String.Format("Man velocity between 1-{0} px/s", 200));
                    manVelocity = 0;
                    velocityTIme.Text = "1";
                }

            }

            else
            {
                velocityTIme.Text = "";
            }
        }

        private void TimeTime_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(timeTime.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter only numbers.");
                timeTime.Text = timeTime.Text.Remove(timeTime.Text.Length - 1);
            }

            if (timeTime.Text.Length > 0)
            {
                manTime = Convert.ToInt32(timeTime.Text);

                if (manTime <= 0 || manTime > 3600)
                {
                    MessageBox.Show(String.Format("Start point value between 1-{0}", 3600));
                    manTime = 0;
                    timeTime.Text = "0";
                }
            }

            else
            {
                timeTime.Text = "";
            }
        }

        private void Distance_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(distance.Text, "[^0-9]"))
            {
                MessageBox.Show("Enter only numbers.");
                distance.Text = distance.Text.Remove(distance.Text.Length - 1);
            }

            if (distance.Text.Length > 0)
            {
                manDistande = Convert.ToInt32(distance.Text);

                if (manDistande <= 0 || manDistande > 150000)
                {
                    MessageBox.Show(String.Format("Start point value between 1-{0}", 150000));
                    manDistande = 1;
                    distance.Text = "1";
                }
            }

            else
            {
                distance.Text = "";
            }
        }

        private void TimeBox_CheckedChanged(object sender, EventArgs e)
        {
            start.Enabled = true;

            if (timeBox.Checked)
            {
                distanceBox.Checked = false;
            }
            if (!timeBox.Checked && !distanceBox.Checked)
            {
                timeBox.Checked = true;
            }
        }

        private void DistanceBox_CheckedChanged(object sender, EventArgs e)
        {
            start.Enabled = true;

            if (distanceBox.Checked)
            {
                timeBox.Checked = false;
            }
            if (!timeBox.Checked && !distanceBox.Checked)
            {
                distanceBox.Checked = true;
            }
        }

        private void Rain_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
