using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.Util.TypeEnum;

namespace OfflinePreprocess
{
  public partial class Form1 : Form
  {
    public Image<Gray, Byte> InputIMG = new Image<Gray, byte>(1, 1, new Gray(0));
    public Image<Bgr, Byte> InputBGR = new Image<Bgr, byte>(1, 1, new  Bgr(0,0,0));
    public Image<Bgr, Byte> InputBGR_Copy = new Image<Bgr, byte>(1, 1, new Bgr(0, 0, 0));
    public List<NeuronBodyMask> NBM = new List<NeuronBodyMask>();

    public int NBM_id = 0;
    public NeuronBodyMask CurNBM = new NeuronBodyMask();
    public Image<Bgr, Byte> newMask = new Image<Bgr, byte>(1, 1, new Bgr(0, 0, 0));


    //
    List<LineSegment2D> Lines = new List<LineSegment2D>();
    public Point LineStart = new Point();
    public Point LineEnd = new Point();
    public bool isMouseDown = false;
    //Point p1, p2;
    bool doDraw = false;

    public void GetConnections(Image<Gray, Byte> src)
    {
      Image<Gray, float> dist = new Image<Gray, float>(src.Size);
      Image<Gray, float> labels = new Image<Gray, float>(src.Size);
      CvInvoke.DistanceTransform(src, dist, labels, DistType.L1, 5);

      

    }



    public Form1()
    {
      InitializeComponent();
    }

    public void Magic()
    {
      Image<Gray, Byte> TMP = ImgProcTools.BinarizationMethods.BinByDistanceTransform(InputIMG);
      //Image<Gray, Byte> rTMP = ImgProcTools.Permutations.CreateBlackFrameForImage(TMP, 5);
      //Image<Gray, Byte> rrTMP = ImgProcTools.Permutations.CreateBlackFrameForImage(InputIMG, 5);
      //VectorOfVectorOfPoint AllContours = ImgProcTools.EdgeDetection.SimplestEdgeDetection(rTMP);
      VectorOfVectorOfPoint AllContours = ImgProcTools.EdgeDetection.SimplestEdgeDetection(TMP);
    
      List<VectorOfPoint> smallContours = new List<VectorOfPoint>();
      List<VectorOfPoint> rejectedContours = new List<VectorOfPoint>();
      List<VectorOfPoint> BigContours = NeuronSeparation.Calculations.SeparateSmallContours(NeuronSeparation.Converter.VVOPToListOfVOP(AllContours), out smallContours, out rejectedContours, 100);
       
      //InputBGR  = new Image<Bgr, byte>(rTMP.Size);
      //InputBGR[0] = InputBGR[1] = InputBGR[2] = rrTMP;
      InputBGR  = new Image<Bgr, byte>(TMP.Size);
      InputBGR[0] = InputBGR[1] = InputBGR[2] = TMP;
      
      //CvInvoke.DrawContours(InputBGR, AllContours, -1, new MCvScalar(100, 0, 128), 1, LineType.EightConnected);
      //CvInvoke.DrawContours(InputBGR, NeuronSeparation.Converter.ListOfVOPtoVVOP(rejectedContours), -1, new MCvScalar(0, 0 , 0), -1, LineType.EightConnected);
      //CvInvoke.DrawContours(InputBGR, NeuronSeparation.Converter.ListOfVOPtoVVOP(smallContours), -1, new MCvScalar(0, 0 , 0), -1, LineType.EightConnected);

      InputBGR_Copy = InputBGR.Clone();

      CvInvoke.DrawContours(InputBGR, NeuronSeparation.Converter.ListOfVOPtoVVOP(BigContours), -1, new MCvScalar(0, 255, 0), 1, LineType.EightConnected);
      CvInvoke.DrawContours(InputBGR, NeuronSeparation.Converter.ListOfVOPtoVVOP(smallContours), -1, new MCvScalar(255, 255, 0), 1, LineType.EightConnected);
      CvInvoke.DrawContours(InputBGR, NeuronSeparation.Converter.ListOfVOPtoVVOP(rejectedContours), -1, new MCvScalar(0, 255, 255), 1, LineType.EightConnected);
      //InputBGR.Save(@"C:\Users\Админ\Desktop\антону\TMPf.png");
      List<VectorOfPoint> Q = NeuronSeparation.Split.SepByQuadroPoints(BigContours);

      //!!!!
      //!!!
      Q.AddRange(smallContours);
      NBM = NeuronSeparation.Masks.GetNeuronBodyMasks(Q);
     // GetConnections(InputIMG);

      /*
      for (int i = 0; i < NBM.Count; i++)
      {
        NBM[i].BodyMask.Not().Save(@"C:\Users\Admin\Desktop\Антон\Contours\" + i.ToString() + ".png");
      }
      */
      //!!!
      /*
      for (int i = 0; i < NBM.Count; i++)
      {
        BGR.Draw(NBM[i].Field, new Bgr(0, 0, 255), 1);
        BGR.Draw(new Cross2DF(new PointF(NBM[i].Center.X, NBM[i].Center.Y), 3, 3), new Bgr(255, 100, 50), 1);
      }
      */
    }

    private void BTN_Ok_Click(object sender, EventArgs e)
    {

    }

    private void BTN_Next_Click(object sender, EventArgs e)
    {
      if (NBM_id < NBM.Count) NBM_id++;
      CurNBM = NBM[NBM_id];
    }

