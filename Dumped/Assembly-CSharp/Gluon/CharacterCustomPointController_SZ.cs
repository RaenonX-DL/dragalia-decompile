/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterCustomPointController_SZ : CharacterCustomPointController
	{
		// Fields
		private int lastCP;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public CharacterCustomPointController_SZ __4__this;
			public AbilityDataElement ade;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _OnCPMatched_b__0();
		}
	
		// Constructors
		public CharacterCustomPointController_SZ();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void AttachToUI();
		public override void SetCP(int index, int value);
		private void OnGaugeAnimComplete(int index);
		private void ApplyUIEffect(Action onUIDone);
		private void OnCPMatched(AbilityDataElement ade);
		public override IconType GetIconType();
		private CharacterBase CheckCurrentCharaIsActiveInHierarchy();
	}
}
