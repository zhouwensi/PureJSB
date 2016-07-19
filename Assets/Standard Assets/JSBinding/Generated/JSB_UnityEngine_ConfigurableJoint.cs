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

public class JSB_UnityEngine_ConfigurableJoint
{

////////////////////// ConfigurableJoint ///////////////////////////////////////
// constructors

static bool ConfigurableJoint_ConfigurableJoint1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.ConfigurableJoint());
    }

    return true;
}

// fields

// properties
static void ConfigurableJoint_secondaryAxis(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.secondaryAxis;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.secondaryAxis = arg0;
    }
}
static void ConfigurableJoint_xMotion(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.xMotion;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ConfigurableJointMotion arg0 = (UnityEngine.ConfigurableJointMotion)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.xMotion = arg0;
    }
}
static void ConfigurableJoint_yMotion(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.yMotion;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ConfigurableJointMotion arg0 = (UnityEngine.ConfigurableJointMotion)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.yMotion = arg0;
    }
}
static void ConfigurableJoint_zMotion(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.zMotion;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ConfigurableJointMotion arg0 = (UnityEngine.ConfigurableJointMotion)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.zMotion = arg0;
    }
}
static void ConfigurableJoint_angularXMotion(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.angularXMotion;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ConfigurableJointMotion arg0 = (UnityEngine.ConfigurableJointMotion)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.angularXMotion = arg0;
    }
}
static void ConfigurableJoint_angularYMotion(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.angularYMotion;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ConfigurableJointMotion arg0 = (UnityEngine.ConfigurableJointMotion)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.angularYMotion = arg0;
    }
}
static void ConfigurableJoint_angularZMotion(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.angularZMotion;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ConfigurableJointMotion arg0 = (UnityEngine.ConfigurableJointMotion)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.angularZMotion = arg0;
    }
}
static void ConfigurableJoint_linearLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.linearLimit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.linearLimit = arg0;
    }
}
static void ConfigurableJoint_lowAngularXLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.lowAngularXLimit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.lowAngularXLimit = arg0;
    }
}
static void ConfigurableJoint_highAngularXLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.highAngularXLimit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.highAngularXLimit = arg0;
    }
}
static void ConfigurableJoint_angularYLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.angularYLimit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.angularYLimit = arg0;
    }
}
static void ConfigurableJoint_angularZLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.angularZLimit;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.SoftJointLimit arg0 = (UnityEngine.SoftJointLimit)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.angularZLimit = arg0;
    }
}
static void ConfigurableJoint_targetPosition(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.targetPosition;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.targetPosition = arg0;
    }
}
static void ConfigurableJoint_targetVelocity(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.targetVelocity;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.targetVelocity = arg0;
    }
}
static void ConfigurableJoint_xDrive(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.xDrive;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.JointDrive arg0 = (UnityEngine.JointDrive)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.xDrive = arg0;
    }
}
static void ConfigurableJoint_yDrive(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.yDrive;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.JointDrive arg0 = (UnityEngine.JointDrive)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.yDrive = arg0;
    }
}
static void ConfigurableJoint_zDrive(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.zDrive;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.JointDrive arg0 = (UnityEngine.JointDrive)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.zDrive = arg0;
    }
}
static void ConfigurableJoint_targetRotation(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.targetRotation;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Quaternion arg0 = (UnityEngine.Quaternion)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.targetRotation = arg0;
    }
}
static void ConfigurableJoint_targetAngularVelocity(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.targetAngularVelocity;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.targetAngularVelocity = arg0;
    }
}
static void ConfigurableJoint_rotationDriveMode(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.rotationDriveMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.RotationDriveMode arg0 = (UnityEngine.RotationDriveMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.rotationDriveMode = arg0;
    }
}
static void ConfigurableJoint_angularXDrive(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.angularXDrive;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.JointDrive arg0 = (UnityEngine.JointDrive)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.angularXDrive = arg0;
    }
}
static void ConfigurableJoint_angularYZDrive(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.angularYZDrive;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.JointDrive arg0 = (UnityEngine.JointDrive)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.angularYZDrive = arg0;
    }
}
static void ConfigurableJoint_slerpDrive(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.slerpDrive;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.JointDrive arg0 = (UnityEngine.JointDrive)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.slerpDrive = arg0;
    }
}
static void ConfigurableJoint_projectionMode(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.projectionMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.JointProjectionMode arg0 = (UnityEngine.JointProjectionMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.projectionMode = arg0;
    }
}
static void ConfigurableJoint_projectionDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.projectionDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.projectionDistance = arg0;
    }
}
static void ConfigurableJoint_projectionAngle(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.projectionAngle;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.projectionAngle = arg0;
    }
}
static void ConfigurableJoint_configuredInWorldSpace(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.configuredInWorldSpace;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.configuredInWorldSpace = arg0;
    }
}
static void ConfigurableJoint_swapBodies(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        var result = _this.swapBodies;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ConfigurableJoint _this = (UnityEngine.ConfigurableJoint)vc.csObj;
        _this.swapBodies = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ConfigurableJoint);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        ConfigurableJoint_secondaryAxis,
        ConfigurableJoint_xMotion,
        ConfigurableJoint_yMotion,
        ConfigurableJoint_zMotion,
        ConfigurableJoint_angularXMotion,
        ConfigurableJoint_angularYMotion,
        ConfigurableJoint_angularZMotion,
        ConfigurableJoint_linearLimit,
        ConfigurableJoint_lowAngularXLimit,
        ConfigurableJoint_highAngularXLimit,
        ConfigurableJoint_angularYLimit,
        ConfigurableJoint_angularZLimit,
        ConfigurableJoint_targetPosition,
        ConfigurableJoint_targetVelocity,
        ConfigurableJoint_xDrive,
        ConfigurableJoint_yDrive,
        ConfigurableJoint_zDrive,
        ConfigurableJoint_targetRotation,
        ConfigurableJoint_targetAngularVelocity,
        ConfigurableJoint_rotationDriveMode,
        ConfigurableJoint_angularXDrive,
        ConfigurableJoint_angularYZDrive,
        ConfigurableJoint_slerpDrive,
        ConfigurableJoint_projectionMode,
        ConfigurableJoint_projectionDistance,
        ConfigurableJoint_projectionAngle,
        ConfigurableJoint_configuredInWorldSpace,
        ConfigurableJoint_swapBodies,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ConfigurableJoint_ConfigurableJoint1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}