using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SyncCharacterPositionData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _syncPlayerPositionEnabled;

		public bool syncPlayerPositionEnabled => default(bool);
	}
}
