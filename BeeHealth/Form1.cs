using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeeHealth
{
    public partial class Form1 : Form
    {
        private List<Bee> bees;
        private Random random;

        public Form1()
        {
            InitializeComponent();

            this.bees = new List<Bee>();
            this.random = new Random();

            for (var i = 0; i < 10; i++)
            {
                this.bees.Add(new WorkerBee());
                this.bees.Add(new QueenBee());
                this.bees.Add(new DroneBee());
            }

            this.dataGridView1.DataSource = this.bees;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var bee in this.bees)
            {
                bee.Damage(this.random.Next(0, 81));
            }

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.bees;
        }
    }
}
