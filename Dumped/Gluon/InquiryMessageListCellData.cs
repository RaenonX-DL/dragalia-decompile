using Gluon.Http;
using UnityEngine.Events;

namespace Gluon
{
	public class InquiryMessageListCellData
	{
		public AtgenOpinionList opinion;

		public UnityAction<string> onClickedCallback;
	}
}
