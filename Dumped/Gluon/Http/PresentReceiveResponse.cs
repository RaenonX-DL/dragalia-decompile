namespace Gluon.Http
{
	public class PresentReceiveResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public ulong[] receive_present_id_list;

			public ulong[] not_receive_present_id_list;

			public ulong[] delete_present_id_list;

			public ulong[] limit_over_present_id_list;

			public PresentDetailList[] present_list;

			public PresentDetailList[] present_limit_list;

			public UpdateDataList update_data_list;

			public EntityResult entity_result;

			public ConvertedEntityList[] converted_entity_list;
		}

		public CommonResponse data;
	}
}
