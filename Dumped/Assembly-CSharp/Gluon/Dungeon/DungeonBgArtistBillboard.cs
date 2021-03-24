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
	public class DungeonBgArtistBillboard : DungeonBgArtistUseCameraBase
	{
		// Fields
		[SerializeField]
		private bool startOnlyFlag;
		[SerializeField]
		private BillboardKind billboardkind;
		[SerializeField]
		private bool fixedAxisYFlag;
	
		// Nested types
		public enum BillboardKind
		{
			LookCameraPos = 0,
			CopyCameraRot = 1
		}
	
		// Constructors
		public DungeonBgArtistBillboard();
	
		// Methods
		protected override void Awake();
		public override void FastUpdate();
		private void SetBillboard();
	}
}
