using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class D00562Data : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _catchAction;

		[SerializeField]
		[HideInInspector]
		private MarkerData _marker;

		[SerializeField]
		[HideInInspector]
		private bool _barrage;

		public int catchAction => default(int);

		public MarkerData markerData => null;

		public bool barrage => default(bool);
	}
}
