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
        Bitmap diagramBitmap, buildingPlan;
        Graphics g;
        Voronoi voronoi;
        List<PointF> sites = new List<PointF>();
        Pen pen;

        public VoronoiDiagramForm()
        {
            InitializeComponent();
            pictBoxDaigram.AutoSize = true;
            diagramBitmap = new Bitmap(512, 512);
            g = Graphics.FromImage(diagramBitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.Transparent);
            pen = new Pen(Color.Black)
            {
                Width = 2
            };
            pictBoxDaigram.Image = diagramBitmap;            
       
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
            }
            else
            {
                for (int i = 0; i < sites.Count; i++)
                {
                    if (Math.Sqrt(Math.Pow(sites[i].X - e.X, 2) + Math.Pow(sites[i].Y - e.Y, 3)) < 2)
                    {
                        sites.RemoveAt(i);
                    }
                }
            }
            if (sites.Count > 1)
                SpreadPoints();

             pictBoxDaigram.Image = showDiagram.Checked ? diagramBitmap : null;


            lblCount.Text = sites.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sites.Clear();
            g.Clear(Color.Transparent);
            pictBoxDaigram.Image = diagramBitmap;
            lblCount.Text = sites.Count.ToString();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            buildingPlan = new Bitmap(openFileDialog1.FileName);
            showBuildPlan_CheckedChanged(showBuildPlan, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();          
        }

        private void showDiagram_CheckedChanged(object sender, EventArgs e)
        {
            pictBoxDaigram.Image = ((CheckBox)sender).Checked ? diagramBitmap : null;
        }

        private void showBuildPlan_CheckedChanged(object sender, EventArgs e)
        {
            DaigramPanel.BackgroundImage = ((CheckBox)sender).Checked ? buildingPlan: null;
        }
    }
}