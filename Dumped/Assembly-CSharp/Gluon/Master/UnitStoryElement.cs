/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class UnitStoryElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private int _GroupId;
		[SerializeField]
		private int _BaseId;
		[SerializeField]
		private int _VariationId;
		[SerializeField]
		private int _StoryReleaseType;
		[SerializeField]
		private int _ReleaseTriggerId;
		[SerializeField]
		private int _ReleaseStep;
		[SerializeField]
		private int _UnlockQuestStoryId;
		[SerializeField]
		private int _UnlockTriggerStoryId;
		[SerializeField]
		private int _SortId;
	
		// Properties
		public int Id { get; }
		public string Title { get; }
		public int GroupId { get; }
		public int BaseId { get; }
		public int VariationId { get; }
		public int StoryReleaseType { get; }
		public int ReleaseTriggerId { get; }
		public int ReleaseStep { get; }
		public int UnlockQuestStoryId { get; }
		public int UnlockTriggerStoryId { get; }
		public int SortId { get; }
	
		// Constructors
		public UnitStoryElement();
	}
}
