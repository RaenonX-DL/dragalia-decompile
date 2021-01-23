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
	public class BoxSummonDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _Priority;
		[SerializeField]
		private int _EventId;
		[SerializeField]
		private string _CommenceDate;
		[SerializeField]
		private string _CompleteDate;
		[SerializeField]
		private int _EventItemId;
		[SerializeField]
		private int _CostNum;
		[SerializeField]
		private GiftType _ResetEntityType;
		[SerializeField]
		private int _ResetEntityId;
		[SerializeField]
		private int _SequenceCount;
	
		// Properties
		public int Id { get; }
		public int Priority { get; }
		public int EventId { get; }
		public string CommenceDate { get; }
		public string CompleteDate { get; }
		public int EventItemId { get; }
		public int CostNum { get; }
		public GiftType ResetEntityType { get; }
		public int ResetEntityId { get; }
		public int SequenceCount { get; }
	
		// Constructors
		public BoxSummonDataElement();
	}
}
