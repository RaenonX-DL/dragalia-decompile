public class NPFSettingsLoader
{
	private class NpfSettings
	{
		public string baasHost;

		public bool purchaseMock;

		public string clientId;

		public string accountHost;

		public string accountApiHost;

		public string pointProgramHost;

		public string basicAuthUser;

		public string basicAuthPass;

		public bool printLog;

		public bool debugLog;

		public string marketForSandbox;
	}

	private const string npfSettingFileName = "npf";

	public string GetAccountHost()
	{
		return null;
	}

	public static string GetBaaSHost()
	{
		return null;
	}

	public static bool IsPurchaseMock()
	{
		return default(bool);
	}

	private static NpfSettings GetNPFSetting()
	{
		return null;
	}
}
