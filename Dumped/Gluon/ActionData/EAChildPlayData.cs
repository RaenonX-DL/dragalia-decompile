using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EAChildPlayData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private bool _onoff;

		[SerializeField]
		[HideInInspector]
		private float _abilityDuraion;

		[SerializeField]
		[HideInInspector]
		private float _abilityRestartTime;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_Poison;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_Burn;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_Freeze;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_Paralysis;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_Darkness;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_Swoon;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_SlowMove;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_Sleep;

		[SerializeField]
		[HideInInspector]
		private int _abnormalResist_Frostbite;

		public bool onoff => default(bool);

		public float abilityDuraion => default(float);

		public float abilityRestartTime => default(float);

		public int abnormalResist_Poison => default(int);

		public int abnormalResist_Burn => default(int);

		public int abnormalResist_Freeze => default(int);

		public int abnormalResist_Paralysis => default(int);

		public int abnormalResist_Darkness => default(int);

		public int abnormalResist_Swoon => default(int);

		public int abnormalResist_SlowMove => default(int);

		public int abnormalResist_Sleep => default(int);

		public int abnormalResist_Frostbite => default(int);
	}
}
