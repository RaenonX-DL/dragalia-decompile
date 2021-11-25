using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsAppearEnemy : ActionParts
	{
		private readonly AppearEnemyData _partsData;

		private EnemyAppearEnemyMultiPlayService.AppearEnemyInfo applyEnemyInfo;

		private int taskId;

		private RunActionIntParameter taskIdParam;

		public ActionPartsAppearEnemy(Gluon.ActionData.ActionParts resource)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		protected override void OnStart()
		{
		}

		protected void PopEnemy(EnemyCharacter enemyOwner, EnemyCtrl popEnemyCtrl)
		{
		}

		private void PopEnemyHostSync(EnemyCharacter enemyOwner, EnemyCtrl popEnemyCtrl, Vector3 popPos, Quaternion popRot)
		{
		}

		private void PopEnemyNoSync(EnemyCharacter enemyOwner, EnemyCtrl popEnemyCtrl, Vector3 popPos, Quaternion popRot)
		{
		}

		private void TargetCorrection(ref CommonObjectStatus target)
		{
		}
	}
}
