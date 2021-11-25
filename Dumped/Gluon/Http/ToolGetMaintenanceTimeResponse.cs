namespace Gluon.Http
{
	public class ToolGetMaintenanceTimeResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public int maintenance_start_time;

			public int maintenance_end_time;
		}

		public CommonResponse data;
	}
}
