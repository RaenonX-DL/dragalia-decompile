/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriAtomExAcbLoader : CriDisposable
{
	// Fields
	private IntPtr handle;
	private byte[] data;

	// Nested types
	public enum Status
	{
		Stop = 0,
		Loading = 1,
		Complete = 2,
		Error = 3
	}

	private struct LoaderConfig
	{
		// Fields
		public bool shouldLoadAwbOnMemory;
	}

	// Constructors
	private CriAtomExAcbLoader(IntPtr handle, byte[] data);

	// Methods
	public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false);
	public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false);
	public Status GetStatus();
	public CriAtomExAcb MoveAcb();
	public override void Dispose();
	private void Dispose(bool disposing);
	~CriAtomExAcbLoader();
	private static extern IntPtr criAtomExAcbLoader_Create(in LoaderConfig config);
	private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader);
	private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path);
	private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, byte[] acb_data, int acb_size, IntPtr awb_binder, string awb_path);
	private static extern Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader);
	private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader);
	private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader);
}

