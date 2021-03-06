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

public class vncClient : vncRunnable {
  private HandleRef swigCPtr;

  internal vncClient(IntPtr cPtr, bool cMemoryOwn) : base(OpenVNCWRAPPINVOKE.vncClientUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(vncClient obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~vncClient() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        OpenVNCWRAPPINVOKE.delete_vncClient(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override string GetObjectId() {
    string ret = OpenVNCWRAPPINVOKE.vncClient_GetObjectId(swigCPtr);
    return ret;
  }

  public virtual bool IsValid() {
    bool ret = OpenVNCWRAPPINVOKE.vncClient_IsValid(swigCPtr);
    return ret;
  }

  public virtual vncClientState_t GetSate() {
    vncClientState_t ret = (vncClientState_t)OpenVNCWRAPPINVOKE.vncClient_GetSate(swigCPtr);
    return ret;
  }

  public virtual vncError_t SetPassword(string pPassword) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_SetPassword(swigCPtr, pPassword);
    return ret;
  }

  public virtual vncError_t SetPixelSize(vncRfbPixelSize_t ePixelSize) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_SetPixelSize(swigCPtr, (int)ePixelSize);
    return ret;
  }

  public virtual vncError_t SetPixelFormat(vncRfbPixelFormat_t pPixelFormat) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_SetPixelFormat(swigCPtr, vncRfbPixelFormat_t.getCPtr(pPixelFormat));
    return ret;
  }

  public virtual vncError_t Configure(string pServerHost, ushort nServerPort, vncNetworkType_t eType, vncNetIPVersion_t eIPVersion) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_Configure__SWIG_0(swigCPtr, pServerHost, nServerPort, (int)eType, (int)eIPVersion);
    return ret;
  }

  public virtual vncError_t Configure(string pServerHost, ushort nServerPort, vncNetworkType_t eType) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_Configure__SWIG_1(swigCPtr, pServerHost, nServerPort, (int)eType);
    return ret;
  }

  public virtual vncError_t Start() {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_Start(swigCPtr);
    return ret;
  }

  public virtual vncError_t Connect() {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_Connect(swigCPtr);
    return ret;
  }

  public virtual vncError_t Disconnect() {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_Disconnect(swigCPtr);
    return ret;
  }

  public virtual bool IsConnected() {
    bool ret = OpenVNCWRAPPINVOKE.vncClient_IsConnected(swigCPtr);
    return ret;
  }

  public virtual bool IsSessionEstablished() {
    bool ret = OpenVNCWRAPPINVOKE.vncClient_IsSessionEstablished(swigCPtr);
    return ret;
  }

  public virtual vncError_t SetParentWindow(byte[] pParentWindow) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_SetParentWindow__SWIG_0(swigCPtr, pParentWindow);
    return ret;
  }

  public virtual vncError_t SetParentWindow(long parentWindow) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_SetParentWindow__SWIG_1(swigCPtr, parentWindow);
    return ret;
  }

  public virtual vncError_t SetCallback(vncClientCallback pcCallback) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_SetCallback(swigCPtr, vncClientCallback.getCPtr(pcCallback));
    return ret;
  }

  public virtual vncError_t SendPointerEvent(byte nButtonMask, ushort nXPosition, ushort nYPosition) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_SendPointerEvent(swigCPtr, nButtonMask, nXPosition, nYPosition);
    return ret;
  }

  public virtual vncError_t SendKeyEvent(bool bDownFlag, uint nKey) {
    vncError_t ret = (vncError_t)OpenVNCWRAPPINVOKE.vncClient_SendKeyEvent(swigCPtr, bDownFlag, nKey);
    return ret;
  }

  public static vncClientObject New(string pLocalHost, ushort nLocalPort, vncNetworkType_t eType) {
    vncClientObject ret = new vncClientObject(OpenVNCWRAPPINVOKE.vncClient_New__SWIG_0(pLocalHost, nLocalPort, (int)eType), true);
    return ret;
  }

  public static vncClientObject New(string pLocalHost, ushort nLocalPort) {
    vncClientObject ret = new vncClientObject(OpenVNCWRAPPINVOKE.vncClient_New__SWIG_1(pLocalHost, nLocalPort), true);
    return ret;
  }

  public static vncClientObject New(string pLocalHost) {
    vncClientObject ret = new vncClientObject(OpenVNCWRAPPINVOKE.vncClient_New__SWIG_2(pLocalHost), true);
    return ret;
  }

  public static vncClientObject New() {
    vncClientObject ret = new vncClientObject(OpenVNCWRAPPINVOKE.vncClient_New__SWIG_3(), true);
    return ret;
  }

  public vncClient ABCD() {
    IntPtr cPtr = OpenVNCWRAPPINVOKE.vncClient_ABCD(swigCPtr);
    vncClient ret = (cPtr == IntPtr.Zero) ? null : new vncClient(cPtr, false);
    return ret;
  }

}

}
