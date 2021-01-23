/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DrumScrollAllController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private DrumScrollRect lowerScrollRect;
		[SerializeField]
		private DrumScrollRect upperScrollRect;
		[SerializeField]
		private DrumScrollRect centerScrollRect;
		public int scrollItemCount;
		public int instantateItemCount;
		public UnityAction<int, GameObject> onUpdateItem;
		public int startScollCount;
	
		// Properties
		public int CurrentTopIndex { get; }
	
		// Constructors
		public DrumScrollAllController();
	
		// Methods
		private void Start();
		private void Update();
	}
}
