using UnityEngine;
using UnityEngine.UIElements;

#if UNITY_EDITOR
#endif

namespace AdvancedSceneManager.Documentation
{

#if ASM_DEV
    [CreateAssetMenu(fileName = "readme", menuName = "Advanced Scene Manager/readme")]
#endif
    public partial class ReadMe : ScriptableObject
    {
        public VisualTreeAsset template;
        public TextAsset guidesReadMe;
        public TextAsset apiDocsReadMe;
    }

}
