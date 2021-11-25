namespace Gluon
{
	public static class PhotonConnectTarget
	{
		public enum ServiceTypes
		{
			PhotonServer,
			PhotonEnterpriseClound
		}

		private struct ConnectTargetData
		{
			public ServiceTypes Type;

			public string Target;
		}

		public static ServiceTypes ServiceType => default(ServiceTypes);

		public static string PhotonServerAddress => null;

		public static string PhotonCloudAppId => null;

		private static ConnectTargetData GetConnectTargetData()
		{
			return default(ConnectTargetData);
		}
	}
}
