using IlyfairyLib.WinApi.Attributes;
using System;
using System.Runtime.InteropServices;

namespace IlyfairyLib.WinApi.User32
{
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode, Size = DEVMODEW.Length)]
    [DEVMODEW]
    public struct DEVMODEW
    {
        public const int Length = 220;

        [FieldOffset(0)]
        public unsafe fixed char dmDeviceName[32];
        [FieldOffset(64)]
        public ushort dmSpecVersion;
        [FieldOffset(66)]
        public ushort dmDriverVersion;
        [FieldOffset(68)]
        public ushort dmSize;
        [FieldOffset(70)]
        public ushort dmDriverExtra;
        [FieldOffset(72)]
        public uint dmFields;

        // start 76
        [FieldOffset(76)]
        public short dmOrientation; // 2
        [FieldOffset(78)]
        public short dmPaperSize;  //2
        [FieldOffset(80)]
        public short dmPaperLength; //2
        [FieldOffset(82)]
        public short dmPaperWidth; //2
        [FieldOffset(84)]
        public short dmScale; //2
        [FieldOffset(86)]
        public short dmCopies; //2
        [FieldOffset(88)]
        public short dmDefaultSource; //2
        [FieldOffset(90)]
        public short dmPrintQuality; //2

        //start 76
        [FieldOffset(76)]
        public POINT dmPosition; // 8
        [FieldOffset(84)]
        public uint dmDisplayOrientation; //4
        [FieldOffset(88)]
        public uint dmDisplayFixedOutput;  //4

        // start 92
        [FieldOffset(92)]
        public short dmColor; // 2
        [FieldOffset(94)]
        public short dmDuplex; // 2
        [FieldOffset(96)]
        public short dmYResolution; // 2
        [FieldOffset(98)]
        public short dmTTOption; // 2
        [FieldOffset(100)]
        public short dmCollate; //2

        [FieldOffset(102)]
        public unsafe fixed char dmFormName[32];

        [FieldOffset(166)]
        public ushort dmLogPixels; //2
        [FieldOffset(168)]
        public uint dmBitsPerPel; //4
        [FieldOffset(172)]
        public uint dmPelsWidth; //4
        [FieldOffset(176)]
        public uint dmPelsHeight; //4

        [FieldOffset(180)]
        public uint dmDisplayFlags; //4
        [FieldOffset(180)]
        public uint dmNup; //4

        [FieldOffset(184)]
        public uint dmDisplayFrequency; //4
        [FieldOffset(188)]
        public uint dmICMMethod; //4
        [FieldOffset(192)]
        public uint dmICMIntent; //4
        [FieldOffset(196)]
        public uint dmMediaType; //4
        [FieldOffset(200)]
        public uint dmDitherType; //4
        [FieldOffset(204)]
        public uint dmReserved1; //4
        [FieldOffset(208)]
        public uint dmReserved2; //4
        [FieldOffset(212)]
        public uint dmPanningWidth; //4
        [FieldOffset(216)]
        public uint dmPanningHeight; //4
    }
}
