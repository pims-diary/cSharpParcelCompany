using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcelCompany.DataLinkLayer.Models
{
    public enum ContainerType
    {
        Drum,
        Box,
        Palette,
        Receptacle
    }

    public enum VesselSize
    {
        Small,
        Medium,
        Large
    }

    public class ContainerDetails
    {
        public ContainerType containerType { get; set; }
        public VesselSize vesselSize { get; set; }
        public string parcelCost { get; set; }
    }
}
