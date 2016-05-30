using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.Util.TypeEnum;


namespace OfflinePreprocess
{
  public static class ImgProcTools
  {
    public static class DeNoising
    {
      public static Image<Gray, Byte> SigmaReject(Image<Gray, Byte> []input)
      {
        return null;
      }

      public static Image<Gray, Byte> SigmaReject2(Image<Gray, Byte>[] input)
      {
        return null;
      }
    }

    public static class BinarizationMethods
    {
      public static Image<Gray, Byte> SISThreshold(Image<Gray, Byte> src)
      {
        Image<Gray, Byte> result = src.Clone();
        result._ThresholdBinary(new Gray(CalculateSISThreshold(src)), new Gray(255));
        return result;
      }

      private static float CalculateSISThreshold(Image<Gray, Byte> src)
      {
        float T = 0;
        byte[, ,] D = src.Data;
        int W = src.Width;
        int H = src.Height;
        float dx = 0;
        float dy = 0;
        float weight = 0;
        float weightT = 0;

        for (int x = 1; x < W - 1; x++)
          for (int y = 1; y < H - 1; y++)
          {
            dx = D[y, x + 1, 0] - D[y, x - 1, 0];
            dy = D[y + 1, x, 0] - D[y - 1, x, 0];
            weight = (dx > dy) ? dx : dy;
            weightT += weight;
            T += weight * D[y, x, 0];
          }
        return (weightT == 0) ? (byte)0 : (byte)(T / weightT);
      }

      public static Image<Gray, Byte> BinByDistanceTransform(Image<Gray, Byte> src)
      {
        
        Image<Gray, float> dist = new Image<Gray, float>(src.Size);
        Image<Gray, float> labels = new Image<Gray, float>(src.Size);
        CvInvoke.DistanceTransform(src, dist, labels, DistType.L1, 5);

        dist = dist.ThresholdBinary(new Gray(0), new Gray(255));
        return dist.Convert<Gray, Byte>();
      }
    }

    public static class EdgeDetection
    {
      public static VectorOfVectorOfPoint SimplestEdgeDetection(Image<Gray, Byte> src)
      {
        Image<Gray, Byte> victim = src.Copy();
        VectorOfVectorOfPoint res = new VectorOfVectorOfPoint();
        CvInvoke.FindContours(victim, res, null, RetrType.List, ChainApproxMethod.ChainApproxNone);
        return res;
      }
    }

    public static class Permutations
    {
      public static Image<Gray, Byte> CreateBlackFrameForImage(Image<Gray, Byte> src, int shift)
      {
        Image<Gray, Byte> result = new Image<Gray, byte>(src.Width + shift * 2, src.Height + shift * 2, new Gray(0));
        CvInvoke.cvSetImageROI(result, new Rectangle(shift - 1, shift - 1, src.Width, src.Height));
        try { src.CopyTo(result); }
        catch (Exception) { }
        CvInvoke.cvResetImageROI(result);

        return result;
      }
      public static Image<Gray, Byte> RemoveBlackFrameFromImage(Image<Gray, Byte> src, int shift)
      {
        
        CvInvoke.cvSetImageROI(src, new Rectangle(shift - 1, shift - 1, src.Width - shift * 2, src.Height - shift * 2));
        Image<Gray, Byte> result = src.Copy();
        CvInvoke.cvResetImageROI(src);

        return result;
      }
    }
  }
}
