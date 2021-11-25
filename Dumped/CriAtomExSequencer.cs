using System.Runtime.InteropServices;

public static class CriAtomExSequencer
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EventCbFunc(string eventParamsString);

	public static void SetEventCallback(EventCbFunc func, string separator = "\t")
	{
	}
}
