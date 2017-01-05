using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LSDMS
{
    class GheloBytes
    {
        public static string Version()
        {
            string buildDate = "10.14.2010";
            return String.Format("Build ({0})", buildDate);
        }
           

        public class LotData
        {
            //@"SERVER=(local);DATABASE=prs92;USER ID=prs92;PASSWORD=prs92;"
            private string _ConnectionString;

            private string _CadSurveyNo;
            private string _MunicipalityPsgc;
            private string _CadCaseNo;
            private string _BarangayPsgc;
            private string _Quadrangle;
            private string _SectionId;
            private string _LotNo;
            private Bitmap _CornerSymbol = null;
            private SharpMap.Map _Map;

            private DataSet ds;
            private SharpMap.Layers.VectorLayer selectedLotLayer = new SharpMap.Layers.VectorLayer("SelectedLotLayer");
            private SharpMap.Layers.LabelLayer selectedLotAreaLabel = new SharpMap.Layers.LabelLayer("SelectedLotLabel");
            private SharpMap.Layers.LabelLayer selectedLotCornerLabel = new SharpMap.Layers.LabelLayer("SelectedLotCornerLabel");
            private SharpMap.Layers.VectorLayer allOtherLotLayer = new SharpMap.Layers.VectorLayer("AllOtherLotLayer");
            private SharpMap.Layers.LabelLayer allOtherLotAreaLabel = new SharpMap.Layers.LabelLayer("OtherLotAreaLabel");

            private struct Features
            {
                public const int SelectedLotCornerFeature = 0;
                public const int SelectedLotAreaFeature = 1;
                public const int OtherLotAreaFeature = 2;
            }


            // Constructor
            public LotData(string connectionString, string cadSurveyNo, string municipalityPsgc, string cadCaseNo, string barangayPsgc, string quadrangle, string sectionId, string lotNo)
            {
                _ConnectionString = connectionString;
                _CadSurveyNo = cadSurveyNo;
                _MunicipalityPsgc = municipalityPsgc;
                _CadCaseNo = cadCaseNo;
                _BarangayPsgc = barangayPsgc;
                _Quadrangle = quadrangle.Replace("'", "''");
                _SectionId = sectionId;
                _LotNo = lotNo;
                _Map = new SharpMap.Map();

                InitFeatureTables();
            }


            // Properties
            public SharpMap.Map Map
            {
                get
                {
                    return _Map;
                }
            }
            public string ConnectionString
            {
                get
                {
                    return _ConnectionString;
                }
                set
                {
                    _ConnectionString = value;
                }
            }
            public Bitmap CornerSymbol
            {
                get
                {
                    return _CornerSymbol;
                }
                set
                {
                    _CornerSymbol = value;
                }
            }
            


            // Methods
            public void ZoomToSelected()
            {
                _Map.ZoomToBox(selectedLotLayer.Envelope);
                _Map.Zoom += 100;
            }
            public void ComposeMap()
            {

                // SELECTED LOT

                // create selected lot layer
                SharpMap.Data.Providers.GeometryProvider selectedLotGeomProvider = new SharpMap.Data.Providers.GeometryProvider(GetSelectedLotGeom());
                selectedLotLayer.DataSource = selectedLotGeomProvider;

                // create selected lot area label layer
                SharpMap.Data.Providers.DataTablePoint selectedLotAreaDataProvider = new SharpMap.Data.Providers.DataTablePoint(ds.Tables[Features.SelectedLotAreaFeature], "FID", "xCoord", "yCoord");

                selectedLotAreaLabel.LabelColumn = "Label";
                selectedLotAreaLabel.DataSource = selectedLotAreaDataProvider;

                // create selected lot corner label layer
                SharpMap.Data.Providers.DataTablePoint selectedLotCornerDataProvider = new SharpMap.Data.Providers.DataTablePoint(ds.Tables[Features.SelectedLotCornerFeature], "FID", "xCoord", "yCoord");

                selectedLotCornerLabel.LabelColumn = "Label";
                selectedLotCornerLabel.DataSource = selectedLotCornerDataProvider;

                selectedLotLayer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                selectedLotLayer.Style.EnableOutline = true;
                selectedLotLayer.Style.Outline = new Pen(Color.FromArgb(78, 188, 77), 3f);
                selectedLotLayer.Style.Fill = new SolidBrush(Color.FromArgb(190, 146, 252, 78));
                selectedLotLayer.Style.Symbol = new Bitmap(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".Symbol.point1.png"));

                selectedLotAreaLabel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                selectedLotAreaLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                selectedLotAreaLabel.Style.Font = new Font("Arial", 15, FontStyle.Bold);

                selectedLotCornerLabel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                selectedLotCornerLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                selectedLotCornerLabel.Style.Font = new Font("Arial", 12);
                selectedLotCornerLabel.Style.Offset = new PointF(10, -10);



                // ALL OTHER LOTS

                // create all other lot layer
                SharpMap.Data.Providers.GeometryProvider otherLotGeomProvider = new SharpMap.Data.Providers.GeometryProvider(GetAllOtherLotGeom());
                allOtherLotLayer.DataSource = otherLotGeomProvider;

                // create all other lot area label layer
                SharpMap.Data.Providers.DataTablePoint otherLotAreaDataProvider = new SharpMap.Data.Providers.DataTablePoint(ds.Tables[Features.OtherLotAreaFeature], "FID", "xCoord", "yCoord");
                allOtherLotAreaLabel.LabelColumn = "Label";
                allOtherLotAreaLabel.DataSource = otherLotAreaDataProvider;
                
                allOtherLotLayer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                allOtherLotLayer.Style.EnableOutline = true;
                allOtherLotLayer.Style.Outline = new Pen(Color.FromArgb(135, 135, 135), 1f);
                allOtherLotLayer.Style.Fill = new SolidBrush(Color.FromArgb(215, 215, 215));
                allOtherLotLayer.Style.EnableOutline = true;

                allOtherLotAreaLabel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                allOtherLotAreaLabel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                allOtherLotAreaLabel.Style.Font = new Font("Arial", 10);
                allOtherLotAreaLabel.Style.ForeColor = Color.FromArgb(125, 0, 0, 0);


                allOtherLotAreaLabel.MaxVisible = 1000;



                // add layers to map
                _Map.Layers.Add(allOtherLotLayer);
                _Map.Layers.Add(allOtherLotAreaLabel);

                _Map.Layers.Add(selectedLotLayer);
                _Map.Layers.Add(selectedLotCornerLabel);
                _Map.Layers.Add(selectedLotAreaLabel);
                

            }
            
            // Helper Methods
            private void InitFeatureTables()
            {
                ds = new DataSet();
                ds.Tables.Add();
                ds.Tables.Add();
                ds.Tables.Add();
                ds.Tables[Features.SelectedLotCornerFeature].Columns.AddRange(new DataColumn[] { new DataColumn("FID",typeof(System.Int32)),
                                                                                                 new DataColumn("xCoord",typeof(System.Double)),
                                                                                                 new DataColumn("yCoord",typeof(System.Double)),
                                                                                                 new DataColumn("Label",typeof(System.String)) });
                ds.Tables[Features.SelectedLotAreaFeature].Columns.AddRange(new DataColumn[] { new DataColumn("FID",typeof(System.Int32)),
                                                                                                 new DataColumn("xCoord",typeof(System.Double)),
                                                                                                 new DataColumn("yCoord",typeof(System.Double)),
                                                                                                 new DataColumn("Label",typeof(System.String)) });
                ds.Tables[Features.OtherLotAreaFeature].Columns.AddRange(new DataColumn[] { new DataColumn("FID",typeof(System.Int32)),
                                                                                                 new DataColumn("xCoord",typeof(System.Double)),
                                                                                                 new DataColumn("yCoord",typeof(System.Double)),
                                                                                                 new DataColumn("Label",typeof(System.String)) });

            }
            private List<SharpMap.Geometries.Geometry> GetSelectedLotGeom()
            {
                List<SharpMap.Geometries.Geometry> retVal = new List<SharpMap.Geometries.Geometry>();
                List<SharpMap.Geometries.Point> lotCorners = new List<SharpMap.Geometries.Point>();
                bool hasValidPoint = false;

                using(SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    string s = String.Format("SELECT * FROM [LotData] WHERE [CadSurveyNo]='{0}' AND [MunicipalityPsgc]='{1}' AND [CadCaseNo]='{2}' AND [BarangayPsgc]='{3}' AND [Quadrangle]='{6}' AND [SectionId] = '{4}' AND [LotNo] = '{5}'", _CadSurveyNo, _MunicipalityPsgc, _CadCaseNo, _BarangayPsgc, _SectionId, _LotNo, _Quadrangle);
                    using (SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM [LotData] WHERE [CadSurveyNo]='{0}' AND [MunicipalityPsgc]='{1}' AND [CadCaseNo]='{2}' AND [BarangayPsgc]='{3}' AND [Quadrangle]='{6}' AND [SectionId] = '{4}' AND [LotNo] = '{5}'", _CadSurveyNo, _MunicipalityPsgc, _CadCaseNo, _BarangayPsgc, _SectionId, _LotNo, _Quadrangle), con))
                    {
                        con.Open();
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {

                                if (reader["ptmX"] != System.DBNull.Value & reader["ptmY"] != System.DBNull.Value)
                                {
                                    hasValidPoint = true;
                                    SharpMap.Geometries.Point lotCorner = new SharpMap.Geometries.Point(Convert.ToDouble(reader["ptmX"]), Convert.ToDouble(reader["ptmY"]));
                                    ds.Tables[Features.SelectedLotCornerFeature].Rows.Add(new object[] { 0, lotCorner.X, lotCorner.Y, reader["Sequence"].ToString() });
                                    lotCorners.Add(lotCorner);
                                }


                                //try
                                //{
                                //    SharpMap.Geometries.Point lotCorner = new SharpMap.Geometries.Point(Convert.ToDouble(reader["ptmX"]), Convert.ToDouble(reader["ptmY"]));
                                //    ds.Tables[Features.SelectedLotCornerFeature].Rows.Add(new object[] { 0, lotCorner.X, lotCorner.Y, reader["Sequence"].ToString() });
                                //    lotCorners.Add(lotCorner);
                                //}
                                //catch (Exception ex)
                                //{
                                //    throw new Exception(ex.Message);
                                //}

                            }

                            //XXX

                            //XXX


                        }
                    }
                }

                if (hasValidPoint)
                {
                    SharpMap.Geometries.Polygon lotArea = new SharpMap.Geometries.Polygon(new SharpMap.Geometries.LinearRing(lotCorners));

                    // record feature info
                    ds.Tables[Features.SelectedLotAreaFeature].Rows.Add(new object[] { 0, lotArea.Centroid.X, lotArea.Centroid.Y, _LotNo });

                    // add area geom
                    retVal.Add(lotArea);

                    // add points geom 
                    foreach (SharpMap.Geometries.Point p in lotCorners)
                    {
                        retVal.Add(p);
                    }
                }
                else
                {
                    List<SharpMap.Geometries.Point> dummyPoints = new List<SharpMap.Geometries.Point>();
                    dummyPoints.Add(new SharpMap.Geometries.Point(0, 0));
                    dummyPoints.Add(new SharpMap.Geometries.Point(0, 0));
                    retVal.Add(new SharpMap.Geometries.Point(0, 0));
                }
                

                return retVal;
            }
            private List<SharpMap.Geometries.Geometry> GetSingleLotGeom(string lotNo)
            {
                List<SharpMap.Geometries.Geometry> retVal = new List<SharpMap.Geometries.Geometry>();
                List<SharpMap.Geometries.Point> lotCorners = new List<SharpMap.Geometries.Point>();

                bool hasValidPoint = false;

                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM [LotData] WHERE [CadSurveyNo]='{0}' AND [MunicipalityPsgc]='{1}' AND [CadCaseNo]='{2}' AND [BarangayPsgc]='{3}' AND [Quadrangle]='{6}' AND [SectionId] = '{4}' AND [LotNo] = '{5}'", _CadSurveyNo, _MunicipalityPsgc, _CadCaseNo, _BarangayPsgc, _SectionId, lotNo, _Quadrangle), con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader["ptmX"] != System.DBNull.Value & reader["ptmY"] != System.DBNull.Value)
                                {
                                    hasValidPoint = true;
                                    SharpMap.Geometries.Point lotCorner = new SharpMap.Geometries.Point(Convert.ToDouble(reader["ptmX"]), Convert.ToDouble(reader["ptmY"]));
                                    lotCorners.Add(lotCorner);
                                }

                                //try
                                //{
                                //    SharpMap.Geometries.Point lotCorner = new SharpMap.Geometries.Point(Convert.ToDouble(reader["ptmX"]), Convert.ToDouble(reader["ptmY"]));
                                //    lotCorners.Add(lotCorner);
                                //}
                                //catch (Exception ex)
                                //{
                                //    //throw new Exception(ex.Message);
                                //}

                            }
                        }
                    }
                }

                SharpMap.Geometries.Polygon lotArea = new SharpMap.Geometries.Polygon(new SharpMap.Geometries.LinearRing(lotCorners));

                if (hasValidPoint)
                {
                    // record feature info
                    ds.Tables[Features.OtherLotAreaFeature].Rows.Add(new object[] { 0, lotArea.Centroid.X, lotArea.Centroid.Y, lotNo });

                    // add area geom
                    retVal.Add(lotArea);
                }

                return retVal;
            }
            private List<SharpMap.Geometries.Geometry> GetAllOtherLotGeom()
            {
                List<SharpMap.Geometries.Geometry> retVal = new List<SharpMap.Geometries.Geometry>();
                List<SharpMap.Geometries.Point> lotPoints = new List<SharpMap.Geometries.Point>();

                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand cmdLot = new SqlCommand(String.Format("SELECT [CadSurveyNo],[MunicipalityPsgc],[CadCaseNo],[BarangayPsgc],[SectionId],[LotNo] FROM [Lot] WHERE [CadSurveyNo]='{0}' AND [MunicipalityPsgc]='{1}' AND [CadCaseNo]='{2}' AND [BarangayPsgc]='{3}' AND [Quadrangle]='{6}' AND [SectionId] = '{4}' AND NOT [LotNo]='{5}'", _CadSurveyNo, _MunicipalityPsgc, _CadCaseNo, _BarangayPsgc, _SectionId, _LotNo, _Quadrangle), con))
                    {
                        con.Open();

                        using (SqlDataReader readerLot = cmdLot.ExecuteReader())
                        {
                            while (readerLot.Read())
                            {
                                List<SharpMap.Geometries.Geometry> lots = GetSingleLotGeom(readerLot["LotNo"].ToString());
                                //Console.WriteLine(String.Format("{0} = {1}", readerLot["LotNo"].ToString(), x.ToString()));
                                foreach (SharpMap.Geometries.Geometry lot in lots)
                                {
                                    retVal.Add(lot);
                                }

                            }
                        }
                    }
                }

                return retVal;
            }
        }
        
        public class TechDesc
        {
            private string _ConnectionString;

            private string _CadSurveyNo;
            private string _MunicipalityPsgc;
            private string _CadCaseNo;
            private string _BarangayPsgc;
            private string _Quadrangle;
            private string _SectionId;
            private string _LotNo;

            private SharpMap.Map _Map = new SharpMap.Map();


            // Constructor
            public TechDesc(string connectionString, string cadSurveyNo, string municipalityPsgc, string cadCaseNo, string barangayPsgc, string quadrangle, string sectionId, string lotNo)
            {
                _ConnectionString = connectionString;
                _CadSurveyNo = cadSurveyNo;
                _MunicipalityPsgc = municipalityPsgc;
                _CadCaseNo = cadCaseNo;
                _BarangayPsgc = barangayPsgc;
                _Quadrangle = quadrangle.Replace("'", "''");
                _SectionId = sectionId;
                _LotNo = lotNo;
                _Map = new SharpMap.Map();

            }

            // Properties
            public SharpMap.Map Map
            {
                get
                {
                    return _Map;
                }
            }
            public string ConnectionString
            {
                get
                {
                    return _ConnectionString;
                }
                set
                {
                    _ConnectionString = value;
                }
            }

            // Methods
            public void ComposeMap()
            {

                DataTable featureDataTable = new DataTable();
                featureDataTable.Columns.AddRange(new DataColumn[] { new DataColumn("FID",typeof(System.Int32)),
                                                                     new DataColumn("xCoord",typeof(System.Double)),
                                                                     new DataColumn("yCoord",typeof(System.Double)),
                                                                     new DataColumn("Label",typeof(System.String)) });

                // will hold tie point and tie line
                List<SharpMap.Geometries.Geometry> tiePointLineGeom = new List<SharpMap.Geometries.Geometry>();

                // will hold all points
                List<SharpMap.Geometries.Geometry> pointGeoms = new List<SharpMap.Geometries.Geometry>();

                // will hold all lines
                List<SharpMap.Geometries.Geometry> lineGeoms = new List<SharpMap.Geometries.Geometry>();


                // fore remembering last read corner
                SharpMap.Geometries.Point lastReadCorner = new SharpMap.Geometries.Point(0, 0);

                bool hasTP = false;


                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(String.Format("SELECT TieLineNS, TieLineEW, TieLineDegree, TieLineMinute, TieLineDistance, ReferencePoint FROM [Lot] WHERE [CadSurveyNo]='{0}' AND [MunicipalityPsgc]='{1}' AND [CadCaseNo]='{2}' AND [BarangayPsgc]='{3}' AND [Quadrangle]='{6}' AND [SectionId] = '{4}' AND [LotNo] = '{5}'", _CadSurveyNo, _MunicipalityPsgc, _CadCaseNo, _BarangayPsgc, _SectionId, _LotNo, _Quadrangle), con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                hasTP = (reader["ReferencePoint"] != System.DBNull.Value);

                                string heading = reader["TieLineNS"].ToString();
                                string bearing = reader["TieLineEW"].ToString();
                                double x = 0;
                                double y = 0;
                                int degree = Convert.ToInt32(handleNull(reader["TieLineDegree"], 0));
                                int minute = Convert.ToInt32(handleNull(reader["TieLineMinute"], 0));
                                double distance = Convert.ToDouble(handleNull(reader["TieLineDistance"], 0));

                                SharpMap.Geometries.Point tiePoint = new SharpMap.Geometries.Point(x, y);

                                // remember corner 1
                                lastReadCorner = NextPoint(x, y, heading, bearing, degree, minute, distance);
                                if (hasTP)
                                    pointGeoms.Add(lastReadCorner);

                                // tie point to corner 1
                                SharpMap.Geometries.LineString lineSegment = Line(tiePoint, lastReadCorner);
                                tiePointLineGeom.Add(lineSegment);

                                if (hasTP)
                                {
                                    
                                    tiePointLineGeom.Add(tiePoint);
                                    featureDataTable.Rows.Add(new object[] { 0, tiePoint.X, tiePoint.Y, "TP"});
                                }
                                    
                            }
                        }
                    }
                }


                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM [TechDesc] WHERE [CadSurveyNo]='{0}' AND [MunicipalityPsgc]='{1}' AND [CadCaseNo]='{2}' AND [BarangayPsgc]='{3}' AND [SectionId] = '{4}' AND [LotNo] = '{5}'", _CadSurveyNo, _MunicipalityPsgc, _CadCaseNo, _BarangayPsgc, _SectionId, _LotNo), con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string heading = reader["NS"].ToString().Trim();
                                string bearing = reader["EW"].ToString().Trim();
                                double x = lastReadCorner.X;
                                double y = lastReadCorner.Y;
                                int degree = Convert.ToInt32(handleNull(reader["Degree"], 0)); ;
                                int minute = Convert.ToInt32(handleNull(reader["Minute"], 0)); ;
                                double distance = Convert.ToDouble(handleNull(reader["Distance"], 0));

                                SharpMap.Geometries.Point nextCorner = NextPoint(x, y, heading, bearing, degree, minute, distance);


                                featureDataTable.Rows.Add(new object[] { 0, lastReadCorner.X, lastReadCorner.Y, reader["FromCorner"].ToString() });

                                // last read corner to next corner
                                SharpMap.Geometries.LineString lineSegment = Line(lastReadCorner, nextCorner);
                                lineGeoms.Add(lineSegment);
                                pointGeoms.Add(lastReadCorner);
                                lastReadCorner = nextCorner;
                                

                                    

                            }
                        }
                    }
                }


                // tie point and line
                SharpMap.Data.Providers.GeometryProvider tiePointLineGeomProvider = new SharpMap.Data.Providers.GeometryProvider(tiePointLineGeom);
                SharpMap.Layers.VectorLayer tiePointLineLayer = new SharpMap.Layers.VectorLayer("TiePointLineLayer");
                tiePointLineLayer.DataSource = tiePointLineGeomProvider;

                // line
                SharpMap.Data.Providers.GeometryProvider lineGeomProvider = new SharpMap.Data.Providers.GeometryProvider(lineGeoms);
                SharpMap.Layers.VectorLayer lineLayer = new SharpMap.Layers.VectorLayer("LineLayer");
                lineLayer.DataSource = lineGeomProvider;

                // point
                SharpMap.Data.Providers.GeometryProvider pointGeomProvider = new SharpMap.Data.Providers.GeometryProvider(pointGeoms);
                SharpMap.Layers.VectorLayer pointLayer = new SharpMap.Layers.VectorLayer("PointLayer");
                pointLayer.DataSource = pointGeomProvider;


                // label
                SharpMap.Data.Providers.DataTablePoint labelDataProvider = new SharpMap.Data.Providers.DataTablePoint(featureDataTable, "FID", "xCoord", "yCoord");
                SharpMap.Layers.LabelLayer labelLayer = new SharpMap.Layers.LabelLayer("LabelLayer");
                labelLayer.LabelColumn = "Label";
                labelLayer.DataSource = labelDataProvider;


                // format tie point and line
                Pen tieLinePen = new Pen(Color.Red);
                tieLinePen.DashPattern = new float[] { 5, 10 };
                tiePointLineLayer.Style.Line = tieLinePen;
                tiePointLineLayer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                tiePointLineLayer.Style.Symbol = new Bitmap(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".Symbol.point1.png")); ;

                // format point
                lineLayer.Style.Line = new Pen(Color.Lime, 3f);


                // format line
                pointLayer.Style.Symbol = new Bitmap(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".Symbol.point1.png")); ;


                // format label
                labelLayer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                labelLayer.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                labelLayer.Style.Font = new Font("Arial", 12);
                labelLayer.Style.Offset = new PointF(10f, -10f);

                _Map.Layers.Add(tiePointLineLayer);
                _Map.Layers.Add(lineLayer);
                _Map.Layers.Add(pointLayer);
                _Map.Layers.Add(labelLayer);


                _Map.ZoomToExtents();
                _Map.Zoom += 500;

            }

            // Helper Method
            object handleNull(object value, object defaultValue)
            {
                if (value == System.DBNull.Value)
                {
                    return defaultValue;
                }
                else
                {
                    return value;
                }
            }
            private SharpMap.Geometries.LineString Line(SharpMap.Geometries.Point startPoint, SharpMap.Geometries.Point endPoint)
            {
                List<SharpMap.Geometries.Point> points = new List<SharpMap.Geometries.Point>();
                points.Add(startPoint);
                points.Add(endPoint);
                return new SharpMap.Geometries.LineString(points);
            }
            private SharpMap.Geometries.Point NextPoint(double startX, double startY, string heading, string bearing, int degree, int minute, double distance)
            {
                double DEG2RAD = 4 * Math.Atan(1) / 180;
                double azimuth = degree + (minute / 60);

                string hb = heading + bearing;

                switch (hb)
                {
                    case "NE":
                        // do nothing
                        break;
                    case "NW":
                        azimuth = 0 - azimuth;
                        break;
                    case "SE":
                        azimuth = 180 - azimuth;
                        break;
                    case "SW":
                        azimuth = -180 + azimuth;
                        break;
                    default:
                        azimuth = 0;
                        break;
                }

                azimuth = azimuth * DEG2RAD;

                double endX = startX + Math.Sin(azimuth) * distance;
                double endY = startY + Math.Cos(azimuth) * distance;

                return new SharpMap.Geometries.Point(endX, endY);
            }

        }

    }

    



}
