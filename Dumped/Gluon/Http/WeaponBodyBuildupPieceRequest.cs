using Cute.Http;

namespace Gluon.Http
{
	public class WeaponBodyBuildupPieceRequest : RequestCommon
	{
		public int weapon_body_id;

		public AtgenBuildupWeaponBodyPieceList[] buildup_weapon_body_piece_list;
	}
}
