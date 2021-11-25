namespace Gluon.Http
{
	public class RedoableSummonPreExecResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UserRedoableSummonData user_redoable_summon_data;
		}

		public CommonResponse data;
	}
}
