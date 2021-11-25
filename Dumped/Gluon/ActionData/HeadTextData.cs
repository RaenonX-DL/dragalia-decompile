using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class HeadTextData : ActionParts.PartsData
	{
		public enum ValueType
		{
			None,
			BuffCount,
			RemainTimes,
			Aura,
			BurstAura
		}

		[SerializeField]
		[HideInInspector]
		private string _text;

		[SerializeField]
		[HideInInspector]
		private ValueType _valueType;

		[SerializeField]
		[HideInInspector]
		private int _valueFactor;

		[SerializeField]
		[HideInInspector]
		private int _valueTargetConditionId;

		[SerializeField]
		[HideInInspector]
		private bool _isDispMasterTextNum;

		[SerializeField]
		[HideInInspector]
		private bool _isCheckAtActionStart;

		public string text => null;

		public ValueType valueType => default(ValueType);

		public int valueFactor => default(int);

		public int valueTargetConditionId => default(int);

		public bool isDispMasterTextNum => default(bool);

		public bool isCheckAtActionStart => default(bool);
	}
}
