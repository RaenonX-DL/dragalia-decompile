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
	public class CampaignTargetElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _GroupId;
		[SerializeField]
		private QuestGroupType _QuestGroupType;
		[SerializeField]
		private int _QuestGroupId;
	
		// Properties
		public int Id { get; }
		public int GroupId { get; }
		public QuestGroupType QuestGroupType { get; }
		public int QuestGroupId { get; }
	
		// Constructors
		public CampaignTargetElement();
	}
}
