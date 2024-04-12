using UnityEngine.Scripting;

namespace SimpleJSON
{
    [Preserve]
    public class SimpleJSONCroppingHelper : UnityEngine.MonoBehaviour
    {
        [Preserve]
        public void Start()
        {
            _ = typeof(SimpleJSON.JSON);
            _ = typeof(SimpleJSON.JSONArray);
            _ = typeof(SimpleJSON.JSONBool);
            _ = typeof(SimpleJSON.JSONContainerType);
            _ = typeof(SimpleJSON.JSONLazyCreator);
            _ = typeof(SimpleJSON.JSONNode);
            _ = typeof(SimpleJSON.JSONNode.Enumerator);
            _ = typeof(SimpleJSON.JSONNode.KeyEnumerator);
            _ = typeof(SimpleJSON.JSONNode.LinqEnumerator);
            _ = typeof(SimpleJSON.JSONNode.ValueEnumerator);
            _ = typeof(SimpleJSON.JSONNodeType);
            _ = typeof(SimpleJSON.JSONNull);
            _ = typeof(SimpleJSON.JSONNumber);
            _ = typeof(SimpleJSON.JSONObject);
            _ = typeof(SimpleJSON.JSONString);
            _ = typeof(SimpleJSON.JSONTextMode);
        }
    }
}