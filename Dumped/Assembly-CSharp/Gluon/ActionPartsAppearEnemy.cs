/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsAppearEnemy : ActionParts
	{
		// Fields
		private readonly AppearEnemyData _partsData;
		private EnemyAppearEnemyMultiPlayService.AppearEnemyInfo applyEnemyInfo;
		private int taskId;
		private RunActionIntParameter taskIdParam;
	
		// Constructors
		public ActionPartsAppearEnemy(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		protected void PopEnemy(EnemyCharacter enemyOwner, EnemyCtrl popEnemyCtrl);
		private void PopEnemyHostSync(EnemyCharacter enemyOwner, EnemyCtrl popEnemyCtrl, Vector3 popPos, Quaternion popRot);
		private void PopEnemyNoSync(EnemyCharacter enemyOwner, EnemyCtrl popEnemyCtrl, Vector3 popPos, Quaternion popRot);
		private void TargetCorrection(ref CommonObjectStatus target);
	}
}
