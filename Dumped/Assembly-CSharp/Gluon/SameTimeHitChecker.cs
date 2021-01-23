/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SameTimeHitChecker : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private readonly List<SameTimeHitData> _listSameTimeHit_k__BackingField;
	
		// Properties
		private List<SameTimeHitData> listSameTimeHit { [CompilerGenerated] get; }
	
		// Nested types
		public struct SameTimeHitData
		{
			// Fields
			public CharacterBase from;
			public CharacterBase to;
			public int actionId;
			public int permitId;
		}
	
		// Constructors
		public SameTimeHitChecker();
	
		// Methods
		private void LateUpdate();
		public void Clear();
		public bool Check(CollisionHitAttribute hit, CharacterBase target);
	}
}
