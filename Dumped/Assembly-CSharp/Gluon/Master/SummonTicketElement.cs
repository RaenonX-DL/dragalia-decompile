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
	public class SummonTicketElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _Name;
		[SerializeField]
		private string _Description;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _DrawType;
		[SerializeField]
		private SummonType _SummonType;
		[SerializeField]
		private int _SummonId;
		[SerializeField]
		private int _LimitType;
		[SerializeField]
		private int _LimitTime;
		[SerializeField]
		private string _CommenceDate;
		[SerializeField]
		private string _CompleteDate;
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public string Description { get; }
		public int SortId { get; }
		public int DrawType { get; }
		public SummonType SummonType { get; }
		public int SummonId { get; }
		public int LimitType { get; }
		public int LimitTime { get; }
		public string CommenceDate { get; }
		public string CompleteDate { get; }
	
		// Constructors
		public SummonTicketElement();
	}
}
