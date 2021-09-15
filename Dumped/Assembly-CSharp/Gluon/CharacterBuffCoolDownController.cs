/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterBuffCoolDownController
	{
		// Fields
		public Dictionary<CharacterBuffType, CoolDownData> buffCoolDownDictonary;
	
		// Nested types
		public class CoolDownData
		{
			// Fields
			public float coolDown;
			public float maxCoolDown;
			public CharacterBase owner;
			public Func<bool> onDelayApply;
			public int buffIconId;
	
			// Properties
			public float CoolDownRate { get; }
	
			// Constructors
			public CoolDownData();
		}
	
		// Constructors
		public CharacterBuffCoolDownController();
	
		// Methods
		public void SetDelayApply(CharacterBuffType type, CharacterBase owner, int conditionId, float rate, Func<bool> onDelayApply);
		public void RegisterCoolDownForBuff(CharacterBuffType type, float coolDown);
		public void Reset();
		public bool IsCoolingDown(CharacterBuffType type);
		public CoolDownData GetCoolingDown(int buffIconId);
		public void Update();
		private void UpdateBuffCoolDown(float delta);
		public void RemoveCoolDownForBuffType(CharacterBuffType type);
		public void RemoveAllCoolDownBuffs();
	}
}
