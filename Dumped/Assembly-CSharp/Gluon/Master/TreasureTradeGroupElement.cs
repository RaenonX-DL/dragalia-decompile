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
	public class TreasureTradeGroupElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _TreasureTradeType;
		[SerializeField]
		private int _Priority;
		[SerializeField]
		private string _CommenceDate;
		[SerializeField]
		private string _CompleteDate;
		[SerializeField]
		private int _TabGroupCount;
		[SerializeField]
		private string _TabGroupText1;
		[SerializeField]
		private string _TabGroupText2;
		[SerializeField]
		private string _TabGroupText3;
		[SerializeField]
		private string _TabGroupText4;
	
		// Properties
		public int Id { get; }
		public int TreasureTradeType { get; }
		public int Priority { get; }
		public string CommenceDate { get; }
		public string CompleteDate { get; }
		public int TabGroupCount { get; }
		public string TabGroupText1 { get; }
		public string TabGroupText2 { get; }
		public string TabGroupText3 { get; }
		public string TabGroupText4 { get; }
	
		// Constructors
		public TreasureTradeGroupElement();
	}
}
