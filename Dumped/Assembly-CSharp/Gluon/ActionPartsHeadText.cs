/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsHeadText : ActionParts
	{
		// Fields
		private readonly HeadTextData _partsData;
		private static readonly string[] textIdNames;
		private int _countOfActionStart;
		private RunActionIntParameter _runActionParam;
	
		// Constructors
		public ActionPartsHeadText(ActionParts resource);
		static ActionPartsHeadText();
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
	}
}
