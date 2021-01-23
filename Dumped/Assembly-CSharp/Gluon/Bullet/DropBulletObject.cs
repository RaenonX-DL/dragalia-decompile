/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class DropBulletObject : BulletObjectWithMarker
	{
		// Fields
		[CompilerGenerated]
		private bool _fixedAim_k__BackingField;
		[CompilerGenerated]
		private Vector3 _aimPosition_k__BackingField;
		[CompilerGenerated]
		private bool _fixPos_k__BackingField;
	
		// Properties
		public bool fixedAim { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 aimPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool fixPos { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public DropBulletObject();
	
		// Methods
		protected override void Clear();
		protected override bool State_MarkerSet();
		protected override bool State_Fire();
		protected override bool State_BulletRun();
	}
}
