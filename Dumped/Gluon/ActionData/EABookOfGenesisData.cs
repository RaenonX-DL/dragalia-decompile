using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EABookOfGenesisData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _onoff;

		[SerializeField]
		[HideInInspector]
		private int _linkedId;

		public bool onoff => default(bool);

		public int linkedId => default(int);
	}
}
