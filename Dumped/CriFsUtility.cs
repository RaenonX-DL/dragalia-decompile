public static class CriFsUtility
{
	public const int DefaultReadUnitSize = 1048576;

	public static CriFsLoadFileRequest LoadFile(string path, int readUnitSize = 1048576)
	{
		return null;
	}

	public static CriFsLoadFileRequest LoadFile(string path, CriFsRequest.DoneDelegate doneDelegate, int readUnitSize = 1048576)
	{
		return null;
	}

	public static CriFsLoadFileRequest LoadFile(CriFsBinder binder, string path, int readUnitSize = 1048576)
	{
		return null;
	}

	public static CriFsLoadAssetBundleRequest LoadAssetBundle(string path, int readUnitSize = 1048576)
	{
		return null;
	}

	public static CriFsLoadAssetBundleRequest LoadAssetBundle(CriFsBinder binder, string path, int readUnitSize = 1048576)
	{
		return null;
	}

	public static CriFsInstallRequest Install(string srcPath, string dstPath)
	{
		return null;
	}

	public static CriFsInstallRequest Install(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
	{
		return null;
	}

	public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath)
	{
		return null;
	}

	public static CriFsInstallRequest Install(CriFsBinder srcBinder, string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
	{
		return null;
	}

	public static CriFsInstallRequest WebInstall(string srcPath, string dstPath, CriFsRequest.DoneDelegate doneDeleagate)
	{
		return null;
	}

	public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, string srcPath)
	{
		return null;
	}

	public static CriFsBindRequest BindCpk(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
	{
		return null;
	}

	public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, string srcPath)
	{
		return null;
	}

	public static CriFsBindRequest BindDirectory(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
	{
		return null;
	}

	public static CriFsBindRequest BindFile(CriFsBinder targetBinder, string srcPath)
	{
		return null;
	}

	public static CriFsBindRequest BindFile(CriFsBinder targetBinder, CriFsBinder srcBinder, string srcPath)
	{
		return null;
	}

	public static void SetUserAgentString(string userAgentString)
	{
	}

	public static void SetProxyServer(string proxyPath, ushort proxyPort)
	{
	}

	public static void SetPathSeparator(string filter)
	{
	}

	private static extern bool CRIWARE21C5A467(string userAgentString);

	private static extern bool CRIWARECF9A6273(string proxyPath, ushort proxyPort);

	private static extern bool CRIWARE4EAFEB7C(string filter);
}
