namespace Gluon.Http
{
	public class InquiryDetailResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public string opinion_id;

			public int opinion_type;

			public string opinion_text;

			public AtgenCommentList[] comment_list;

			public int occurred_at;

			public int created_at;
		}

		public CommonResponse data;
	}
}
