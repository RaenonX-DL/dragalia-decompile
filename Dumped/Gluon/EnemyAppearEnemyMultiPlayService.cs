using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class EnemyAppearEnemyMultiPlayService : ImportantTaskMultiPlayServiceBase<EnemyAppearEnemyMultiPlayService.AppearEnemyInfo>
	{
		public class AppearEnemyInfo
		{
			public EnemyCharacter owner;

			public EnemyCtrl popEnemyCtrl;

			public CharacterBase target;

			public Vector3 popPos;

			public Quaternion popRot;

			public int childActionId;

			public bool isPopedInvincible;

			public bool production;

			public void Reset()
			{
			}

			public void CopyTo(AppearEnemyInfo dest)
			{
			}
		}

		private AppearEnemyInfo _tmpTaskParam;

		public void RequestAppearEnemy(int summonEventId, AppearEnemyInfo param)
		{
		}

		protected override void SendEvent(int taskId, AppearEnemyInfo param)
		{
		}

		public void OnReceiveAppearEnemy(AppearEnemyEvent recvEvent)
		{
		}

		protected override AppearEnemyInfo CloneParam(AppearEnemyInfo src)
		{
			return null;
		}

		protected override void Execute(AppearEnemyInfo param)
		{
		}

		protected override void OnReserved(AppearEnemyInfo param)
		{
		}

		protected override void OnResetReserve(AppearEnemyInfo param)
		{
		}
	}
}
