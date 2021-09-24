/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlEventHeal : CUGCtrlBase, ICollideCallback
	{
		// Fields
		[CompilerGenerated]
		private State _state_k__BackingField;
		private const float POINT_MAX = 1000f;
		[SerializeField]
		private float _point;
		private float _pointSpeed;
		private float _timer;
		private float _waitTime;
		private CollisionHitAttribute _hitAttribute;
		private AlloutAssaultUniqueCtrl _assault;
		private string _effName;
		private EffectObject _eoSkill;
		private string _seName;
	
		// Properties
		private State state { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override CharacterBase owner { get; }
		public override bool active { get; }
		public float point { get; set; }
		public float rate { get; }
		private Transform transform { get; }
	
		// Nested types
		public enum State
		{
			NotReady = 0,
			Wait = 1,
			Charging = 2,
			FullCharge = 3,
			Unavailable = 4,
			End = 5
		}
	
		// Constructors
		public CtrlEventHeal();
	
		// Methods
		public void Setup(CharacterSelector selector, CharacterBase owner_, CollisionHitAttribute hitAttr, float chargeTime, float waitTime);
		public void SetupEffect(string effName, string seName);
		private void Reset();
		public override void ResetState();
		public override void Update(CharacterBase src);
		private bool CanHealCondition();
		public void OnBtnEventHeal();
		public override void OnDead();
		public void OnCollided(GameObject target, bool isPropagation);
		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		private void PlayReadyVoice();
	}
}
