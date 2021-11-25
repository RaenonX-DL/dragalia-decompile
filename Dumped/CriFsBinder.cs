using System;

public class CriFsBinder : CriDisposable
{
	public enum Status
	{
		None,
		Analyze,
		Complete,
		Unbind,
		Removed,
		Invalid,
		Error
	}

	public struct ContentsFileInfo
	{
		public readonly string directory;

		public readonly string fileName;

		public uint readSize;

		public uint extractSize;

		public ulong offset;

		public int fileId;

		private string userStr;

		public ContentsFileInfo(byte[] data, int startIndex)
		{
		}
	}

	private IntPtr handle;

	public IntPtr nativeHandle => default(IntPtr);

	public override void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}

	public uint BindCpk(CriFsBinder srcBinder, string path)
	{
		return default(uint);
	}

	public uint BindDirectory(CriFsBinder srcBinder, string path)
	{
		return default(uint);
	}

	public uint BindFile(CriFsBinder srcBinder, string path)
	{
		return default(uint);
	}

	public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName)
	{
		return default(uint);
	}

	public static void Unbind(uint bindId)
	{
	}

	public static Status GetStatus(uint bindId)
	{
		return default(Status);
	}

	public long GetFileSize(string path)
	{
		return default(long);
	}

	public long GetFileSize(int id)
	{
		return default(long);
	}

	public bool GetContentsFileInfo(string path, out ContentsFileInfo info)
	{
		return default(bool);
	}

	public bool GetContentsFileInfo(int id, out ContentsFileInfo info)
	{
		return default(bool);
	}

	public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info)
	{
		return default(bool);
	}

	public static int GetNumContentsFiles(uint bindId)
	{
		return default(int);
	}

	public static void SetPriority(uint bindId, int priority)
	{
	}

	~CriFsBinder()
	{
	}

	private static extern uint criFsBinder_Create(out IntPtr binder);

	private static extern uint criFsBinder_Destroy(IntPtr binder);

	private static extern uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId);

	private static extern uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId);

	private static extern uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId);

	private static extern uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId);

	private static extern int criFsBinder_Unbind(uint bindId);

	private static extern int criFsBinder_GetStatus(uint bindId, out Status status);

	private static extern int criFsBinder_GetFileSize(IntPtr binder, string path, out long size);

	private static extern int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size);

	private static extern int criFsBinder_SetPriority(uint bindId, int priority);

	private static extern int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info);

	private static extern int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info);

	private static extern int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num);

	private static extern int CRIWARE0CF3A524(uint id);
}
