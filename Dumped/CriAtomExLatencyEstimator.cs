public static class CriAtomExLatencyEstimator
{
	public enum Status
	{
		Stop,
		Processing,
		Done,
		Error
	}

	public struct EstimatorInfo
	{
		public Status status;

		public uint estimated_latency;
	}

	public static void InitializeModule()
	{
	}

	public static void FinalizeModule()
	{
	}

	public static EstimatorInfo GetCurrentInfo()
	{
		return default(EstimatorInfo);
	}

	private static extern void criAtomLatencyEstimator_Initialize_ANDROID();

	private static extern void criAtomLatencyEstimator_Finalize_ANDROID();

	private static extern EstimatorInfo criAtomLatencyEstimator_GetCurrentInfo_ANDROID();
}
