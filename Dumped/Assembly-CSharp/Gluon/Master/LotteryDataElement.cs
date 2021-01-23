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
	public class LotteryDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _ViewStartDate;
		[SerializeField]
		private string _LotteryDate;
		[SerializeField]
		private string _ViewCloseDate;
		[SerializeField]
		private int _InformationId;
		[SerializeField]
		private int _InformationEndId;
		[SerializeField]
		private int _LotteryTicketId;
	
		// Properties
		public int Id { get; }
		public string ViewStartDate { get; }
		public string LotteryDate { get; }
		public string ViewCloseDate { get; }
		public int InformationId { get; }
		public int InformationEndId { get; }
		public int LotteryTicketId { get; }
	
		// Constructors
		public LotteryDataElement();
	}
}
