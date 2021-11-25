namespace Gluon
{
	public static class BuildParameter
	{
		private static string[] texts;

		public const string BranchNamePrefs = "BuildParameterBranchName";

		public const string BuildNumberPrefs = "BuildParameterBuildNumber";

		public static string branchName => null;

		public static string serverId => null;

		public static string buildNumber => null;

		public static string buildId => null;

		static BuildParameter()
		{
		}
	}
}
