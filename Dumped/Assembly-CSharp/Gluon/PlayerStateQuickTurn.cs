/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerStateQuickTurn : PlayerStateBase
	{
		// Fields
		private float elapsedTime;
		private Vector3 subVelocity;
		private float time;
		public Direction direction;
	
		// Nested types
		public enum Direction
		{
			Back = 0,
			Right = 1,
			Left = 2
		}
	
		// Constructors
		public PlayerStateQuickTurn();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		public override void OnStateExit();
	}
}
