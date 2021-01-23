/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TargetEffectCtrl
	{
		// Fields
		[CompilerGenerated]
		private CharacterBase _target_k__BackingField;
		private PlayerCharacter owner;
		private EffectObject effObj;
		private Vector3 startPoint;
		private Vector3 relayPoint;
		private Vector3 endPoint;
		private float elapsedTime;
		private float durationTime;
		private float range;
		private float topOffset;
		private TargetType targetType;
	
		// Properties
		public CharacterBase target { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum TargetType
		{
			None = 0,
			AllyHpRateLowest = 1
		}
	
		// Constructors
		public TargetEffectCtrl(PlayerCharacter player);
	
		// Methods
		private void Clear();
		public void ResetTarget();
		public void Setup(TargetEffectData partsData);
		public void Start();
		public void Update();
		private Vector3 CalcPoint(float step);
		private CharacterBase FindTargetCharacter();
	}
}
