using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestBuildupPlusCountRequest : RequestCommon
	{
		public int ability_crest_id;

		public AtgenPlusCountParamsList[] plus_count_params_list;
	}
}
