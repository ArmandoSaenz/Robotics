using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Legends;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using OxyPlot.Annotations;

namespace Pelicano
{
    public partial class Form1 : Form
    {
        #region members
        double l1 => double.Parse(tbL1.Text);
        double l2 => double.Parse(tbL2.Text);
        double x => double.Parse(tbX.Text);
        double y => double.Parse(tbY.Text);
        double theta1
        {
            get
            {
                return double.Parse(lTheta1.Text);
            }
            set
            {
                lTheta1.Text = value.ToString();
            }
        }
        double theta2
        {
            get
            {
                return double.Parse(lTheta2.Text);
            }
            set
            {
                lTheta2.Text = value.ToString();
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            PlotModel Grafica = new PlotModel()
            {
                Title = "Gráfica del robot RR",
                Subtitle = "Simulador",
                PlotType = PlotType.XY,
            };
            LineSeries Robot = new LineSeries();
            Robot.Points.Add(new DataPoint(0, 0));
            Grafica.Series.Add(Robot);
            plotView1.Model = Grafica;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (2 * l1 * l2 >= Math.Abs(x * x + y * y - l1 * l1 - l2 * l2))
            {
                theta2 = -Math.Acos((x * x + y * y - l1 * l1 - l2 * l2) / (2 * l1 * l2));
                theta1 = Math.Atan2(y, x) + Math.Atan2(l2 * Math.Sin(theta2), l1 + l2 * Math.Cos(theta2));
                double XScalar = 0;
                if (plotView1.ActualModel != null)
                {
                    XScalar = plotView1.ActualModel.PlotArea.Width / plotView1.ActualModel.PlotArea.Height;
                }
                PlotModel Grafica = new PlotModel()
                {
                    Title = "Gráfica del robot RR",
                    Subtitle = "Simulador",
                    PlotType = PlotType.XY,
                    Axes =
                    {
                        new LinearAxis()
                        {
                            Position = AxisPosition.Bottom,
                            Maximum = (l1+l2)*XScalar,
                            Minimum = (-l1-l2)*XScalar,
                            MajorGridlineStyle = LineStyle.Dot,
                            Key="Horizontal"
                        },
                        new LinearAxis()
                        {
                            Position = AxisPosition.Left,
                            Maximum = (l1+l2),
                            Minimum = (-l1-l2),
                            MajorGridlineStyle = LineStyle.Dot,
                            Key="Vertical"
                        }
                    },
                };
                Grafica.Annotations.Add(new EllipseAnnotation()
                {
                    Text = "Motor 1",
                    X = 0,
                    Y = 0,
                    Width = 1, 
                    Height = 1
                }
                );
                Grafica.Annotations.Add(new EllipseAnnotation()
                {
                    Text = "Motor 2",
                    X = l1*Math.Cos(theta1),
                    Y = l1 * Math.Sin(theta1),
                    Width = 1,
                    Height = 1
                }
                );

                LineSeries Robot = new LineSeries();
                Robot.Color = OxyColor.FromRgb(255, 0, 255);
                Robot.LineStyle = LineStyle.Dot;
                Robot.Title = "Robot RR";
                Robot.Points.Add(new DataPoint(0, 0));
                Robot.Points.Add(new DataPoint(Math.Cos(theta1) * l1, Math.Sin(theta1) * l1));
                Robot.Points.Add(new DataPoint(x, y));
                Grafica.Series.Add(Robot);
                plotView1.Model = Grafica;
                plotView1.InvalidatePlot(true);
            }
            else
            {
                MessageBox.Show($"La posicion {x}, {y} no es valida para el robot", "Error de posicion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
