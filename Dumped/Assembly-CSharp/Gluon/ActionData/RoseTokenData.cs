/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class RoseTokenData : BulletData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _generateNum;
		[HideInInspector]
		[SerializeField]
		private float _generateRadius;
		[HideInInspector]
		[SerializeField]
		private float _attackInterval;
		[HideInInspector]
		[SerializeField]
		private float _bloomSec;
		[HideInInspector]
		[SerializeField]
		private int _witherTrigger;
		[HideInInspector]
		[SerializeField]
		private float _witherActionRange;
		[HideInInspector]
		[SerializeField]
		private int _killCount;
		[HideInInspector]
		[SerializeField]
		private HitData _hitAttack;
		[HideInInspector]
		[SerializeField]
		private EffectData _effAttack;
		[HideInInspector]
		[SerializeField]
		private string _seAttack;
		[HideInInspector]
		[SerializeField]
		private HitData _hitHeal;
		[HideInInspector]
		[SerializeField]
		private EffectData _effHeal;
		[HideInInspector]
		[SerializeField]
		private string _seHeal;
	
		// Properties
		public int generateNum { get; }
		public float generateRadius { get; }
		public float attackInterval { get; }
		public float bloomSec { get; }
		public int witherTrigger { get; }
		public float witherActionRange { get; }
		public int killCount { get; }
		public HitData hitAttack { get; }
		public EffectData effAttack { get; }
		public string seAttack { get; }
		public HitData hitHeal { get; }
		public EffectData effHeal { get; }
		public string seHeal { get; }
	
		// Constructors
		public RoseTokenData();
	}
}
