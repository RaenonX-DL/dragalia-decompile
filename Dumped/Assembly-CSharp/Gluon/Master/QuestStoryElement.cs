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
	public class QuestStoryElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _SectionName;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private int _GroupId;
		[SerializeField]
		private QuestGroupType _GroupType;
		[SerializeField]
		private int _IsCutscene;
		[SerializeField]
		private int _IsViewNewStoryBadge;
		[SerializeField]
		private int _SortKey;
		[SerializeField]
		private string _ThumbnailImage;
		[SerializeField]
		private int _StoryReadCount;
		[SerializeField]
		private int _PayEntityTargetType;
		[SerializeField]
		private GiftType _PayEntityType;
		[SerializeField]
		private int _PayEntityId;
		[SerializeField]
		private int _PayEntityQuantity;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
	
		// Properties
		public int Id { get; }
		public string SectionName { get; }
		public string Title { get; }
		public int GroupId { get; }
		public QuestGroupType GroupType { get; }
		public int IsCutscene { get; }
		public int IsViewNewStoryBadge { get; }
		public int SortKey { get; }
		public string ThumbnailImage { get; }
		public int StoryReadCount { get; }
		public int PayEntityTargetType { get; }
		public GiftType PayEntityType { get; }
		public int PayEntityId { get; }
		public int PayEntityQuantity { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
	
		// Constructors
		public QuestStoryElement();
	}
}
