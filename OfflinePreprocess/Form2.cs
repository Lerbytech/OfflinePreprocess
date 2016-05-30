using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace OfflinePreprocess
{
  public partial class Form2 : Form
  {
    public int N = 17;

    public Form2()
    {
      InitializeComponent();
    }
    /*
    private void DrawGraph()
    {
      //
      ZedGraph.MasterPane masterPane = zedGraphControl1.MasterPane;

      //
      masterPane.PaneList.Clear();

      //
      for (int i = 0; i < N; i++)
      {
        // Создаем экземпляр класса GraphPane, представляющий собой один график
        GraphPane pane = new GraphPane ();
        // Заполнение графика данными не изменилось, 
        // поэтому вынесем заполнение точек в отдельный метод DrawSingleGraph()
        DrawSingleGraph (pane);             
        // Добавим новый график в MasterPane
        masterPane.Add (pane);
      }


       // Будем размещать добавленные графики в MasterPane
    using (Graphics g = CreateGraphics ())
    {
        // Закомментарены разные варианты (не все) размещения графиков.

        // Графики будут размещены в один столбец друг под другом
        //masterPane.SetLayout (g, PaneLayout.SingleColumn);

        //Графики будут размещены в одну строку друг за другом
        //masterPane.SetLayout (g, PaneLayout.SingleRow);

        // Графики будут размещены в две строки, 
        // в первой будет один столбец, а во второй - две
        masterPane.SetLayout (g, PaneLayout.ExplicitCol12);
    }

    // Обновим оси и перерисуем график
    zedGraphControl1.AxisChange ();
    zedGraphControl1.Invalidate ();
}

    private void DrawSingleGraph (GraphPane pane)
{
    pane.CurveList.Clear ();

    PointPairList list = new PointPairList ();

    double xmin = -40;
    double xmax = 40;

    for (double x = xmin; x <= xmax; x += 0.01)
    {
        list.Add (x, f (x));
    }

    LineItem myCurve = pane.AddCurve ("Sinc", list, Color.Blue, SymbolType.None);
}
     

    }*/
  }
}
