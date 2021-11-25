using System;
using System.Runtime.InteropServices;

public class CriAtomExAcbLoader : CriDisposable
{
	public enum Status
	{
		Stop,
		Loading,
		Complete,
		Error
	}

	private struct LoaderConfig
	{
		public bool shouldLoadAwbOnMemory;
	}

	private IntPtr handle;

	private byte[] data;

	public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false)
	{
		return null;
	}

	public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false)
	{
		return null;
	}

	public Status GetStatus()
	{
		return default(Status);
	}

	public CriAtomExAcb MoveAcb()
	{
		return null;
	}

	public override void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	private CriAtomExAcbLoader(IntPtr handle, byte[] data)
	{
	}

	~CriAtomExAcbLoader()
	{
	}

	private static extern IntPtr criAtomExAcbLoader_Create([In] ref LoaderConfig config);

	private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader);

	private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path);

	private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, byte[] acb_data, int acb_size, IntPtr awb_binder, string awb_path);

	private static extern Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader);

	private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader);

	private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader);
}
