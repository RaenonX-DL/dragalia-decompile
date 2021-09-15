/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlDoll : CUGCtrlBase
	{
		// Fields
		private State _state;
		private CharacterBase _hexer;
		private DamageType _dmgType;
		private float _duration;
		private float _timer;
		private bool _isTimeUp;
		private bool _killOnRelease;
		private bool _cancelAbnormal;
		private bool _visible;
		[CompilerGenerated]
		private bool _canTransform_k__BackingField;
		private bool checkDragon;
		private string _dollEffName;
		private EffectObject _eoDoll;
		private const int EFF_TRIG_DOLL = 8;
		private const int EFF_TRIG_CANCEL = 1;
		private int _timeupEffTrigger;
		private string _dollSeName;
		private string _timeupSeName;
		private string _logId;
		private List<DollEvent> _recvEventList;
		private bool _isAbortReserved;
	
		// Properties
		public State state { get; private set; }
		public override bool active { get; }
		public bool canTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum State
		{
			Idle = 0,
			Doll = 1,
			Abort = 2
		}
	
		public enum DamageType
		{
			Invincible = 0,
			None = 1,
			Immunity = 2
		}
	
		// Constructors
		public CtrlDoll();
	
		// Methods
		public void Setup(CharacterBase owner, CharacterSelector selector, DamageType dmgtype, bool killOnRelease, bool cancelAbnormal, bool visible, bool canTransform_);
		public void SetupEffect(string eff_name = "", string se_name = "", string log_id = "", int timeupEffTrigger = 0, string timeup_se_name = "");
		public override void ResetState();
		public bool CanStart();
		public void Start(CharacterBase hexer, float duration);
		public override void Abort();
		public override void Update(CharacterBase src);
		private void ProcBegin(CharacterBase hexer);
		private bool CheckReleaseCondition();
		private void ProcAbort();
		public bool CanReleaseOnHit(CollisionHitAttribute hitAttr);
		public override void OnCollided(CollisionHitAttribute hitAttr);
		public override bool IsRestoreEffect();
		private void PlayEffectLocal();
		private new void StopEffect();
		public void DeleteEffect();
		private void SendDollEvent(State state);
		public void OnReceiveEvent(DollEvent recvData);
		private void ProcessReceivedEvent();
	}
}
