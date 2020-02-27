# unity-editor-scripts

## Useful Tips
  ### Attributes
  - `[MenuItem(string path)]` - Adds static function to Menu.
  - `[ContextMenu(string name)]` - Adds function to ContextMenu of MonoBehaviour.
  - `[SelectionBase]` - Forces selection on GameObject holding MonoBehaviour.
  - `[RequiredComponent(typeof(type))]` - Forces component on GameObject holding MonoBehaviour.
  - `[DisallowMultipleComponent]` - Blocks from adding serveral instances of MonoBehaviour on single GameObject.
  - `[DefaultExecutionOrder(int order)]` - Forces script execution order, aligned with ProjectSettings.
