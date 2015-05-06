using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace COE487{
    public partial class HelloOpenCV : Form{

        Capture cam = null;
        bool caping = false;
        Image<Bgr, Byte> org;
        Image<Gray, Byte> proc;

        public HelloOpenCV(){
            InitializeComponent();
        }

        private void HelloOpenCV_Load(object sender, EventArgs e){
            try{
                cam = new Capture();
            }
            catch (NullReferenceException ex) {
                return;
            }

            Application.Idle += processFrameAndUpdateGUI;
            caping = true;

        }

        public void HelloOpenCV_FormClosed(object sender, FormClosedEventArgs e) {
            if (cam != null) {
                cam.Dispose();
            }
        }

        void processFrameAndUpdateGUI(object sender, EventArgs arg) {
            org = cam.QueryFrame();
            if (org == null) return;
            //#TODO make red detection
            proc = org.InRange(new Bgr(175, 0, 0), new Bgr(256, 100, 100));

            proc = proc.SmoothGaussian(9);

            CircleF[] circles = proc.HoughCircles(new Gray(100), new Gray(50), 2, proc.Height / 4, 10, 400)[0];

            foreach (CircleF circle in circles) {
                CvInvoke.cvCircle(org, new Point((int)circle.Center.X, (int)circle.Center.Y), 3, new MCvScalar(0, 255, 0), -1, LINE_TYPE.CV_AA, 0);

                org.Draw(circle, new Bgr(Color.Red), 3);
            }

            imageBox1.Image = org;
            imageBox2.Image = proc;

        }
    }
}
