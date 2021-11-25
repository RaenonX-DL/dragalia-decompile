using System;
using System.Runtime.InteropServices;

public class CriFsInstaller : CriDisposable
{
	public enum Status
	{
		Stop,
		Busy,
		Complete,
		Error
	}

	private enum CopyPolicy
	{
		Always
	}

	private byte[] installBuffer;

	private GCHandle installBufferGch;

	private IntPtr handle;

	public override void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize)
	{
	}

	public void Stop()
	{
	}

	public Status GetStatus()
	{
		return default(Status);
	}

	public float GetProgress()
	{
		return default(float);
	}

	public static void ExecuteMain()
	{
	}

	~CriFsInstaller()
	{
	}

	private static extern int criFsInstaller_ExecuteMain();

	private static extern int criFsInstaller_Create(out IntPtr installer, CopyPolicy option);

	private static extern int criFsInstaller_Destroy(IntPtr installer);

	private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size);

	private static extern int criFsInstaller_Stop(IntPtr installer);

	private static extern int criFsInstaller_GetStatus(IntPtr installer, out Status status);

	private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress);
}
