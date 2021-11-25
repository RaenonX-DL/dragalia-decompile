namespace Gluon.Http
{
	public class CharaGetListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public CharaList[] chara_list;
		}

		public CommonResponse data;
	}
}
