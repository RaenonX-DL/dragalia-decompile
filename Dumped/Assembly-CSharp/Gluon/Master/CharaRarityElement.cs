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
	public class CharaRarityElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _MaxLimitLevel;
		[SerializeField]
		private int _MaxLimitBreakCount;
		[SerializeField]
		private int _DuplicateDewPoint;
		[SerializeField]
		private int _MaxHpPlusCount;
		[SerializeField]
		private int _MaxAtkPlusCount;
	
		// Properties
		public int Id { get; }
		public int MaxLimitLevel { get; }
		public int MaxLimitBreakCount { get; }
		public int DuplicateDewPoint { get; }
		public int MaxHpPlusCount { get; }
		public int MaxAtkPlusCount { get; }
	
		// Constructors
		public CharaRarityElement();
	}
}
