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
	public class InitializeWeakData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private AppearEnemyData.ChildType _childType;
		[HideInInspector]
		[SerializeField]
		private float _priorityTargetRange;
		[HideInInspector]
		[SerializeField]
		private int[] _changeHps;
	
		// Properties
		public AppearEnemyData.ChildType childType { get; }
		public float priorityTargetRange { get; }
		public int[] changeHps { get; }
	
		// Constructors
		public InitializeWeakData();
	}
}
