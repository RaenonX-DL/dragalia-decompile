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
	public class EnemyAbilityProcChildPlay : EnemyAbilityProcBase
	{
		// Fields
		[CompilerGenerated]
		private float _duration_k__BackingField;
		[CompilerGenerated]
		private float _restartTime_k__BackingField;
		private float _timer;
		private bool _reserveRestart;
		private float[] _abnormalResist;
		private float[] _abnormalPreResist;
	
		// Properties
		public float duration { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float restartTime { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public EnemyAbilityProcChildPlay(Gluon.EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_);
	
		// Methods
		public override void Play();
		private void OnPlay();
		public override void Stop();
		private void OnStop();
		public override void OnUpdate();
		public void SetAbnormalResist(AbnormalStatusType type, int value);
		private bool UnisonPlay();
		private bool UnisonStop();
		public void ResetTimer();
		public override void OnEnemyAbilityEvent(Gluon.Event.EnemyAbility recvData);
	}
}
