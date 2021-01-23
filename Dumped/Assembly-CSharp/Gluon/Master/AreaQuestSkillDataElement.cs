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
	public class AreaQuestSkillDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _AreaId;
		[SerializeField]
		private int _Difficulty;
		[SerializeField]
		private QuestSkillEnum _QuestSkillName1;
		[SerializeField]
		private string _GimmickLabel1;
	
		// Properties
		public int Id { get; }
		public string AreaId { get; }
		public int Difficulty { get; }
		public QuestSkillEnum QuestSkillName1 { get; }
		public string GimmickLabel1 { get; }
	
		// Constructors
		public AreaQuestSkillDataElement();
	}
}
