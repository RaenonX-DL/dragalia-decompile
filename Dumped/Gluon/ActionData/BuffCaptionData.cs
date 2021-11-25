using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class BuffCaptionData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _actionConditionId;

		public int actionConditionId => default(int);
	}
}
