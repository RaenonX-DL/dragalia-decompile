using System.Collections.Generic;

namespace Gluon
{
	public class AIScriptContext
	{
		public float awakeTime;

		public float hpRecode;

		public bool isCountTime;

		public float countTime;

		public float trgLength;

		public float trgHpRate;

		public bool isSearchAction;

		private Dictionary<string, AIScriptValue> _localValueDic;

		public Dictionary<string, AIScriptValue>.KeyCollection AllLocalValueNames => null;

		public void AddLocalValue(string name, AIScriptValue value)
		{
		}

		public bool ContainsLocalValue(string name)
		{
			return default(bool);
		}

		public AIScriptValue GetLocalValue(string name)
		{
			return null;
		}

		public void ClearAllLocalValues()
		{
		}

		public void ClearAll()
		{
		}

		public void CopyTo(AIScriptContext context)
		{
		}

		public static void EncodeDeltaCompression(DeltaCompressionEncoder encoder, AIScriptContext prev, AIScriptContext next, out byte[] result)
		{
		}

		public static bool DecodeDeltaCompression(DeltaCompressionDecoder decoder, AIScriptContext prev, byte[] nextBinary, AIScriptContext outNext)
		{
			return default(bool);
		}
	}
}
