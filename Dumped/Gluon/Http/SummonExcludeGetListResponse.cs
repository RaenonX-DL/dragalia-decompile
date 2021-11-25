namespace Gluon.Http
{
	public class SummonExcludeGetListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenDuplicateEntityList[] summon_exclude_unit_list;
		}

		public CommonResponse data;
	}
}
