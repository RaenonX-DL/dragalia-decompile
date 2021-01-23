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
	public class QuestSkillTalk
	{
		// Fields
		private NotifyCharacter.CharaDialogueNPCParam _dialogueParam;
		private List<QuestSkillTalkElement> _datas;
		private List<int> _candidates;
		private List<int> _finished;
		private static int TriggerNum;
		private deleWatchTrigger[] _watchTrigger;
		private QuestSkillEnum questSkillType;
	
		// Properties
		public bool NoTalk { get; }
	
		// Nested types
		private delegate void deleWatchTrigger(float paramFloat_1 = 0f, float paraFloat_2 = 0f);
	
		// Constructors
		public QuestSkillTalk(QuestSkillEnum type);
		static QuestSkillTalk();
	
		// Methods
		public void Initialize();
		public void Reset();
		private void RegistryDelegate();
		public bool WatchTrigger(QuestSkillTalkTrigger trig, float paramFloat_1 = 0f, float paramFloat_2 = 0f);
		private void Talk(int id);
		private void FuncTrigger_QuestSkill(float paramFloat_1 = 0f, float paramFloat_2 = 0f);
		private void FuncTrigger_RecastRateHiger(float paramFloat_1 = 0f, float paramFloat_2 = 0f);
		private void FuncTrigger_PrayObjectDestory(float paramFloat_1 = 0f, float paramFloat_2 = 0f);
		private void FuncTrigger_MiasmaBegin(float paramFloat_1 = 0f, float paramFloat_2 = 0f);
	}
}
