/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class QuestSkillTalkElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private QuestSkillEnum _QuestSkillName;
		[SerializeField]
		private int _QuestSkillLevel;
		[SerializeField]
		private int _TalkId;
		[SerializeField]
		private QuestSkillTalkTrigger _Trigger;
		[SerializeField]
		private int _IntValue01;
		[SerializeField]
		private int _IsPlayPlural;
	
		// Properties
		public int Id { get; }
		public QuestSkillEnum QuestSkillName { get; }
		public int QuestSkillLevel { get; }
		public int TalkId { get; }
		public QuestSkillTalkTrigger Trigger { get; }
		public int IntValue01 { get; }
		public int IsPlayPlural { get; }
	
		// Constructors
		public QuestSkillTalkElement();
	}
}
