using Cute.Http;

namespace Gluon.Http
{
	public class CharaBuildupRequest : RequestCommon
	{
		public int chara_id;

		public AtgenEnemyPiece[] material_list;
	}
}
