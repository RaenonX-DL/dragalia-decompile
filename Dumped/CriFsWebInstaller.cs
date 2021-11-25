using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class CriFsWebInstaller : CriDisposable
{
	public enum Status
	{
		Stop,
		Busy,
		Complete,
		Error
	}

	public enum Error
	{
		None,
		Timeout,
		Memory,
		LocalFs,
		DNS,
		Connection,
		SSL,
		HTTP,
		Internal
	}

	public struct StatusInfo
	{
		public Status status;

		public Error error;

		public int httpStatusCode;

		public long contentsSize;

		public long receivedSize;
	}

	public struct ModuleConfig
	{
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
		public byte reserved;

		public static ModulePlatformConfig defaultConfig => default(ModulePlatformConfig);
	}

	public const int InvalidHttpStatusCode = -1;

	public const long InvalidContentsSize = -1L;

	private IntPtr handle;

	public static bool isInitialized
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool isCrcEnabled
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static ModuleConfig defaultModuleConfig => default(ModuleConfig);

	~CriFsWebInstaller()
	{
	}

	public override void Dispose()
	{
	}

	public void Copy(string url, string dstPath)
	{
	}

	public void Stop()
	{
	}

	public StatusInfo GetStatusInfo()
	{
		return default(StatusInfo);
	}

	public bool GetCRC32(out uint ret_val)
	{
		return default(bool);
	}

	public static void InitializeModule(ModuleConfig config)
	{
	}

	public static void FinalizeModule()
	{
	}

	public static void ExecuteMain()
	{
	}

	public static bool SetRequestHeader(string field, string value)
	{
		return default(bool);
	}

	private void Dispose(bool disposing)
	{
	}

	private static extern int criFsWebInstaller_Initialize([In] ref ModuleConfig config);

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
