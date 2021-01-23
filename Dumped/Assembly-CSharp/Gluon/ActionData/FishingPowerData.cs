/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class FishingPowerData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _redFishingPower;
		[HideInInspector]
		[SerializeField]
		private int _goldFishingPower;
		[HideInInspector]
		[SerializeField]
		private int _yakiFishingPower;
	
		// Properties
		public int redFishingPower { get; }
		public int goldFishingPower { get; }
		public int yakiFishingPower { get; }
	
		// Constructors
		public FishingPowerData();
	}
}
