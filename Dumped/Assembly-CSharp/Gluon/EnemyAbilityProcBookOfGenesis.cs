/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcBookOfGenesis : EnemyAbilityProcBase
	{
		// Fields
		private EnemyCharacter _book;
		private bool _hasBook;
		private EnemyCharacter _linked;
		[CompilerGenerated]
		private int _linkedId_k__BackingField;
		private bool _isPlayReserved;
		private bool _isStopReserved;
		private bool _isAppliedBuff;
	
		// Properties
		public int linkedId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public EnemyAbilityProcBookOfGenesis(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		private void SetBook();
		public override void Play();
		private void OnPlay();
		public override void Stop();
		private void OnStop();
		public override void OnUpdate();
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
	}
}
