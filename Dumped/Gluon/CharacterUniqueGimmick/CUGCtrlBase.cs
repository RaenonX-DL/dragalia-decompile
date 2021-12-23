using System.Runtime.CompilerServices;

namespace Gluon.CharacterUniqueGimmick
{
	public class CUGCtrlBase
	{
		protected CharacterBase _owner;

		protected CharacterSelector _ownerSelector;

		public CUGCtrl.Type type
		{
			[CompilerGenerated]
			get
			{
				return default(CUGCtrl.Type);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public virtual CharacterBase owner => null;

		public virtual CharacterSelector ownerSelector => null;

		public virtual bool active => default(bool);

		public CUGCtrlBase(CUGCtrl.Type type_)
		{
		}

		public virtual void ResetState()
		{
		}

		public virtual void Abort()
		{
		}

		public virtual void Update(CharacterBase src)
		{
		}

		public virtual void FixedUpdate(CharacterBase src)
		{
		}

		public virtual void OnDead()
		{
		}

		public virtual void OnShapeShift()
		{
		}

		public virtual void OnCollided(CollisionHitAttribute hitAttr)
		{
		}

		public virtual void OnStartSupport()
		{
		}

		public virtual void OnEndSupport()
		{
		}

		public virtual bool IsRestoreEffect()
		{
			return default(bool);
		}

		public virtual void PlayEffect()
		{
		}

		public virtual void StopEffect()
		{
		}

		public virtual void OnAreaChange()
		{
		}

		public virtual void TakeOverStatus(EnemyCharacter src, bool restoreEff = true)
		{
		}
	}
}
