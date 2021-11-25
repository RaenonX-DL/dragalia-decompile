using Gluon.ActionData;
using Gluon.Dungeon;

namespace Gluon
{
	public class CharacterHitStopCaster
	{
		private bool isAccept;

		private bool isDefault;

		private float stopPosition;

		private float stopLength;

		private float stopMotionPlayScale;

		private bool isRepeat;

		private int hitCount;

		private int acceptIndex;

		private CharacterBase _owner;

		private bool isOwnerOnly;

		private bool includeNoDamage;

		public CharacterHitStopCaster(CharacterBase owner)
		{
		}

		public void Clear()
		{
		}

		public void Accept(HitStopData data)
		{
		}

		public void AcceptDefault()
		{
		}

		private void AcceptSub()
		{
		}

		public int getAcceptIndex()
		{
			return default(int);
		}

		public void ProcOnHit(CharacterBase owner, CharacterBase target, DungeonObjectBase dunObj, CollisionHitAttribute hitAttr, bool isNoDamage)
		{
		}

		public void OnLateUpdate()
		{
		}
	}
}
