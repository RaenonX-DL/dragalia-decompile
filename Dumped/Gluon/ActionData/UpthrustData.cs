using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class UpthrustData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		[SerializeField]
		[HideInInspector]
		private string _popEffect;

		[SerializeField]
		[HideInInspector]
		private string _popSE;

		public int childActionId => default(int);

		public string popEffect => null;

		public string popSE => null;
	}
}
