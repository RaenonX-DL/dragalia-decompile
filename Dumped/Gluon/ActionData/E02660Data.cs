using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class E02660Data : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private float _catchRange;

		[SerializeField]
		[HideInInspector]
		private string _destructMotion;

		public float catchRange => default(float);

		public string destructMotion => null;
	}
}
