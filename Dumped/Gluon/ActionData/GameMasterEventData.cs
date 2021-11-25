using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class GameMasterEventData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _uiId;

		public int uiId => default(int);
	}
}
