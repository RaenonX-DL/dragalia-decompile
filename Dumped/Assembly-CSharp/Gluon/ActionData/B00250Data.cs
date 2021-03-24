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
	public class B00250Data : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private Behavior _behavior;
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
		[HideInInspector]
		[SerializeField]
		private float _moveDuration;
	
		// Properties
		public Behavior behavior { get; }
		public int childActionId { get; }
		public float moveDuration { get; }
	
		// Nested types
		public enum Behavior
		{
			attack = 0,
			retreat = 1
		}
	
		// Constructors
		public B00250Data();
	}
}
