﻿using System.Drawing;
using TCI.Model.Resource;

namespace TCI.Model.Types.Station
{
    public class Dlc : Station
    {
        public override bool HaveCableRoom => false;
        public override bool HaveOcdf => true;
        public override Image Image => ImageResource.Dlc;
    }
}
