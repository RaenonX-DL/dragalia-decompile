/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAppearEnemyMultiPlayService : ImportantTaskMultiPlayServiceBase<Gluon.EnemyAppearEnemyMultiPlayService.AppearEnemyInfo>
	{
		// Fields
		private AppearEnemyInfo _tmpTaskParam;
	
		// Nested types
		public class AppearEnemyInfo
		{
			// Fields
			public EnemyCharacter owner;
			public EnemyCtrl popEnemyCtrl;
			public CharacterBase target;
			public Vector3 popPos;
			public Quaternion popRot;
			public int childActionId;
			public bool isPopedInvincible;
			public bool production;
	
			// Constructors
			public AppearEnemyInfo();
	
			// Methods
			public void Reset();
			public void CopyTo(AppearEnemyInfo dest);
		}
	
		// Constructors
		public EnemyAppearEnemyMultiPlayService();
	
		// Methods
		public void RequestAppearEnemy(int summonEventId, AppearEnemyInfo param);
		protected override void SendEvent(int taskId, AppearEnemyInfo param);
		public void OnReceiveAppearEnemy(AppearEnemyEvent recvEvent);
		protected override AppearEnemyInfo CloneParam(AppearEnemyInfo src);
		protected override void Execute(AppearEnemyInfo param);
	}
}
