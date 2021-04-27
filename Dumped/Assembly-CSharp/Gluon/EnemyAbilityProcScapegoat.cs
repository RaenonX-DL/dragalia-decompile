/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAbilityProcScapegoat : EnemyAbilityProcBase
	{
		// Fields
		private float _timer;
		private float _totalTime;
		[CompilerGenerated]
		private List<EnemyCharacter> _SubtractedTargets_k__BackingField;
	
		// Properties
		public List<EnemyCharacter> SubtractedTargets { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public EnemyAbilityProcScapegoat(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Setup();
		public override void Stop();
		public override void Play();
		public override void OnUpdate();
		public void SetTimer(float time);
		private void ShowUI();
		private void HideUI();
		private void SetUIGaugeTimer();
		public override void CreateCharacterMarkRelationUI();
	}
}
