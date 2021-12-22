using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class FormLab : Form
    {
        int old_x, old_y;
        List<Figure> list = new List<Figure>();
        
        public FormLab()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, 0, 0, pictureBoxDraw.Width, pictureBoxDraw.Height);
            foreach (Figure fig in list)
                fig.draw(e.Graphics);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Figure fig in list)
                fig.selected = false;
            for(int i = list.Count - 1; i >= 0; i--)
            {
                Figure fig = list[i];
                fig.selected |= fig.test(e.X, e.Y);
                if (fig.selected == true) { listBox1.SelectedIndex = i; break; }
            }
            pictureBoxDraw.Invalidate();
        }
        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - old_x;
                int dy = e.Y - old_y;
                foreach (Figure fig in list)
                {
                    if (fig.selected == false) continue;
                    fig.pos_x += dx;
                    fig.pos_y += dy;
                }
                pictureBoxDraw.Invalidate();
            }
            old_x = e.X;
            old_y = e.Y;
        }

        
        int rectNum = 1;
        int circNum = 1;
        int triangNum = 1;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Figure fig = createFigure(comboBoxFigure.Text);
            fig.thickness = trackBarThickness.Value;
            fig.Set(trackBarRadius.Value);

            
            if (fig == null) return;
            fig.pos_x = pictureBoxDraw.Width/2;
            fig.pos_y = pictureBoxDraw.Height/2;
            list.Add(fig);
            switch (comboBoxFigure.Text)
            {
                case "Квадрат": listBox1.Items.Add(comboBoxFigure.Text + rectNum.ToString()); rectNum++; break;
                case "Круг": listBox1.Items.Add(comboBoxFigure.Text + circNum.ToString()); circNum++; break;
                case "Треугольник": listBox1.Items.Add(comboBoxFigure.Text + triangNum.ToString()); triangNum++; break;
            }
            
            pictureBoxDraw.Invalidate();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < list.Count)
            {
                if (list[i].selected == true) { list.RemoveAt(i); listBox1.Items.RemoveAt(i);}
                i++;
            }
            pictureBoxDraw.Invalidate();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Figure fig in list)
                fig.selected = false;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                try
                {
                    Figure fig = list[listBox1.SelectedIndex];
                    fig.selected = true;
                }catch
                { }
            }
            pictureBoxDraw.Invalidate();
        }

        int w, h;
        Bitmap bmp;
        private void FormLab_Load(object sender, EventArgs e)
        {
            pictureBoxDraw.MouseWheel += PictureBoxDraw_MouseWheel;
             
        }

        

        Figure createFigure(string fig_type)
        {
            switch (fig_type)
            {
                case "Круг": return new Circle();
                case "Квадрат": return new Rectangle();
                case "Треугольник":  return new Triangle();
            }
            return null;
        }

        private void PictureBoxDraw_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.None)
            {
                if (e.Delta > 0)
                {
                    if (trackBarRadius.Value < trackBarRadius.Maximum - 9)
                    {
                        trackBarRadius.Value += 10;
                    }
                }
                else
                {
                    if (trackBarRadius.Value > trackBarRadius.Minimum + 9)
                    {
                        trackBarRadius.Value -= 10;
                    }
                }
            }


            if (ModifierKeys == Keys.Control)
            {

                if (e.Delta > 0)
                {
                    if (trackBarThickness.Value < trackBarThickness.Maximum )
                    {
                        trackBarThickness.Value += 1;
                    }
                }
                else
                {
                    if (trackBarThickness.Value > trackBarThickness.Minimum )
                    {
                        trackBarThickness.Value -= 1;
                    }
                }
            }
        }

        private void trackBarRadius_ValueChanged(object sender, EventArgs e)
        {
            foreach (Figure fig in list)
            {
                if (fig.selected == false) continue;
                fig.Set(trackBarRadius.Value);
            }
            pictureBoxDraw.Invalidate();
        }
        private void trackBarRadius_Scroll(object sender, EventArgs e)
        {
            foreach (Figure fig in list)
            {
                if (fig.selected == false) continue;
                fig.Set(trackBarRadius.Value);
            }
            pictureBoxDraw.Invalidate();
        }

        private void trackBarThickness_Scroll(object sender, EventArgs e)
        {
            foreach (Figure fig in list)
            {
                if (fig.selected == false) continue;
                fig.thickness = trackBarThickness.Value;
            }
            pictureBoxDraw.Invalidate();
        }

        

        

        private void trackBarThickness_ValueChanged(object sender, EventArgs e)
        {
            foreach (Figure fig in list)
            {
                if (fig.selected == false) continue;
                fig.thickness = trackBarThickness.Value;
            }
            pictureBoxDraw.Invalidate();
        }

        //private void buttonRender_Click(object sender, EventArgs e)
        //{
        //    w = pictureBoxDraw.Width;
        //    h = pictureBoxDraw.Height;
        //     bmp = new Bitmap(w, h);
        //    pictureBoxDraw.Image = bmp;
        //    for (int y = 0; y < h; y++)
        //    {
        //        for (int x = 0; x < w; x++)
        //        {
        //            RGB c = new RGB();
        //            foreach (Figure fig in list)
        //                if (fig.test(x, y)) c = fig.clr;
        //            bmp.SetPixel(x, y, c.getColor());
        //        }
        //    }
        //    pictureBoxDraw.Invalidate();
        //}
        private void buttonRender_Click(object sender, EventArgs e)
        {
            w = pictureBoxDraw.Width;
            h = pictureBoxDraw.Height;
            bmp = new Bitmap(w, h);
            pictureBoxDraw.Image = bmp;
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    RGB c = new RGB();
                    foreach (Figure fig in list)
                        if (fig.test(x, y)) c = fig.clr;
                    bmp.SetPixel(x, y, c.getColor());
                }
            }
            pictureBoxDraw.Invalidate();
        }


        private void buttonColour_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Figure fig in list)
                {
                    if (fig.selected == false) continue;
                    fig.color = colorDialog1.Color;
                    fig.colTrue = true;
                }
                pictureBoxDraw.Invalidate();
            }
        }
    }
}
