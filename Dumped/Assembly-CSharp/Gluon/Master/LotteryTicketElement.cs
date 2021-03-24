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
	public class LotteryTicketElement : IMasterElement
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
		private int _LotteryId;
		[SerializeField]
		private string _ViewStartTime;
		[SerializeField]
		private string _ViewEndTime;
	
		// Properties
		public int Id { get; }
		public string Name { get; }
		public string Description { get; }
		public int SortId { get; }
		public int LotteryId { get; }
		public string ViewStartTime { get; }
		public string ViewEndTime { get; }
	
		// Constructors
		public LotteryTicketElement();
	}
}
