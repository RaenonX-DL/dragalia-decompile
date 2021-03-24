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
	public class WeaponLimitBreakElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _WeaponQuantity1;
		[SerializeField]
		private int _WeaponQuantity2;
		[SerializeField]
		private int _WeaponQuantity3;
		[SerializeField]
		private int _WeaponQuantity4;
	
		// Properties
		public int Id { get; }
		public int WeaponQuantity1 { get; }
		public int WeaponQuantity2 { get; }
		public int WeaponQuantity3 { get; }
		public int WeaponQuantity4 { get; }
	
		// Constructors
		public WeaponLimitBreakElement();
	}
}
