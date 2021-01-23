/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class ExchangeTicketElement
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
		private int _TicketType;
		[SerializeField]
		private string _CommenceDate;
		[SerializeField]
		private string _CompleteDate;
		[SerializeField]
		private string _ExchangeList;
		[SerializeField]
		private int _LimitTime;
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public string Description { get; }
		public int SortId { get; }
		public int TicketType { get; }
		public string CommenceDate { get; }
		public string CompleteDate { get; }
		public string ExchangeList { get; }
		public int LimitTime { get; }
	
		// Constructors
		public ExchangeTicketElement();
	}
}
