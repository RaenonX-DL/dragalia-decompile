namespace Gluon.Http
{
	public class MaintenanceGetTextResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public string maintenance_text;
		}

		public CommonResponse data;
	}
}
