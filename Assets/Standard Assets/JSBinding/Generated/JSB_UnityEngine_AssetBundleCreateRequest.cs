﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by CSGenerator.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using jsval = JSApi.jsval;

public class JSB_UnityEngine_AssetBundleCreateRequest
{

////////////////////// AssetBundleCreateRequest ///////////////////////////////////////
// constructors

static bool AssetBundleCreateRequest_AssetBundleCreateRequest1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AssetBundleCreateRequest());
    }

    return true;
}

// fields

// properties
static void AssetBundleCreateRequest_assetBundle(JSVCall vc)
{
        UnityEngine.AssetBundleCreateRequest _this = (UnityEngine.AssetBundleCreateRequest)vc.csObj;
        var result = _this.assetBundle;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AssetBundleCreateRequest);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        AssetBundleCreateRequest_assetBundle,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AssetBundleCreateRequest_AssetBundleCreateRequest1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
