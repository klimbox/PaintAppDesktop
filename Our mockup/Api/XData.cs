using System.Drawing;

namespace Our_mockup.Api
{
    public class XData
    {
        public int StrockeWidth { get; set; }
        public Color StrockeColor { get; set; }
        public string FigureType { get; set; }
        public string Text { get; set; }
        public Font FontText { get; set; }
        public Color ColorText { get; set; }
        public Point pointText { get; set; }
        public XData()
        {
            StrockeWidth = 1;
            StrockeColor = Color.Black;
            FigureType = "Rectangle";
            Text = "";
            ColorText = Color.Black;
            FontText = new Font("GenericMonospace", 8);
        }
    }
}
