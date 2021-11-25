using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupHolyLightData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _isResetRecast;

		public bool isResetRecast => default(bool);
	}
}
