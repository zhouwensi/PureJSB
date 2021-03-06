﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_GUI_TransChange : JSComponent
{
    int idOnGUI;
    int idOnTransformChildrenChanged;
    int idOnTransformParentChanged;

    protected override void initMemberFunction()
    {
        base.initMemberFunction();
        idOnGUI = JSApi.getObjFunction(jsObjID, "OnGUI");
        idOnTransformChildrenChanged = JSApi.getObjFunction(jsObjID, "OnTransformChildrenChanged");
        idOnTransformParentChanged = JSApi.getObjFunction(jsObjID, "OnTransformParentChanged");
    }

    void OnGUI()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnGUI);
    }
    void OnTransformChildrenChanged()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTransformChildrenChanged);
    }
    void OnTransformParentChanged()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTransformParentChanged);
    }

}