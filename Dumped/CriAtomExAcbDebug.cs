using System;

public static class CriAtomExAcbDebug
{
	public struct AcbInfo
	{
		public string name;

		public uint size;

		public uint version;

		public CriAtomEx.CharacterEncoding characterEncoding;

		public float volume;

		public int numCues;
	}

	private struct AcbInfoForMarshaling
	{
		public IntPtr namePtr;

		public uint size;

		public uint version;

		public CriAtomEx.CharacterEncoding characterEncoding;

		public float volume;

		public int numCues;

		public void Convert(out AcbInfo x)
		{
		}
	}

	public static bool GetAcbInfo(CriAtomExAcb acb, out AcbInfo acbInfo)
	{
		return default(bool);
	}

	private static extern int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out AcbInfoForMarshaling acbInfo);
}
