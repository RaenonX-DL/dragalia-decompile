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
	public class DragonReliabilityLevelElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _DragonUnitType;
		[SerializeField]
		private int _Level;
		[SerializeField]
		private int _NecessaryReliability;
		[SerializeField]
		private int _TotalReliability;
	
		// Properties
		public int Id { get; }
		public int DragonUnitType { get; }
		public int Level { get; }
		public int NecessaryReliability { get; }
		public int TotalReliability { get; }
	
		// Constructors
		public DragonReliabilityLevelElement();
	}
}
