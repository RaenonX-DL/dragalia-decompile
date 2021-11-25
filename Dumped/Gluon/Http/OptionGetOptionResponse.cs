namespace Gluon.Http
{
	public class OptionGetOptionResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public OptionData option_data;
		}

		public CommonResponse data;
	}
}
