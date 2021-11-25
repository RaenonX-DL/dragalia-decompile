using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class OperateParamData : ActionParts.PartsData
	{
		public enum ParameterType
		{
			None,
			BreakDamageRate,
			Rage
		}

		[SerializeField]
		[HideInInspector]
		private InGameDef.CharacterType _characterType;

		[SerializeField]
		[HideInInspector]
		private ParameterType _parameterType;

		[SerializeField]
		[HideInInspector]
		private float _value;

		public InGameDef.CharacterType characterType => default(InGameDef.CharacterType);

		public ParameterType parameterType => default(ParameterType);

		public float value => default(float);
	}
}
