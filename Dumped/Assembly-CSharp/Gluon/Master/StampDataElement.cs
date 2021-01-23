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
	public class StampDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _ViewEndDate;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private string _Title;
		[SerializeField]
		private string _InfoMsg;
		[SerializeField]
		private string _VoiceId;
		[SerializeField]
		private GiftType _DuplicateEntityType;
		[SerializeField]
		private int _DuplicateEntityId;
		[SerializeField]
		private int _DuplicateEntityQuantity;
	
		// Properties
		public int Id { get; }
		public string ViewStartDate { get; }
		public string ViewEndDate { get; }
		public int SortId { get; }
		public string Title { get; }
		public string InfoMsg { get; }
		public string VoiceId { get; }
		public GiftType DuplicateEntityType { get; }
		public int DuplicateEntityId { get; }
		public int DuplicateEntityQuantity { get; }
	
		// Constructors
		public StampDataElement();
	}
}
