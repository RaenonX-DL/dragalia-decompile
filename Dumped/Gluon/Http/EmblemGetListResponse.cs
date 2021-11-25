namespace Gluon.Http
{
	public class EmblemGetListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public EmblemList[] emblem_list;
		}

		public CommonResponse data;
	}
}
