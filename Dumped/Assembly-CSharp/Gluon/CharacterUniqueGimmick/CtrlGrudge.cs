/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlGrudge : CUGCtrlBase, ICollideCallback
	{
		// Fields
		[CompilerGenerated]
		private State _state_k__BackingField;
		private CollisionHitAttribute _hitAttribute;
		private HitException _hitException;
		public const int STACK_MAX = 5;
		[CompilerGenerated]
		private int _stackNum_k__BackingField;
		private int[] _fixedDamage;
		public const string GRUDGE_EFFECT_NAME = "EFF_BOS_DRG_20000601_012";
		private const int EFF_VENT_TRIG = 13;
		private EffectObject _eoGrudge;
	
		// Properties
		public State state { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int stackNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private Transform transform { get; }
	
		// Nested types
		public enum State
		{
			Idle = 0,
			AddStack = 1,
			Vent = 2,
			Abort = 3,
			End = 4
		}
	
		// Constructors
		public CtrlGrudge(CUGCtrl.Type type_);
	
		// Methods
		public void Setup(CharacterSelector owner, CollisionHitAttribute hitAttribute);
		private void Reset();
		public override void ResetState();
		public override void Abort();
		public override void Update();
		public void OnAddStack();
		private void AddStack();
		public void OnVent();
		private void Vent();
		public virtual void OnCollided(GameObject target, bool isPropagation);
		public virtual void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public virtual void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		public override void PlayEffect();
		public override void StopEffect();
		public void DeleteEffect();
		public void SetFixedDamage(int stack_num, int damage);
		public void OnReceiveEvent(CharacterSpecialState recvData);
		private void SendGrudgeEvent(bool isVent);
		private void AddBattleLogUI();
	}
}
