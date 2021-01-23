/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsInstaller : CriDisposable
{
	// Fields
	private byte[] installBuffer;
	private GCHandle installBufferGch;
	private IntPtr handle;

	// Nested types
	public enum Status
	{
		Stop = 0,
		Busy = 1,
		Complete = 2,
		Error = 3
	}

	private enum CopyPolicy
	{
		Always = 0
	}

	// Constructors
	public CriFsInstaller();

	// Methods
	public override void Dispose();
	private void Dispose(bool disposing);
	public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize);
	public void Stop();
	public Status GetStatus();
	public float GetProgress();
	public static void ExecuteMain();
	~CriFsInstaller();
	private static extern int criFsInstaller_ExecuteMain();
	private static extern int criFsInstaller_Create(out IntPtr installer, CopyPolicy option);
	private static extern int criFsInstaller_Destroy(IntPtr installer);
	private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size);
	private static extern int criFsInstaller_Stop(IntPtr installer);
	private static extern int criFsInstaller_GetStatus(IntPtr installer, out Status status);
	private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress);
}

