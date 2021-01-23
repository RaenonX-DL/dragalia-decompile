/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterCustomPointController_ZN : CharacterCustomPointController
	{
		// Fields
		private int lastCP;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public CharacterCustomPointController_ZN __4__this;
			public AbilityDataElement ade;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _OnCPMatched_b__0();
		}
	
		// Constructors
		public CharacterCustomPointController_ZN();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void SetCP(int index, int value);
		private void OnGaugeAnimComplete(int index);
		private void ApplyUIEffect(Action onUIDone);
		private void OnCPMatched(AbilityDataElement ade);
		public override IconType GetIconType();
		private CharacterBase CheckCurrentCharaIsActiveInHierarchy();
		public override void OnContinue();
	}
}
