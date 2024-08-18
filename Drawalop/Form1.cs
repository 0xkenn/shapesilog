using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Drawalop
{
    public partial class Form1 : Form
    {
        int x, y, h, w;
        Pen pen = new Pen(Color.Black, 3);
        IAbstracDraw draw;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;


            Graphics graphics = this.CreateGraphics();
            InitDraw implementor = new InitDrawImplementation();
            draw = new AbstractDraw(implementor, graphics);
          

            if (radioButton1.Checked && radioButton3.Checked)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                draw.DrawVectorCircle(x, y, h, w, pen);
                stopwatch.Stop();
              
                MessageBox.Show($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
                
            }
            else if (radioButton1.Checked && radioButton4.Checked)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                draw.DrawRasterCircle(x, y, w, h, pen);
                stopwatch.Stop();

                MessageBox.Show($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            }
            else if (radioButton2.Checked && radioButton3.Checked)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                draw.DrawVectorRectangle(x, y, w, h, pen);
                stopwatch.Stop();

                MessageBox.Show($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            }
            else if (radioButton2.Checked && radioButton4.Checked)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                draw.DrawRasterRectangle(x, y, w, h, pen);
                stopwatch.Stop();

                MessageBox.Show($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
            }
          
            
            


          

          


        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.AntiqueWhite);
        }
       
    }
   
}
