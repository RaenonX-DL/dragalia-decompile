/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyTalk
	{
		// Fields
		private EnemyCharacter _owner;
		private NotifyCharacter.CharaDialogueNPCParam _dialogueParam;
		private List<EnemyTalkDataElement> _datas;
		private List<int> _candidates;
		private List<int> _finished;
		private static int TriggerNum;
		private deleWatchTrigger[] _watchTrigger;
	
		// Properties
		public bool NoTalk { get; }
	
		// Nested types
		private delegate void deleWatchTrigger();
	
		// Constructors
		public EnemyTalk();
		static EnemyTalk();
	
		// Methods
		public void Initialize(EnemyCharacter owner);
		public void Reset();
		private void RegistryDelegate();
		public bool WatchTrigger(EnemyTalkTrigger trig);
		private void Talk(int id, bool clearAndPlay);
		private void FuncTrigger_EntryTiming();
		private void FuncTrigger_DeadTiming();
		private void FuncTrigger_HpRate();
		private void FuncTrigger_BreakHpRate();
		[CompilerGenerated]
		private void _RegistryDelegate_b__13_0();
	}
}
