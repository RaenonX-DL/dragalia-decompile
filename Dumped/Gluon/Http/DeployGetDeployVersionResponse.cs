namespace Gluon.Http
{
	public class DeployGetDeployVersionResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public string deploy_hash;
		}

		public CommonResponse data;
	}
}
