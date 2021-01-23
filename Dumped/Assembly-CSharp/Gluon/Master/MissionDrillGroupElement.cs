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
	public class MissionDrillGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _TextName;
		[SerializeField]
		private string _TextNameShort;
		[SerializeField]
		private int _Step;
		[SerializeField]
		private string _TextTitle;
		[SerializeField]
		private string _TextDetail;
		[SerializeField]
		private GiftType _UnlockEntityType1;
		[SerializeField]
		private int _UnlockEntityId1;
		[SerializeField]
		private int _UnlockEntityQuantity1;
		[SerializeField]
		private string _StartDate;
		[SerializeField]
		private string _EndDate;
	
		// Properties
		public int Id { get; }
		public string TextName { get; }
		public string TextNameShort { get; }
		public int Step { get; }
		public string TextTitle { get; }
		public string TextDetail { get; }
		public GiftType UnlockEntityType1 { get; }
		public int UnlockEntityId1 { get; }
		public int UnlockEntityQuantity1 { get; }
		public string StartDate { get; }
		public string EndDate { get; }
	
		// Constructors
		public MissionDrillGroupElement();
	}
}
