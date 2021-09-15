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
	public class EnemyCallMinionMultiPlayService : ImportantTaskMultiPlayServiceBase<Gluon.EnemyCharacter.CallMinionInfo>
	{
		// Fields
		private EnemyCharacter.CallMinionInfo _tmpTaskParam;
	
		// Constructors
		public EnemyCallMinionMultiPlayService();
	
		// Methods
		public void RequestCallMinion(int taskId, EnemyCharacter.CallMinionInfo param);
		protected override void SendEvent(int taskId, EnemyCharacter.CallMinionInfo param);
		public void OnReceiveCallMinion(CallMinionEvent recvEvent);
		protected override EnemyCharacter.CallMinionInfo CloneParam(EnemyCharacter.CallMinionInfo src);
		protected override void Execute(EnemyCharacter.CallMinionInfo param);
		protected override void OnReserved(EnemyCharacter.CallMinionInfo param);
		protected override void OnResetReserve(EnemyCharacter.CallMinionInfo param);
	}
}
