/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.openvnc {

using System;
using System.Runtime.InteropServices;

public class DebugCallback : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DebugCallback(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DebugCallback obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DebugCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        OpenVNCWRAPPINVOKE.delete_DebugCallback(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public DebugCallback() : this(OpenVNCWRAPPINVOKE.new_DebugCallback(), true) {
    SwigDirectorConnect();
  }

  public virtual int OnDebugInfo(string message) {
    int ret = ((this.GetType() == typeof(DebugCallback)) ? OpenVNCWRAPPINVOKE.DebugCallback_OnDebugInfo(swigCPtr, message) : OpenVNCWRAPPINVOKE.DebugCallback_OnDebugInfoSwigExplicitDebugCallback(swigCPtr, message));
    return ret;
  }

  public virtual int OnDebugWarn(string message) {
    int ret = ((this.GetType() == typeof(DebugCallback)) ? OpenVNCWRAPPINVOKE.DebugCallback_OnDebugWarn(swigCPtr, message) : OpenVNCWRAPPINVOKE.DebugCallback_OnDebugWarnSwigExplicitDebugCallback(swigCPtr, message));
    return ret;
  }

  public virtual int OnDebugError(string message) {
    int ret = ((this.GetType() == typeof(DebugCallback)) ? OpenVNCWRAPPINVOKE.DebugCallback_OnDebugError(swigCPtr, message) : OpenVNCWRAPPINVOKE.DebugCallback_OnDebugErrorSwigExplicitDebugCallback(swigCPtr, message));
    return ret;
  }

  public virtual int OnDebugFatal(string message) {
    int ret = ((this.GetType() == typeof(DebugCallback)) ? OpenVNCWRAPPINVOKE.DebugCallback_OnDebugFatal(swigCPtr, message) : OpenVNCWRAPPINVOKE.DebugCallback_OnDebugFatalSwigExplicitDebugCallback(swigCPtr, message));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnDebugInfo", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateDebugCallback_0(SwigDirectorOnDebugInfo);
    if (SwigDerivedClassHasMethod("OnDebugWarn", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateDebugCallback_1(SwigDirectorOnDebugWarn);
    if (SwigDerivedClassHasMethod("OnDebugError", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateDebugCallback_2(SwigDirectorOnDebugError);
    if (SwigDerivedClassHasMethod("OnDebugFatal", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateDebugCallback_3(SwigDirectorOnDebugFatal);
    OpenVNCWRAPPINVOKE.DebugCallback_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(DebugCallback));
    return hasDerivedMethod;
  }

  private int SwigDirectorOnDebugInfo(string message) {
    return OnDebugInfo(message);
  }

  private int SwigDirectorOnDebugWarn(string message) {
    return OnDebugWarn(message);
  }

  private int SwigDirectorOnDebugError(string message) {
    return OnDebugError(message);
  }

  private int SwigDirectorOnDebugFatal(string message) {
    return OnDebugFatal(message);
  }

  public delegate int SwigDelegateDebugCallback_0(string message);
  public delegate int SwigDelegateDebugCallback_1(string message);
  public delegate int SwigDelegateDebugCallback_2(string message);
  public delegate int SwigDelegateDebugCallback_3(string message);

  private SwigDelegateDebugCallback_0 swigDelegate0;
  private SwigDelegateDebugCallback_1 swigDelegate1;
  private SwigDelegateDebugCallback_2 swigDelegate2;
  private SwigDelegateDebugCallback_3 swigDelegate3;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(string) };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(string) };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(string) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(string) };
}

}