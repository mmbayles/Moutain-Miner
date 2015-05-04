using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Data;
using DotSpatial.Controls;
using DotSpatial.Topology;

namespace WFA01
{
    public partial class frmMain : Form
    {
        private bool amDigitizing = false; //drawing flag
        private List<DotSpatial.Topology.Coordinate> myDigitizedPoints = null; //store digitized points
        int flag = -1; // 1--cut polygon 2--fill polygon
        DotSpatial.Controls.MapPolygonLayer CutPolygon = null;
        DotSpatial.Controls.MapPolygonLayer FillPolygon = null;
        IMapRasterLayer MyMainRaster = null;
        IMapRasterLayer MyFillRaster = null;
        private DotSpatial.Controls.IMapLayer myLayer = null;
        double Volume = 0;
        double Fillcells = 0;
        double AddVolume = 0;
        double Cellsize = 0 ;
        double CutVolume = 0;        

        public frmMain()
        {
            InitializeComponent();
            appManager1.LoadExtensions();
        }

        //Close the App
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Add/Remove layers
        //Add layers     
        private void addLayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myLayer = mapMain.AddLayer();
            MyMainRaster = (IMapRasterLayer)myLayer;
        }        

        //Remove layers
        private void removeLayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapMain.Layers.Remove(myLayer);
        }

        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            addLayerToolStripMenuItem_Click(null, null);
        }

        private void btnRemoveLayer_Click(object sender, EventArgs e)
        {
            mapMain.Layers.Remove(myLayer);
        }
        #endregion Add/Remove layers


        #region Zoom In/Out/Pan
        //Zoom in
        private void zoomInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn;
        }

        //Zoom out
        private void zoomOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut;
        }

        //Zoom to Extent
        private void zoomToExtentMenu_Click(object sender, EventArgs e)
        {
            mapMain.ZoomToMaxExtent();
        }

        //Pan
        private void panMenu_Click(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomIn;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.ZoomOut;
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
        }
        #endregion


        #region Create Cut/Fill Polygons
        //click the button to create cut polygon                   
        private void creatCutMenu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click on the map to draw a polyline. Double click to stop drawing.");
            amDigitizing = true;
            //Reset the list of points
            myDigitizedPoints = new List<DotSpatial.Topology.Coordinate>();
            //mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
            //Clarify that the polygon being drawn is for cutting
            flag = 1;            
        }

        //click the button to create fill polygon
        private void createFillMenu_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click on the map to draw a polyline. Double click to stop drawing.");
            amDigitizing = true;
            myDigitizedPoints = new List<DotSpatial.Topology.Coordinate>();
            //mapMain.FunctionMode = DotSpatial.Controls.FunctionMode.Select;
            flag = 2;            
        }

        private void btnCreateCutPolygon_Click(object sender, EventArgs e)
        {
            creatCutMenu_Click(null, null);            
        }

        private void btnCreateFillPolygon_Click(object sender, EventArgs e)
        {
            createFillMenu_Click(null, null);            
        }
        #endregion       


        #region Map Mouse Callbacks for Move/Click/Double
        // draw polygon        
        DotSpatial.Controls.IMapFeatureLayer DrawingLayer;
        private void mapMain_Click(object sender, EventArgs e)
        {
            if (amDigitizing == true)
            {
                MouseEventArgs pm = e as MouseEventArgs;
                updateFeatures(pm.X, pm.Y);
            }
        }

        DotSpatial.Data.Feature f;
        DotSpatial.Data.FeatureSet fs;

        private void updateFeatures(int TheX, int TheY)
        {
            DotSpatial.Topology.Coordinate c = new DotSpatial.Topology.Coordinate();
            System.Drawing.Point p = new System.Drawing.Point();
            p.X = TheX;
            p.Y = TheY;
            c = mapMain.PixelToProj(p);
            if (myDigitizedPoints.Count >= 4)
            {
                myDigitizedPoints.RemoveAt(myDigitizedPoints.Count - 1);
            }
            myDigitizedPoints.Add(c);
            //MessageBox.Show(myDigitizedPoints.Count.ToString());
            //display polygon when drawing
            if (myDigitizedPoints.Count > 2)
            {
                f = new DotSpatial.Data.Feature(DotSpatial.Topology.FeatureType.Polygon, myDigitizedPoints);
                // MessageBox.Show(myDigitizedPoints.Count.ToString());
                fs = new DotSpatial.Data.FeatureSet();
                fs.AddFeature(f);
                fs.Projection = mapMain.Projection;
                try
                {
                    mapMain.Layers.Remove(DrawingLayer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DrawingLayer = mapMain.Layers.Add(fs);
            }
        }

        // finish drawing the polygon with double-click
        private void mapMain_DoubleClick(object sender, EventArgs e)
        {
            if (amDigitizing == true)
            {
                MouseEventArgs pm = e as MouseEventArgs;
                updateFeatures(pm.X, pm.Y);
                amDigitizing = false;

                //save the polygon as a cutting polygon
                if (flag == 1)
                {
                    fs.Projection = mapMain.Projection;
                    fs.SaveAs("CutPolygon.shp", true);
                    try
                    {
                        mapMain.Layers.Remove(DrawingLayer);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    CutPolygon = (DotSpatial.Controls.MapPolygonLayer)mapMain.AddLayer("CutPolygon.shp");
                }
                else  //save the polygon as a cutting polygon
                {
                    fs.Projection = mapMain.Projection;
                    fs.SaveAs("FillPolygon.shp", true);
                    try
                    {
                        mapMain.Layers.Remove(DrawingLayer);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    FillPolygon = (DotSpatial.Controls.MapPolygonLayer)mapMain.AddLayer("FillPolygon.shp");
                }
            }            
        }
       

        // mousemove to show the coordinates
        private void mapMouseMove1(object sender, MouseEventArgs e)
        {
            Coordinate c_mouse = mapMain.PixelToProj(new System.Drawing.Point(e.X, e.Y));  
            stax.Text = "X:" + Convert.ToString(c_mouse.X);
            stay.Text = "Y:" + Convert.ToString(c_mouse.Y);

            if (displayElev)
            {                
                DotSpatial.Topology.Coordinate c;
                double Cellsize = r1.CellWidth;

                for (int i = 0; i < r1.NumRows; i++)
                {
                    for (int j = 0; j < r1.NumColumns; j++)
                    {
                        c = r1.CellToProj(i, j);
                        if (c.X - 0.5 * Cellsize < c_mouse.X && c_mouse.X < c.X + 0.5 * Cellsize)
                        {
                            if (c.Y - 0.5 * Cellsize < c_mouse.Y && c_mouse.Y < c.Y + 0.5 * Cellsize)
                            {                                
                                string msg = "   Previous Elevation: " 
                                    + Convert.ToString(r1.Value[i, j]) 
                                    + "\r\n" + "   New Elevation: " 
                                    + Convert.ToString(r3.Value[i, j]);
                                toolTip1.Show(msg, mapMain);
                                return;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        
        #region Caculate Cut/Fill
        IRaster r1;
        IRaster r2;
        IRaster r3;
        //User specifies the cutting elevation and caculate the volume of cutting field.
        private void caculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyMainRaster == null)
            {
                MessageBox.Show("Please add a layer.");
                return;
            }

            //set up variables
            Volume = 0;
            Fillcells = 0;
            AddVolume = 0;
            DotSpatial.Topology.Coordinate c;
            IFeature Polygon = CutPolygon.DataSet.Features[0];
            IFeature Fill = FillPolygon.DataSet.Features[0];
            double CutElevation = Convert.ToDouble(txtCutElevation.Text);
            //create a raster with the cut polygon combined with the initial raster
            r1 = (IRaster)MyMainRaster.DataSet;
            r2 = Raster.Create("CutRaster.bgd", null, r1.NumColumns, r1.NumRows, 1, r1.DataType, null);
            r2.Bounds = r1.Bounds;
            r2.Projection = r1.Projection;
            r2.NoDataValue = r1.NoDataValue;

            //Get cell size
            Cellsize = Math.Round(Polygon.Area() / (r1.NumValueCells));

            //Make the cuts and store volume information
            for (int i = 0; i < r1.NumRows; i++)
            {
                for (int j = 0; j < r1.NumColumns; j++)
                {                    
                    c = r1.CellToProj(i, j);
                    if (Polygon.Intersects(c))
                    {
                        if (r1.Value[i, j] < CutElevation)
                        {
                            r2.Value[i, j] = r1.Value[i, j];
                        }
                        else
                        {
                            Volume = Volume + (r1.Value[i, j] - CutElevation);
                            r2.Value[i, j] = CutElevation;
                        }
                    }
                    else
                    //Keep data outside the polygon unchanged
                    {
                        r2.Value[i, j] = r1.Value[i, j];
                    }
                }
            }

            CutVolume = Volume * Cellsize;
            //Create a raster with the fill polygon added
            r3 = Raster.Create("FillRaster.bgd", null, r1.NumColumns, r1.NumRows, 1, r1.DataType, null);
            r3.Bounds = r1.Bounds;
            r3.Projection = r1.Projection;
            r3.NoDataValue = r1.NoDataValue;
            
            //Count the number of cells in the fill polygon
            for (int i = 0; i < r2.NumRows; i++)
            {
                for (int j = 0; j < r2.NumColumns; j++)
                {
                    c = r1.CellToProj(i, j);
                    if (Fill.Intersects(c))
                    {
                        Fillcells += 1;
                    }
                }
            }

            //Caculate the elevation augment in the fill polygon
            AddVolume = Volume / Fillcells;

            //Add the elevation augment to fill polygon
            for (int i = 0; i < r2.NumRows; i++)
            {
                for (int j = 0; j < r2.NumColumns; j++)
                {
                    c = r2.CellToProj(i, j);
                    if (Fill.Intersects(c))
                    {
                        r3.Value[i, j] = r2.Value[i, j] + AddVolume;
                    }
                    else
                    {                        
                        r3.Value[i, j] = r2.Value[i, j];
                    }
                }
            }

            //Project and add final layer to the map            
            r3.Projection = mapMain.Projection;
            MyFillRaster = mapMain.Layers.Add(r3);
            DotSpatial.Projections.LinearUnit u = r1.Projection.Unit;
            string UnitName = u.Name.ToString();
            UnitName = UnitName.ToLower();

            if (UnitName == "meter")
            {
                MessageBox.Show("Total cut volume is: " + CutVolume.ToString() + " m^3");
            }
            else if (UnitName == "meters")
            {
                MessageBox.Show("Total cut volume is: " + CutVolume.ToString() + " m^3");
            }
            else
            {
                MessageBox.Show("Current units:" + u.Name + "Please reproject your data into meters for volume calculation.");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            caculatorToolStripMenuItem_Click(null, null);
        }
        #endregion               


        #region View Cut/Fill values
        bool displayElev = false;
        private void viewElevationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayElev = !displayElev;
        }

        private void btnViewElevation_Click(object sender, EventArgs e)
        {
            viewElevationsToolStripMenuItem_Click(null, null);
        }
        #endregion

    }
}
