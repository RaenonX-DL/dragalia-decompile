﻿/*
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
	public class RankingGroupDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _RankingTierGroupId;
		[SerializeField]
		private string _RankingStartDate;
		[SerializeField]
		private string _RankingEndDate;
		[SerializeField]
		private string _RankingViewEndDate;
		[SerializeField]
		private int _IsUseDecimalNumber;
	
		// Properties
		public int Id { get; }
		public int RankingTierGroupId { get; }
		public string RankingStartDate { get; }
		public string RankingEndDate { get; }
		public string RankingViewEndDate { get; }
		public int IsUseDecimalNumber { get; }
	
		// Constructors
		public RankingGroupDataElement();
	}
}
