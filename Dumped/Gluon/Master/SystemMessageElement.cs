using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SystemMessageElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _IsShowResultCode;

		[SerializeField]
		private SystemMessageTransportType _TransportType;

		public int Id => default(int);

		public int IsShowResultCode => default(int);

		public SystemMessageTransportType TransportType => default(SystemMessageTransportType);
	}
}
