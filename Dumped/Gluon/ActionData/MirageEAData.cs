using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MirageEAData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _abilityId;

		[SerializeField]
		[HideInInspector]
		private string _generatorLabel;

		[SerializeField]
		[HideInInspector]
		private bool _isHpCopy;

		public int abilityId => default(int);

		public string generatorLabel => null;

		public bool isHpCopy => default(bool);
	}
}
