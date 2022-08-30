using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Explicit,CharSet = CharSet.Ansi, Size = DEVMODEA.Length)]
    public struct DEVMODEA
    {
        public const int Length = 156;

        [FieldOffset(0)]
        public unsafe fixed byte dmDeviceName[32]; //32
        [FieldOffset(32)]
        public ushort dmSpecVersion;
        [FieldOffset(34)]
        public ushort dmDriverVersion;
        [FieldOffset(36)]
        public ushort dmSize;
        [FieldOffset(38)]
        public ushort dmDriverExtra;
        [FieldOffset(40)]
        public uint dmFields;

        // start 44
        [FieldOffset(44)]
        public short dmOrientation; // 2
        [FieldOffset(46)]
        public short dmPaperSize;  //2
        [FieldOffset(48)]
        public short dmPaperLength; //2
        [FieldOffset(50)]
        public short dmPaperWidth; //2
        [FieldOffset(52)]
        public short dmScale; //2
        [FieldOffset(54)]
        public short dmCopies; //2
        [FieldOffset(56)]
        public short dmDefaultSource; //2
        [FieldOffset(58)]
        public short dmPrintQuality; //2

        // start 44
        [FieldOffset(44)]
        public POINT dmPosition; // 8
        [FieldOffset(52)]
        public uint dmDisplayOrientation; //4
        [FieldOffset(56)]
        public uint dmDisplayFixedOutput;  //4

        // start 60
        [FieldOffset(60)]
        public short dmColor; // 2
        [FieldOffset(62)]
        public short dmDuplex; // 2
        [FieldOffset(64)]
        public short dmYResolution; // 2
        [FieldOffset(66)]
        public short dmTTOption; // 2
        [FieldOffset(68)]
        public short dmCollate; //2

        [FieldOffset(70)]
        public unsafe fixed byte dmFormName[32]; // 32

        [FieldOffset(102)]
        public ushort dmLogPixels; //2
        [FieldOffset(104)]
        public uint dmBitsPerPel; //4
        [FieldOffset(108)]
        public uint dmPelsWidth; //4
        [FieldOffset(112)]
        public uint dmPelsHeight; //4

        [FieldOffset(116)]
        public uint dmDisplayFlags; //4
        [FieldOffset(116)]
        public uint dmNup; //4

        [FieldOffset(120)]
        public uint dmDisplayFrequency; //4
        [FieldOffset(124)]
        public uint dmICMMethod; //4
        [FieldOffset(128)]
        public uint dmICMIntent; //4
        [FieldOffset(132)]
        public uint dmMediaType; //4
        [FieldOffset(136)]
        public uint dmDitherType; //4
        [FieldOffset(140)]
        public uint dmReserved1; //4
        [FieldOffset(144)]
        public uint dmReserved2; //4
        [FieldOffset(148)]
        public uint dmPanningWidth; //4
        [FieldOffset(152)]
        public uint dmPanningHeight; //4
    }

}
