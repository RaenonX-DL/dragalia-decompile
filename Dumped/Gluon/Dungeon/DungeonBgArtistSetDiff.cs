using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonBgArtistSetDiff : FastUpdateMonoBehaviour
	{
		public enum SetActiveType
		{
			None,
			Enable,
			Disable
		}

		[SerializeField]
		private List<Transform> targetNodeList;

		[SerializeField]
		private SetActiveType setTargetNodeActiveType;

		[SerializeField]
		private bool searchTargetChildren;

		[SerializeField]
		private bool destroyCollider;

		private void Awake()
		{
		}
	}
}
