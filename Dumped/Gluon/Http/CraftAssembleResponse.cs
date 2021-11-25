namespace Gluon.Http
{
	public class CraftAssembleResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public DeleteDataList delete_data_list;

			public SettingSupport setting_support;
		}

		public CommonResponse data;
	}
}
