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
	public class CharacterBuffRestoreCtrl
	{
		// Fields
		private List<RestoreData> _restoreDataList;
	
		// Nested types
		private struct RestoreTrait
		{
			// Fields
			public bool durationNum;
	
			// Methods
			public bool IsRestoreAny();
		}
	
		private struct RestoreData
		{
			// Fields
			public RestoreTrait trait;
			public int actionConditionId;
			public int abilityId;
			public CharacterBuffType type;
			public int durationNum;
		}
	
		// Constructors
		public CharacterBuffRestoreCtrl();
	
		// Methods
		public bool NeedRestore(int actionConditionId, int abilityId);
		public void SaveRestoreData(ref CharacterBuff.BuffUnion buff);
		public bool HasRestoreData(int actionConditionId, int abilityId, CharacterBuffType type = CharacterBuffType.None);
		public void Restore(int actionConditionId, int abilityId, ref int durationNum, CharacterBuffType type = CharacterBuffType.None);
		public void ClearAll();
		private RestoreTrait GetRestoreTrait(int actionConditionId);
		private int FindRestoreDataIndex(int actionConditionId, int abilityId, CharacterBuffType type);
	}
}
