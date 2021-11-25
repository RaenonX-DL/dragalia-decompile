public static class CriFsPlugin
{
	private static int initializationCount;

	private static bool isConfigured;

	public static int defaultInstallBufferSize;

	public static int installBufferSize;

	public static bool isInitialized => default(bool);

	public static void SetConfigParameters(int num_loaders, int num_binders, int num_installers, int argInstallBufferSize, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check)
	{
	}

	public static void SetConfigAdditionalParameters_ANDROID(int device_read_bps)
	{
	}

	public static void SetMemoryFileSystemThreadPriorityExperimentalAndroid(int prio)
	{
	}

	public static void SetDataDecompressionThreadPriorityExperimentalAndroid(int prio)
	{
	}

	public static void InitializeLibrary()
	{
	}

	public static bool IsLibraryInitialized()
	{
		return default(bool);
	}

	public static void FinalizeLibrary()
	{
	}

	private static extern void CRIWAREB37DBD37(int num_loaders, int num_binders, int num_installers, int max_path, bool minimize_file_descriptor_usage, bool enable_crc_check);

	private static extern void CRIWARE5607FE7A();

	public static extern bool CRIWAREB2EB8B5F();

	private static extern void CRIWARE1692E4D8();

	public static extern uint CRIWARE48587738();

	public static extern uint criFsLoader_GetRetryCount();

	public static extern int criFs_GetNumBinds(ref int cur, ref int max, ref int limit);

	public static extern int criFs_GetNumUsedLoaders(ref int cur, ref int max, ref int limit);

	public static extern int criFs_GetNumUsedInstallers(ref int cur, ref int max, ref int limit);

	private static extern void criFsUnity_SetConfigAdditionalParameters_ANDROID(int device_read_bps);

	public static extern void criFsUnity_SetMemoryFileSystemThreadPriority_ANDROID(int prio);

	public static extern void criFsUnity_SetDataDecompressionThreadPriority_ANDROID(int prio);
}
