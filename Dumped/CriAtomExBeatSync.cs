using System;
using System.Runtime.InteropServices;

public static class CriAtomExBeatSync
{
	public struct Info
	{
		public IntPtr playerHn;

		public uint playbackId;

		public uint barCount;

		public uint beatCount;

		public float beatProgress;

		public float bpm;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CbFunc(ref Info info);

	public static void SetCallback(CbFunc func)
	{
	}
}
