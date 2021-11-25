using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SabnackFlameArmData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsSabnackFlameArm.FlameType _flameType;

		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsSabnackFlameArm.PartsType _partsType;

		[SerializeField]
		[HideInInspector]
		private float _beginColor;

		[SerializeField]
		[HideInInspector]
		private float _endColor;

		[SerializeField]
		[HideInInspector]
		private float _beginSize;

		[SerializeField]
		[HideInInspector]
		private float _endSize;

		[SerializeField]
		[HideInInspector]
		private string _effectCtrlKey_Body;

		[SerializeField]
		[HideInInspector]
		private int _effectTrigger_Body;

		public Gluon.ActionPartsSabnackFlameArm.FlameType flameType => default(Gluon.ActionPartsSabnackFlameArm.FlameType);

		public Gluon.ActionPartsSabnackFlameArm.PartsType partsType => default(Gluon.ActionPartsSabnackFlameArm.PartsType);

		public float beginColor => default(float);

		public float endColor => default(float);

		public float beginSize => default(float);

		public float endSize => default(float);

		public string effectCtrlKey_Body => null;

		public int effectTrigger_Body => default(int);
	}
}
