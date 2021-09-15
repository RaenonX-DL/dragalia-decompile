/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsHit : ActionParts
	{
		// Fields
		private readonly HitData _partsData;
		private readonly long _partsDataId;
		private float timeCount;
		private float _dynamicScaleElapsed;
		protected HitException _hitException;
		private CollisionHitAttribute hitAttribute;
		private CharacterBase _firstTargetPlayer;
		private float _baseCollisionLength;
		private float _baseCollisionWidth;
		private float _baseCollisionHeight;
		[CompilerGenerated]
		private Vector3 _lastKnownPosition_k__BackingField;
		[CompilerGenerated]
		private GameObject _substituteTarget_k__BackingField;
	
		// Properties
		private Vector3 lastKnownPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		private GameObject substituteTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public ActionPartsHit(ActionParts resource, long resourceId);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnFinish();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void ConvertHitAttribute();
		private void ConvertHitAttributeForPlayer(string label);
		private void ConvertHitAttributeForEnemy(string label);
		private void SetupCollisionParameter(HitData data);
		private void CollisionScale();
		private void DynamicScale(float delta);
		private string GetLabel();
		public int GetActionConditionId(CharacterBase chara, int skillId);
		public PlayerActionHitAttributeElement GetPlayerActionHitAttribute(CharacterBase chara);
		private void PlayHitSE(CharacterBase target, Vector3 pos);
		public override void OnCollided(GameObject target, bool isPropagation);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
	}
}
