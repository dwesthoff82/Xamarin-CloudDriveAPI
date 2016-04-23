using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='AccountConfiguration']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/configuration/AccountConfiguration", DoNotGenerateAcw=true)]
	public partial class AccountConfiguration : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/configuration/AccountConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AccountConfiguration); }
		}

		protected AccountConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='AccountConfiguration']/constructor[@name='AccountConfiguration' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.auth.AuthenticatedURLConnectionFactory']]"
		[Register (".ctor", "(Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;)V", "")]
		public unsafe AccountConfiguration (global::Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactory p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AccountConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;)V", __args);
					return;
				}

				if (id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_Lcom_amazon_clouddrive_configuration_EndpointsCache_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='AccountConfiguration']/constructor[@name='AccountConfiguration' and count(parameter)=2 and parameter[1][@type='com.amazon.clouddrive.auth.AuthenticatedURLConnectionFactory'] and parameter[2][@type='com.amazon.clouddrive.configuration.EndpointsCache']]"
		[Register (".ctor", "(Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;Lcom/amazon/clouddrive/configuration/EndpointsCache;)V", "")]
		public unsafe AccountConfiguration (global::Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactory p0, global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (AccountConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;Lcom/amazon/clouddrive/configuration/EndpointsCache;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;Lcom/amazon/clouddrive/configuration/EndpointsCache;)V", __args);
					return;
				}

				if (id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_Lcom_amazon_clouddrive_configuration_EndpointsCache_ == IntPtr.Zero)
					id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_Lcom_amazon_clouddrive_configuration_EndpointsCache_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;Lcom/amazon/clouddrive/configuration/EndpointsCache;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_Lcom_amazon_clouddrive_configuration_EndpointsCache_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_amazon_clouddrive_auth_AuthenticatedURLConnectionFactory_Lcom_amazon_clouddrive_configuration_EndpointsCache_, __args);
			} finally {
			}
		}

		static Delegate cb_getAuthenticatedURLConnectionFactory;
#pragma warning disable 0169
		static Delegate GetGetAuthenticatedURLConnectionFactoryHandler ()
		{
			if (cb_getAuthenticatedURLConnectionFactory == null)
				cb_getAuthenticatedURLConnectionFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthenticatedURLConnectionFactory);
			return cb_getAuthenticatedURLConnectionFactory;
		}

		static IntPtr n_GetAuthenticatedURLConnectionFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.AccountConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.AccountConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthenticatedURLConnectionFactory);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthenticatedURLConnectionFactory;
		public virtual unsafe global::Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactory AuthenticatedURLConnectionFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='AccountConfiguration']/method[@name='getAuthenticatedURLConnectionFactory' and count(parameter)=0]"
			[Register ("getAuthenticatedURLConnectionFactory", "()Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;", "GetGetAuthenticatedURLConnectionFactoryHandler")]
			get {
				if (id_getAuthenticatedURLConnectionFactory == IntPtr.Zero)
					id_getAuthenticatedURLConnectionFactory = JNIEnv.GetMethodID (class_ref, "getAuthenticatedURLConnectionFactory", "()Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactory> (JNIEnv.CallObjectMethod  (Handle, id_getAuthenticatedURLConnectionFactory), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Auth.IAuthenticatedURLConnectionFactory> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthenticatedURLConnectionFactory", "()Lcom/amazon/clouddrive/auth/AuthenticatedURLConnectionFactory;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEndpointsCache;
#pragma warning disable 0169
		static Delegate GetGetEndpointsCacheHandler ()
		{
			if (cb_getEndpointsCache == null)
				cb_getEndpointsCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndpointsCache);
			return cb_getEndpointsCache;
		}

		static IntPtr n_GetEndpointsCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.AccountConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.AccountConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndpointsCache);
		}
#pragma warning restore 0169

		static IntPtr id_getEndpointsCache;
		public virtual unsafe global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache EndpointsCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='AccountConfiguration']/method[@name='getEndpointsCache' and count(parameter)=0]"
			[Register ("getEndpointsCache", "()Lcom/amazon/clouddrive/configuration/EndpointsCache;", "GetGetEndpointsCacheHandler")]
			get {
				if (id_getEndpointsCache == IntPtr.Zero)
					id_getEndpointsCache = JNIEnv.GetMethodID (class_ref, "getEndpointsCache", "()Lcom/amazon/clouddrive/configuration/EndpointsCache;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache> (JNIEnv.CallObjectMethod  (Handle, id_getEndpointsCache), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndpointsCache", "()Lcom/amazon/clouddrive/configuration/EndpointsCache;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
