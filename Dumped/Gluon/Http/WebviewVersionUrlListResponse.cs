namespace Gluon.Http
{
	public class WebviewVersionUrlListResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public AtgenWebviewUrlList[] webview_url_list;
		}

		public CommonResponse data;
	}
}
