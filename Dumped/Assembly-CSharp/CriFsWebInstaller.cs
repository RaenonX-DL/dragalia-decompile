/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CriFsWebInstaller : CriDisposable
{
	// Fields
	[CompilerGenerated]
	private static bool _isInitialized_k__BackingField;
	[CompilerGenerated]
	private static bool _isCrcEnabled_k__BackingField;
	public const int InvalidHttpStatusCode = -1;
	public const long InvalidContentsSize = -1;
	private IntPtr handle;

	// Properties
	public static bool isInitialized { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public static bool isCrcEnabled { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public static ModuleConfig defaultModuleConfig { get; }

	// Nested types
	public enum Status
	{
		Stop = 0,
		Busy = 1,
		Complete = 2,
		Error = 3
	}

	public enum Error
	{
		None = 0,
		Timeout = 1,
		Memory = 2,
		LocalFs = 3,
		DNS = 4,
		Connection = 5,
		SSL = 6,
		HTTP = 7,
		Internal = 8
	}

	public struct StatusInfo
	{
		// Fields
		public Status status;
		public Error error;
		public int httpStatusCode;
		public long contentsSize;
		public long receivedSize;
	}

	public struct ModuleConfig
	{
		// Fields
		public uint numInstallers;
		public string proxyHost;
		public ushort proxyPort;
		public string userAgent;
		public uint inactiveTimeoutSec;
		public bool allowInsecureSSL;
		public bool crcEnabled;
		public ModulePlatformConfig platformConfig;
	}

	public struct ModulePlatformConfig
	{
		// Fields
		public byte reserved;

		// Properties
		public static ModulePlatformConfig defaultConfig { get; }
	}

	// Constructors
	public CriFsWebInstaller();

	// Methods
	~CriFsWebInstaller();
	public override void Dispose();
	public void Copy(string url, string dstPath);
	public void Stop();
	public StatusInfo GetStatusInfo();
	public bool GetCRC32(out uint ret_val);
	public static void InitializeModule(ModuleConfig config);
	public static void FinalizeModule();
	public static void ExecuteMain();
	public static bool SetRequestHeader(string field, string value);
	private void Dispose(bool disposing);
	private static extern int criFsWebInstaller_Initialize(in ModuleConfig config);
	private static extern int criFsWebInstaller_Finalize();
	private static extern int criFsWebInstaller_ExecuteMain();
	private static extern int criFsWebInstaller_Create(out IntPtr installer);
	private static extern int criFsWebInstaller_Destroy(IntPtr installer);
	private static extern int criFsWebInstaller_Copy(IntPtr installer, string url, string dstPath);
	private static extern int criFsWebInstaller_Stop(IntPtr installer);
	private static extern int criFsWebInstaller_GetStatusInfo(IntPtr installer, out StatusInfo status);
	private static extern int criFsWebInstaller_GetCRC32(IntPtr installer, out uint crc32);
	private static extern int criFsWebInstaller_SetRequestHeader(string field, string value);
}

