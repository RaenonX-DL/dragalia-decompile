/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsScapegoatRites : ActionParts
	{
		// Fields
		private readonly ScapegoatRitesData _partsData;
		private List<EnemyCharacter> _listTarget;
		private bool _isDone;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<EnemyCharacter> __9__7_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Proc_b__7_0(EnemyCharacter a, EnemyCharacter b);
		}
	
		// Constructors
		public ActionPartsScapegoatRites(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		private void Proc();
	}
}
