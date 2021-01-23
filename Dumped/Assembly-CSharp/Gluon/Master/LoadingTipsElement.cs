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
	public class LoadingTipsElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _TipsLayoutType;
		[SerializeField]
		private int _TipsType;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private string _Text;
		[SerializeField]
		private int _ImageId;
		[SerializeField]
		private QuestType _ReleaseQuestType;
		[SerializeField]
		private int _ReleaseQuestId;
		[SerializeField]
		private int _AssignedTurorialStepId;
		[SerializeField]
		private int _AssignedTipsType;
		[SerializeField]
		private int _AssignedTargetId;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
	
		// Properties
		public int Id { get; }
		public int TipsLayoutType { get; }
		public int TipsType { get; }
		public string Title { get; }
		public string Text { get; }
		public int ImageId { get; }
		public QuestType ReleaseQuestType { get; }
		public int ReleaseQuestId { get; }
		public int AssignedTurorialStepId { get; }
		public int AssignedTipsType { get; }
		public int AssignedTargetId { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
	
		// Constructors
		public LoadingTipsElement();
	}
}
