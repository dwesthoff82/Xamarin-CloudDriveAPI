using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='StrongCipherSSLSocketFactory']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/auth/StrongCipherSSLSocketFactory", DoNotGenerateAcw=true)]
	public partial class StrongCipherSSLSocketFactory : global::Javax.Net.Ssl.SSLSocketFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/auth/StrongCipherSSLSocketFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StrongCipherSSLSocketFactory); }
		}

		protected StrongCipherSSLSocketFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_createSocket_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_lang_String_IHandler ()
		{
			if (cb_createSocket_Ljava_lang_String_I == null)
				cb_createSocket_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreateSocket_Ljava_lang_String_I);
			return cb_createSocket_Ljava_lang_String_I;
		}

		static IntPtr n_CreateSocket_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSocket_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='StrongCipherSSLSocketFactory']/method[@name='createSocket' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_lang_String_IHandler")]
		public override unsafe global::Java.Net.Socket CreateSocket (string p0, int p1)
		{
			if (id_createSocket_Ljava_lang_String_I == IntPtr.Zero)
				id_createSocket_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Java.Net.Socket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod  (Handle, id_createSocket_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_lang_String_ILjava_net_InetAddress_IHandler ()
		{
			if (cb_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I == null)
				cb_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr>) n_CreateSocket_Ljava_lang_String_ILjava_net_InetAddress_I);
			return cb_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I;
		}

		static IntPtr n_CreateSocket_Ljava_lang_String_ILjava_net_InetAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetAddress p2 = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='StrongCipherSSLSocketFactory']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.net.InetAddress'] and parameter[4][@type='int']]"
		[Register ("createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_lang_String_ILjava_net_InetAddress_IHandler")]
		public override unsafe global::Java.Net.Socket CreateSocket (string p0, int p1, global::Java.Net.InetAddress p2, int p3)
		{
			if (id_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I == IntPtr.Zero)
				id_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I = JNIEnv.GetMethodID (class_ref, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Java.Net.Socket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod  (Handle, id_createSocket_Ljava_lang_String_ILjava_net_InetAddress_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSocket", "(Ljava/lang/String;ILjava/net/InetAddress;I)Ljava/net/Socket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createSocket_Ljava_net_InetAddress_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_net_InetAddress_IHandler ()
		{
			if (cb_createSocket_Ljava_net_InetAddress_I == null)
				cb_createSocket_Ljava_net_InetAddress_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreateSocket_Ljava_net_InetAddress_I);
			return cb_createSocket_Ljava_net_InetAddress_I;
		}

		static IntPtr n_CreateSocket_Ljava_net_InetAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetAddress p0 = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSocket_Ljava_net_InetAddress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='StrongCipherSSLSocketFactory']/method[@name='createSocket' and count(parameter)=2 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int']]"
		[Register ("createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_net_InetAddress_IHandler")]
		public override unsafe global::Java.Net.Socket CreateSocket (global::Java.Net.InetAddress p0, int p1)
		{
			if (id_createSocket_Ljava_net_InetAddress_I == IntPtr.Zero)
				id_createSocket_Ljava_net_InetAddress_I = JNIEnv.GetMethodID (class_ref, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Java.Net.Socket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod  (Handle, id_createSocket_Ljava_net_InetAddress_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSocket", "(Ljava/net/InetAddress;I)Ljava/net/Socket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_IHandler ()
		{
			if (cb_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I == null)
				cb_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr>) n_CreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I);
			return cb_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I;
		}

		static IntPtr n_CreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
		{
			global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetAddress p0 = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.InetAddress p2 = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='StrongCipherSSLSocketFactory']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int'] and parameter[3][@type='java.net.InetAddress'] and parameter[4][@type='int']]"
		[Register ("createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;", "GetCreateSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_IHandler")]
		public override unsafe global::Java.Net.Socket CreateSocket (global::Java.Net.InetAddress p0, int p1, global::Java.Net.InetAddress p2, int p3)
		{
			if (id_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I == IntPtr.Zero)
				id_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I = JNIEnv.GetMethodID (class_ref, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Java.Net.Socket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod  (Handle, id_createSocket_Ljava_net_InetAddress_ILjava_net_InetAddress_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSocket", "(Ljava/net/InetAddress;ILjava/net/InetAddress;I)Ljava/net/Socket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetCreateSocket_Ljava_net_Socket_Ljava_lang_String_IZHandler ()
		{
			if (cb_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ == null)
				cb_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_CreateSocket_Ljava_net_Socket_Ljava_lang_String_IZ);
			return cb_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ;
		}

		static IntPtr n_CreateSocket_Ljava_net_Socket_Ljava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket p0 = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateSocket (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='StrongCipherSSLSocketFactory']/method[@name='createSocket' and count(parameter)=4 and parameter[1][@type='java.net.Socket'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;", "GetCreateSocket_Ljava_net_Socket_Ljava_lang_String_IZHandler")]
		public override unsafe global::Java.Net.Socket CreateSocket (global::Java.Net.Socket p0, string p1, int p2, bool p3)
		{
			if (id_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ == IntPtr.Zero)
				id_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Java.Net.Socket __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallObjectMethod  (Handle, id_createSocket_Ljava_net_Socket_Ljava_lang_String_IZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSocket", "(Ljava/net/Socket;Ljava/lang/String;IZ)Ljava/net/Socket;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getDefaultCipherSuites;
#pragma warning disable 0169
		static Delegate GetGetDefaultCipherSuitesHandler ()
		{
			if (cb_getDefaultCipherSuites == null)
				cb_getDefaultCipherSuites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultCipherSuites);
			return cb_getDefaultCipherSuites;
		}

		static IntPtr n_GetDefaultCipherSuites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDefaultCipherSuites ());
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultCipherSuites;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='StrongCipherSSLSocketFactory']/method[@name='getDefaultCipherSuites' and count(parameter)=0]"
		[Register ("getDefaultCipherSuites", "()[Ljava/lang/String;", "GetGetDefaultCipherSuitesHandler")]
		public override unsafe string[] GetDefaultCipherSuites ()
		{
			if (id_getDefaultCipherSuites == IntPtr.Zero)
				id_getDefaultCipherSuites = JNIEnv.GetMethodID (class_ref, "getDefaultCipherSuites", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getDefaultCipherSuites), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultCipherSuites", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getSupportedCipherSuites;
#pragma warning disable 0169
		static Delegate GetGetSupportedCipherSuitesHandler ()
		{
			if (cb_getSupportedCipherSuites == null)
				cb_getSupportedCipherSuites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedCipherSuites);
			return cb_getSupportedCipherSuites;
		}

		static IntPtr n_GetSupportedCipherSuites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.StrongCipherSSLSocketFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetSupportedCipherSuites ());
		}
#pragma warning restore 0169

		static IntPtr id_getSupportedCipherSuites;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.auth']/class[@name='StrongCipherSSLSocketFactory']/method[@name='getSupportedCipherSuites' and count(parameter)=0]"
		[Register ("getSupportedCipherSuites", "()[Ljava/lang/String;", "GetGetSupportedCipherSuitesHandler")]
		public override unsafe string[] GetSupportedCipherSuites ()
		{
			if (id_getSupportedCipherSuites == IntPtr.Zero)
				id_getSupportedCipherSuites = JNIEnv.GetMethodID (class_ref, "getSupportedCipherSuites", "()[Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getSupportedCipherSuites), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportedCipherSuites", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
