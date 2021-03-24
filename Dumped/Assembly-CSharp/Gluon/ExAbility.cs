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
	public class ExAbility : AbilityBase
	{
		// Constructors
		public ExAbility();
	
		// Methods
		public void Initialize(CharacterBase original, CharacterBase current);
		public void Update(CharacterBase original, CharacterBase current);
		private void Apply(CharacterBase owner, ExAbilityDataElement ade, int idx);
		public static int GetType(ExAbilityDataElement ade, int idx);
		public static AbilityTargetAction GetTargetAction(ExAbilityDataElement ade, int idx);
		public static int GetVariousId(ExAbilityDataElement ade, int idx);
		public static float GetValue(ExAbilityDataElement ade, int idx);
	}
}
