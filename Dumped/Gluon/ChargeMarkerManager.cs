using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class ChargeMarkerManager : SingletonMonoBehaviour<ChargeMarkerManager>
	{
		private struct PrefabData
		{
			public static readonly string prefabPath;

			public string path;

			public int poolCount;
		}

		private List<ChargeMarker> _markers;

		private static PrefabData[] _markerPrefabs;

		public List<ChargeMarker> MarkerList => null;

		public int GetActiveMarkerNum => default(int);

		private void Start()
		{
		}

		public ChargeMarker CreateMarker(ChargeMarker.eType type)
		{
			return null;
		}

		public bool IsTargetedByMarker(GameObject obj)
		{
			return default(bool);
		}
	}
}
