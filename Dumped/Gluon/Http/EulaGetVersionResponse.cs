namespace Gluon.Http
{
	public class EulaGetVersionResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenVersionHash version_hash;

			public bool is_required_agree;

			public int agreement_status;
		}

		public CommonResponse data;
	}
}
