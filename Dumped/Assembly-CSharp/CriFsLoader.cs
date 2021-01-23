/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsLoader : CriDisposable
{
	// Fields
	private IntPtr handle;
	private GCHandle dstGch;
	private GCHandle srcGch;

	// Nested types
	public enum Status
	{
		Stop = 0,
		Loading = 1,
		Complete = 2,
		Error = 3
	}

	// Constructors
	public CriFsLoader();

	// Methods
	public override void Dispose();
	private void Dispose(bool disposing);
	public void Load(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer);
	public void LoadById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer);
	public void LoadWithoutDecompression(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer);
	public void LoadWithoutDecompressionById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer);
	public void DecompressData(long srcSize, byte[] srcBuffer, long dstSize, byte[] dstBuffer);
	public void Stop();
	public Status GetStatus();
	public void SetReadUnitSize(int unit_size);
	~CriFsLoader();
	private static extern int criFsLoader_Create(out IntPtr loader);
	private static extern int criFsLoader_Destroy(IntPtr loader);
	private static extern int criFsLoader_Load(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size);
	private static extern int criFsLoader_LoadById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size);
	private static extern int criFsLoader_Stop(IntPtr loader);
	private static extern int criFsLoader_GetStatus(IntPtr loader, out Status status);
	private static extern int criFsLoader_SetReadUnitSize(IntPtr loader, long unit_size);
	private static extern int criFsLoader_LoadWithoutDecompression(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size);
	private static extern int criFsLoader_LoadWithoutDecompressionById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size);
	private static extern int criFsLoader_DecompressData(IntPtr loader, IntPtr src, long src_size, IntPtr dst, long dst_size);
}

