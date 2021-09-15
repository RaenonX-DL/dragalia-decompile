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
	public class CtrlThrown : CUGCtrlBase, ICollideCallback
	{
		// Fields
		private State _state;
		private ActionMove _move;
		private int _movePoperty;
		private CharacterBase _thrower;
		private Vector3 _fireOffset;
		private string _attachNodeName;
		private Transform _attachNode;
		private float _attachTiming;
		private float _elapsed;
		private float _timer;
		private float _waitPick;
		private float _reelTime;
		private float _waitFire;
		private float _velocity;
		private float _radius;
		private string _crashHitDifficultyLabel;
		private string _freedHitDifficultyLabel;
		private CollisionHitAttribute _crashHitAttr;
		protected HitException _crashHitException;
		private CollisionHitAttribute _freedHitAttr;
		protected HitException _freedHitException;
		private string _catchingEffName;
		private int _startTrigger;
		private int _freedTrigger;
		private EffectObject _eoCatching;
		private string _startSeName;
		private string _fireSeName;
		private string _freedSeName;
	
		// Nested types
		private enum State
		{
			Idle = 0,
			Caught = 1,
			Wait1 = 2,
			Reel = 3,
			Wait2 = 4,
			Fire = 5,
			Move = 6,
			Freed = 7,
			Abort = 8,
			End = 9
		}
	
		// Constructors
		public CtrlThrown();
	
		// Methods
		public void Setup(Vector3 fireOffset, string attachNodeName = "", float attachTiming = 0f, float radius = 0f, float waitPick = 0f, float reelTime = 0f, float waitFire = 0f, float velocity = 1f, string crashHitDifficultyLabel = "", string freedHitDifficultyLabel = "");
		public void SetupEffect(string catchingEffName = "", int startTrigger = 8, int freedTrigger = 1, string startSeName = "", string fireSeName = "", string freedSeName = "");
		public void Start(CharacterBase owner, CharacterBase thrower);
		public override void Abort();
		public override void Update(CharacterBase src);
		private void ProcCaught();
		private void ProcWait1();
		private void SetReel();
		private void ProcReel();
		private void SetWait2();
		private void ProcWait2();
		private void ProcFire();
		private void ProcMove();
		private void ProcFreed();
		private void ProcAbort();
		public override void FixedUpdate(CharacterBase src);
		private bool CancelWaitByFreeze();
		private Vector3 CalcWallPosition(Vector3 start, Vector3 forward);
		private void CreateHitAttribute(string label, ActionCollision shape, ref CollisionHitAttribute hit);
		public void OnCollided(GameObject target, bool isPropagation);
		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		private void PlayEffectLocal();
		public void DeleteEffect();
	}
}
