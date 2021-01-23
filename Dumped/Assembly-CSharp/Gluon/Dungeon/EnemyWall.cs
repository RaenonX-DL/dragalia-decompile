/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class EnemyWall : Wall
	{
		// Fields
		[SerializeField]
		protected WallSize _wallSize;
	
		// Nested types
		protected enum WallSize
		{
			Small = 0,
			Long = 1
		}
	
		// Constructors
		public EnemyWall();
	
		// Methods
		protected override void DrawModelOpen(bool isOpenFlag);
		protected override void OnTriggerEvent();
	}
}
