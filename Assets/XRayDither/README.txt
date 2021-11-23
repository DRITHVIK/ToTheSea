1) Create a Layer you wish to apply this effect to
2) Apply the that layer to an object in the scene you wish to effect.
3) In the UniversalRenderPipelineAsset_Renderer asset, apply that layer to the 'Layer Mask' field in the CharacterBehind and CharacterInfront Render Objects.
4) Add the UniversalRenderPipelineAsset_Renderer to your own UniversalRenderPipelineAsset or use the one inside this package.
5) Make sure you are using the correct pipeline asset in your Project Settings -> Graphics.