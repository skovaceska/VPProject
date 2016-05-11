using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryBrainGame
{
    public partial class Form2 : Form
    {
        public PictureBox first;
        public PictureBox second;
        public int cliked;
        public bool finish;
        private Memory memory;
        public int level;
        public Dictionary<int, Bitmap> images;

        internal Memory Memory
        {
            get
            {
                return memory;
            }

            set
            {
                memory = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
            DoubleBuffered = true;
           
            first = new PictureBox();
            second = new PictureBox();
            cliked = 0;
            finish = false;

            level = Form1.level;

            Memory = new Memory(level);
            images = new Dictionary<int, Bitmap>();
            initialize();
        }

        public void initialize()
        {
            images.Add(1, new Bitmap(MemoryBrainGame.Properties.Resources.angularjs));
            images.Add(2, new Bitmap(MemoryBrainGame.Properties.Resources.cobol));
            images.Add(3, new Bitmap(MemoryBrainGame.Properties.Resources.c_));
            images.Add(4, new Bitmap(MemoryBrainGame.Properties.Resources.c__));
            images.Add(5, new Bitmap(MemoryBrainGame.Properties.Resources.html));
            images.Add(6, new Bitmap(MemoryBrainGame.Properties.Resources.jade));
            images.Add(7, new Bitmap(MemoryBrainGame.Properties.Resources.java));
            images.Add(8, new Bitmap(MemoryBrainGame.Properties.Resources.javascript));
            images.Add(9, new Bitmap(MemoryBrainGame.Properties.Resources.php));
            images.Add(10, new Bitmap(MemoryBrainGame.Properties.Resources.prolog));
            images.Add(11, new Bitmap(MemoryBrainGame.Properties.Resources.python));
            images.Add(12, new Bitmap(MemoryBrainGame.Properties.Resources.ruby));
            images.Add(13, new Bitmap(MemoryBrainGame.Properties.Resources.sql));
            images.Add(14, new Bitmap(MemoryBrainGame.Properties.Resources.swift));
            images.Add(15, new Bitmap(MemoryBrainGame.Properties.Resources.visualBasic));
        }

       

       
    }
}
