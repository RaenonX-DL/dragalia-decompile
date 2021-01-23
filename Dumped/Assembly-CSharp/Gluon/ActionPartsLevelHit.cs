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
	public class ActionPartsLevelHit : ActionParts
	{
		// Fields
		private readonly LevelHitData _partsData;
		[CompilerGenerated]
		private CollisionHitAttribute _hitAttribute_k__BackingField;
		protected HitException _hitException;
		private float timeCount;
		private float _dynamicScaleElapsed;
		private float _baseCollisionLength;
		private float _baseCollisionWidth;
		private float _baseCollisionHeight;
	
		// Properties
		private CollisionHitAttribute hitAttribute { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public ActionPartsLevelHit(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		private void SetupHitAttribute(int lv);
		private string GetLabel(int lv);
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void SetupCollisionParameter(LevelHitData data);
		private void CollisionScale();
		private void DynamicScale();
		public override void OnCollided(GameObject target, bool isPropagation);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		private void PlayHitSE(CharacterBase target, Vector3 pos);
	}
}
