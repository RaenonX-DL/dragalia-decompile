/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonIconDetailPopup : CommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		protected AnimationUIAutoPublisher exitUIPublisher;
		[Header]
		[SerializeField]
		public CommonIcon icon;
		public UnityEngine.UI.Text itemName;
		public UnityEngine.UI.Text description;
		protected Action onOKOrClose;
		protected Action onCancel;
		private CommonIcon iconSource;
	
		// Constructors
		public CommonIconDetailPopup();
	
		// Methods
		public static CommonIconDetailPopup Create(CommonIcon icon);
		protected override void Start();
		public virtual void OnOKOrClosePopup();
		public virtual void OnCancelPopup();
		[CompilerGenerated]
		private void _OnOKOrClosePopup_b__9_0();
		[CompilerGenerated]
		private void _OnCancelPopup_b__10_0();
	}
}
