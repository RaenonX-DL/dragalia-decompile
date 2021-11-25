using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public abstract class ProductionTimeCallback : MonoBehaviour
	{
		private static List<ProductionTimeCallback> callbackList;

		protected virtual void Awake()
		{
		}

		public static void ClearList()
		{
		}

		public static void SetProductionTime()
		{
		}

		public virtual void OnProductionTime()
		{
		}
	}
}
