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
	public class QuestWallElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _QuestGroupId;
		[SerializeField]
		private QuestGroupType _GroupType;
		[SerializeField]
		private string _SectionName;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private string _Class;
		[SerializeField]
		private ElementalType _Elemental;
		[SerializeField]
		private int _IsLockView;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
		[SerializeField]
		private string _ThumbnailImage;
		[SerializeField]
		private string _ArmoryBackImage;
	
		// Properties
		public int Id { get; }
		public int QuestGroupId { get; }
		public QuestGroupType GroupType { get; }
		public string SectionName { get; }
		public string Title { get; }
		public string Class { get; }
		public ElementalType Elemental { get; }
		public int IsLockView { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
		public string ThumbnailImage { get; }
		public string ArmoryBackImage { get; }
	
		// Constructors
		public QuestWallElement();
	}
}
