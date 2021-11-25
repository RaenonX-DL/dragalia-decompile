using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class TanatosHourglassSetActionData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _actionId;

		public int actionId => default(int);
	}
}
