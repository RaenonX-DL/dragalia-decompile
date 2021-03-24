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
	public class WeaponTypePool
	{
		// Fields
		private Dictionary<string, HashSet<CharacterBase>> actionEffectPoolInfo;
		private static EffectPoolInfo[][] effectPoolInfos;
		private int[] bulletPoolCount;
		private EffectPoolInfo[] charaEffectPoolInfos;
		private EffectPoolInfo[] playerEffectPoolInfos;
	
		// Nested types
		private struct EffectPoolInfo
		{
			// Fields
			public string name;
			public int count;
		}
	
		// Constructors
		public WeaponTypePool();
		static WeaponTypePool();
	
		// Methods
		public void CreatePool(List<CharacterSelector> characterSelectors);
		public static void CreateCommonPoolOnType(WeaponType weaponType);
		public void AddActionEffectGroupPool(string effectName, CharacterBase actionOwner);
		public void CreateActionEffectPool();
		public static void GetAllPoolTypeGroupName(out HashSet<string> groupNameList);
	}
}
