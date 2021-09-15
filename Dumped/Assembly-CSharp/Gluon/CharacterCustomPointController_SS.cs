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
	public class CharacterCustomPointController_SS : CharacterCustomPointController
	{
		// Constructors
		public CharacterCustomPointController_SS();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void SetCP(int index, int value);
		private void OnGaugeAnimComplete(int index, int prevCP, int currCP);
		public override void OnSkill(int actionId, int skillId, int skillIndex);
		private void OnCPMatched(AbilityDataElement ade, int actionId, int skillId, int skillIndex);
		public override IconType GetIconType();
		public override bool ClearCPOnContinue();
	}
}
