using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPicture
{
    public partial class GraphForm : PlotForm
    {
        
        internal static List<int> RedPix { get; set; }
        internal static List<int> GreenPix { get; set; }
        internal static List<int> BluePix { get; set; }

        internal static List<int> Temperature { get; set; }

        public GraphForm(List<int> redPix, List<int> greenPix, List<int> bluePix, List<int> temperature)
        {
            RedPix = redPix;
            GreenPix = greenPix;
            BluePix = bluePix;
            Temperature = temperature;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(434, 409);
            this.Name = "GraphForm";
            this.Text = "Plot";
            this.ResumeLayout(false);

        }
    }

    public partial class GraphFormBack : PlotForm
    {
        internal static List<int> RedPix { get; set; }
        internal static List<int> GreenPix { get; set; }
        internal static List<int> BluePix { get; set; }

        public GraphFormBack(List<int> redPix, List<int> greenPix, List<int> bluePix)
        {
            RedPix = redPix;
            GreenPix = greenPix;
            BluePix = bluePix;
        }
    }

    public partial class DevGraphForm : PlotForm
    {
        internal static List<int> RedPix { get; set; }
        internal static List<int> GreenPix { get; set; }
        internal static List<int> BluePix { get; set; }


        public DevGraphForm(List<int> redPix, List<int> greenPix, List<int> bluePix)
        {
            RedPix = redPix;
            GreenPix = greenPix;
            BluePix = bluePix;
        }
    }

    public partial class DevGraphFormBack : PlotForm
    {
        internal static List<int> RedPix { get; set; }
        internal static List<int> GreenPix { get; set; }
        internal static List<int> BluePix { get; set; }

        public DevGraphFormBack(List<int> redPix, List<int> greenPix, List<int> bluePix)
        {
            RedPix = redPix;
            GreenPix = greenPix;
            BluePix = bluePix;
        }
    }

}
