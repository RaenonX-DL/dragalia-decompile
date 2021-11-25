using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestBuildupPieceRequest : RequestCommon
	{
		public int ability_crest_id;

		public AtgenBuildupAbilityCrestPieceList[] buildup_ability_crest_piece_list;
	}
}
