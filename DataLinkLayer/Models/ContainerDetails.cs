using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcelCompany.DataLinkLayer.Models
{
    enum ContainerType
    {
        Drum,
        Box,
        Palette,
        Receptacle
    }

    enum VesselSize
    {
        OneKG,
        TwoKG,
        ThreeKG,
        FiveKG,
        TenKG,
        FifteenKg,
        TwentyKG,
        TwentyFiveKG
    }

    internal class ContainerDetails
    {
        public ContainerType containerType { get; set; }
        public VesselSize vesselSize { get; set; }
        public string parcelCost { get; set; }
    }
}
