using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class ProximityReaction : Reaction
	{
		private HashSet<int> triggerHistory;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
