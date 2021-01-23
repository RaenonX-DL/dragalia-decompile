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
	public class VisibleData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _isVisible;
		[HideInInspector]
		[SerializeField]
		private string _name;
		[HideInInspector]
		[SerializeField]
		private bool _isActionClear;
		[HideInInspector]
		[SerializeField]
		private bool _isEffUi;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public bool isVisible { get; }
		public string name { get; }
		public bool isActionClear { get; }
		public bool isEffUi { get; }
		public bool guarantee { get; }
	
		// Constructors
		public VisibleData();
	}
}
