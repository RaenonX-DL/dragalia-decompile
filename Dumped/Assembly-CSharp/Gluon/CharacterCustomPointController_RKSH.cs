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
	public class CharacterCustomPointController_RKSH : CharacterCustomPointController
	{
		// Fields
		private int lastCP;
	
		// Properties
		public override int maxCP { get; }
	
		// Constructors
		public CharacterCustomPointController_RKSH();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void Update();
		public override void SetCP(int index, int value);
		private void OnGaugeAnimComplete(int index, int prevCP, int currCP);
		private void OnCPMatched(AbilityDataElement ade, int skillId, int skillIndex);
		public override IconType GetIconType();
		private CharacterBase CheckCurrentCharaIsActiveInHierarchy();
		public override bool ClearCPOnReborn();
	}
}
