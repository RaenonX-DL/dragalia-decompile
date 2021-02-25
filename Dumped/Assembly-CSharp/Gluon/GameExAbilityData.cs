/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GameExAbilityData
	{
		// Fields
		private int _partySwitchIndex;
		private List<ExAbilityDataElement>[] exAbility1List;
		private List<AbilityDataElement>[] exAbility2List;
	
		// Nested types
		private class ExAbilityBuildData
		{
			// Fields
			[CompilerGenerated]
			private List<UnitData> _partyUnitList_k__BackingField;
	
			// Properties
			public List<UnitData> partyUnitList { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Nested types
			public class UnitData
			{
				// Fields
				public int charaId;
				public int exAbility1Level;
				public int exAbility2Level;
	
				// Constructors
				public UnitData();
			}
	
			// Constructors
			public ExAbilityBuildData();
	
			// Methods
			public void AddUnit(UnitData unit);
			public void AppendFromPartyUnitList(PartyUnitList[] partyUnitList);
			public void AppendFromHeroParamList(HeroParam[] heroParams);
		}
	
		// Constructors
		public GameExAbilityData(int partySwitchIndex);
	
		// Methods
		public void SetupExAbility();
		public List<ExAbilityDataElement> GetExAbility1List(int actorIndex);
		public List<AbilityDataElement> GetExAbility2List(int actorIndex);
	}
}
