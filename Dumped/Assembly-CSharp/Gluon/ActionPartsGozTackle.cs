/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsGozTackle : ActionParts
	{
		// Fields
		private readonly GozTackleData _partsData;
		private State _state;
		private List<CharacterBase> _listTarget;
		private CharacterBase _currentTarget;
		private const float TARGET_SYNC_TIME = 2f;
		private float _timer;
		private ActionMove _move;
		private float _moveDuration;
		private int _moveProperty;
		private CollisionHitAttribute _hitAttr;
		protected HitException _hitException;
		private ChargeMarker _marker;
		private float _markerDuration;
		private int _targetingCnt;
	
		// Nested types
		public enum State
		{
			Idle = 0,
			Targeting = 1,
			PostTargeting = 2,
			Aim = 3,
			Wait = 4,
			BeginTackle = 5,
			Move = 6,
			EndTackle = 7,
			ReturnCenter = 8,
			PostReturn = 9,
			CrashRock = 10,
			End = 11
		}
	
		// Constructors
		public ActionPartsGozTackle(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		protected override bool OnFixedUpdate(float delta);
		private void ProcTargeting();
		private void ProcPostTargeting();
		private void ProcAim();
		private void ProcBeginTackle();
		private void ProcMove(float delta);
		private void ProcEndTackle();
		private void ProcReturnCenter();
		private void ProcPostReturn();
		public override void OnCollided(GameObject target, bool isPropagation);
		private void ProcCrashRock();
		private void CreateTargetList();
		private void CreateMarker();
		private void ProcClear();
	}
}
