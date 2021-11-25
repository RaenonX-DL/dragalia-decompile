using Cute.Http;

namespace Gluon.Http
{
	public class CharaSetCharaUnitSetRequest : RequestCommon
	{
		public int unit_set_no;

		public string unit_set_name;

		public int chara_id;

		public AtgenRequestCharaUnitSetData request_chara_unit_set_data;
	}
}
