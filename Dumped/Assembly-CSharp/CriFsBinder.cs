/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsBinder : CriDisposable
{
	// Fields
	private IntPtr handle;

	// Properties
	public IntPtr nativeHandle { get; }

	// Nested types
	public enum Status
	{
		None = 0,
		Analyze = 1,
		Complete = 2,
		Unbind = 3,
		Removed = 4,
		Invalid = 5,
		Error = 6
	}

	public struct ContentsFileInfo
	{
		// Fields
		public readonly string directory;
		public readonly string fileName;
		public uint readSize;
		public uint extractSize;
		public ulong offset;
		public int fileId;
		private string userStr;

		// Constructors
		public ContentsFileInfo(byte[] data, int startIndex);
	}

	// Constructors
	public CriFsBinder();

	// Methods
	public override void Dispose();
	private void Dispose(bool disposing);
	public uint BindCpk(CriFsBinder srcBinder, string path);
	public uint BindDirectory(CriFsBinder srcBinder, string path);
	public uint BindFile(CriFsBinder srcBinder, string path);
	public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName);
	public static void Unbind(uint bindId);
	public static Status GetStatus(uint bindId);
	public long GetFileSize(string path);
	public long GetFileSize(int id);
	public bool GetContentsFileInfo(string path, out ContentsFileInfo info);
	public bool GetContentsFileInfo(int id, out ContentsFileInfo info);
	public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out ContentsFileInfo[] info);
	public static int GetNumContentsFiles(uint bindId);
	public static void SetPriority(uint bindId, int priority);
	~CriFsBinder();
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

