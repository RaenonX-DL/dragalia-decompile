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
	public class HeadTextData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _text;
		[HideInInspector]
		[SerializeField]
		private ValueType _valueType;
	
		// Properties
		public string text { get; }
		public ValueType valueType { get; }
	
		// Nested types
		public enum ValueType
		{
			None = 0,
			BuffCount = 1,
			RemainTimes = 2
		}
	
		// Constructors
		public HeadTextData();
	}
}
