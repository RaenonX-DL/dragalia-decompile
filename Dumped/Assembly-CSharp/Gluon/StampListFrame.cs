/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StampListFrame : MonoBehaviour
	{
		// Fields
		public UnityAction<int> listButtonCallBack;
		public UnityAction<int> listLongPressCallBack;
		public StampSetData nowStampSet;
		public Button saveButton;
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private UnityEngine.UI.Text stampNum;
		[SerializeField]
		private UnityEngine.UI.Text stampNumValue;
		[SerializeField]
		private StampListController _stampListCtrl;
	
		// Properties
		public StampListController stampListCtrl { get; }
	
		// Constructors
		public StampListFrame();
	
		// Methods
		public void SetTitle(Localize.TextId id);
		public void SetNum(int num);
	}
}
