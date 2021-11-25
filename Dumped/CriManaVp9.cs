using System;

public static class CriManaVp9
{
	private const string scriptVersionString = "1.00.01";

	private const int scriptVersionNumber = 16777472;

	public const string cri_mana_vp9_name = "cri_mana_vpx";

	public static bool SupportCurrentPlatform()
	{
		return default(bool);
	}

	public static void SetupVp9Decoder()
	{
	}

	private static extern IntPtr criWareUnity_GetAllocateFunc();

	private static extern IntPtr criWareUnity_GetDeallocateFunc();

	private static extern IntPtr CRIWAREC6C0C4BE();

	private static extern void criMvPly_AttachCodecInterface(int codec_type, IntPtr codec_if, IntPtr codecalpha_if);

	private static extern void criVvp9_SetUserAllocator(IntPtr alloc_func, IntPtr free_func, IntPtr usr_obj);

	private static extern IntPtr criVvp9_GetInterface();

	private static extern IntPtr criVvp9_GetAlphaInterface();
}
