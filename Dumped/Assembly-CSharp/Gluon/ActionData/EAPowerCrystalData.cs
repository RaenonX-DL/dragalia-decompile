/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class EAPowerCrystalData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _abilityId;
		[HideInInspector]
		[SerializeField]
		private EnemyAbilityProcPowerCrystal.ConditionType _conditionType;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public int abilityId { get; }
		public EnemyAbilityProcPowerCrystal.ConditionType conditionType { get; }
		public bool guarantee { get; }
	
		// Constructors
		public EAPowerCrystalData();
	}
}
