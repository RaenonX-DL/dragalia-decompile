using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ShapeShiftData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _onoff;

		public bool onoff => default(bool);
	}
}
