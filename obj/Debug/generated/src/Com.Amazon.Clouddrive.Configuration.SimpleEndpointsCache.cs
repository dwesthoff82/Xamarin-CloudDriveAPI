using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='SimpleEndpointsCache']"
	[global::Android.Runtime.Register ("com/amazon/clouddrive/configuration/SimpleEndpointsCache", DoNotGenerateAcw=true)]
	public partial class SimpleEndpointsCache : global::Java.Lang.Object, global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/amazon/clouddrive/configuration/SimpleEndpointsCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleEndpointsCache); }
		}

		protected SimpleEndpointsCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='SimpleEndpointsCache']/constructor[@name='SimpleEndpointsCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleEndpointsCache ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SimpleEndpointsCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getEndpoints;
#pragma warning disable 0169
		static Delegate GetGetEndpointsHandler ()
		{
			if (cb_getEndpoints == null)
				cb_getEndpoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndpoints);
			return cb_getEndpoints;
		}

		static IntPtr n_GetEndpoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.SimpleEndpointsCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.SimpleEndpointsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Endpoints);
		}
#pragma warning restore 0169

		static Delegate cb_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_;
#pragma warning disable 0169
		static Delegate GetSetEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_Handler ()
		{
			if (cb_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_ == null)
				cb_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_);
			return cb_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_;
		}

		static void n_SetEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Amazon.Clouddrive.Configuration.SimpleEndpointsCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.SimpleEndpointsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Configuration.Endpoints p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.Endpoints> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Endpoints = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEndpoints;
		static IntPtr id_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_;
		public virtual unsafe global::Com.Amazon.Clouddrive.Configuration.Endpoints Endpoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='SimpleEndpointsCache']/method[@name='getEndpoints' and count(parameter)=0]"
			[Register ("getEndpoints", "()Lcom/amazon/clouddrive/configuration/Endpoints;", "GetGetEndpointsHandler")]
			get {
				if (id_getEndpoints == IntPtr.Zero)
					id_getEndpoints = JNIEnv.GetMethodID (class_ref, "getEndpoints", "()Lcom/amazon/clouddrive/configuration/Endpoints;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.Endpoints> (JNIEnv.CallObjectMethod  (Handle, id_getEndpoints), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.Endpoints> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndpoints", "()Lcom/amazon/clouddrive/configuration/Endpoints;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='SimpleEndpointsCache']/method[@name='setEndpoints' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.configuration.Endpoints']]"
			[Register ("setEndpoints", "(Lcom/amazon/clouddrive/configuration/Endpoints;)V", "GetSetEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_Handler")]
			set {
				if (id_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_ == IntPtr.Zero)
					id_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_ = JNIEnv.GetMethodID (class_ref, "setEndpoints", "(Lcom/amazon/clouddrive/configuration/Endpoints;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndpoints", "(Lcom/amazon/clouddrive/configuration/Endpoints;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_cacheHasExpired;
#pragma warning disable 0169
		static Delegate GetCacheHasExpiredHandler ()
		{
			if (cb_cacheHasExpired == null)
				cb_cacheHasExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CacheHasExpired);
			return cb_cacheHasExpired;
		}

		static bool n_CacheHasExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.SimpleEndpointsCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.SimpleEndpointsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheHasExpired ();
		}
#pragma warning restore 0169

		static IntPtr id_cacheHasExpired;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='SimpleEndpointsCache']/method[@name='cacheHasExpired' and count(parameter)=0]"
		[Register ("cacheHasExpired", "()Z", "GetCacheHasExpiredHandler")]
		public virtual unsafe bool CacheHasExpired ()
		{
			if (id_cacheHasExpired == IntPtr.Zero)
				id_cacheHasExpired = JNIEnv.GetMethodID (class_ref, "cacheHasExpired", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_cacheHasExpired);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cacheHasExpired", "()Z"));
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Amazon.Clouddrive.Configuration.SimpleEndpointsCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.SimpleEndpointsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/class[@name='SimpleEndpointsCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

	}
}
