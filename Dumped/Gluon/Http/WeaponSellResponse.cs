namespace Gluon.Http
{
	public class WeaponSellResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public DeleteDataList delete_data_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
