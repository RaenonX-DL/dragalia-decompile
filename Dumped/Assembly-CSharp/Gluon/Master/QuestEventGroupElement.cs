/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class QuestEventGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _EventViewName;
		[SerializeField]
		private int _BaseQuestGroupId;
		[SerializeField]
		private int _SortKey;
		[SerializeField]
		private QuestGroupIntervalType _QuestGroupIntervalType;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
		[SerializeField]
		private int _IsViewSoloMultiTab;
		[SerializeField]
		private int _IsHideBanner;
		[SerializeField]
		private int _NoticeDayCount;
		[SerializeField]
		private int _FirstViewQuestStory;
	
		// Properties
		public int Id { get; }
		public string EventViewName { get; }
		public int BaseQuestGroupId { get; }
		public int SortKey { get; }
		public QuestGroupIntervalType QuestGroupIntervalType { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
		public int IsViewSoloMultiTab { get; }
		public int IsHideBanner { get; }
		public int NoticeDayCount { get; }
		public int FirstViewQuestStory { get; }
	
		// Constructors
		public QuestEventGroupElement();
	}
}
