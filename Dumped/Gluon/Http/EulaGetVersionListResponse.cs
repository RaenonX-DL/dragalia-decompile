namespace Gluon.Http
{
	public class EulaGetVersionListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenVersionHash[] version_hash_list;
		}

		public CommonResponse data;
	}
}
