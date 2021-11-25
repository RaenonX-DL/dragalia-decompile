using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class BRItemGenerator : MonoBehaviour
	{
		public static BRItemGenerator instance;

		private Dictionary<int, List<BRItemPopPoint>> popPointDict;

		private int totalPointCount;

		private bool isReady;

		public static int RegisterPopPoint(BRItemPopPoint popPoint)
		{
			return default(int);
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public bool CanGenerateItems()
		{
			return default(bool);
		}

		public void GenerateItems()
		{
		}
	}
}
