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
        Queue<PointF> newSites = new Queue<PointF>();
        Pen pen;

        public VoronoiDiagramForm()
        {
            InitializeComponent();
            pictBox.AutoSize = true;
            bitmap = new Bitmap(512, 512);
            g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.Transparent);
            pen = new Pen(Color.Black);
            pen.Width = 2;
            pictBox.Image = bitmap;            
       
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
            pictBox.Image = bitmap;
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
                pictBox.Image = bitmap;
            }
        }

        private void btnOpenPlanFile_Click(object sender, EventArgs e)
        {
            openPlanFile.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sites.Clear();
            g.Clear(Color.Transparent);
            pictBox.Image = bitmap;
        }

        private void openPlanFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            BuildingPlanImage.BackgroundImage = new Bitmap(openPlanFile.FileName);
        }
    }
}