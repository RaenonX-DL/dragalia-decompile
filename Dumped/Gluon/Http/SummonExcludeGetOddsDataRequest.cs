using Cute.Http;

namespace Gluon.Http
{
	public class SummonExcludeGetOddsDataRequest : RequestCommon
	{
		public int summon_id;

		public int exclude_entity_type;

		public int[] exclude_entity_id_list;
	}
}
