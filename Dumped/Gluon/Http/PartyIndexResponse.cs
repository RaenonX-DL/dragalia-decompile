namespace Gluon.Http
{
	public class PartyIndexResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public BuildList[] build_list;
		}

		public CommonResponse data;
	}
}
