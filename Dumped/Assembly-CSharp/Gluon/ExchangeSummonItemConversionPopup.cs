/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExchangeSummonItemConversionPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text summonEndtimeText;
		[SerializeField]
		private UnityEngine.UI.Text summonNameText;
		[SerializeField]
		private UnityEngine.UI.Text coversionText;
		[SerializeField]
		private CommonIcon iconA;
		[SerializeField]
		private CommonIcon iconB;
		[SerializeField]
		private UnityEngine.UI.Text beforeExchangePointCount;
		[SerializeField]
		private UnityEngine.UI.Text afterExchangePointCount;
		[SerializeField]
		private UnityEngine.UI.Text overSummonPointText;
		private SummonDataElement sde;
		private SummonPointDataElement spde;
		private int summonId;
		private UnityAction onExchangeEnd;
	
		// Constructors
		public ExchangeSummonItemConversionPopup();
	
		// Methods
		public static ExchangeSummonItemConversionPopup Create(int summonId, int beforeExchangeItem, int getExchangeItem);
		public void SetContent(int summonId, int beforeExchangeItem, int getExchangeItem);
		public void OnCloseExchangePopup();
	}
}
