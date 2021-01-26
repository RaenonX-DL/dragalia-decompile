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
	public class EnemyBoostData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _onoff;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public bool onoff { get; }
		public bool guarantee { get; }
	
		// Constructors
		public EnemyBoostData();
	}
}
