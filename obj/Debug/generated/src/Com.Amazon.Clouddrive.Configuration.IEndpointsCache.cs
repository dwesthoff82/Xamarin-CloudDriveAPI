using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Amazon.Clouddrive.Configuration {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/interface[@name='EndpointsCache']"
	[Register ("com/amazon/clouddrive/configuration/EndpointsCache", "", "Com.Amazon.Clouddrive.Configuration.IEndpointsCacheInvoker")]
	public partial interface IEndpointsCache : IJavaObject {

		global::Com.Amazon.Clouddrive.Configuration.Endpoints Endpoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/interface[@name='EndpointsCache']/method[@name='getEndpoints' and count(parameter)=0]"
			[Register ("getEndpoints", "()Lcom/amazon/clouddrive/configuration/Endpoints;", "GetGetEndpointsHandler:Com.Amazon.Clouddrive.Configuration.IEndpointsCacheInvoker, CloudDriveAPI")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/interface[@name='EndpointsCache']/method[@name='setEndpoints' and count(parameter)=1 and parameter[1][@type='com.amazon.clouddrive.configuration.Endpoints']]"
			[Register ("setEndpoints", "(Lcom/amazon/clouddrive/configuration/Endpoints;)V", "GetSetEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_Handler:Com.Amazon.Clouddrive.Configuration.IEndpointsCacheInvoker, CloudDriveAPI")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/interface[@name='EndpointsCache']/method[@name='cacheHasExpired' and count(parameter)=0]"
		[Register ("cacheHasExpired", "()Z", "GetCacheHasExpiredHandler:Com.Amazon.Clouddrive.Configuration.IEndpointsCacheInvoker, CloudDriveAPI")]
		bool CacheHasExpired ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.amazon.clouddrive.configuration']/interface[@name='EndpointsCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Com.Amazon.Clouddrive.Configuration.IEndpointsCacheInvoker, CloudDriveAPI")]
		void Clear ();

	}

	[global::Android.Runtime.Register ("com/amazon/clouddrive/configuration/EndpointsCache", DoNotGenerateAcw=true)]
	internal class IEndpointsCacheInvoker : global::Java.Lang.Object, IEndpointsCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/amazon/clouddrive/configuration/EndpointsCache");
		IntPtr class_ref;

		public static IEndpointsCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEndpointsCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.amazon.clouddrive.configuration.EndpointsCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEndpointsCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEndpointsCacheInvoker); }
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
			global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Amazon.Clouddrive.Configuration.Endpoints p0 = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.Endpoints> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Endpoints = p0;
		}
#pragma warning restore 0169

		IntPtr id_getEndpoints;
		IntPtr id_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_;
		public unsafe global::Com.Amazon.Clouddrive.Configuration.Endpoints Endpoints {
			get {
				if (id_getEndpoints == IntPtr.Zero)
					id_getEndpoints = JNIEnv.GetMethodID (class_ref, "getEndpoints", "()Lcom/amazon/clouddrive/configuration/Endpoints;");
				return global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.Endpoints> (JNIEnv.CallObjectMethod (Handle, id_getEndpoints), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_ == IntPtr.Zero)
					id_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_ = JNIEnv.GetMethodID (class_ref, "setEndpoints", "(Lcom/amazon/clouddrive/configuration/Endpoints;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (Handle, id_setEndpoints_Lcom_amazon_clouddrive_configuration_Endpoints_, __args);
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
			global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheHasExpired ();
		}
#pragma warning restore 0169

		IntPtr id_cacheHasExpired;
		public unsafe bool CacheHasExpired ()
		{
			if (id_cacheHasExpired == IntPtr.Zero)
				id_cacheHasExpired = JNIEnv.GetMethodID (class_ref, "cacheHasExpired", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_cacheHasExpired);
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
			global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache __this = global::Java.Lang.Object.GetObject<global::Com.Amazon.Clouddrive.Configuration.IEndpointsCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

	}

}
