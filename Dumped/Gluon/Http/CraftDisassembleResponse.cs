namespace Gluon.Http
{
	public class CraftDisassembleResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public DeleteDataList delete_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
