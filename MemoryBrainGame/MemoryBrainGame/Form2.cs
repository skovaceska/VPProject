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
        public Dictionary<int, Image> images;

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
            images = new Dictionary<int, Image>();
            initialaze();
        }

        public void initialaze()
        {
            images.Add(1, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\angularjs.png"));
            images.Add(2, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\c#.png"));
            images.Add(3, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\c++.png"));
            images.Add(4, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\cobol.png"));
            images.Add(5, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\html.png"));
            images.Add(6, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\java.png"));
            images.Add(7, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\javascript.png"));
            images.Add(8, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\php.png"));
            images.Add(9, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\prolog.jpg"));
            images.Add(10, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\python.png"));
            images.Add(11, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\ruby.png"));
            images.Add(12, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\visualBasic.png"));
            images.Add(13, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\jade.png"));
            images.Add(14, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\sql.png"));
            images.Add(15, Image.FromFile("C:\\Users\\X\\Desktop\\VPProject\\VP_pictures\\swift.png"));
        }

       

       
    }
}
