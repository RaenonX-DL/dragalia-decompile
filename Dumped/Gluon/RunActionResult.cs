using Gluon.Event;

namespace Gluon
{
	public struct RunActionResult
	{
		public ActionBase action;

		public RunActionParameterBase param;

		public RunActionResult(ActionBase action, RunActionParameterBase param)
		{
		}

		public static RunActionResult Empty()
		{
			return default(RunActionResult);
		}

		public bool IsEmpty()
		{
			return default(bool);
		}
	}
}