    private void BTN_Prev_Click(object sender, EventArgs e)
    {
      if (NBM_id >= 0) NBM_id--;
      CurNBM = NBM[NBM_id];
    }

    private void BTN_OpenFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog OF = new OpenFileDialog();
      if (OF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        InputIMG = new Image<Gray, byte>(OF.FileName);
      }
      imageBox1.Image = InputIMG.Resize(imageBox1.Width, imageBox1.Height, Inter.Nearest);
      PrepareTab2(sender, e);
    }

    private void PrepareTab2(object sender, EventArgs e)
    {
      Stopwatch timer = new Stopwatch();
      timer.Start();
      Magic();
      timer.Stop();
      imageBox2.Image = InputBGR.Resize(imageBox2.Width, imageBox2.Height, Inter.Nearest);
      pictureBox1.Image = InputBGR.Resize(imageBox2.Width, imageBox2.Height, Inter.Nearest).ToBitmap();
    }

    private void Magic2(object sender, EventArgs e)
    {
      Image<Gray, Byte> tmp = InputBGR.Convert<Gray, Byte>();
      Image<Gray, Byte> new_mask = tmp.CopyBlank();
      CvInvoke.BitwiseXor(CurNBM.BodyMask, newMask.Convert<Gray, Byte>().ThresholdBinary(new Gray(1), new Gray(255)), new_mask); 
      tmp = tmp.Copy(new_mask);

      VectorOfVectorOfPoint vvop = ImgProcTools.EdgeDetection.SimplestEdgeDetection(tmp.ThresholdBinary(new Gray(1), new Gray(255)));

      List<NeuronBodyMask> newNBM = NeuronSeparation.Masks.GetNeuronBodyMasks(NeuronSeparation.Converter.VVOPToListOfVOP(vvop));
      
      NBM.InsertRange(NBM_id, newNBM);
      NBM.RemoveAt(NBM_id);
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      isMouseDown = true;
      //doDraw = true;
      LineStart = new Point(e.X, e.Y);
      //p1 = LineStart;
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (isMouseDown)
      {
        if (LineEnd != null)
        {
//          p2 = e.Location;
          LineEnd = e.Location;
          pictureBox1.Invalidate();//refreshes the picturebox
        }
      }

    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
      isMouseDown = false;      
      //foreach (var VAL in Lines) InputBGR_Copy.Draw(VAL, new Bgr(0, 0, 0), 1);  
      // 185 / 161
      // 312 / 166
      double dX = 1.0 * InputBGR.Width / pictureBox1.Width;
      double dY = 1.0 * InputBGR.Height / pictureBox1.Height;
      LineStart = new Point((int)(LineStart.X * dX), (int)(LineStart.Y * dY));
      LineEnd = new Point((int)(LineEnd.X * dX), (int)(LineEnd.Y * dY));
      InputBGR.Draw(new LineSegment2D(LineStart, LineEnd), new Bgr(0,0,0), 2);
      Lines.Add(new LineSegment2D(LineStart, LineEnd));
      LineEnd = Point.Empty;

      //
      Magic();
      InputBGR.Resize(1, Inter.Nearest);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      List<Image<Gray, Byte>> MASKS = NeuronSeparation.Masks.GetMergedMasks(NBM);
      List<Image<Gray, Byte>> newM = new List<Image<Gray, Byte>>();
      for (int i = 0; i < MASKS.Count; i++)
      {
        newM.Add(ImgProcTools.Permutations.RemoveBlackFrameFromImage(MASKS[i], 5));

      }
      //foreach (var Val in MASKS) Tools.IO.BinaryIO.WriteToBinaryFile<Image<Gray, Byte>> (@"C:\Users\Админ\Desktop\Masks.bin", Val, true);
      //Tools.IO.BinaryIO.WriteToBinaryFile<List<Image<Gray, Byte>>>(@"C:\Users\Admin\Desktop\Антон\MASKS.bin", MASKS, false);
      Tools.IO.BinaryIO.WriteToBinaryFile<List<Image<Gray, Byte>>>(@"C:\Users\Admin\Desktop\Антон\MASKS.bin", newM, false);

      //TEST read
      List<Image<Gray, Byte>> MASKS2 = Tools.IO.BinaryIO.ReadFromBinaryFile<List<Image<Gray, Byte>>>(@"C:\Users\Admin\Desktop\Антон\MASKS.bin");
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
      if (isMouseDown)
      {
        using (Graphics g = Graphics.FromImage(pictureBox1.Image))
        {
          g.Clear(Color.FromArgb(0, Color.White));
          g.DrawImage(InputBGR.Resize(imageBox2.Width, imageBox2.Height, Inter.Nearest).ToBitmap(), new Point(0, 0));
          g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
          //
          InputBGR = InputBGR_Copy.Clone();
          foreach (var Val in Lines) InputBGR.Draw(Val, new Bgr(0, 0, 0), 2);
          //pictureBox1.Image = InputBGR.Resize(imageBox2.Width, imageBox2.Height, Inter.Nearest).ToBitmap();

          //
          g.DrawLine(new Pen(Color.Yellow, 2), LineStart,LineEnd);
        }
      }
    }

    private void BTN_Back_Click(object sender, EventArgs e)
    {
      InputBGR = InputBGR_Copy.Clone();

      if (Lines.Count >= 1) Lines.RemoveAt(Lines.Count - 1);
      else Lines = new List<LineSegment2D>();
    }
  }
}
