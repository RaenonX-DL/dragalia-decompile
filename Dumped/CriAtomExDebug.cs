public static class CriAtomExDebug
{
	public struct ResourcesInfo
	{
		public CriAtomEx.ResourceUsage virtualVoiceUsage;

		public CriAtomEx.ResourceUsage sequenceUsage;

		public CriAtomEx.ResourceUsage sequenceTrackUsage;

		public CriAtomEx.ResourceUsage sequenceTrackItemUsage;
	}

	public static void GetResourcesInfo(out ResourcesInfo resourcesInfo)
	{
	}

	private static extern void criAtomExDebug_GetResourcesInfo(out ResourcesInfo resourcesInfo);
}
