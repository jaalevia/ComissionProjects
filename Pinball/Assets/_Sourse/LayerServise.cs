using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LayerServise
{
    
        public static bool CheckLayersEquality(LayerMask objectLayer, LayerMask requiredLayer) => ((1 << objectLayer) & requiredLayer) > 0;
    
}
