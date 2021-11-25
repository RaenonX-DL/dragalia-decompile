using Cute.Http;

namespace Gluon.Http
{
	public class QuestSearchQuestClearPartyMultiRequest : RequestCommon
	{
		public int quest_id;

		public int party_switch_no;

		public int[] chara_id_list;

		public int[] dragon_id_list;

		public int[] weapon_body_id_list;

		public int[] ability_crest_id_list;
	}
}
