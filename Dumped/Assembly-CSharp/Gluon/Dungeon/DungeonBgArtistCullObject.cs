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
	public class DungeonBgArtistCullObject : DungeonBgArtistUseCameraBase
	{
		// Fields
		private Renderer[] targetRendererArray;
		private bool enableFlagLog;
		[SerializeField]
		private float cullDistance;
		private static readonly float gizmoHeight;
		private static readonly Vector3[] gizmoOffset;
	
		// Constructors
		public DungeonBgArtistCullObject();
		static DungeonBgArtistCullObject();
	
		// Methods
		protected override void Awake();
		public override void FastUpdate();
		private void OnDrawGizmos();
	}
}
