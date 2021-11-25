namespace Gluon.Event
{
	public static class RunActionUtil
	{
		public static RunActionParameterBase ComposeIfNeed(RunActionParameterBase baseParam, RunActionParameterBase extParam, RunActionCompositeParameter compositeParam)
		{
			return null;
		}

		public static void DecomposeIfNeed<ExtParamType>(RunActionParameterBase param, out RunActionParameterBase baseParam, out ExtParamType extParam) where ExtParamType : class, RunActionParameterBase
		{
		}
	}
}
