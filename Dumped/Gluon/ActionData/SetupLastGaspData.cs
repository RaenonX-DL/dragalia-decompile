using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupLastGaspData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _actionId;

		[SerializeField]
		[HideInInspector]
		private int _takedownActionId;

		public int actionId => default(int);

		public int takedownActionId => default(int);
	}
}
