using UnityEngine;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlThrown : CUGCtrlBase, ICollideCallback
	{
		private enum State
		{
			Idle,
			Caught,
			Wait1,
			Reel,
			Wait2,
			Fire,
			Move,
			Freed,
			Abort,
			End
		}

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

		public void Setup(Vector3 fireOffset, string attachNodeName = "", float attachTiming = 0f, float radius = 0f, float waitPick = 0f, float reelTime = 0f, float waitFire = 0f, float velocity = 1f, string crashHitDifficultyLabel = "", string freedHitDifficultyLabel = "")
		{
		}

		public void SetupEffect(string catchingEffName = "", int startTrigger = 8, int freedTrigger = 1, string startSeName = "", string fireSeName = "", string freedSeName = "")
		{
		}

		public void Start(CharacterBase owner, CharacterBase thrower)
		{
		}

		public override void Abort()
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		private void ProcCaught()
		{
		}

		private void ProcWait1()
		{
		}

		private void SetReel()
		{
		}

		private void ProcReel()
		{
		}

		private void SetWait2()
		{
		}

		private void ProcWait2()
		{
		}

		private void ProcFire()
		{
		}

		private void ProcMove()
		{
		}

		private void ProcFreed()
		{
		}

		private void ProcAbort()
		{
		}

		public override void FixedUpdate(CharacterBase src)
		{
		}

		private bool CancelWaitByFreeze()
		{
			return default(bool);
		}

		private Vector3 CalcWallPosition(Vector3 start, Vector3 forward)
		{
			return default(Vector3);
		}

		private void CreateHitAttribute(string label, ActionCollision shape, ref CollisionHitAttribute hit)
		{
		}

		public void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public void OnNotCollided(CharacterBase chara)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		private void PlayEffectLocal()
		{
		}

		public void DeleteEffect()
		{
		}
	}
}
