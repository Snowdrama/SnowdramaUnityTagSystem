using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snowdrama.TagSystem
{
    public class Tags : MonoBehaviour
    {
        [Header("Tags"), Tooltip("Assign tags to group this object into a pool related to the tag")]
        public List<string> tags;
        private void OnEnable()
        {
            foreach (var item in tags)
            {
                Debug.LogWarningFormat("Setting {0} with Tag {1}", this.gameObject.name, item);
                TagObjects.RegisterTaggedObject(item, this.gameObject);
            }
        }
        private void OnDisable()
        {
            foreach (var item in tags)
            {
                Debug.LogWarningFormat("Clearing {0} with Tag {1}", this.gameObject.name, item);
                TagObjects.UnregisterTaggedObject(item, this.gameObject);
            }
        }
    }
}