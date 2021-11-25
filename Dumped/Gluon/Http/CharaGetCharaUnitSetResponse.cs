namespace Gluon.Http
{
	public class CharaGetCharaUnitSetResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public CharaUnitSetList[] chara_unit_set_list;
		}

		public CommonResponse data;
	}
}
