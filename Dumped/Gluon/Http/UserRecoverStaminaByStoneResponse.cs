namespace Gluon.Http
{
	public class UserRecoverStaminaByStoneResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public AtgenRecoverData recover_data;
		}

		public CommonResponse data;
	}
}
