﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_GUI_TransChange_Application_Physics : JSComponent
{
    int idOnGUI;
    int idOnTransformChildrenChanged;
    int idOnTransformParentChanged;
    int idOnApplicationFocus;
    int idOnApplicationPause;
    int idOnApplicationQuit;
    int idOnCollisionEnter;
    int idOnCollisionExit;
    int idOnCollisionStay;
    int idOnTriggerEnter;
    int idOnTriggerExit;
    int idOnTriggerStay;
    int idOnControllerColliderHit;

    protected override void initMemberFunction()
    {
        base.initMemberFunction();
        idOnGUI = JSApi.getObjFunction(jsObjID, "OnGUI");
        idOnTransformChildrenChanged = JSApi.getObjFunction(jsObjID, "OnTransformChildrenChanged");
        idOnTransformParentChanged = JSApi.getObjFunction(jsObjID, "OnTransformParentChanged");
        idOnApplicationFocus = JSApi.getObjFunction(jsObjID, "OnApplicationFocus");
        idOnApplicationPause = JSApi.getObjFunction(jsObjID, "OnApplicationPause");
        idOnApplicationQuit = JSApi.getObjFunction(jsObjID, "OnApplicationQuit");
        idOnCollisionEnter = JSApi.getObjFunction(jsObjID, "OnCollisionEnter");
        idOnCollisionExit = JSApi.getObjFunction(jsObjID, "OnCollisionExit");
        idOnCollisionStay = JSApi.getObjFunction(jsObjID, "OnCollisionStay");
        idOnTriggerEnter = JSApi.getObjFunction(jsObjID, "OnTriggerEnter");
        idOnTriggerExit = JSApi.getObjFunction(jsObjID, "OnTriggerExit");
        idOnTriggerStay = JSApi.getObjFunction(jsObjID, "OnTriggerStay");
        idOnControllerColliderHit = JSApi.getObjFunction(jsObjID, "OnControllerColliderHit");
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
    void OnApplicationFocus(bool focusStatus)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnApplicationFocus, focusStatus);
    }
    void OnApplicationPause(bool pauseStatus)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnApplicationPause, pauseStatus);
    }
    void OnApplicationQuit()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnApplicationQuit);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionEnter, collisionInfo);
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionExit, collisionInfo);
    }
    void OnCollisionStay(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionStay, collisionInfo);
    }
    void OnTriggerEnter(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerEnter, other);
    }
    void OnTriggerExit(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerExit, other);
    }
    void OnTriggerStay(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerStay, other);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnControllerColliderHit, hit);
    }

}