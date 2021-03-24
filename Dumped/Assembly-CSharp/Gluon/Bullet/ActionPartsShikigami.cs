/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsShikigami : ActionPartsBullet
	{
		// Fields
		private readonly ShikigamiData _partsData;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<int, bool> __9__5_1;
			public static Func<int, bool> __9__5_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _GetActionIdsForLoad_b__5_1(int x);
			internal bool _GetActionIdsForLoad_b__5_0(int x);
		}
	
		// Constructors
		public ActionPartsShikigami(Gluon.ActionData.ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Initialize(CharacterBase chara);
		protected override void Fire();
		public override int[] GetActionIdsForLoad();
	}
}
