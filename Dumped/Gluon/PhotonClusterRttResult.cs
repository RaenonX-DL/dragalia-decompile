using System.Collections.Generic;

namespace Gluon
{
	public class PhotonClusterRttResult
	{
		private Dictionary<string, float> _rttTable;

		private string _bestRegionName;

		private float _bestRegionRtt;

		public void Clear()
		{
		}

		public void RegisterRtt(string regionName, string clusterName, float rtt)
		{
		}

		public bool TryGetRtt(string regionName, string clusterName, out float rtt)
		{
			return default(bool);
		}

		public string GetBestRegionName()
		{
			return null;
		}
	}
}
