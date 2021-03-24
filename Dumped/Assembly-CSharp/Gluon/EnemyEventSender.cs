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
	public class EnemyEventSender : EventSenderBase
	{
		// Fields
		private EnemyCharacter enemy;
		private EnemyCtrl enemyCtrl;
	
		// Properties
		public override CharacterBase character { get; }
	
		// Constructors
		public EnemyEventSender();
	
		// Methods
		public override void Initialize(CharacterId characterId, bool useMoveBundle = false);
		protected override bool IsAiAwake();
	}
}
