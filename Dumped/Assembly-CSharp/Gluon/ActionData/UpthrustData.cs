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
	public class UpthrustData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
		[HideInInspector]
		[SerializeField]
		private string _popEffect;
		[HideInInspector]
		[SerializeField]
		private string _popSE;
	
		// Properties
		public int childActionId { get; }
		public string popEffect { get; }
		public string popSE { get; }
	
		// Constructors
		public UpthrustData();
	}
}
