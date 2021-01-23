/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickInputCtrl
	{
		// Fields
		private Dictionary<CharacterBase, CharaGimmickBaseInputUI> _inputDic;
		private CharaGimmickBaseInputUI _commonAddCountInputUI;
		private CharaGimmickBaseInputUI _commonAddGaugeInputUI;
		private CharaGimmickBaseInputUI _activeInputUI;
	
		// Nested types
		public enum InputType
		{
			None = 0,
			AddCountInput = 1,
			AddGaugeInput = 2
		}
	
		// Constructors
		public CharaGimmickInputCtrl();
	
		// Methods
		public void Attach(CharacterBase owner, InputType type);
		public void Show(CharacterBase owner);
		public void Hide(CharacterBase owner, bool anim);
		public void Hide(bool anim);
		public void SetCount(CharacterBase owner, int num, bool force = false, bool immediate = false);
		public bool CheckAdditionalInputCount(CharacterBase chara);
		public bool CheckAdditionalInputGauge(CharacterBase chara);
	}
}
