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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlloutAssaultUniqueCtrl : EnemyUniqueCtrl, ICollideCallback
	{
		// Fields
		private EventType _eventType;
		private State _state;
		[SerializeField]
		private float _limit;
		[SerializeField]
		private float _point;
		private float _timer;
		[CompilerGenerated]
		private bool _isDisplayedBtn_k__BackingField;
		private bool _isShowCutt;
		private bool _hasPlayed;
		private bool _isCreatedUI;
		private CollisionHitAttribute _hitAttribute;
		protected HitException _hitException;
		private List<int> _listMenberId;
		private string[] _voiceLabel;
		private AudioPlayback _voice;
		private float _nextSendGaugeValueEventTimer;
		private static readonly float SendGaugeValueEventInterval;
	
		// Properties
		public EventType eventType { get; }
		public State state { get; }
		public float rate { get; }
		public bool isDisplayedBtn { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum EventType
		{
			Eight = 0,
			Angel = 1
		}
	
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
		static AlloutAssaultUniqueCtrl();
	
		// Methods
		public override void Initialize();
		public void Setup(SetupAlloutAssaultData resource);
		public void OnStart(CollisionHitAttribute hitAttr);
		public override void FastUpdate();
		private void Ready();
		private void CreateUI();
		public bool CheckDown();
		public bool OnDown();
		public bool ProcStandup();
		public void OnDamage(CollisionHitAttribute hitAttr, int damage);
		private bool CanAssaultCondition();
		private bool CanAssaultCondition_ForEight();
		private bool CanAssaultCondition_ForAngel();
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
		private void PlayReadyVoice_Eight();
		public void SendAlloutAssaultDown();
		public void SendAlloutAssaultDownGaugeValue();
		public override void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent);
	}
}
