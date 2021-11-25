using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EAMelodyData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _abilityId;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsEAMelody.OperateType _operateType;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public int abilityId => default(int);

		public Gluon.ActionPartsEAMelody.OperateType operateType => default(Gluon.ActionPartsEAMelody.OperateType);

		public bool guarantee => default(bool);
	}
}
