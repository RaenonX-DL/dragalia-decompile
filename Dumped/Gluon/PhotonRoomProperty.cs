using ExitGames.Client.Photon;

namespace Gluon
{
	public class PhotonRoomProperty
	{
		private PhotonClient _client;

		private Hashtable _failedChangeProperty;

		private Hashtable _propertyCache;

		public PhotonRoomProperty(PhotonClient client)
		{
		}

		public bool TrySetProperty(string key, object value)
		{
			return default(bool);
		}

		public bool TryGetProperty(string key, out object value)
		{
			return default(bool);
		}

		public void Resend()
		{
		}
	}
}
