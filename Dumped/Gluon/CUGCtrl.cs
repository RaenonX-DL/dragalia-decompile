using System.Collections.Generic;
using Gluon.CharacterUniqueGimmick;

namespace Gluon
{
	public class CUGCtrl
	{
		public enum Type
		{
			None,
			Electrified,
			Grudge,
			Virus,
			Thrown,
			Doll,
			HealBlock,
			HolyLight,
			YinYang,
			OdCounter,
			DrasticForce,
			EventHeal,
			Pursuit
		}

		private List<CUGCtrlBase> _listCtrl;

		private static readonly Type[] TypesInhibitedFromTransform;

		private static readonly Type[] TypesInhibitedFromUniqueTransform;

		public void Set<T>(T ctrl_) where T : CUGCtrlBase
		{
		}

		public T Get<T>() where T : CUGCtrlBase
		{
			return null;
		}

		public bool IsActive(Type type_)
		{
			return default(bool);
		}

		public void Clear()
		{
		}

		public void Reset(Type type_ = Type.None)
		{
		}

		public void Abort(Type type_ = Type.None)
		{
		}

		public void OnAreaChange(Type type_ = Type.None)
		{
		}

		public void Update(CharacterBase src, Type type_ = Type.None)
		{
		}

		public void FixedUpdate(CharacterBase src, Type type_ = Type.None)
		{
		}

		public void OnDead(Type type_ = Type.None)
		{
		}

		public void OnShapeShift(Type type_ = Type.None)
		{
		}

		public void OnCollided(CollisionHitAttribute hitAttr, Type type_ = Type.None)
		{
		}

		public void OnStartSupport(Type type_ = Type.None)
		{
		}

		public void OnEndSupport(Type type_ = Type.None)
		{
		}

		public bool IsRestoreEffect(Type type_ = Type.None)
		{
			return default(bool);
		}

		public void PlayEffect(Type type_ = Type.None)
		{
		}

		public void StopEffect(Type type_ = Type.None)
		{
		}

		public bool InhibitTransform()
		{
			return default(bool);
		}

		public bool InhibitUniqueTransform()
		{
			return default(bool);
		}
	}
}
