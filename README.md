# unity-editor-scripts

## Useful Tips
  ### Attributes
  - `[MenuItem(string path)]` - Adds static function to Menu.
  - `[ContextMenu(string name)]` - Adds function to ContextMenu of MonoBehaviour.
  - `[TextArea(int minLine, int MaxLine)]` - Adds text area to MonoBegaviour's property field.
  - `[SelectionBase]` - Forces selection on GameObject holding MonoBehaviour.
  - `[RequiredComponent(typeof(type))]` - Forces component on GameObject holding MonoBehaviour.
  - `[DisallowMultipleComponent]` - Prevents from adding serveral instances of MonoBehaviour on single GameObject.
  - `[DefaultExecutionOrder(int order)]` - Forces script execution order, aligned with ProjectSettings.
