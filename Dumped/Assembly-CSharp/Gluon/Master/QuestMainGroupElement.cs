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
	public class QuestMainGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _EventViewName;
		[SerializeField]
		private int _ChapterNum;
		[SerializeField]
		private int _WorldMapId;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
		[SerializeField]
		private float _TopBackgroundPoint;
		[SerializeField]
		private float _LeftBackgroundPoint;
		[SerializeField]
		private float _RightBackgroundPoint;
		[SerializeField]
		private float _BottomBackgroundPoint;
		[SerializeField]
		private string _SynopsisText;
		[SerializeField]
		private string _TrailerTitle;
		[SerializeField]
		private string _TrailerText;
		[SerializeField]
		private QuestType _TrailerQuestType;
		[SerializeField]
		private int _TrailerQuestId;
	
		// Properties
		public int Id { get; }
		public string EventViewName { get; }
		public int ChapterNum { get; }
		public int WorldMapId { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
		public float TopBackgroundPoint { get; }
		public float LeftBackgroundPoint { get; }
		public float RightBackgroundPoint { get; }
		public float BottomBackgroundPoint { get; }
		public string SynopsisText { get; }
		public string TrailerTitle { get; }
		public string TrailerText { get; }
		public QuestType TrailerQuestType { get; }
		public int TrailerQuestId { get; }
	
		// Constructors
		public QuestMainGroupElement();
	}
}
