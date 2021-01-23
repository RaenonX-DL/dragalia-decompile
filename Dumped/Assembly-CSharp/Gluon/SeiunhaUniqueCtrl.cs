/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Bullet;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SeiunhaUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private List<SeiunhaBulletObject> _listBullet;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<SeiunhaBulletObject> __9__1_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _FastUpdate_b__1_0(SeiunhaBulletObject s);
		}
	
		// Constructors
		public SeiunhaUniqueCtrl();
	
		// Methods
		public override void FastUpdate();
		public void OnFire(SeiunhaBulletObject bullet);
		public void OnBringBack();
	}
}
