/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class AmuletTradeElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _AmuletId;
		[SerializeField]
		private int _NeedDewPoint1;
		[SerializeField]
		private int _NeedDewPoint2;
		[SerializeField]
		private int _NeedDewPoint3;
		[SerializeField]
		private int _NeedDewPoint4;
		[SerializeField]
		private int _NeedDewPoint5;
		[SerializeField]
		private int _Priority;
		[SerializeField]
		private int _Limit;
		[SerializeField]
		private string _CommenceDate;
		[SerializeField]
		private string _CompleteDate;
		[SerializeField]
		private string _PickupViewStartDate;
		[SerializeField]
		private string _PickupViewEndDate;
		[SerializeField]
		private int _MemoryPickupEventId;
	
		// Properties
		public int Id { get; }
		public int AmuletId { get; }
		public int NeedDewPoint1 { get; }
		public int NeedDewPoint2 { get; }
		public int NeedDewPoint3 { get; }
		public int NeedDewPoint4 { get; }
		public int NeedDewPoint5 { get; }
		public int Priority { get; }
		public int Limit { get; }
		public string CommenceDate { get; }
		public string CompleteDate { get; }
		public string PickupViewStartDate { get; }
		public string PickupViewEndDate { get; }
		public int MemoryPickupEventId { get; }
	
		// Constructors
		public AmuletTradeElement();
	}
}
