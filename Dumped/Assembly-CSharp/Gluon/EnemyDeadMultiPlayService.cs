/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyDeadMultiPlayService
	{
		// Fields
		private bool _isDirty;
		private float _nextSendEventTimer;
		private static readonly float SendEventInterval;
		private EnemyDead _tempSendEvent;
	
		// Constructors
		public EnemyDeadMultiPlayService();
		static EnemyDeadMultiPlayService();
	
		// Methods
		public void PostInitializeEnemy(EnemyCharacter enemy);
		public void UpdateSendEvent();
		public void OnEnemyDead(EnemyCharacter deadEnemy, DeadReason reason);
		private void NotifyEnemyDead(EnemyCharacter deadEnemy);
		private void SendEnemyDead();
		private void SetDirty();
	}
}
