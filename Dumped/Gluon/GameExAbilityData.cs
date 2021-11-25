using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Http;
using Gluon.Master;

namespace Gluon
{
	public class GameExAbilityData
	{
		private class ExAbilityBuildData
		{
			public class UnitData
			{
				public int charaId;

				public int exAbility1Level;

				public int exAbility2Level;
			}

			public List<UnitData> partyUnitList
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void AddUnit(UnitData unit)
			{
			}

			public void AppendFromPartyUnitList(PartyUnitList[] partyUnitList)
			{
			}

			public void AppendFromHeroParamList(HeroParam[] heroParams)
			{
			}
		}

		private int _partySwitchIndex;

		private List<ExAbilityDataElement>[] exAbility1List;

		private List<AbilityDataElement>[] exAbility2List;

		public GameExAbilityData(int partySwitchIndex)
		{
		}

		public void SetupExAbility()
		{
		}

		public List<ExAbilityDataElement> GetExAbility1List(int actorIndex)
		{
			return null;
		}

		public List<AbilityDataElement> GetExAbility2List(int actorIndex)
		{
			return null;
		}
	}
}
