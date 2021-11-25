using ExitGames.Client.Photon;
using ExitGames.Client.Photon.LoadBalancing;

namespace Gluon
{
	public class PhotonPlayerProperty
	{
		private Player _player;

		private Hashtable _failedChangeProperty;

		public PhotonPlayerProperty(Player player)
		{
		}

		public bool TrySetProperty(string key, object value)
		{
			return default(bool);
		}

		public static bool TryGetProperty(Player player, string key, out object value)
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

		public bool IsSelf(Player player)
		{
			return default(bool);
		}
	}
}
