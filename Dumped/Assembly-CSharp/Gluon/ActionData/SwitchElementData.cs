/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SwitchElementData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ElementalType _elementaType;
		[HideInInspector]
		[SerializeField]
		private bool _isSubSame;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ElementalType elementaType { get; }
		public bool isSubSame { get; }
		public bool guarantee { get; }
	
		// Constructors
		public SwitchElementData();
	}
}
