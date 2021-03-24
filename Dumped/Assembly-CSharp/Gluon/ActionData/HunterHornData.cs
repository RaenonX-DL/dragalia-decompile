/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class HunterHornData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _hitLabel;
		[HideInInspector]
		[SerializeField]
		private string _hitLabelBoost;
		[HideInInspector]
		[SerializeField]
		private string _seName;
	
		// Properties
		public string hitLabel { get; }
		public string hitLabelBoost { get; }
		public string seName { get; }
	
		// Constructors
		public HunterHornData();
	}
}
