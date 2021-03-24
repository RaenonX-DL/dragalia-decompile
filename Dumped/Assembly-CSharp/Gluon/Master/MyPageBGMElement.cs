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
	public class MyPageBGMElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _BgmId;
		[SerializeField]
		private string _BgmName;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
		[SerializeField]
		private int _ReleaseQuestStoryId;
		[SerializeField]
		private int _IsForceSetting;
	
		// Properties
		public int Id { get; }
		public int BgmId { get; }
		public string BgmName { get; }
		public int SortId { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
		public int ReleaseQuestStoryId { get; }
		public int IsForceSetting { get; }
	
		// Constructors
		public MyPageBGMElement();
	}
}
