/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyOutsideWall
	{
		// Fields
		private EnemyCharacter _owner;
		private const float CHECK_TIME = 2f;
		private float _checkTiming;
		private int _rayHitTimes;
		private Vector3 _safePosition;
		private bool _active;
	
		// Properties
		public bool active { get; set; }
	
		// Constructors
		public EnemyOutsideWall(EnemyCharacter owner);
	
		// Methods
		public void Update();
		private void Warp();
		public void Reset();
	}
}
