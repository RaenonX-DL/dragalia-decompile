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
	public class EnemyAbilityProcBookOfDoom : EnemyAbilityProcBase
	{
		// Fields
		private int _count;
		private bool _hasBoost;
		private bool _hasPlayed;
		private const float RESTART_TIME = 5f;
		private float _timer;
		private bool _isExtinctionActionReserved;
		private bool _isExtinctionAactionSyncd;
		private int _isSubCountReserved;
		[CompilerGenerated]
		private bool _isWaitActionForExtraAction_k__BackingField;
	
		// Properties
		public int Count { get; }
		private bool isWaitActionForExtraAction { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public EnemyAbilityProcBookOfDoom(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void Stop();
		public override void OnUpdate();
		public void SubCount(int point, EnemyCharacter deadEnemy, bool isSync);
		private void UpdateCountUI(int count);
		private bool CheckWaitAction();
		private void PlayAction();
		public override void OnRecieveCharacterState(CharacterState characterState);
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
	}
}
