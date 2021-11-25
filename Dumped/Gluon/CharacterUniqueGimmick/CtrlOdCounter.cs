using System.Collections.Generic;
using Gluon.Event;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlOdCounter : CUGCtrlBase
	{
		public enum Type
		{
			None,
			HitDamage,
			TotalScore
		}

		public struct CounteredData
		{
			public int type;

			public int bonus;

			public EnemyCharacter target;

			public int hitCount;

			public int limit;
		}

		public struct ActionInfo
		{
			public int actionId;

			public int productId;
		}

		private List<CounteredData> _counteredList;

		private List<ActionInfo> _actionsInSkill;

		private const string SUCCESS_SE_NAME = "SE_IN_SYSTEM_0071";

		public override bool active => default(bool);

		public void Setup(CharacterBase owner)
		{
		}

		public void Reset()
		{
		}

		public void AddActionInSkill(int actionId_, int productId_)
		{
		}

		public bool Contain(EnemyCharacter target_)
		{
			return default(bool);
		}

		public void Register(EnemyCharacter enemy, CollisionHitAttribute attr)
		{
		}

		public bool CalcDamage(EnemyCharacter enemy, CollisionHitAttribute hitAttr, int hp_dmg, ref int od_dmg)
		{
			return default(bool);
		}

		private void SendOverDriveCounter(CharacterBase target)
		{
		}

		public static void OnRecieveOverDriveCounter(OverDriveCounter recvEvent)
		{
		}
	}
}
