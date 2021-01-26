/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlloutAssaultUniqueCtrl : EnemyUniqueCtrl, ICollideCallback
	{
		// Fields
		private State _state;
		[SerializeField]
		private float _limit;
		[SerializeField]
		private float _point;
		private float _timer;
		private bool _isDisplayedBtn;
		private bool _isShowCutt;
		private bool _hasPlayed;
		private CollisionHitAttribute _hitAttribute;
		protected HitException _hitException;
		private List<int> _listMenberId;
		private string[] _voiceLabel;
		private AudioPlayback _voice;
	
		// Properties
		public float rate { get; }
	
		// Nested types
		public enum State
		{
			Init = 0,
			Idle = 1,
			Running = 2,
			Down = 3,
			Standup = 4
		}
	
		// Constructors
		public AlloutAssaultUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public void Setup(SetupAlloutAssaultData resource);
		public void OnStart(CollisionHitAttribute hitAttr);
		public override void FastUpdate();
		private void Ready();
		public bool CheckDown();
		public bool OnDown();
		public bool ProcStandup();
		public void OnDamage(CollisionHitAttribute hitAttr, int damage);
		private bool CanAssaultCondition();
		public void OnBtnAssault();
		public void OnEndCutScene();
		public void OnEndAlloutAssault();
		public override float GetAtkValue();
		public override float GetDefValue();
		public void OnCollided(GameObject target, bool isPropagation);
		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		private bool IsEightMember(CharacterBase target);
		private void PlayReadyVoice();
		public override void OnChangeState(CharacterState state);
	}
}
