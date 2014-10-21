﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WoWMap.Chunks
{
    public class MVER
    {
        public uint Version;

        public void Read(BinaryReader br)
        {
            Version = br.ReadUInt32();
        }
    }
}