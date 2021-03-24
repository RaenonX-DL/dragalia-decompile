/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonBgArtistCullUnit : DungeonBgArtistUseCameraBase
	{
		// Fields
		private Transform childTransform;
		private bool enableFlagLog;
		private static readonly float cullDistanceHuman;
		private static readonly float cullDistanceDragon;
		[SerializeField]
		private float cullDistance;
	
		// Constructors
		public DungeonBgArtistCullUnit();
		static DungeonBgArtistCullUnit();
	
		// Methods
		protected override void Awake();
		protected void Start();
		public override void FastUpdate();
	}
}
