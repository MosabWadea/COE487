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
        Bgr bgrH = new Bgr();
        Bgr bgrL = new Bgr();

        public HelloOpenCV(){
            InitializeComponent();

            bgrH.Blue = 255;
            bgrH.Green = 100;
            bgrH.Red = 100;

            bgrL.Blue = 175;
            bgrL.Green = 0;
            bgrL.Red = 0;

            blueH.Value = 255;
            greenH.Value = 100;
            redH.Value = 100;

            blueL.Value = 175;

            blueHT.Text = "255";
            greenHT.Text = "100";
            redHT.Text = "100";

            blueLT.Text = "175";
            greenLT.Text = "0";
            redLT.Text = "0";

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



        void processFrameAndUpdateGUI(object sender, EventArgs arg) {
            string con = "";
            org = cam.QueryFrame();
            if (org == null) return;

            proc = org.InRange(bgrL, bgrH);

            proc = proc.SmoothGaussian(9);

            CircleF[] circles = proc.HoughCircles(new Gray(100), new Gray(50), 2, proc.Height / 4, 10, 400)[0];

            for (int i =0; i<circles.Length; i++) {
                CvInvoke.cvCircle(org, new Point((int)circles[i].Center.X, (int)circles[i].Center.Y), 3, new MCvScalar(0, 255, 0), -1, LINE_TYPE.CV_AA, 0);

                org.Draw(circles[i], new Bgr(Color.Red), 3);
                con += "(" + (i+1) + ", " + circles[i].Center.X + ", " + circles[i].Center.Y+"), ";
            }
            if(circles.Length>0)
                consol.AppendText(con+"\n");
            imageBox1.Image = org;
            imageBox2.Image = proc;

        }

        //set scroll values for low
        private void redL_Scroll(object sender, EventArgs e) {
            bgrL.Red = redL.Value;
            redLT.Text = redL.Value +"";
        }
        private void greenL_Scroll(object sender, EventArgs e) {
            bgrL.Green = greenL.Value;
            greenLT.Text = greenL.Value + "";
        }
        private void blueL_Scroll(object sender, EventArgs e) {
            bgrL.Blue = blueL.Value;
            blueLT.Text = blueL.Value + "";
        }

        //set text values for low
        private void redLT_TextChanged(object sender, EventArgs e) {
            bgrL.Red = Convert.ToInt32(redLT.Text);
            redL.Value = Convert.ToInt32(redLT.Text);
        }
        private void greenLT_TextChanged(object sender, EventArgs e) {
            bgrL.Green = Convert.ToInt32(greenLT.Text);
            greenL.Value = Convert.ToInt32(greenLT.Text);
        }
        private void blueLT_TextChanged(object sender, EventArgs e) {
            bgrL.Blue = Convert.ToInt32(blueLT.Text);
            blueL.Value = Convert.ToInt32(blueLT.Text);
        }

        //set scroll values for high
        private void redH_Scroll(object sender, EventArgs e) {
            bgrH.Red = redH.Value;
            redHT.Text = redH.Value + "";
        }
        private void greenH_Scroll(object sender, EventArgs e) {
            bgrH.Green = greenH.Value;
            greenHT.Text = greenH.Value + "";
        }
        private void blueH_Scroll(object sender, EventArgs e) {
            bgrH.Blue = blueH.Value;
            blueHT.Text = blueH.Value + "";
        }

        //set text values for high
        private void redHT_TextChanged(object sender, EventArgs e) {
            bgrH.Red = Convert.ToInt32(redHT.Text);
            redH.Value = Convert.ToInt32(redHT.Text);
        }
        private void greenHT_TextChanged(object sender, EventArgs e) {
            bgrH.Green = Convert.ToInt32(greenHT.Text);
            greenH.Value = Convert.ToInt32(greenHT.Text);
        }
        private void blueHT_TextChanged(object sender, EventArgs e) {
            bgrH.Blue = Convert.ToInt32(blueHT.Text);
            blueH.Value = Convert.ToInt32(blueHT.Text);
        }


        public void HelloOpenCV_FormClosed(object sender, FormClosedEventArgs e) {
            if (cam != null) {
                cam.Dispose();
            }
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.SetText(consol.Text);
        }

        private void control_Click(object sender, EventArgs e) {
            if (caping == true) {
                Application.Idle -= processFrameAndUpdateGUI;
                caping = false;
                control.Text = "Resume Capturing";
            }
            else {
                Application.Idle += processFrameAndUpdateGUI;
                caping = true;
                control.Text = "Stop Capturing";
            }
        }
    }
}
