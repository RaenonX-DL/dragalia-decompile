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
	public class RankingDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _GroupId;
		[SerializeField]
		private int _QuestId;
		[SerializeField]
		private string _RankingStartDate;
		[SerializeField]
		private string _RankingEndDate;
		[SerializeField]
		private string _RankingViewEndDate;
	
		// Properties
		public int Id { get; }
		public int GroupId { get; }
		public int QuestId { get; }
		public string RankingStartDate { get; }
		public string RankingEndDate { get; }
		public string RankingViewEndDate { get; }
	
		// Constructors
		public RankingDataElement();
	}
}
