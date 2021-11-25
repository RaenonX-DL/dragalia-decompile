using System.Collections.Generic;

namespace Gluon
{
	public class PhotonClusterSet
	{
		private Dictionary<string, List<PhotonCluster>> _container;

		public void Clear()
		{
		}

		public void RegisterAll(string[] availableRegions, string[] availableRegionsServers)
		{
		}

		public void Register(PhotonCluster cluster)
		{
		}

		public void Unregister(PhotonCluster cluster)
		{
		}

		public PhotonCluster FindClusterByName(string clusterName)
		{
			return null;
		}

		public IEnumerable<string> GetAllRegions()
		{
			return null;
		}

		public List<PhotonCluster> GetClustersByRegion(string region)
		{
			return null;
		}

		public int Count()
		{
			return default(int);
		}
	}
}
