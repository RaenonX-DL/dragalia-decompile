/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsOdCounteredHit : ActionParts
	{
		// Fields
		private readonly OdCounteredHitData _partsData;
		private readonly long _partsDataId;
		private EnemyCharacter ownerEnemy;
		private float timeCount;
		private float _dynamicScaleElapsed;
		private CollisionHitAttribute hitAttribute;
		protected HitException _hitException;
		private CharacterBase _firstTargetPlayer;
		private float _baseCollisionLength;
		private float _baseCollisionWidth;
		private float _baseCollisionHeight;
		private State _state;
		private bool _1stFrame;
		private ChargeMarker _marker;
		private Transform _iconBase;
		private Vector2 _counterIconOffset;
		private bool _canCounter;
	
		// Nested types
		private enum State
		{
			Init = 0,
			MarkerSet = 1,
			MarkerRun = 2,
			HitRun = 3,
			End = 4
		}
	
		public enum IconBasePosition
		{
			Marker = 0,
			Owner = 1,
			Stage = 2,
			AreaAnchor = 3
		}
	
		// Constructors
		public ActionPartsOdCounteredHit(ActionParts resource, long resourceId);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void MarkerSet();
		private void MarkerRun(float delta);
		private void HitSet();
		private void HitRun(float delta);
		private void ConvertHitAttribute(string label);
		private void SetupCollisionParameter(OdCounteredHitData data);
		private void CollisionScale();
		private void DynamicScale();
		private string GetLabel();
		private void PlayHitSE(CharacterBase target, Vector3 pos);
		public override void OnCollided(GameObject target, bool isPropagation);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		private void CheckOdCounter();
	}
}
