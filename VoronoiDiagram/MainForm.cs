using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace VoronoiDiagram
{
    public partial class VoronoiDiagramForm : Form
    {
        Bitmap bitmap;
        Graphics g;
        Voronoi voronoi;
        List<PointF> sites = new List<PointF>();
        Pen pen;

        public VoronoiDiagramForm()
        {
            InitializeComponent();
            pictBoxDaigram.AutoSize = true;
            bitmap = new Bitmap(512, 512);
            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.Transparent);
            pen = new Pen(Color.Black)
            {
                Width = 2
            };
            pictBoxDaigram.Image = bitmap;            
       
            voronoi = new Voronoi(0.1);
        }

        private void SpreadPoints()
        {
            g.Clear(Color.Transparent);

            for (int i = 0; i < sites.Count; i++)
            {
                g.FillEllipse(Brushes.Blue, sites[i].X - 2, sites[i].Y - 2, 4, 4);
            }
            List<GraphEdge> ge;
            ge = MakeVoronoiGraph(sites, 512, 512);

            for (int i = 0; i < ge.Count; i++)
            {
                Point p1 = new Point((int)ge[i].x1, (int)ge[i].y1);
                Point p2 = new Point((int)ge[i].x2, (int)ge[i].y2);
                g.DrawLine(pen, p1.X, p1.Y, p2.X, p2.Y);
            }
        }

        private List<GraphEdge> MakeVoronoiGraph(List<PointF> sites, int width, int height)
        {
            double[] xVal = new double[sites.Count];
            double[] yVal = new double[sites.Count];
            for (int i = 0; i < sites.Count; i++)
            {
                xVal[i] = sites[i].X;
                yVal[i] = sites[i].Y;
            }
            return voronoi.GenerateVoronoi(xVal, yVal, 0, width, 0, height);
        }

        private void pbHousePlan_MouseClick(object sender, MouseEventArgs e)
        {        
            if (e.Button == MouseButtons.Left)
            {
                if(!sites.Contains(new PointF(e.X, e.Y)))
                    sites.Add(new PointF(e.X, e.Y));
                g.FillEllipse(Brushes.Blue, e.X  - 2, e.Y - 2, 4, 4);
                if (sites.Count > 1)
                    SpreadPoints();
                if (showDiagram.Checked)
                {
                    pictBoxDaigram.Image = bitmap;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sites.Clear();
            g.Clear(Color.Transparent);
            pictBoxDaigram.Image = bitmap;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DaigramPanel.BackgroundImage = new Bitmap(openFileDialog1.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            DaigramPanel.BackgroundImage = Properties.Resources.voronoi;
            showBuildPlan.Checked = true;
        }

        private void showDiagram_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if(checkBox.Checked)
            {
                pictBoxDaigram.Image = bitmap;
            }
            else
            {
                pictBoxDaigram.Image = null;
            }
        }

        private void showBuildPlan_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                DaigramPanel.BackgroundImage = Properties.Resources.voronoi;
            }
            else
            {
                DaigramPanel.BackgroundImage = null;
            }
        }
    }
}