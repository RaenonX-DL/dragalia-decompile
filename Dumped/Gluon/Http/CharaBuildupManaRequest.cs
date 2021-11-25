using Cute.Http;

namespace Gluon.Http
{
	public class CharaBuildupManaRequest : RequestCommon
	{
		public int chara_id;

		public int[] mana_circle_piece_id_list;

		public int is_use_grow_material;
	}
}
