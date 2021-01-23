/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EditSkillCharaOffsetElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _EditSkillRelationId;
		[SerializeField]
		private WeaponType _TargetWeaponType;
		[SerializeField]
		private float _SpOffset;
		[SerializeField]
		private float _StrengthOffset;
		[SerializeField]
		private float _RecoveryOffset;
		[SerializeField]
		private float _BuffDebuffOffset;
	
		// Properties
		public int Id { get; }
		public int EditSkillRelationId { get; }
		public WeaponType TargetWeaponType { get; }
		public float SpOffset { get; }
		public float StrengthOffset { get; }
		public float RecoveryOffset { get; }
		public float BuffDebuffOffset { get; }
	
		// Constructors
		public EditSkillCharaOffsetElement();
	}
}
