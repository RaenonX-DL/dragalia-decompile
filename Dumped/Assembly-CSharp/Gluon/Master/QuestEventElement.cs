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
	public class QuestEventElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _EventViewName;
		[SerializeField]
		private int _ShowCatetory;
		[SerializeField]
		private int _UpsideCategory;
		[SerializeField]
		private int _SortKey;
		[SerializeField]
		private QuestEventType _QuestEventType;
		[SerializeField]
		private int _QuestRibbonImageNo;
		[SerializeField]
		private int _IsViewSoloMultiTab;
		[SerializeField]
		private int _IsHeaderQuest;
		[SerializeField]
		private int _InformationId;
		[SerializeField]
		private int _IsViewNewBadge;
		[SerializeField]
		private int _QuestBonusReceiveType;
		[SerializeField]
		private QuestResetIntervalType _QuestBonusType;
		[SerializeField]
		private int _QuestBonusCount;
		[SerializeField]
		private int _QuestBonusStackCountMax;
		[SerializeField]
		private string _ReleaseText;
		[SerializeField]
		private string _ReleaseTextDetail;
	
		// Properties
		public int Id { get; }
		public string EventViewName { get; }
		public int ShowCatetory { get; }
		public int UpsideCategory { get; }
		public int SortKey { get; }
		public QuestEventType QuestEventType { get; }
		public int QuestRibbonImageNo { get; }
		public int IsViewSoloMultiTab { get; }
		public int IsHeaderQuest { get; }
		public int InformationId { get; }
		public int IsViewNewBadge { get; }
		public int QuestBonusReceiveType { get; }
		public QuestResetIntervalType QuestBonusType { get; }
		public int QuestBonusCount { get; }
		public int QuestBonusStackCountMax { get; }
		public string ReleaseText { get; }
		public string ReleaseTextDetail { get; }
	
		// Constructors
		public QuestEventElement();
	}
}
