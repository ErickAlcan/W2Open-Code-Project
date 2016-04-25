﻿using System.Runtime.InteropServices;
using W2Open.Common.GameStructure;

namespace W2Open.Common.IncomingPacketStructure
{
    /// <summary>
    /// A simple ping packet sent periodically from the client to maintain the connection with the server active.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = ProjectBasics.DEFAULT_PACK)]
    public struct MPingPacket : IGamePacket
    {
        public const ushort Opcode = 0x3A0;

        public MPacketHeader Header { get; set; }
    }
}